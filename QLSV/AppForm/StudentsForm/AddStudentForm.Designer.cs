﻿
namespace QLSV.AppForm.StudentsForm
{
    partial class AddStudentForm
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
            this.id_lb = new System.Windows.Forms.Label();
            this.fname_lb = new System.Windows.Forms.Label();
            this.lname_lb = new System.Windows.Forms.Label();
            this.bdate_lb = new System.Windows.Forms.Label();
            this.gender_lb = new System.Windows.Forms.Label();
            this.phone_lb = new System.Windows.Forms.Label();
            this.address_lb = new System.Windows.Forms.Label();
            this.picture_lb = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.fname_tx = new System.Windows.Forms.TextBox();
            this.lname_tb = new System.Windows.Forms.TextBox();
            this.phone_tb = new System.Windows.Forms.TextBox();
            this.bdate_picker = new System.Windows.Forms.DateTimePicker();
            this.address_rtb = new System.Windows.Forms.RichTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.genderBtn_group = new System.Windows.Forms.GroupBox();
            this.female_rbtn = new System.Windows.Forms.RadioButton();
            this.male_rbtn = new System.Windows.Forms.RadioButton();
            this.upload_btn = new System.Windows.Forms.Button();
            this.check_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.genderBtn_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lb.Location = new System.Drawing.Point(8, 12);
            this.id_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(91, 20);
            this.id_lb.TabIndex = 0;
            this.id_lb.Text = "Student ID:";
            // 
            // fname_lb
            // 
            this.fname_lb.AutoSize = true;
            this.fname_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_lb.Location = new System.Drawing.Point(9, 51);
            this.fname_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fname_lb.Name = "fname_lb";
            this.fname_lb.Size = new System.Drawing.Size(90, 20);
            this.fname_lb.TabIndex = 1;
            this.fname_lb.Text = "First Name:";
            this.fname_lb.Click += new System.EventHandler(this.fname_lb_Click);
            // 
            // lname_lb
            // 
            this.lname_lb.AutoSize = true;
            this.lname_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_lb.Location = new System.Drawing.Point(9, 95);
            this.lname_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lname_lb.Name = "lname_lb";
            this.lname_lb.Size = new System.Drawing.Size(90, 20);
            this.lname_lb.TabIndex = 2;
            this.lname_lb.Text = "Last Name:";
            // 
            // bdate_lb
            // 
            this.bdate_lb.AutoSize = true;
            this.bdate_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdate_lb.Location = new System.Drawing.Point(18, 140);
            this.bdate_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bdate_lb.Name = "bdate_lb";
            this.bdate_lb.Size = new System.Drawing.Size(81, 20);
            this.bdate_lb.TabIndex = 3;
            this.bdate_lb.Text = "BirthDate:";
            // 
            // gender_lb
            // 
            this.gender_lb.AutoSize = true;
            this.gender_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_lb.Location = new System.Drawing.Point(32, 193);
            this.gender_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gender_lb.Name = "gender_lb";
            this.gender_lb.Size = new System.Drawing.Size(67, 20);
            this.gender_lb.TabIndex = 4;
            this.gender_lb.Text = "Gender:";
            // 
            // phone_lb
            // 
            this.phone_lb.AutoSize = true;
            this.phone_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_lb.Location = new System.Drawing.Point(36, 244);
            this.phone_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phone_lb.Name = "phone_lb";
            this.phone_lb.Size = new System.Drawing.Size(59, 20);
            this.phone_lb.TabIndex = 5;
            this.phone_lb.Text = "Phone:";
            this.phone_lb.Click += new System.EventHandler(this.phone_lb_Click);
            // 
            // address_lb
            // 
            this.address_lb.AutoSize = true;
            this.address_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_lb.Location = new System.Drawing.Point(323, 13);
            this.address_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.address_lb.Name = "address_lb";
            this.address_lb.Size = new System.Drawing.Size(72, 20);
            this.address_lb.TabIndex = 6;
            this.address_lb.Text = "Address:";
            // 
            // picture_lb
            // 
            this.picture_lb.AutoSize = true;
            this.picture_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picture_lb.Location = new System.Drawing.Point(332, 122);
            this.picture_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.picture_lb.Name = "picture_lb";
            this.picture_lb.Size = new System.Drawing.Size(62, 20);
            this.picture_lb.TabIndex = 7;
            this.picture_lb.Text = "Picture:";
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Location = new System.Drawing.Point(370, 310);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(123, 34);
            this.cancel_btn.TabIndex = 8;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Lime;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(174, 310);
            this.add_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(123, 34);
            this.add_btn.TabIndex = 9;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // id_tb
            // 
            this.id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_tb.Location = new System.Drawing.Point(103, 6);
            this.id_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(108, 26);
            this.id_tb.TabIndex = 10;
            this.id_tb.Text = " ";
            this.id_tb.TextChanged += new System.EventHandler(this.id_tb_TextChanged);
            // 
            // fname_tx
            // 
            this.fname_tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_tx.Location = new System.Drawing.Point(102, 48);
            this.fname_tx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fname_tx.Name = "fname_tx";
            this.fname_tx.Size = new System.Drawing.Size(203, 26);
            this.fname_tx.TabIndex = 11;
            this.fname_tx.TextChanged += new System.EventHandler(this.fname_tx_TextChanged);
            // 
            // lname_tb
            // 
            this.lname_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_tb.Location = new System.Drawing.Point(103, 92);
            this.lname_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lname_tb.Name = "lname_tb";
            this.lname_tb.Size = new System.Drawing.Size(202, 26);
            this.lname_tb.TabIndex = 12;
            this.lname_tb.TextChanged += new System.EventHandler(this.lname_tb_TextChanged);
            // 
            // phone_tb
            // 
            this.phone_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_tb.Location = new System.Drawing.Point(99, 242);
            this.phone_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phone_tb.Name = "phone_tb";
            this.phone_tb.Size = new System.Drawing.Size(205, 26);
            this.phone_tb.TabIndex = 13;
            this.phone_tb.TextChanged += new System.EventHandler(this.phone_tb_TextChanged);
            // 
            // bdate_picker
            // 
            this.bdate_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bdate_picker.Location = new System.Drawing.Point(103, 135);
            this.bdate_picker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bdate_picker.Name = "bdate_picker";
            this.bdate_picker.Size = new System.Drawing.Size(203, 26);
            this.bdate_picker.TabIndex = 15;
            // 
            // address_rtb
            // 
            this.address_rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_rtb.Location = new System.Drawing.Point(398, 14);
            this.address_rtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.address_rtb.Name = "address_rtb";
            this.address_rtb.Size = new System.Drawing.Size(202, 101);
            this.address_rtb.TabIndex = 16;
            this.address_rtb.Text = "";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox.Location = new System.Drawing.Point(398, 122);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(201, 118);
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            // 
            // genderBtn_group
            // 
            this.genderBtn_group.Controls.Add(this.female_rbtn);
            this.genderBtn_group.Controls.Add(this.male_rbtn);
            this.genderBtn_group.Location = new System.Drawing.Point(101, 181);
            this.genderBtn_group.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genderBtn_group.Name = "genderBtn_group";
            this.genderBtn_group.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genderBtn_group.Size = new System.Drawing.Size(203, 44);
            this.genderBtn_group.TabIndex = 18;
            this.genderBtn_group.TabStop = false;
            // 
            // female_rbtn
            // 
            this.female_rbtn.AutoSize = true;
            this.female_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female_rbtn.Location = new System.Drawing.Point(119, 10);
            this.female_rbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.female_rbtn.Name = "female_rbtn";
            this.female_rbtn.Size = new System.Drawing.Size(80, 24);
            this.female_rbtn.TabIndex = 1;
            this.female_rbtn.TabStop = true;
            this.female_rbtn.Text = "Female";
            this.female_rbtn.UseVisualStyleBackColor = true;
            // 
            // male_rbtn
            // 
            this.male_rbtn.AutoSize = true;
            this.male_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_rbtn.Location = new System.Drawing.Point(16, 10);
            this.male_rbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.male_rbtn.Name = "male_rbtn";
            this.male_rbtn.Size = new System.Drawing.Size(61, 24);
            this.male_rbtn.TabIndex = 0;
            this.male_rbtn.TabStop = true;
            this.male_rbtn.Text = "Male";
            this.male_rbtn.UseVisualStyleBackColor = true;
            this.male_rbtn.CheckedChanged += new System.EventHandler(this.male_rbtn_CheckedChanged);
            // 
            // upload_btn
            // 
            this.upload_btn.Location = new System.Drawing.Point(398, 245);
            this.upload_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Size = new System.Drawing.Size(201, 23);
            this.upload_btn.TabIndex = 19;
            this.upload_btn.Text = "Upload Image";
            this.upload_btn.UseVisualStyleBackColor = true;
            this.upload_btn.Click += new System.EventHandler(this.upload_btn_Click);
            // 
            // check_btn
            // 
            this.check_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_btn.Location = new System.Drawing.Point(223, 6);
            this.check_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(81, 27);
            this.check_btn.TabIndex = 20;
            this.check_btn.Text = "Check";
            this.check_btn.UseVisualStyleBackColor = true;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(641, 360);
            this.Controls.Add(this.check_btn);
            this.Controls.Add(this.upload_btn);
            this.Controls.Add(this.genderBtn_group);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.address_rtb);
            this.Controls.Add(this.bdate_picker);
            this.Controls.Add(this.phone_tb);
            this.Controls.Add(this.lname_tb);
            this.Controls.Add(this.fname_tx);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.picture_lb);
            this.Controls.Add(this.address_lb);
            this.Controls.Add(this.phone_lb);
            this.Controls.Add(this.gender_lb);
            this.Controls.Add(this.bdate_lb);
            this.Controls.Add(this.lname_lb);
            this.Controls.Add(this.fname_lb);
            this.Controls.Add(this.id_lb);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "AddStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a new student";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.genderBtn_group.ResumeLayout(false);
            this.genderBtn_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.Label fname_lb;
        private System.Windows.Forms.Label lname_lb;
        private System.Windows.Forms.Label bdate_lb;
        private System.Windows.Forms.Label gender_lb;
        private System.Windows.Forms.Label phone_lb;
        private System.Windows.Forms.Label address_lb;
        private System.Windows.Forms.Label picture_lb;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.TextBox fname_tx;
        private System.Windows.Forms.TextBox lname_tb;
        private System.Windows.Forms.TextBox phone_tb;
        private System.Windows.Forms.DateTimePicker bdate_picker;
        private System.Windows.Forms.RichTextBox address_rtb;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox genderBtn_group;
        private System.Windows.Forms.RadioButton female_rbtn;
        private System.Windows.Forms.RadioButton male_rbtn;
        private System.Windows.Forms.Button upload_btn;
        private System.Windows.Forms.Button check_btn;
    }
}