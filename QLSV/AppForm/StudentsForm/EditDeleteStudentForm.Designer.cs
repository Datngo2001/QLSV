
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
            this.id_lb = new System.Windows.Forms.Label();
            this.fname_lb = new System.Windows.Forms.Label();
            this.lname_lb = new System.Windows.Forms.Label();
            this.bdate_lb = new System.Windows.Forms.Label();
            this.gender_lb = new System.Windows.Forms.Label();
            this.phone_lb = new System.Windows.Forms.Label();
            this.findID_btn = new System.Windows.Forms.Button();
            this.address_lb = new System.Windows.Forms.Label();
            this.Address_rtb = new System.Windows.Forms.RichTextBox();
            this.picture_lb = new System.Windows.Forms.Label();
            this.edit_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.upload_btn = new System.Windows.Forms.Button();
            this.findByPhone_btn = new System.Windows.Forms.Button();
            this.firstNameFind_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
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
            this.Id_tb.Location = new System.Drawing.Point(218, 75);
            this.Id_tb.Name = "Id_tb";
            this.Id_tb.Size = new System.Drawing.Size(186, 35);
            this.Id_tb.TabIndex = 0;
            // 
            // FirstName_tb
            // 
            this.FirstName_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName_tb.Location = new System.Drawing.Point(218, 148);
            this.FirstName_tb.Name = "FirstName_tb";
            this.FirstName_tb.Size = new System.Drawing.Size(186, 35);
            this.FirstName_tb.TabIndex = 0;
            // 
            // LastName_tb
            // 
            this.LastName_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_tb.Location = new System.Drawing.Point(218, 223);
            this.LastName_tb.Name = "LastName_tb";
            this.LastName_tb.Size = new System.Drawing.Size(301, 35);
            this.LastName_tb.TabIndex = 0;
            // 
            // Phone_tb
            // 
            this.Phone_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_tb.Location = new System.Drawing.Point(218, 469);
            this.Phone_tb.Name = "Phone_tb";
            this.Phone_tb.Size = new System.Drawing.Size(186, 35);
            this.Phone_tb.TabIndex = 0;
            // 
            // BirthDay_picker
            // 
            this.BirthDay_picker.CustomFormat = "dd-mm-yyyy";
            this.BirthDay_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDay_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDay_picker.Location = new System.Drawing.Point(218, 305);
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
            this.genderBtn_group.Location = new System.Drawing.Point(218, 366);
            this.genderBtn_group.Name = "genderBtn_group";
            this.genderBtn_group.Size = new System.Drawing.Size(302, 58);
            this.genderBtn_group.TabIndex = 19;
            this.genderBtn_group.TabStop = false;
            // 
            // female_rbtn
            // 
            this.female_rbtn.AutoSize = true;
            this.female_rbtn.Location = new System.Drawing.Point(176, 15);
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
            this.male_rbtn.Location = new System.Drawing.Point(16, 15);
            this.male_rbtn.Name = "male_rbtn";
            this.male_rbtn.Size = new System.Drawing.Size(91, 33);
            this.male_rbtn.TabIndex = 0;
            this.male_rbtn.TabStop = true;
            this.male_rbtn.Text = "Male";
            this.male_rbtn.UseVisualStyleBackColor = true;
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lb.Location = new System.Drawing.Point(46, 75);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(42, 29);
            this.id_lb.TabIndex = 20;
            this.id_lb.Text = "ID:";
            // 
            // fname_lb
            // 
            this.fname_lb.AutoSize = true;
            this.fname_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_lb.Location = new System.Drawing.Point(46, 152);
            this.fname_lb.Name = "fname_lb";
            this.fname_lb.Size = new System.Drawing.Size(137, 29);
            this.fname_lb.TabIndex = 20;
            this.fname_lb.Text = "First Name:";
            // 
            // lname_lb
            // 
            this.lname_lb.AutoSize = true;
            this.lname_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_lb.Location = new System.Drawing.Point(46, 223);
            this.lname_lb.Name = "lname_lb";
            this.lname_lb.Size = new System.Drawing.Size(134, 29);
            this.lname_lb.TabIndex = 20;
            this.lname_lb.Text = "Last Name:";
            // 
            // bdate_lb
            // 
            this.bdate_lb.AutoSize = true;
            this.bdate_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdate_lb.Location = new System.Drawing.Point(46, 305);
            this.bdate_lb.Name = "bdate_lb";
            this.bdate_lb.Size = new System.Drawing.Size(115, 29);
            this.bdate_lb.TabIndex = 20;
            this.bdate_lb.Text = "Birth Day:";
            // 
            // gender_lb
            // 
            this.gender_lb.AutoSize = true;
            this.gender_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_lb.Location = new System.Drawing.Point(46, 382);
            this.gender_lb.Name = "gender_lb";
            this.gender_lb.Size = new System.Drawing.Size(100, 29);
            this.gender_lb.TabIndex = 20;
            this.gender_lb.Text = "Gender:";
            // 
            // phone_lb
            // 
            this.phone_lb.AutoSize = true;
            this.phone_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_lb.Location = new System.Drawing.Point(46, 472);
            this.phone_lb.Name = "phone_lb";
            this.phone_lb.Size = new System.Drawing.Size(89, 29);
            this.phone_lb.TabIndex = 20;
            this.phone_lb.Text = "Phone:";
            // 
            // findID_btn
            // 
            this.findID_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findID_btn.Location = new System.Drawing.Point(408, 75);
            this.findID_btn.Name = "findID_btn";
            this.findID_btn.Size = new System.Drawing.Size(110, 40);
            this.findID_btn.TabIndex = 21;
            this.findID_btn.Text = "Find";
            this.findID_btn.UseVisualStyleBackColor = true;
            this.findID_btn.Click += new System.EventHandler(this.Find_Click);
            // 
            // address_lb
            // 
            this.address_lb.AutoSize = true;
            this.address_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_lb.Location = new System.Drawing.Point(580, 75);
            this.address_lb.Name = "address_lb";
            this.address_lb.Size = new System.Drawing.Size(108, 29);
            this.address_lb.TabIndex = 20;
            this.address_lb.Text = "Address:";
            // 
            // Address_rtb
            // 
            this.Address_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_rtb.Location = new System.Drawing.Point(716, 75);
            this.Address_rtb.Name = "Address_rtb";
            this.Address_rtb.Size = new System.Drawing.Size(388, 226);
            this.Address_rtb.TabIndex = 22;
            this.Address_rtb.Text = "";
            // 
            // picture_lb
            // 
            this.picture_lb.AutoSize = true;
            this.picture_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picture_lb.Location = new System.Drawing.Point(580, 318);
            this.picture_lb.Name = "picture_lb";
            this.picture_lb.Size = new System.Drawing.Size(87, 29);
            this.picture_lb.TabIndex = 20;
            this.picture_lb.Text = "Pictire:";
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edit_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit_btn.Location = new System.Drawing.Point(240, 657);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(256, 58);
            this.edit_btn.TabIndex = 24;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.Edit_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.remove_btn.BackColor = System.Drawing.Color.Red;
            this.remove_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.remove_btn.Location = new System.Drawing.Point(546, 657);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(168, 58);
            this.remove_btn.TabIndex = 24;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = false;
            this.remove_btn.Click += new System.EventHandler(this.Remove_Click);
            // 
            // upload_btn
            // 
            this.upload_btn.Location = new System.Drawing.Point(716, 595);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Size = new System.Drawing.Size(388, 40);
            this.upload_btn.TabIndex = 25;
            this.upload_btn.Text = "Upload Image";
            this.upload_btn.UseVisualStyleBackColor = true;
            this.upload_btn.Click += new System.EventHandler(this.Upload_Click);
            // 
            // findByPhone_btn
            // 
            this.findByPhone_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findByPhone_btn.Location = new System.Drawing.Point(408, 469);
            this.findByPhone_btn.Name = "findByPhone_btn";
            this.findByPhone_btn.Size = new System.Drawing.Size(110, 40);
            this.findByPhone_btn.TabIndex = 21;
            this.findByPhone_btn.Text = "Find";
            this.findByPhone_btn.UseVisualStyleBackColor = true;
            this.findByPhone_btn.Click += new System.EventHandler(this.findByPhone_btn_Click);
            // 
            // firstNameFind_btn
            // 
            this.firstNameFind_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameFind_btn.Location = new System.Drawing.Point(408, 148);
            this.firstNameFind_btn.Name = "firstNameFind_btn";
            this.firstNameFind_btn.Size = new System.Drawing.Size(110, 40);
            this.firstNameFind_btn.TabIndex = 21;
            this.firstNameFind_btn.Text = "Find";
            this.firstNameFind_btn.UseVisualStyleBackColor = true;
            this.firstNameFind_btn.Click += new System.EventHandler(this.firstNameFind_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel_btn.BackColor = System.Drawing.Color.DarkGray;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel_btn.Location = new System.Drawing.Point(758, 657);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(168, 58);
            this.cancel_btn.TabIndex = 24;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // courses_btn
            // 
            this.courses_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.courses_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courses_btn.ForeColor = System.Drawing.Color.Black;
            this.courses_btn.Location = new System.Drawing.Point(218, 549);
            this.courses_btn.Name = "courses_btn";
            this.courses_btn.Size = new System.Drawing.Size(302, 40);
            this.courses_btn.TabIndex = 24;
            this.courses_btn.Text = "Add Course";
            this.courses_btn.UseVisualStyleBackColor = false;
            this.courses_btn.Click += new System.EventHandler(this.courses_btn_Click);
            // 
            // cources_lb
            // 
            this.cources_lb.AutoSize = true;
            this.cources_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cources_lb.Location = new System.Drawing.Point(46, 555);
            this.cources_lb.Name = "cources_lb";
            this.cources_lb.Size = new System.Drawing.Size(109, 29);
            this.cources_lb.TabIndex = 20;
            this.cources_lb.Text = "Cources:";
            // 
            // student_pcb
            // 
            this.student_pcb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.student_pcb.Location = new System.Drawing.Point(716, 318);
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
            this.ClientSize = new System.Drawing.Size(1164, 732);
            this.Controls.Add(this.upload_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.courses_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.student_pcb);
            this.Controls.Add(this.Address_rtb);
            this.Controls.Add(this.firstNameFind_btn);
            this.Controls.Add(this.findByPhone_btn);
            this.Controls.Add(this.findID_btn);
            this.Controls.Add(this.picture_lb);
            this.Controls.Add(this.address_lb);
            this.Controls.Add(this.cources_lb);
            this.Controls.Add(this.phone_lb);
            this.Controls.Add(this.gender_lb);
            this.Controls.Add(this.bdate_lb);
            this.Controls.Add(this.lname_lb);
            this.Controls.Add(this.fname_lb);
            this.Controls.Add(this.id_lb);
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
        public System.Windows.Forms.Label address_lb;
        public System.Windows.Forms.RichTextBox Address_rtb;
        public System.Windows.Forms.Label picture_lb;
        public System.Windows.Forms.PictureBox student_pcb;
        public System.Windows.Forms.Button edit_btn;
        public System.Windows.Forms.Button remove_btn;
        public System.Windows.Forms.Button upload_btn;
        public System.Windows.Forms.Button findByPhone_btn;
        public System.Windows.Forms.Button firstNameFind_btn;
        public System.Windows.Forms.Button cancel_btn;
        public System.Windows.Forms.Button courses_btn;
        public System.Windows.Forms.Label id_lb;
        public System.Windows.Forms.Label fname_lb;
        public System.Windows.Forms.Label lname_lb;
        public System.Windows.Forms.Label bdate_lb;
        public System.Windows.Forms.Label gender_lb;
        public System.Windows.Forms.Label phone_lb;
        public System.Windows.Forms.Label cources_lb;
    }
}