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
    public partial class frmUserInfo : Form
    {
        public frmUserInfo()
        {
            InitializeComponent();

        }

        private void llblChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChangePassword frm =new frmChangePassword();
            frm.ShowDialog();
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            clsUser currentUser = clsGlobal.CurrentUser;
            lblUserID.Text = currentUser.UserID.ToString();
            lblName.Text = currentUser.Name.ToString();
            lblUsername.Text=currentUser.UserName.ToString();
            lblMajor.Text = currentUser.UniversityWithMajor.Major.Name;
            lblUniversity.Text = currentUser.UniversityWithMajor.University.Name;

            clsGPASave gpaSave = currentUser.LastGPASaveForUser();
            if (gpaSave != null)
                lblGPA.Text = gpaSave.GPA.ToString();
            else
                lblGPA.Text = 0.ToString();
            
        }

        private void llblCertifiedCourses_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCertifiedCoursesForUser frm=new frmCertifiedCoursesForUser();
            frm.ShowDialog();   
        }

        private void llblResetUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmConfirmForUserReset frm=new frmConfirmForUserReset();    
            frm.ShowDialog();
            frmUserInfo_Load(null, null);


        }
    }
}
