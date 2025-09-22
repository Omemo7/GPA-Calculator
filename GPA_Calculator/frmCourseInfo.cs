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
    public partial class frmCourseInfo : Form
    {
        clsCourse course;

        public frmCourseInfo(int courseID)
        {
            
            course = clsCourse.Find(courseID);
            if (course == null)
            {
                MessageBox.Show("Course was not found!!");
                this.Close();
                return;
            }

            InitializeComponent();


        }
        
       
        private void frmCourseInfo_Load(object sender, EventArgs e)
        {

            dgvCoursePrerequisists.setDataSource(course.PrerequisitsForCourse());  
            dgvCoursesThatThisCourseIsPrerequisiteFor.setDataSource(course.CoursesThatThisCourseIsPrerequisiteFor());


            lblCourseNO.Text=course.CourseID.ToString();
            lblName.Text=course.Name;
            lblGroup.Text=clsGlobal.CurrentUser.FindCourseGroupForCourseForThisUser(course.CourseID).Name;
            lblHours.Text=course.Hours.ToString();


        }

       
    }
}
