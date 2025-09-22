namespace GPACalculator
{
    partial class frmCalculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPrevHours = new System.Windows.Forms.NumericUpDown();
            this.nudPrevGpa = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCoursesCount = new System.Windows.Forms.Label();
            this.gbPrevData = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.llblUserInfo = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCompletedHours = new System.Windows.Forms.Label();
            this.llbLogout = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrevHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrevGpa)).BeginInit();
            this.gbPrevData.SuspendLayout();
            this.gbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 570);
            this.panel1.TabIndex = 3;
            // 
            // txtGPA
            // 
            this.txtGPA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGPA.Enabled = false;
            this.txtGPA.Location = new System.Drawing.Point(686, 317);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.ReadOnly = true;
            this.txtGPA.Size = new System.Drawing.Size(112, 30);
            this.txtGPA.TabIndex = 10;
            this.txtGPA.TabStop = false;
            this.txtGPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Location = new System.Drawing.Point(507, 76);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(40, 39);
            this.btnAddCourse.TabIndex = 1;
            this.btnAddCourse.TabStop = false;
            this.btnAddCourse.Text = "+";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Previous GPA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Previous Hours:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "GPA:";
            // 
            // nudPrevHours
            // 
            this.nudPrevHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudPrevHours.Location = new System.Drawing.Point(177, 46);
            this.nudPrevHours.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudPrevHours.Name = "nudPrevHours";
            this.nudPrevHours.Size = new System.Drawing.Size(63, 30);
            this.nudPrevHours.TabIndex = 1;
            this.nudPrevHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPrevHours.ValueChanged += new System.EventHandler(this.nudPrevHours_ValueChanged);
            // 
            // nudPrevGpa
            // 
            this.nudPrevGpa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudPrevGpa.DecimalPlaces = 2;
            this.nudPrevGpa.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPrevGpa.Location = new System.Drawing.Point(177, 85);
            this.nudPrevGpa.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudPrevGpa.Name = "nudPrevGpa";
            this.nudPrevGpa.Size = new System.Drawing.Size(63, 30);
            this.nudPrevGpa.TabIndex = 2;
            this.nudPrevGpa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPrevGpa.ValueChanged += new System.EventHandler(this.nudPrevGpa_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 636);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Courses Count:";
            // 
            // lblCoursesCount
            // 
            this.lblCoursesCount.AutoSize = true;
            this.lblCoursesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoursesCount.Location = new System.Drawing.Point(175, 636);
            this.lblCoursesCount.Name = "lblCoursesCount";
            this.lblCoursesCount.Size = new System.Drawing.Size(24, 25);
            this.lblCoursesCount.TabIndex = 21;
            this.lblCoursesCount.Text = "0";
            // 
            // gbPrevData
            // 
            this.gbPrevData.Controls.Add(this.nudPrevGpa);
            this.gbPrevData.Controls.Add(this.label2);
            this.gbPrevData.Controls.Add(this.nudPrevHours);
            this.gbPrevData.Controls.Add(this.label1);
            this.gbPrevData.Enabled = false;
            this.gbPrevData.Location = new System.Drawing.Point(590, 109);
            this.gbPrevData.Name = "gbPrevData";
            this.gbPrevData.Size = new System.Drawing.Size(272, 146);
            this.gbPrevData.TabIndex = 23;
            this.gbPrevData.TabStop = false;
            this.gbPrevData.Text = "Previous Data";
            // 
            // btnCalculate
            // 
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Location = new System.Drawing.Point(35, 40);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(222, 49);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(35, 154);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(223, 49);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(177, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 38);
            this.label5.TabIndex = 24;
            this.label5.Text = "Courses";
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.btnCalculate);
            this.gbActions.Controls.Add(this.btnReset);
            this.gbActions.Controls.Add(this.btnSave);
            this.gbActions.Enabled = false;
            this.gbActions.Location = new System.Drawing.Point(590, 358);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(281, 231);
            this.gbActions.TabIndex = 25;
            this.gbActions.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(35, 97);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(222, 49);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // llblUserInfo
            // 
            this.llblUserInfo.AutoSize = true;
            this.llblUserInfo.Location = new System.Drawing.Point(772, 51);
            this.llblUserInfo.Name = "llblUserInfo";
            this.llblUserInfo.Size = new System.Drawing.Size(90, 25);
            this.llblUserInfo.TabIndex = 3;
            this.llblUserInfo.Text = "User Info";
            this.llblUserInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblUserInfo_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Completed Hours:";
            // 
            // lblCompletedHours
            // 
            this.lblCompletedHours.AutoSize = true;
            this.lblCompletedHours.Location = new System.Drawing.Point(782, 278);
            this.lblCompletedHours.Name = "lblCompletedHours";
            this.lblCompletedHours.Size = new System.Drawing.Size(34, 25);
            this.lblCompletedHours.TabIndex = 29;
            this.lblCompletedHours.Text = "??";
            this.lblCompletedHours.Click += new System.EventHandler(this.lblCompletedHours_Click);
            // 
            // llbLogout
            // 
            this.llbLogout.AutoSize = true;
            this.llbLogout.LinkColor = System.Drawing.Color.Red;
            this.llbLogout.Location = new System.Drawing.Point(772, 605);
            this.llbLogout.Name = "llbLogout";
            this.llbLogout.Size = new System.Drawing.Size(82, 25);
            this.llbLogout.TabIndex = 30;
            this.llbLogout.TabStop = true;
            this.llbLogout.Text = "Log Out";
            this.llbLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbLogout_LinkClicked);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 712);
            this.Controls.Add(this.llbLogout);
            this.Controls.Add(this.lblCompletedHours);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.llblUserInfo);
            this.Controls.Add(this.gbActions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbPrevData);
            this.Controls.Add(this.lblCoursesCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrevHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrevGpa)).EndInit();
            this.gbPrevData.ResumeLayout(false);
            this.gbPrevData.PerformLayout();
            this.gbActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPrevHours;
        private System.Windows.Forms.NumericUpDown nudPrevGpa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCoursesCount;
        private System.Windows.Forms.GroupBox gbPrevData;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.LinkLabel llblUserInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCompletedHours;
        private System.Windows.Forms.LinkLabel llbLogout;
    }
}

