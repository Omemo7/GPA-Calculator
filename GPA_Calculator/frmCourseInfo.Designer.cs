namespace GPACalculator
{
    partial class frmCourseInfo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCourseNO = new System.Windows.Forms.Label();
            this.dgvCoursePrerequisists = new GPACalculator.ctrMyDataGridView();
            this.dgvCoursesThatThisCourseIsPrerequisiteFor = new GPACalculator.ctrMyDataGridView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Group:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hours:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Course prerequisites:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(380, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Courses that this course is prerequisite for:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(247, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 42);
            this.label7.TabIndex = 8;
            this.label7.Text = "Course Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHours);
            this.groupBox1.Controls.Add(this.lblGroup);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblCourseNO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(11, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 144);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(405, 41);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(34, 25);
            this.lblHours.TabIndex = 7;
            this.lblHours.Text = "??";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.Location = new System.Drawing.Point(403, 81);
            this.lblGroup.MaximumSize = new System.Drawing.Size(185, 0);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(34, 25);
            this.lblGroup.TabIndex = 6;
            this.lblGroup.Text = "??";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(96, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 25);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "??";
            // 
            // lblCourseNO
            // 
            this.lblCourseNO.AutoSize = true;
            this.lblCourseNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseNO.Location = new System.Drawing.Point(128, 41);
            this.lblCourseNO.Name = "lblCourseNO";
            this.lblCourseNO.Size = new System.Drawing.Size(34, 25);
            this.lblCourseNO.TabIndex = 4;
            this.lblCourseNO.Text = "??";
            // 
            // dgvCoursePrerequisists
            // 
            this.dgvCoursePrerequisists.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dgvCoursePrerequisists.BackColor = System.Drawing.Color.White;
            this.dgvCoursePrerequisists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCoursePrerequisists.Location = new System.Drawing.Point(9, 292);
            this.dgvCoursePrerequisists.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCoursePrerequisists.Name = "dgvCoursePrerequisists";
            this.dgvCoursePrerequisists.Size = new System.Drawing.Size(669, 154);
            this.dgvCoursePrerequisists.TabIndex = 14;
            // 
            // dgvCoursesThatThisCourseIsPrerequisiteFor
            // 
            this.dgvCoursesThatThisCourseIsPrerequisiteFor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dgvCoursesThatThisCourseIsPrerequisiteFor.BackColor = System.Drawing.Color.White;
            this.dgvCoursesThatThisCourseIsPrerequisiteFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCoursesThatThisCourseIsPrerequisiteFor.Location = new System.Drawing.Point(10, 513);
            this.dgvCoursesThatThisCourseIsPrerequisiteFor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCoursesThatThisCourseIsPrerequisiteFor.Name = "dgvCoursesThatThisCourseIsPrerequisiteFor";
            this.dgvCoursesThatThisCourseIsPrerequisiteFor.Size = new System.Drawing.Size(669, 154);
            this.dgvCoursesThatThisCourseIsPrerequisiteFor.TabIndex = 15;
            // 
            // frmCourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 707);
            this.Controls.Add(this.dgvCoursesThatThisCourseIsPrerequisiteFor);
            this.Controls.Add(this.dgvCoursePrerequisists);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCourseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmCourseInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCourseNO;
        private ctrMyDataGridView dgvCoursePrerequisists;
        private ctrMyDataGridView dgvCoursesThatThisCourseIsPrerequisiteFor;
    }
}