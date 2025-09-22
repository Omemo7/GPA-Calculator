namespace GPACalculator
{
    partial class ctrCourse
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPrevGrade = new System.Windows.Forms.Label();
            this.cbPrevGrade = new System.Windows.Forms.ComboBox();
            this.chkRepeated = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.llblMoreInfo = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCourse.ForeColor = System.Drawing.Color.Maroon;
            this.btnRemoveCourse.Location = new System.Drawing.Point(406, -4);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(32, 33);
            this.btnRemoveCourse.TabIndex = 13;
            this.btnRemoveCourse.TabStop = false;
            this.btnRemoveCourse.Text = "X";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.llblMoreInfo);
            this.panel1.Controls.Add(this.btnRemoveCourse);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 256);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblPrevGrade);
            this.panel2.Controls.Add(this.cbPrevGrade);
            this.panel2.Controls.Add(this.chkRepeated);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.cbGrade);
            this.panel2.Controls.Add(this.nudHours);
            this.panel2.Controls.Add(this.lblHours);
            this.panel2.Location = new System.Drawing.Point(15, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 138);
            this.panel2.TabIndex = 0;
            // 
            // lblPrevGrade
            // 
            this.lblPrevGrade.AutoSize = true;
            this.lblPrevGrade.Enabled = false;
            this.lblPrevGrade.Location = new System.Drawing.Point(193, 83);
            this.lblPrevGrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrevGrade.Name = "lblPrevGrade";
            this.lblPrevGrade.Size = new System.Drawing.Size(153, 25);
            this.lblPrevGrade.TabIndex = 24;
            this.lblPrevGrade.Text = "Previous Grade:";
            // 
            // cbPrevGrade
            // 
            this.cbPrevGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrevGrade.Enabled = false;
            this.cbPrevGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPrevGrade.FormattingEnabled = true;
            this.cbPrevGrade.Location = new System.Drawing.Point(321, 80);
            this.cbPrevGrade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPrevGrade.Name = "cbPrevGrade";
            this.cbPrevGrade.Size = new System.Drawing.Size(45, 33);
            this.cbPrevGrade.TabIndex = 3;
            // 
            // chkRepeated
            // 
            this.chkRepeated.AutoSize = true;
            this.chkRepeated.Location = new System.Drawing.Point(42, 83);
            this.chkRepeated.Name = "chkRepeated";
            this.chkRepeated.Size = new System.Drawing.Size(118, 29);
            this.chkRepeated.TabIndex = 2;
            this.chkRepeated.Text = "Repeated";
            this.chkRepeated.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Grade:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblID.Location = new System.Drawing.Point(3, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(36, 27);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "??";
            // 
            // cbGrade
            // 
            this.cbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Location = new System.Drawing.Point(99, 34);
            this.cbGrade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(45, 33);
            this.cbGrade.TabIndex = 0;
            this.cbGrade.SelectedIndexChanged += new System.EventHandler(this.cbGrade_SelectedIndexChanged);
            // 
            // nudHours
            // 
            this.nudHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudHours.Location = new System.Drawing.Point(260, 37);
            this.nudHours.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(56, 30);
            this.nudHours.TabIndex = 1;
            this.nudHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHours.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(193, 39);
            this.lblHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(70, 25);
            this.lblHours.TabIndex = 20;
            this.lblHours.Text = "Hours:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Firebrick;
            this.lblName.Location = new System.Drawing.Point(10, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 29);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name";
            // 
            // llblMoreInfo
            // 
            this.llblMoreInfo.AutoSize = true;
            this.llblMoreInfo.Location = new System.Drawing.Point(332, 213);
            this.llblMoreInfo.Name = "llblMoreInfo";
            this.llblMoreInfo.Size = new System.Drawing.Size(93, 25);
            this.llblMoreInfo.TabIndex = 4;
            this.llblMoreInfo.Text = "More info";
            this.llblMoreInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblMoreInfo_LinkClicked);
            // 
            // ctrCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrCourse";
            this.Size = new System.Drawing.Size(445, 262);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llblMoreInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPrevGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblHours;
        public System.Windows.Forms.NumericUpDown nudHours;
        public System.Windows.Forms.CheckBox chkRepeated;
        public System.Windows.Forms.ComboBox cbPrevGrade;
        public System.Windows.Forms.ComboBox cbGrade;
    }
}
