using GPACalculatorBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPACalculator
{
    public partial class frmCourseAttempts : Form
    {
        DataTable CourseAttempts=new DataTable();
        clsCourse Course=new clsCourse();
        public frmCourseAttempts(int courseID)
        {
            InitializeComponent();
            
            Course = clsCourse.Find(courseID);
            if (Course==null) 
            {
                MessageBox.Show("Course was not found!!");
                this.Close();
                return;
            }
            FillAndCustomizeCourseAttemptsTable();

        }
        private void FillAndCustomizeCourseAttemptsTable()
        {
            CourseAttempts = clsGlobal.CurrentUser.
                AllCourseAttempts(Course.CourseID).DefaultView
                .ToTable(true,"SavingDate", "GradeSymbol");
            CourseAttempts.Columns["SavingDate"].ColumnName = "Saving Date";
            CourseAttempts.Columns["GradeSymbol"].ColumnName = "Grade Symbol";
        }
       

        private void frmCourseAttempts_Load(object sender, EventArgs e)
        {
            lblCourseName.Text = Course.Name;
            lblCourseNO.Text=Course.CourseID.ToString();
            dataGridView1.setDataSource(CourseAttempts) ;
            dataGridView1.isContextMenueAllowed=false;

           
        }
    }
}
