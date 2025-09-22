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

namespace GPACalculator
{
    public partial class frmAddCourse : Form
    {
        public event EventHandler<int> OnCourseAdd;
        

        List<int> AddedCoursesIDs;//i need them from panel outside of this form to remove them from this cb
        public frmAddCourse(List<int>l)
        {
            InitializeComponent();
            AddedCoursesIDs= l;
            cbCourseName.DataSource =
                clsGlobal.CurrentUser.AllAllowedToTakeCoursesIdsWithNames()
                .Where(course => !AddedCoursesIDs.Contains(course.Key))
                .ToList();

            if (cbCourseName.Items.Count == 0)
            {
                MessageBox.Show("No courses to be added!");
                this.Close();
                return;
            }
        }

        private void frmAddCourse_Load(object sender, EventArgs e)
        {
           
            cbCourseName.DisplayMember = "Value";
            cbCourseName.ValueMember = "Key";
            cbCourseName.SelectedIndex= 0;
            
        }

        private void cbCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ;

            int selectedCourseID =((KeyValuePair<int,string>)cbCourseName.SelectedItem).Key;

            clsCourse course=clsCourse.Find(selectedCourseID);
            if (course == null)
            {
                MessageBox.Show("Course doesn't exist");
                return;
            }
                
            lblCourseNo.Text=course.CourseID.ToString();
            lblHours.Text=course.Hours.ToString();
            bool isAllowedToRetake = clsGlobal.CurrentUser.IsUserAllowedToRetakeThisCourse(course.CourseID);
            chkRetakeCourse.Checked = isAllowedToRetake;
            llblCourseAttempts.Enabled = isAllowedToRetake;




        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OnCourseAdd?.Invoke(this,int.Parse(lblCourseNo.Text));
            
            this.Close();
            
        }

        private void llblCourseAttempts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCourseAttempts frm = new frmCourseAttempts(int.Parse(lblCourseNo.Text));
            frm.ShowDialog();
        }

        private void lblMoreInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCourseInfo frm = new frmCourseInfo(int.Parse(lblCourseNo.Text));
            if (!frm.IsDisposed)//course id not found it will be disposed i n form
                frm.ShowDialog();
        }
    }
}
