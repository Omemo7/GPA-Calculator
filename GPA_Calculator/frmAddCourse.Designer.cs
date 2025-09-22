namespace GPACalculator
{
    partial class frmAddCourse
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
            this.cbCourseName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCourseNo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblHours = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMoreInfo = new System.Windows.Forms.LinkLabel();
            this.llblCourseAttempts = new System.Windows.Forms.LinkLabel();
            this.chkRetakeCourse = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(188, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Course";
            // 
            // cbCourseName
            // 
            this.cbCourseName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCourseName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCourseName.DropDownHeight = 150;
            this.cbCourseName.DropDownWidth = 350;
            this.cbCourseName.FormattingEnabled = true;
            this.cbCourseName.IntegralHeight = false;
            this.cbCourseName.ItemHeight = 25;
            this.cbCourseName.Location = new System.Drawing.Point(142, 86);
            this.cbCourseName.Name = "cbCourseName";
            this.cbCourseName.Size = new System.Drawing.Size(176, 33);
            this.cbCourseName.TabIndex = 0;
            this.cbCourseName.SelectedIndexChanged += new System.EventHandler(this.cbCourseName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course NO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Course Name:";
            // 
            // lblCourseNo
            // 
            this.lblCourseNo.AutoSize = true;
            this.lblCourseNo.Location = new System.Drawing.Point(138, 40);
            this.lblCourseNo.Name = "lblCourseNo";
            this.lblCourseNo.Size = new System.Drawing.Size(34, 25);
            this.lblCourseNo.TabIndex = 4;
            this.lblCourseNo.Text = "??";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(416, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 237);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(91, 138);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(34, 25);
            this.lblHours.TabIndex = 7;
            this.lblHours.Text = "??";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hours:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMoreInfo);
            this.groupBox1.Controls.Add(this.llblCourseAttempts);
            this.groupBox1.Controls.Add(this.chkRetakeCourse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbCourseName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblHours);
            this.groupBox1.Controls.Add(this.lblCourseNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(52, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 249);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // lblMoreInfo
            // 
            this.lblMoreInfo.AutoSize = true;
            this.lblMoreInfo.Location = new System.Drawing.Point(242, 40);
            this.lblMoreInfo.Name = "lblMoreInfo";
            this.lblMoreInfo.Size = new System.Drawing.Size(93, 25);
            this.lblMoreInfo.TabIndex = 1;
            this.lblMoreInfo.TabStop = true;
            this.lblMoreInfo.Text = "More info";
            this.lblMoreInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblMoreInfo_LinkClicked);
            // 
            // llblCourseAttempts
            // 
            this.llblCourseAttempts.AutoSize = true;
            this.llblCourseAttempts.Enabled = false;
            this.llblCourseAttempts.Location = new System.Drawing.Point(190, 190);
            this.llblCourseAttempts.Name = "llblCourseAttempts";
            this.llblCourseAttempts.Size = new System.Drawing.Size(158, 25);
            this.llblCourseAttempts.TabIndex = 3;
            this.llblCourseAttempts.TabStop = true;
            this.llblCourseAttempts.Text = "Course Attempts";
            this.llblCourseAttempts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCourseAttempts_LinkClicked);
            // 
            // chkRetakeCourse
            // 
            this.chkRetakeCourse.AutoSize = true;
            this.chkRetakeCourse.Enabled = false;
            this.chkRetakeCourse.Location = new System.Drawing.Point(20, 186);
            this.chkRetakeCourse.Name = "chkRetakeCourse";
            this.chkRetakeCourse.Size = new System.Drawing.Size(164, 29);
            this.chkRetakeCourse.TabIndex = 12;
            this.chkRetakeCourse.Text = "Retake Course";
            this.chkRetakeCourse.UseVisualStyleBackColor = true;
            // 
            // frmAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 419);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddCourse";
            this.Load += new System.EventHandler(this.frmAddCourse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCourseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCourseNo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel llblCourseAttempts;
        private System.Windows.Forms.CheckBox chkRetakeCourse;
        private System.Windows.Forms.LinkLabel lblMoreInfo;
    }
}