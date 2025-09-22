using GPACalculatorBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPACalculator
{
    public partial class frmCertifiedCoursesForUser : Form
    {
        DataTable certifiedCourses;
        
        public frmCertifiedCoursesForUser()
        {
            InitializeComponent();
        }
       
        private void frmCertifiedCoursesForUser_Load(object sender, EventArgs e)
        {
            certifiedCourses = 
                clsGlobal.CurrentUser.AllCertifiedCoursesResultsForUser().DefaultView
                .ToTable(true, "CourseID", "Name", "GradeSymbol");
            certifiedCourses.Columns["CourseID"].ColumnName = "Course ID";
            certifiedCourses.Columns["Name"].ColumnName = "Name";
            certifiedCourses.Columns["GradeSymbol"].ColumnName = "Grade Symbol";


            ctrMyDataGridView1.setDataSource(certifiedCourses);
            
            cbFilterBy.SelectedIndex = 0;
            List<string> GradesSymbols = clsUniversityGradeSymbolPoints.
                GradeSymbolPointsTableForThisUniversity(clsGlobal.CurrentUser.UniversityWithMajor.University.ID)
                .AsEnumerable().Select(row => row.Field<string>("GradeSymbol")).ToList();
            GradesSymbols.Insert(0, "None");
            cbGradeSymbol.DataSource=GradesSymbols;
           
            
            
        }

        
        void FilterByName()
        {
            certifiedCourses.DefaultView.RowFilter=$"Name like '%{txtFilter.Text}%'";
        }
        void FilterByCourseID()
        {
 
               
            certifiedCourses.DefaultView.RowFilter = $"[Course ID] = {txtFilter.Text}";
        }


        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text == "")
            {
                certifiedCourses.DefaultView.RowFilter = "";//clear rowFilter
                ctrMyDataGridView1.setDataSource(certifiedCourses);
                return;
            }
            switch (cbFilterBy.SelectedItem.ToString())
            {
                case "Name": FilterByName(); return;
                case "Course ID":FilterByCourseID(); return;
            }
        }
        void ResetFilter()
        {
            txtFilter.Clear();
            certifiedCourses.DefaultView.RowFilter = "";
            
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetFilter();
            if (cbFilterBy.SelectedItem.ToString()=="Grade Symbol")
            {
                cbGradeSymbol.SelectedIndex = 0;
                cbGradeSymbol.Visible=true;
                txtFilter.Visible=false;
                return;
            }
            cbGradeSymbol.Visible = false;
            txtFilter.Visible = true;
        }

        private void cbGradeSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbGradeSymbol.SelectedItem.ToString() == "None")
            {
                certifiedCourses.DefaultView.RowFilter = "";
                return;
            }
            
            if(cbFilterBy.SelectedItem.ToString()=="Grade Symbol")
                certifiedCourses.DefaultView.RowFilter = $"[Grade Symbol] = '{cbGradeSymbol.SelectedItem.ToString()}'";
           
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.SelectedItem.ToString() != "Course ID")
                return;
            if(!char.IsDigit(e.KeyChar)&& e.KeyChar!=(char)Keys.Back)
                e.Handled = true;
        }
    }
}
