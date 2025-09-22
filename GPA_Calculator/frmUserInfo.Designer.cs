namespace GPACalculator
{
    partial class frmUserInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.llblChangePassword = new System.Windows.Forms.LinkLabel();
            this.llblCertifiedCourses = new System.Windows.Forms.LinkLabel();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblUniversity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblGPA = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llblResetUser = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(254, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "User ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Major:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "University:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Username:";
            // 
            // llblChangePassword
            // 
            this.llblChangePassword.AutoSize = true;
            this.llblChangePassword.Location = new System.Drawing.Point(430, 307);
            this.llblChangePassword.Name = "llblChangePassword";
            this.llblChangePassword.Size = new System.Drawing.Size(173, 25);
            this.llblChangePassword.TabIndex = 1;
            this.llblChangePassword.Text = "Change Password";
            this.llblChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblChangePassword_LinkClicked);
            // 
            // llblCertifiedCourses
            // 
            this.llblCertifiedCourses.AutoSize = true;
            this.llblCertifiedCourses.Location = new System.Drawing.Point(17, 307);
            this.llblCertifiedCourses.Name = "llblCertifiedCourses";
            this.llblCertifiedCourses.Size = new System.Drawing.Size(163, 25);
            this.llblCertifiedCourses.TabIndex = 0;
            this.llblCertifiedCourses.Text = "Certified Courses";
            this.llblCertifiedCourses.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCertifiedCourses_LinkClicked);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(109, 45);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(34, 25);
            this.lblUserID.TabIndex = 12;
            this.lblUserID.Text = "??";
            // 
            // lblUniversity
            // 
            this.lblUniversity.AutoSize = true;
            this.lblUniversity.Location = new System.Drawing.Point(394, 45);
            this.lblUniversity.Name = "lblUniversity";
            this.lblUniversity.Size = new System.Drawing.Size(34, 25);
            this.lblUniversity.TabIndex = 27;
            this.lblUniversity.Text = "??";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(94, 131);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 25);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "??";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(307, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "GPA:";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(366, 88);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(34, 25);
            this.lblMajor.TabIndex = 30;
            this.lblMajor.Text = "??";
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Location = new System.Drawing.Point(356, 130);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(34, 25);
            this.lblGPA.TabIndex = 31;
            this.lblGPA.Text = "??";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(124, 88);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(34, 25);
            this.lblUsername.TabIndex = 32;
            this.lblUsername.Text = "??";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblGPA);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblMajor);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblUserID);
            this.groupBox1.Controls.Add(this.lblUniversity);
            this.groupBox1.Location = new System.Drawing.Point(22, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 189);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Info";
            // 
            // llblResetUser
            // 
            this.llblResetUser.AutoSize = true;
            this.llblResetUser.LinkColor = System.Drawing.Color.Red;
            this.llblResetUser.Location = new System.Drawing.Point(430, 332);
            this.llblResetUser.Name = "llblResetUser";
            this.llblResetUser.Size = new System.Drawing.Size(103, 25);
            this.llblResetUser.TabIndex = 2;
            this.llblResetUser.Text = "ResetUser";
            this.llblResetUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblResetUser_LinkClicked);
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 361);
            this.Controls.Add(this.llblResetUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.llblCertifiedCourses);
            this.Controls.Add(this.llblChangePassword);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserInfo";
            this.Load += new System.EventHandler(this.frmUserInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel llblChangePassword;
        private System.Windows.Forms.LinkLabel llblCertifiedCourses;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblUniversity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel llblResetUser;
    }
}