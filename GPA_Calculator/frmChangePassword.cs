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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void txtOldPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtOldPassword.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtOldPassword, "Feild is required!");
            }
            if (!clsGlobal.CurrentUser.VerifyPassword(txtOldPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtOldPassword, "Password is incorrect!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtOldPassword, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Invalid inputs!!");
                return;
            }
            clsGlobal.CurrentUser.Password = txtNewPassword.Text.Trim();
            if (clsGlobal.CurrentUser.Save())
            {
                MessageBox.Show("Password has been changed successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to change password");
            }
            
            
            
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtNewPassword.Text=="")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNewPassword, "Feild is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNewPassword, "");
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmPassword.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Feild is required!");
            }
            else if (txtConfirmPassword.Text!=txtNewPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password doesn't match!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, "");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to reset?","Warning",MessageBoxButtons.YesNo)==DialogResult.No)
                return;
            
            
            errorProvider1.Clear();
            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
        }
    }
}
