
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
            this.selectedCourse_lstb = new System.Windows.Forms.ListBox();
            this.availableCourse_lstb = new System.Windows.Forms.ListBox();
            this.labelSelectedCourse = new System.Windows.Forms.Label();
            this.labelAvailableCourse = new System.Windows.Forms.Label();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.id_cb = new System.Windows.Forms.ComboBox();
            this.labelSemester = new System.Windows.Forms.Label();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.remove_btn = new System.Windows.Forms.Button();
            this.removeAll_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAll
            // 
            this.buttonAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAll.Location = new System.Drawing.Point(325, 157);
            this.buttonAll.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(136, 62);
            this.buttonAll.TabIndex = 21;
            this.buttonAll.Text = "Add All";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(279, 452);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(220, 52);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(325, 228);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(136, 62);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // selectedCourse_lstb
            // 
            this.selectedCourse_lstb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCourse_lstb.FormattingEnabled = true;
            this.selectedCourse_lstb.HorizontalScrollbar = true;
            this.selectedCourse_lstb.ItemHeight = 29;
            this.selectedCourse_lstb.Location = new System.Drawing.Point(36, 157);
            this.selectedCourse_lstb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.selectedCourse_lstb.Name = "selectedCourse_lstb";
            this.selectedCourse_lstb.Size = new System.Drawing.Size(283, 265);
            this.selectedCourse_lstb.TabIndex = 18;
            // 
            // availableCourse_lstb
            // 
            this.availableCourse_lstb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableCourse_lstb.FormattingEnabled = true;
            this.availableCourse_lstb.ItemHeight = 29;
            this.availableCourse_lstb.Location = new System.Drawing.Point(467, 156);
            this.availableCourse_lstb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.availableCourse_lstb.Name = "availableCourse_lstb";
            this.availableCourse_lstb.Size = new System.Drawing.Size(283, 265);
            this.availableCourse_lstb.TabIndex = 17;
            // 
            // labelSelectedCourse
            // 
            this.labelSelectedCourse.AutoSize = true;
            this.labelSelectedCourse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedCourse.Location = new System.Drawing.Point(12, 112);
            this.labelSelectedCourse.Name = "labelSelectedCourse";
            this.labelSelectedCourse.Size = new System.Drawing.Size(197, 27);
            this.labelSelectedCourse.TabIndex = 16;
            this.labelSelectedCourse.Text = "Selected Course:";
            // 
            // labelAvailableCourse
            // 
            this.labelAvailableCourse.AutoSize = true;
            this.labelAvailableCourse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableCourse.Location = new System.Drawing.Point(466, 111);
            this.labelAvailableCourse.Name = "labelAvailableCourse";
            this.labelAvailableCourse.Size = new System.Drawing.Size(199, 27);
            this.labelAvailableCourse.TabIndex = 15;
            this.labelAvailableCourse.Text = "Available Course:";
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.Font = new System.Drawing.Font("Arial", 13F);
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Location = new System.Drawing.Point(582, 42);
            this.comboBoxSemester.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(168, 39);
            this.comboBoxSemester.TabIndex = 14;
            // 
            // id_cb
            // 
            this.id_cb.Font = new System.Drawing.Font("Arial", 13F);
            this.id_cb.FormattingEnabled = true;
            this.id_cb.Location = new System.Drawing.Point(158, 42);
            this.id_cb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.id_cb.Name = "id_cb";
            this.id_cb.Size = new System.Drawing.Size(148, 39);
            this.id_cb.TabIndex = 13;
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemester.Location = new System.Drawing.Point(465, 49);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(121, 27);
            this.labelSemester.TabIndex = 12;
            this.labelSemester.Text = "Semester:";
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentID.Location = new System.Drawing.Point(16, 48);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(134, 27);
            this.labelStudentID.TabIndex = 11;
            this.labelStudentID.Text = "Student ID:";
            // 
            // remove_btn
            // 
            this.remove_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.Location = new System.Drawing.Point(325, 309);
            this.remove_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(136, 62);
            this.remove_btn.TabIndex = 19;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // removeAll_btn
            // 
            this.removeAll_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAll_btn.Location = new System.Drawing.Point(325, 378);
            this.removeAll_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.removeAll_btn.Name = "removeAll_btn";
            this.removeAll_btn.Size = new System.Drawing.Size(136, 62);
            this.removeAll_btn.TabIndex = 19;
            this.removeAll_btn.Text = "Remove All";
            this.removeAll_btn.UseVisualStyleBackColor = true;
            this.removeAll_btn.Click += new System.EventHandler(this.removeAll_btn_Click);
            // 
            // AddStudentToCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 515);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.removeAll_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.selectedCourse_lstb);
            this.Controls.Add(this.availableCourse_lstb);
            this.Controls.Add(this.labelSelectedCourse);
            this.Controls.Add(this.labelAvailableCourse);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.id_cb);
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
        private System.Windows.Forms.ListBox selectedCourse_lstb;
        private System.Windows.Forms.ListBox availableCourse_lstb;
        private System.Windows.Forms.Label labelSelectedCourse;
        private System.Windows.Forms.Label labelAvailableCourse;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button removeAll_btn;
        private System.Windows.Forms.ComboBox id_cb;
    }
}