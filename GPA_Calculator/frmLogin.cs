using GPACalculatorBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPACalculator
{
    public partial class frmLogin : Form
    {
        string credentialsFileName = "credentials.txt";
        public frmLogin()
        {
            InitializeComponent();
            try
            {
                (string Username, string Password) credentials = clsConfigCredentialManager.LoadCredentials();
                txtUsername.Text = credentials.Username;
                txtPassword.Text = credentials.Password;
            }
            catch
            {
                
            }


            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            
            UserLogin();
        }
        
        void UserLogin()
        {
            
            clsUser user=clsUser.Find(txtUsername.Text.Trim());
            if (user == null)
            {
                MessageBox.Show("User doesn't exist!!");
                return;
            }
            
            if (!user.VerifyPassword(txtPassword.Text))
            {
                MessageBox.Show("Password is incorrect!!");
                return;
            }
            clsGlobal.CurrentUser = user;

            
            if (chkRememberMe.Checked)
            {
                clsConfigCredentialManager.SaveCredentials(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            }
            else
            {
                clsConfigCredentialManager.SaveCredentials("","");

            }

            frmCalculator frm=new frmCalculator(clsGlobal.CurrentUser.UserID);
            frm.OnLogout += OnChildLogout;
            this.Hide();
            frm.Show();
            
        }

        private void OnChildLogout(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
            
            this.Show();
        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void llblCreatNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCreateAccount frm = new frmCreateAccount();
            frm.OnAccountCreation += (username,password) =>
            {
                txtPassword.Text = password;
                txtUsername.Text =username;
            };
            frm.ShowDialog();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }
    }
}
