namespace Formationofgroups.UI
{
    partial class Form1
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
            this.Tabpage = new System.Windows.Forms.TabControl();
            this.Course = new System.Windows.Forms.TabPage();
            this.ElectiveCourseDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageofStudent = new System.Windows.Forms.TabPage();
            this.StudentDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageOfGroup = new System.Windows.Forms.TabPage();
            this.GroupDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.StudentNameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ataGridView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Tabpage.SuspendLayout();
            this.Course.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElectiveCourseDataGridView)).BeginInit();
            this.tabPageofStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).BeginInit();
            this.tabPageOfGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabpage
            // 
            this.Tabpage.Controls.Add(this.Course);
            this.Tabpage.Controls.Add(this.tabPageofStudent);
            this.Tabpage.Controls.Add(this.tabPageOfGroup);
            this.Tabpage.Controls.Add(this.tabPage2);
            this.Tabpage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabpage.Location = new System.Drawing.Point(0, 0);
            this.Tabpage.Name = "Tabpage";
            this.Tabpage.SelectedIndex = 0;
            this.Tabpage.Size = new System.Drawing.Size(981, 450);
            this.Tabpage.TabIndex = 0;
            // 
            // Course
            // 
            this.Course.Controls.Add(this.ElectiveCourseDataGridView);
            this.Course.Location = new System.Drawing.Point(4, 25);
            this.Course.Name = "Course";
            this.Course.Padding = new System.Windows.Forms.Padding(3);
            this.Course.Size = new System.Drawing.Size(973, 421);
            this.Course.TabIndex = 0;
            this.Course.Text = "Elective course";
            this.Course.UseVisualStyleBackColor = true;
            // 
            // ElectiveCourseDataGridView
            // 
            this.ElectiveCourseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ElectiveCourseDataGridView.Location = new System.Drawing.Point(9, 7);
            this.ElectiveCourseDataGridView.Name = "ElectiveCourseDataGridView";
            this.ElectiveCourseDataGridView.RowHeadersWidth = 51;
            this.ElectiveCourseDataGridView.RowTemplate.Height = 24;
            this.ElectiveCourseDataGridView.Size = new System.Drawing.Size(605, 406);
            this.ElectiveCourseDataGridView.TabIndex = 0;
            // 
            // tabPageofStudent
            // 
            this.tabPageofStudent.Controls.Add(this.StudentDataGridView);
            this.tabPageofStudent.Location = new System.Drawing.Point(4, 25);
            this.tabPageofStudent.Name = "tabPageofStudent";
            this.tabPageofStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageofStudent.Size = new System.Drawing.Size(973, 421);
            this.tabPageofStudent.TabIndex = 1;
            this.tabPageofStudent.Text = "Students";
            this.tabPageofStudent.UseVisualStyleBackColor = true;
            // 
            // StudentDataGridView
            // 
            this.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataGridView.Location = new System.Drawing.Point(8, 6);
            this.StudentDataGridView.Name = "StudentDataGridView";
            this.StudentDataGridView.RowHeadersWidth = 51;
            this.StudentDataGridView.RowTemplate.Height = 24;
            this.StudentDataGridView.Size = new System.Drawing.Size(629, 407);
            this.StudentDataGridView.TabIndex = 0;
            this.StudentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataGridView_CellContentClick);
            // 
            // tabPageOfGroup
            // 
            this.tabPageOfGroup.Controls.Add(this.GroupDataGridView);
            this.tabPageOfGroup.Location = new System.Drawing.Point(4, 25);
            this.tabPageOfGroup.Name = "tabPageOfGroup";
            this.tabPageOfGroup.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOfGroup.Size = new System.Drawing.Size(973, 421);
            this.tabPageOfGroup.TabIndex = 2;
            this.tabPageOfGroup.Text = "Group";
            this.tabPageOfGroup.UseVisualStyleBackColor = true;
            // 
            // GroupDataGridView
            // 
            this.GroupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupDataGridView.Location = new System.Drawing.Point(6, 6);
            this.GroupDataGridView.Name = "GroupDataGridView";
            this.GroupDataGridView.RowHeadersWidth = 51;
            this.GroupDataGridView.RowTemplate.Height = 24;
            this.GroupDataGridView.Size = new System.Drawing.Size(341, 407);
            this.GroupDataGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.StudentNameLabel);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.ataGridView);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(973, 421);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Course registration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // StudentNameLabel
            // 
            this.StudentNameLabel.AutoSize = true;
            this.StudentNameLabel.Location = new System.Drawing.Point(643, 21);
            this.StudentNameLabel.Name = "StudentNameLabel";
            this.StudentNameLabel.Size = new System.Drawing.Size(84, 16);
            this.StudentNameLabel.TabIndex = 4;
            this.StudentNameLabel.Text = "Student Data";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(881, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(643, 57);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(322, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // ataGridView
            // 
            this.ataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ataGridView.Location = new System.Drawing.Point(8, 6);
            this.ataGridView.Name = "ataGridView";
            this.ataGridView.RowHeadersWidth = 51;
            this.ataGridView.RowTemplate.Height = 24;
            this.ataGridView.Size = new System.Drawing.Size(629, 407);
            this.ataGridView.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(643, 213);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.Tabpage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tabpage.ResumeLayout(false);
            this.Course.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ElectiveCourseDataGridView)).EndInit();
            this.tabPageofStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).EndInit();
            this.tabPageOfGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GroupDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabpage;
        private System.Windows.Forms.TabPage Course;
        private System.Windows.Forms.TabPage tabPageofStudent;
        private System.Windows.Forms.TabPage tabPageOfGroup;
        private System.Windows.Forms.DataGridView StudentDataGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView ElectiveCourseDataGridView;
        private System.Windows.Forms.DataGridView GroupDataGridView;
        private System.Windows.Forms.DataGridView ataGridView;
        private System.Windows.Forms.Label StudentNameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

