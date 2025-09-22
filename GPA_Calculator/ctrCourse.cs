using GPACalculatorBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GPACalculator
{
    public partial class ctrCourse : UserControl
    {

        public event EventHandler<int> OnRemove;

        DataTable dtGradeSymbolPointsForUniversity=new DataTable();

        public clsCourse Course { get; set; }
       
        public ctrCourse()
        {

        }
        public ctrCourse(int CourseID)
        {

            InitializeComponent();
            Course = clsCourse.Find(CourseID);

            if (clsGlobal.CurrentUser == null)
            {
                MessageBox.Show("User was not found!!");
                return;
            }
            if (Course == null)
            {
                MessageBox.Show("Course was not found!!");
                return;
            }

            LoadCourse();

            

        }
        void LoadCourse()
        {
            lblName.Text = Course.Name;
            lblID.Text = Course.CourseID.ToString();
            chkRepeated.Enabled = false;
            nudHours.Enabled = false;
            nudHours.Value = Course.Hours;


            dtGradeSymbolPointsForUniversity = clsUniversityGradeSymbolPoints.GradeSymbolPointsTableForThisUniversity(
       clsGlobal.CurrentUser.UniversityWithMajor.University.ID);


            if (Course.Hours > 0)
            {
                cbGrade.DataSource = dtGradeSymbolPointsForUniversity.AsEnumerable()
         .Where(row => row.Field<string>("GradeSymbol").Trim() != "P")
         .Select(row => row.Field<string>("GradeSymbol")).ToList();

                List<string> PrevGradeSymbols = dtGradeSymbolPointsForUniversity.AsEnumerable()
         .Where(row => row.Field<int>("Rank") >= 7)//i have to get this 7 from db later
         .Select(row => row.Field<string>("GradeSymbol").Trim()).ToList();


                cbPrevGrade.DataSource = PrevGradeSymbols;

            }
            else
            {
                cbGrade.DataSource = new List<string> { "P", "F" };
                cbPrevGrade.DataSource = new List<string> { "F".Trim() };
            }


            cbPrevGrade.SelectedIndex = -1;


        }

        private void cbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            OnRemove?.Invoke(this, Course.CourseID);
        }

        private void llblMoreInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCourseInfo frm =new frmCourseInfo(int.Parse(lblID.Text));
            if(!frm.IsDisposed)
                frm.ShowDialog();
           
        }
    }
}
