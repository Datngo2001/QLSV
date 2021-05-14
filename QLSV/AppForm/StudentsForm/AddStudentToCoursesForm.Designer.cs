
namespace QLSV.AppForm.StudentsForm
{
    partial class AddStudentToCoursesForm
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
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxSelectedCourse = new System.Windows.Forms.ListBox();
            this.listBoxAvailableCourse = new System.Windows.Forms.ListBox();
            this.labelSelectedCourse = new System.Windows.Forms.Label();
            this.labelAvailableCourse = new System.Windows.Forms.Label();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.labelSemester = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAll
            // 
            this.buttonAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAll.Location = new System.Drawing.Point(321, 185);
            this.buttonAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(107, 62);
            this.buttonAll.TabIndex = 21;
            this.buttonAll.Text = "All";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(321, 325);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(107, 62);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(321, 255);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(107, 62);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxSelectedCourse
            // 
            this.listBoxSelectedCourse.FormattingEnabled = true;
            this.listBoxSelectedCourse.HorizontalScrollbar = true;
            this.listBoxSelectedCourse.ItemHeight = 20;
            this.listBoxSelectedCourse.Location = new System.Drawing.Point(445, 157);
            this.listBoxSelectedCourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxSelectedCourse.Name = "listBoxSelectedCourse";
            this.listBoxSelectedCourse.Size = new System.Drawing.Size(283, 284);
            this.listBoxSelectedCourse.TabIndex = 18;
            // 
            // listBoxAvailableCourse
            // 
            this.listBoxAvailableCourse.FormattingEnabled = true;
            this.listBoxAvailableCourse.ItemHeight = 20;
            this.listBoxAvailableCourse.Location = new System.Drawing.Point(22, 157);
            this.listBoxAvailableCourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxAvailableCourse.Name = "listBoxAvailableCourse";
            this.listBoxAvailableCourse.Size = new System.Drawing.Size(283, 284);
            this.listBoxAvailableCourse.TabIndex = 17;
            // 
            // labelSelectedCourse
            // 
            this.labelSelectedCourse.AutoSize = true;
            this.labelSelectedCourse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedCourse.Location = new System.Drawing.Point(440, 112);
            this.labelSelectedCourse.Name = "labelSelectedCourse";
            this.labelSelectedCourse.Size = new System.Drawing.Size(197, 27);
            this.labelSelectedCourse.TabIndex = 16;
            this.labelSelectedCourse.Text = "Selected Course:";
            // 
            // labelAvailableCourse
            // 
            this.labelAvailableCourse.AutoSize = true;
            this.labelAvailableCourse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableCourse.Location = new System.Drawing.Point(21, 112);
            this.labelAvailableCourse.Name = "labelAvailableCourse";
            this.labelAvailableCourse.Size = new System.Drawing.Size(199, 27);
            this.labelAvailableCourse.TabIndex = 15;
            this.labelAvailableCourse.Text = "Available Course:";
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.Font = new System.Drawing.Font("Arial", 13F);
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Location = new System.Drawing.Point(560, 41);
            this.comboBoxSemester.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(168, 39);
            this.comboBoxSemester.TabIndex = 14;
            // 
            // comboBoxID
            // 
            this.comboBoxID.Font = new System.Drawing.Font("Arial", 13F);
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(157, 41);
            this.comboBoxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(148, 39);
            this.comboBoxID.TabIndex = 13;
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.Location = new System.Drawing.Point(440, 44);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(121, 27);
            this.labelSemester.TabIndex = 12;
            this.labelSemester.Text = "Semester:";
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentID.Location = new System.Drawing.Point(17, 48);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(134, 27);
            this.labelStudentID.TabIndex = 11;
            this.labelStudentID.Text = "Student ID:";
            // 
            // AddStudentToCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 459);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxSelectedCourse);
            this.Controls.Add(this.listBoxAvailableCourse);
            this.Controls.Add(this.labelSelectedCourse);
            this.Controls.Add(this.labelAvailableCourse);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.labelSemester);
            this.Controls.Add(this.labelStudentID);
            this.Name = "AddStudentToCoursesForm";
            this.Text = "AddStudentToCoursesForm";
            this.Load += new System.EventHandler(this.AddCourseToStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxSelectedCourse;
        private System.Windows.Forms.ListBox listBoxAvailableCourse;
        private System.Windows.Forms.Label labelSelectedCourse;
        private System.Windows.Forms.Label labelAvailableCourse;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Label labelStudentID;
    }
}