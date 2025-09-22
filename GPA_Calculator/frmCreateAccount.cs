using GPACalculatorBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPACalculator
{
    public partial class frmCreateAccount : Form
    {
        public delegate void AccountCreationDelegate(string username, string password);
        public event AccountCreationDelegate OnAccountCreation;
        DataTable dtUniversitiesWithMajors = clsUniversityWithMajor.AllUniversitiesWithMajorsDataTable();
        public frmCreateAccount()
        {
            InitializeComponent();
        }
        void FillCbUniversities()
        {
            HashSet<string> UniversitiesSet = dtUniversitiesWithMajors.AsEnumerable()
                                                     .Select(row => row.Field<string>("University"))
                                                     .ToHashSet();

            cbUniversity.DataSource = UniversitiesSet.ToList();
        }
        void FillCbMajorsBasedOnUniversitySelected()
        {
            HashSet<string> MajorsSet = dtUniversitiesWithMajors.AsEnumerable()
                .Where(row => row.Field<string>("University") == cbUniversity.SelectedItem.ToString())
                                         .Select(row => row.Field<string>("Major"))
                                         .ToHashSet();


            cbMajor.DataSource = MajorsSet.ToList();
        }
        void SetAutoCompleteForCbs()
        {
            
            cbUniversity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbUniversity.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbMajor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbMajor.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            FillCbUniversities();
            FillCbMajorsBasedOnUniversitySelected();
            SetAutoCompleteForCbs();


        }

        private void cbUniversity_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbUniversity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMajor.DataSource = null;  
            cbMajor.Items.Clear();
            FillCbMajorsBasedOnUniversitySelected();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to reset form?","Reset",MessageBoxButtons.YesNo)==DialogResult.No)
                return;
            txtName.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
            txtConfirmPassword.Clear();
            frmCreateAccount_Load(null,null);
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("not valid");
                return;
            }
            int SelectedUniversityWithMajorID = dtUniversitiesWithMajors.AsEnumerable()
                .Where(row=>(row.Field<string>("University")==cbUniversity.SelectedItem.ToString())&&
                (row.Field<string>("Major") == cbMajor.SelectedItem.ToString()))
                .Select(row => row.Field<int>("UniversityWithMajorID"))
                .ToList()[0];//from dt I took Selected university and major then mapped them and took their id in common table
           
            clsUser user = new clsUser();
            user.Name = txtName.Text;
            user.Password = txtPassword.Text;
            user.UserName = txtUsername.Text;
            //this find method is needed so i can fill the whole user object with its compositions properly
            user.UniversityWithMajor = clsUniversityWithMajor.Find(SelectedUniversityWithMajorID);
            if (user.Save())
            {
                MessageBox.Show("Account has been created successfully");
                OnAccountCreation?.Invoke(txtUsername.Text.Trim(),txtPassword.Text.Trim());
                this.Close();
            }
            else
            {
                MessageBox.Show("Faild to create account");
            }

        }

        private void cbMajor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMajor_TextChanged(object sender, EventArgs e)
        {
            
        }
        void ValidateTxtNotEmpty(TextBox t, CancelEventArgs e, string ErrorProviderMessage="Feild is required!")
        {
            if (t.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(t, ErrorProviderMessage);
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(t, "");
            }
        }
        private void txtName_Validating(object sender, CancelEventArgs e)
        {

            ValidateTxtNotEmpty(txtName, e);

        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidateTxtNotEmpty(txtPassword, e);
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsername.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "Feild is required!");
            }
            else if (clsUser.DoesUsernameExist(txtUsername.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "Username already exists! try another one");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, "");
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            
            if (txtConfirmPassword.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Feild is required!");
            }
            else if (txtConfirmPassword.Text != txtPassword.Text)
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

        private void cbUniversity_Leave(object sender, EventArgs e)
        {
            if (!cbUniversity.Items.Contains(cbUniversity.Text))
            {
               cbUniversity.SelectedIndex=0;
            }
        }

        private void cbMajor_Leave(object sender, EventArgs e)
        {
            if (!cbMajor.Items.Contains(cbUniversity.Text))
            {
                cbMajor.SelectedIndex = 0;
            }
        }
    }
}
