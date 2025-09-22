namespace GPACalculator
{
    partial class frmCertifiedCoursesForUser
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGradeSymbol = new System.Windows.Forms.ComboBox();
            this.ctrMyDataGridView1 = new GPACalculator.ctrMyDataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(372, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Certified Courses";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(292, 201);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(136, 30);
            this.txtFilter.TabIndex = 5;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "Course ID",
            "Name",
            "Grade Symbol"});
            this.cbFilterBy.Location = new System.Drawing.Point(125, 198);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(161, 33);
            this.cbFilterBy.TabIndex = 6;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Filter By:";
            // 
            // cbGradeSymbol
            // 
            this.cbGradeSymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGradeSymbol.FormattingEnabled = true;
            this.cbGradeSymbol.Location = new System.Drawing.Point(292, 198);
            this.cbGradeSymbol.Name = "cbGradeSymbol";
            this.cbGradeSymbol.Size = new System.Drawing.Size(80, 33);
            this.cbGradeSymbol.TabIndex = 8;
            this.cbGradeSymbol.Visible = false;
            this.cbGradeSymbol.SelectedIndexChanged += new System.EventHandler(this.cbGradeSymbol_SelectedIndexChanged);
            // 
            // ctrMyDataGridView1
            // 
            this.ctrMyDataGridView1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrMyDataGridView1.BackColor = System.Drawing.Color.White;
            this.ctrMyDataGridView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrMyDataGridView1.Location = new System.Drawing.Point(35, 239);
            this.ctrMyDataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrMyDataGridView1.Name = "ctrMyDataGridView1";
            this.ctrMyDataGridView1.Size = new System.Drawing.Size(918, 432);
            this.ctrMyDataGridView1.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmCertifiedCoursesForUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 692);
            this.Controls.Add(this.ctrMyDataGridView1);
            this.Controls.Add(this.cbGradeSymbol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCertifiedCoursesForUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCertifiedCoursesForUser";
            this.Load += new System.EventHandler(this.frmCertifiedCoursesForUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGradeSymbol;
        private ctrMyDataGridView ctrMyDataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}