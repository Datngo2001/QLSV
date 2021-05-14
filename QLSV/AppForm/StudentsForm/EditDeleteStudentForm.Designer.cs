
namespace QLSV.AppForm.StudentsForm
{
    partial class EditDeleteStudentForm
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
            this.Id_tb = new System.Windows.Forms.TextBox();
            this.FirstName_tb = new System.Windows.Forms.TextBox();
            this.LastName_tb = new System.Windows.Forms.TextBox();
            this.Phone_tb = new System.Windows.Forms.TextBox();
            this.BirthDay_picker = new System.Windows.Forms.DateTimePicker();
            this.genderBtn_group = new System.Windows.Forms.GroupBox();
            this.female_rbtn = new System.Windows.Forms.RadioButton();
            this.male_rbtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.findID_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Address_rtb = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Upload = new System.Windows.Forms.Button();
            this.findByPhone_btn = new System.Windows.Forms.Button();
            this.firstNameFind_btn = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.courses_btn = new System.Windows.Forms.Button();
            this.cources_lb = new System.Windows.Forms.Label();
            this.student_pcb = new System.Windows.Forms.PictureBox();
            this.genderBtn_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_pcb)).BeginInit();
            this.SuspendLayout();
            // 
            // Id_tb
            // 
            this.Id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_tb.Location = new System.Drawing.Point(217, 76);
            this.Id_tb.Name = "Id_tb";
            this.Id_tb.Size = new System.Drawing.Size(185, 35);
            this.Id_tb.TabIndex = 0;
            // 
            // FirstName_tb
            // 
            this.FirstName_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName_tb.Location = new System.Drawing.Point(217, 147);
            this.FirstName_tb.Name = "FirstName_tb";
            this.FirstName_tb.Size = new System.Drawing.Size(185, 35);
            this.FirstName_tb.TabIndex = 0;
            // 
            // LastName_tb
            // 
            this.LastName_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_tb.Location = new System.Drawing.Point(217, 223);
            this.LastName_tb.Name = "LastName_tb";
            this.LastName_tb.Size = new System.Drawing.Size(301, 35);
            this.LastName_tb.TabIndex = 0;
            // 
            // Phone_tb
            // 
            this.Phone_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_tb.Location = new System.Drawing.Point(217, 469);
            this.Phone_tb.Name = "Phone_tb";
            this.Phone_tb.Size = new System.Drawing.Size(185, 35);
            this.Phone_tb.TabIndex = 0;
            // 
            // BirthDay_picker
            // 
            this.BirthDay_picker.CustomFormat = "dd-mm-yyyy";
            this.BirthDay_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDay_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDay_picker.Location = new System.Drawing.Point(217, 304);
            this.BirthDay_picker.Name = "BirthDay_picker";
            this.BirthDay_picker.Size = new System.Drawing.Size(301, 35);
            this.BirthDay_picker.TabIndex = 1;
            this.BirthDay_picker.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // genderBtn_group
            // 
            this.genderBtn_group.Controls.Add(this.female_rbtn);
            this.genderBtn_group.Controls.Add(this.male_rbtn);
            this.genderBtn_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderBtn_group.Location = new System.Drawing.Point(217, 366);
            this.genderBtn_group.Name = "genderBtn_group";
            this.genderBtn_group.Size = new System.Drawing.Size(301, 58);
            this.genderBtn_group.TabIndex = 19;
            this.genderBtn_group.TabStop = false;
            // 
            // female_rbtn
            // 
            this.female_rbtn.AutoSize = true;
            this.female_rbtn.Location = new System.Drawing.Point(175, 16);
            this.female_rbtn.Name = "female_rbtn";
            this.female_rbtn.Size = new System.Drawing.Size(120, 33);
            this.female_rbtn.TabIndex = 1;
            this.female_rbtn.TabStop = true;
            this.female_rbtn.Text = "Female";
            this.female_rbtn.UseVisualStyleBackColor = true;
            // 
            // male_rbtn
            // 
            this.male_rbtn.AutoSize = true;
            this.male_rbtn.Location = new System.Drawing.Point(16, 16);
            this.male_rbtn.Name = "male_rbtn";
            this.male_rbtn.Size = new System.Drawing.Size(91, 33);
            this.male_rbtn.TabIndex = 0;
            this.male_rbtn.TabStop = true;
            this.male_rbtn.Text = "Male";
            this.male_rbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Birth Day:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Phone:";
            // 
            // findID_btn
            // 
            this.findID_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findID_btn.Location = new System.Drawing.Point(408, 76);
            this.findID_btn.Name = "findID_btn";
            this.findID_btn.Size = new System.Drawing.Size(110, 35);
            this.findID_btn.TabIndex = 21;
            this.findID_btn.Text = "Find";
            this.findID_btn.UseVisualStyleBackColor = true;
            this.findID_btn.Click += new System.EventHandler(this.Find_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(580, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "Address:";
            // 
            // Address_rtb
            // 
            this.Address_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_rtb.Location = new System.Drawing.Point(715, 76);
            this.Address_rtb.Name = "Address_rtb";
            this.Address_rtb.Size = new System.Drawing.Size(388, 226);
            this.Address_rtb.TabIndex = 22;
            this.Address_rtb.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(580, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "Pictire:";
            // 
            // Edit
            // 
            this.Edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Edit.BackColor = System.Drawing.Color.LimeGreen;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Edit.Location = new System.Drawing.Point(132, 671);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(257, 59);
            this.Edit.TabIndex = 24;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Remove
            // 
            this.Remove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Remove.BackColor = System.Drawing.Color.Red;
            this.Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Remove.Location = new System.Drawing.Point(426, 671);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(168, 59);
            this.Remove.TabIndex = 24;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(715, 596);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(388, 40);
            this.Upload.TabIndex = 25;
            this.Upload.Text = "Upload Image";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // findByPhone_btn
            // 
            this.findByPhone_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findByPhone_btn.Location = new System.Drawing.Point(408, 469);
            this.findByPhone_btn.Name = "findByPhone_btn";
            this.findByPhone_btn.Size = new System.Drawing.Size(110, 35);
            this.findByPhone_btn.TabIndex = 21;
            this.findByPhone_btn.Text = "Find";
            this.findByPhone_btn.UseVisualStyleBackColor = true;
            this.findByPhone_btn.Click += new System.EventHandler(this.findByPhone_btn_Click);
            // 
            // firstNameFind_btn
            // 
            this.firstNameFind_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameFind_btn.Location = new System.Drawing.Point(408, 147);
            this.firstNameFind_btn.Name = "firstNameFind_btn";
            this.firstNameFind_btn.Size = new System.Drawing.Size(110, 35);
            this.firstNameFind_btn.TabIndex = 21;
            this.firstNameFind_btn.Text = "Find";
            this.firstNameFind_btn.UseVisualStyleBackColor = true;
            this.firstNameFind_btn.Click += new System.EventHandler(this.firstNameFind_btn_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel.BackColor = System.Drawing.Color.DarkGray;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel.Location = new System.Drawing.Point(642, 671);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(168, 59);
            this.Cancel.TabIndex = 24;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // courses_btn
            // 
            this.courses_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.courses_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courses_btn.ForeColor = System.Drawing.Color.Black;
            this.courses_btn.Location = new System.Drawing.Point(217, 550);
            this.courses_btn.Name = "courses_btn";
            this.courses_btn.Size = new System.Drawing.Size(301, 40);
            this.courses_btn.TabIndex = 24;
            this.courses_btn.Text = "Add Course";
            this.courses_btn.UseVisualStyleBackColor = false;
            this.courses_btn.Click += new System.EventHandler(this.courses_btn_Click);
            // 
            // cources_lb
            // 
            this.cources_lb.AutoSize = true;
            this.cources_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cources_lb.Location = new System.Drawing.Point(47, 556);
            this.cources_lb.Name = "cources_lb";
            this.cources_lb.Size = new System.Drawing.Size(109, 29);
            this.cources_lb.TabIndex = 20;
            this.cources_lb.Text = "Cources:";
            // 
            // student_pcb
            // 
            this.student_pcb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.student_pcb.Location = new System.Drawing.Point(715, 319);
            this.student_pcb.Name = "student_pcb";
            this.student_pcb.Size = new System.Drawing.Size(388, 271);
            this.student_pcb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.student_pcb.TabIndex = 23;
            this.student_pcb.TabStop = false;
            // 
            // EditDeleteStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1164, 752);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.courses_btn);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.student_pcb);
            this.Controls.Add(this.Address_rtb);
            this.Controls.Add(this.firstNameFind_btn);
            this.Controls.Add(this.findByPhone_btn);
            this.Controls.Add(this.findID_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cources_lb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genderBtn_group);
            this.Controls.Add(this.BirthDay_picker);
            this.Controls.Add(this.Phone_tb);
            this.Controls.Add(this.LastName_tb);
            this.Controls.Add(this.FirstName_tb);
            this.Controls.Add(this.Id_tb);
            this.Name = "EditDeleteStudentForm";
            this.Text = "Edit and Delete";
            this.Load += new System.EventHandler(this.EditDeleteStudentForm_Load);
            this.genderBtn_group.ResumeLayout(false);
            this.genderBtn_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_pcb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Id_tb;
        public System.Windows.Forms.TextBox FirstName_tb;
        public System.Windows.Forms.TextBox LastName_tb;
        public System.Windows.Forms.TextBox Phone_tb;
        public System.Windows.Forms.DateTimePicker BirthDay_picker;
        public System.Windows.Forms.GroupBox genderBtn_group;
        public System.Windows.Forms.RadioButton female_rbtn;
        public System.Windows.Forms.RadioButton male_rbtn;
        public System.Windows.Forms.Button findID_btn;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.RichTextBox Address_rtb;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.PictureBox student_pcb;
        public System.Windows.Forms.Button Edit;
        public System.Windows.Forms.Button Remove;
        public System.Windows.Forms.Button Upload;
        public System.Windows.Forms.Button findByPhone_btn;
        public System.Windows.Forms.Button firstNameFind_btn;
        public System.Windows.Forms.Button Cancel;
        public System.Windows.Forms.Button courses_btn;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label cources_lb;
    }
}