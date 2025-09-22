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
    public partial class ctrMyDataGridView : UserControl
    {
        public bool isContextMenueAllowed{ get; set; }

        public ctrMyDataGridView()
        {
            InitializeComponent();
            isContextMenueAllowed = true;
            contextMenuStrip1.Opening += CheckIfContextMenueAllowed;
            dataGridView1.RowStateChanged+= changeCount;
            
        }

        private void CheckIfContextMenueAllowed(object sender, CancelEventArgs e)
        {
            e.Cancel = !isContextMenueAllowed;

        }

        private void changeCount(object sender, EventArgs e)
        {
            lblCount.Text=dataGridView1.RowCount.ToString();
        }

       
        private void ctrMyDataGridView_Load(object sender, EventArgs e)
        {
           
        }
        private void CustomizeDataGridViewUsingBaseStyle()
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            }
            dataGridView1.BackgroundColor = Color.White;
        }
        public void setDataSource(DataTable dt)
        {
            dataGridView1.DataSource=dt;
            CustomizeDataGridViewUsingBaseStyle();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        
        private void CourseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedCourseID =(int)dataGridView1.CurrentRow.Cells[0].Value;
            frmCourseInfo frmCourseInfo=new frmCourseInfo(selectedCourseID);
            frmCourseInfo.ShowDialog();
        }

        private void courseAttemptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedCourseID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            frmCourseAttempts frm=new frmCourseAttempts(selectedCourseID);
            frm.ShowDialog();
        }
    }
}
