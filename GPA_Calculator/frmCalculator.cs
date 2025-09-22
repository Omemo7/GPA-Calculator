using GPACalculatorBusiness;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPACalculator
{
    public partial class frmCalculator : Form
    {
        public event EventHandler OnLogout;
        bool isLogout = false;

        List<ctrCourse> ctrCoursesList = new List<ctrCourse>();


        int XOffsetFromPanelForCtr = -6;
        int YOffsetFromPanelForCtr = 38;
        int DefaultNumberOfCourses = 1;

        public frmCalculator(int userID)
        {
            InitializeComponent();
            this.FormClosing += OnFormClosing;
           


        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall || isLogout)
                return;
            if(MessageBox.Show("Are you sure you want to exit? unsaved progress will be lost!", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
            else
                e.Cancel = true;
        }

        double CalculateGPAForUser()
        {
            double CurrentGPA;
            int prevHours = (int)nudPrevHours.Value;
            double prevGPA = (double)nudPrevGpa.Value;

            var CoursesResults=
                new List<(int Hours, double CurrentGradePoints,double PrevGradePoints)>();

            foreach (ctrCourse ctr in ctrCoursesList)
            {
                double currentGradePointsForCourse = clsUniversityGradeSymbolPoints.
                      SymbolPointsForThisSymbolAndThisUniversity(ctr.cbGrade.SelectedItem.ToString(),
                      clsGlobal.CurrentUser.UniversityWithMajor.University.ID);

                double prevGradePointsForCourse = -1;

                clsCourseResult PrevCourseResult= clsGlobal.CurrentUser
                    .CertifiedCourseResultByCourseIDForUser(ctr.Course.CourseID);
                if (PrevCourseResult != null) {

                prevGradePointsForCourse = 
                    clsUniversityGradeSymbolPoints.
                      SymbolPointsForThisSymbolAndThisUniversity(
                        PrevCourseResult.GradeSymbol.GradeSymbolAsText,
                      clsGlobal.CurrentUser.UniversityWithMajor.University.ID);

                }

                CoursesResults.Add((ctr.Course.Hours,  currentGradePointsForCourse, prevGradePointsForCourse)); 
            }

            CurrentGPA = clsCalculations.CalculateGPA(prevHours,prevGPA,CoursesResults);
            return Math.Round(CurrentGPA, 2);
        }

        
       
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double gpa = CalculateGPAForUser();
            txtGPA.Text = "";
            
            if (gpa > 4 ||gpa<0)
            {
                MessageBox.Show("Wrong inputs");
                return;
            }

            txtGPA.Text = gpa.ToString();

        }
        void ChangeCoursesCountLabel()
        {
            lblCoursesCount.Text=panel1.Controls.Count.ToString();
        }
        void AddNewCourseForGuest()
        {
            ctrCourse ctr = new ctrCourse();
            ctr.OnRemove += RemoveCourse;

            int CourseIndex = ctrCoursesList.Count;
            if (CourseIndex == 0)
            {
                int xAxisForFirstCtr = panel1.Location.X - XOffsetFromPanelForCtr;
                int yAxisForFirstCtr = panel1.Location.Y - YOffsetFromPanelForCtr;
                ctr.Location =
                    new Point(xAxisForFirstCtr, yAxisForFirstCtr);
            }
            else
            {
                int verticalDistance = ctrCoursesList[0].Size.Height;
                int xAxis = ctrCoursesList[CourseIndex - 1].Location.X;
                int yAxis = ctrCoursesList[CourseIndex - 1].Location.Y + verticalDistance;
                ctr.Location =
                    new Point(xAxis, yAxis);
            }



            panel1.Controls.Add(ctr);
            ctrCoursesList.Add(ctr);
            panel1.ScrollControlIntoView(ctr);
        }
        void LocateCtrCourseInPanel(ctrCourse ctr,int CourseIndex)
        {
            if (CourseIndex == 0)
            {
                int xAxisForFirstCtr = panel1.Location.X - XOffsetFromPanelForCtr;
                int yAxisForFirstCtr = panel1.Location.Y - YOffsetFromPanelForCtr;
                ctr.Location =
                    new Point(xAxisForFirstCtr, yAxisForFirstCtr);
            }
            else
            {
                int verticalDistance = ctrCoursesList[0].Size.Height;
                int xAxis = ctrCoursesList[CourseIndex - 1].Location.X;
                int yAxis = ctrCoursesList[CourseIndex - 1].Location.Y + verticalDistance;
                ctr.Location =
                    new Point(xAxis, yAxis);
            }
        }
        void AddNewCourseForUser(object sender,int CourseID)
        {
           
            ctrCourse ctr=new ctrCourse(CourseID);
            
            clsCourseResult PrevCourseResultForThisCourse =
                clsGlobal.CurrentUser.CertifiedCourseResultByCourseIDForUser(ctr.Course.CourseID);

            ctr.OnRemove += RemoveCourse;
            int CourseIndex = ctrCoursesList.Count;


            ctr.chkRepeated.Checked = (PrevCourseResultForThisCourse != null);
            if (ctr.chkRepeated.Checked)
            {
                ctr.cbPrevGrade.SelectedIndex =
                    ctr.cbPrevGrade.FindStringExact(
                        PrevCourseResultForThisCourse.GradeSymbol.GradeSymbolAsText.Trim());
              
            }

            LocateCtrCourseInPanel(ctr,CourseIndex);

            panel1.Controls.Add(ctr);
            ctrCoursesList.Add(ctr);
            panel1.ScrollControlIntoView(ctr);
            
        }

        void AddCoursesInListToPanel()
        {
            panel1.Controls.Clear();
            int CourseIndex = 0;
            foreach (var ctr in ctrCoursesList)
            {
                 


                LocateCtrCourseInPanel (ctr,CourseIndex);
                panel1.Controls.Add(ctr);
                panel1.ScrollControlIntoView(ctr);
                CourseIndex++;
                
            }


        }
        
        private void RemoveCourse(object sender, int CourseID)
        {
            
            ctrCoursesList.RemoveAll(e=>e.Course.CourseID==CourseID);
            
            AddCoursesInListToPanel();



        }


        
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.ControlAdded += DoOnItemAddedOrRemovedFromPanel;
            panel1.ControlRemoved += DoOnItemAddedOrRemovedFromPanel;
           

            LoadFormForUser();
        }
       

        private void DoOnItemAddedOrRemovedFromPanel(object sender, ControlEventArgs e)
        {
            EnableDisableGbActionsOnPanelState();
            ChangeCoursesCountLabel();
            

        }

        private void EnableDisableGbActionsOnPanelState()
        {
            if (panel1.Controls.Count > 0)
            {
                gbActions.Enabled= true;
                return;
            }
            gbActions.Enabled= false;
        }

        
        void LoadFormForUser()
        {
            

            clsGPASave lastGPASave = clsGPASave.GetLastGPASaveForUser(clsGlobal.CurrentUser.UserID);
            if(lastGPASave != null)
            {

                lblCompletedHours.Text = clsGlobal.CurrentUser.TotalCompletedHours().ToString () ;
                nudPrevGpa.Value = (decimal)lastGPASave.GPA;
                nudPrevHours.Value=clsGlobal.CurrentUser.TotalCertifiedHours();//certified not completed

            }
            else
            {
                nudPrevGpa.Value = 0;
                nudPrevHours.Value = 0;
            }
           
            lblCompletedHours.Text = clsGlobal.CurrentUser.TotalCompletedHours().ToString();
            
                

        }
       
      
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Everything will be reset, are you sure you want to continue","Warning!",MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) ==DialogResult.No)
                return;
            Reset();
            
            
        }
        
        void Reset()
        {
            ctrCoursesList.Clear();
            panel1.Controls.Clear();
            txtGPA.Text = "";
            LoadFormForUser();




        }
        

        private void nudPrevGpa_ValueChanged(object sender, EventArgs e)
        {

        }

       

        private void Form1_Activated(object sender, EventArgs e)
        {
            nudPrevHours.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Check if the Enter key is pressed
           
            if (keyData == Keys.Oemplus||keyData==Keys.Add)
            {
                // Perform the calculation
                btnAddCourse_Click(null,null);

                // Return true to indicate that the key was handled
                return true;
            }
           
            // Call base method for other key events
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void nudPrevHours_ValueChanged(object sender, EventArgs e)
        {
           
            
        }
        

        private void btnAddCourse_Click(object sender, EventArgs e)
        {


            List<int> AddedCoursesIDs = new List<int>();
            foreach (ctrCourse ctr in ctrCoursesList)
            {
                AddedCoursesIDs.Add(ctr.Course.CourseID);
            }

            frmAddCourse frm = new frmAddCourse(AddedCoursesIDs);

            frm.OnCourseAdd += AddNewCourseForUser;

            frm.ShowDialog();





        }

        

        private void llblUserInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

            frmUserInfo frm=new frmUserInfo();
            frm.ShowDialog();
            LoadFormForUser();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnCalculate_Click(null, null);

            clsGPASave GPASave= new clsGPASave();  
            GPASave.User=clsGlobal.CurrentUser;
            GPASave.GPA = float.Parse(txtGPA.Text);
            foreach (ctrCourse ctr in ctrCoursesList)
            {
                GPASave.dtCoursesResults.Rows.Add(ctr.Course.CourseID,
                    clsGradeSymbol.Find(ctr.cbGrade.SelectedItem.ToString()).ID);
            }

            if (GPASave.Save())
            {
                MessageBox.Show("Saved");
                Reset();
            }
               
            else
                MessageBox.Show("not Saved");
            

        }

        private void lblCompletedHours_Click(object sender, EventArgs e)
        {

        }

        private void llbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                OnLogout?.Invoke(this, EventArgs.Empty);
                isLogout = true;
                this.Close();

               
            }
        }
    }
}
