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
    public partial class frmConfirmForUserReset : Form
    {
        public frmConfirmForUserReset()
        {
            InitializeComponent();
        }

        private void btnResetUser_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
                return;

            if(MessageBox.Show("Are you sure you want to reset, " +
                "Data can't be recovered after reset!!", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clsGlobal.CurrentUser.ResetUser();
                MessageBox.Show("User has been reset successfully");
                this.Close();
            }
                

        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
           
            if(!clsPasswordHasher.VerifyPassword(txtPassword.Text, clsGlobal.CurrentUser.Password))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password is incorrect!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, "");
            }
            
            
        }

        private void frmConfirmForUserReset_Load(object sender, EventArgs e)
        {

        }
    }
}
