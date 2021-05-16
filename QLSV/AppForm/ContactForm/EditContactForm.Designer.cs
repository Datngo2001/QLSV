
namespace QLSV.AppForm.ContactForm
{
    partial class EditContactForm
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
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.labelPicture = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.labelFname = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelEdit = new System.Windows.Forms.Label();
            this.pictureContact = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureContact)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(123, 233);
            this.comboBoxGroup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(237, 26);
            this.comboBoxGroup.TabIndex = 51;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.White;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(271, 71);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(87, 26);
            this.buttonSearch.TabIndex = 50;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(409, 387);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(139, 47);
            this.buttonCancel.TabIndex = 49;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Lime;
            this.buttonEdit.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(231, 387);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(139, 47);
            this.buttonEdit.TabIndex = 48;
            this.buttonEdit.Text = "Edit Contact";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpload.Location = new System.Drawing.Point(457, 338);
            this.buttonUpload.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(238, 26);
            this.buttonUpload.TabIndex = 47;
            this.buttonUpload.Text = "Upload Image";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(459, 71);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(237, 96);
            this.textBoxAddress.TabIndex = 45;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(123, 338);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(239, 26);
            this.textBoxEmail.TabIndex = 44;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(123, 284);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(237, 26);
            this.textBoxPhone.TabIndex = 43;
            // 
            // textBoxLname
            // 
            this.textBoxLname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLname.Location = new System.Drawing.Point(121, 182);
            this.textBoxLname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(237, 26);
            this.textBoxLname.TabIndex = 42;
            // 
            // textBoxFname
            // 
            this.textBoxFname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFname.Location = new System.Drawing.Point(121, 126);
            this.textBoxFname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(237, 26);
            this.textBoxFname.TabIndex = 41;
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPicture.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPicture.Location = new System.Drawing.Point(384, 182);
            this.labelPicture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(74, 22);
            this.labelPicture.TabIndex = 40;
            this.labelPicture.Text = "Picture:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAddress.Location = new System.Drawing.Point(374, 71);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(87, 22);
            this.labelAddress.TabIndex = 39;
            this.labelAddress.Text = "Address:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEmail.Location = new System.Drawing.Point(59, 341);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(62, 22);
            this.labelEmail.TabIndex = 38;
            this.labelEmail.Text = "Email:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPhone.Location = new System.Drawing.Point(50, 286);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(70, 22);
            this.labelPhone.TabIndex = 37;
            this.labelPhone.Text = "Phone:";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGroup.Location = new System.Drawing.Point(53, 237);
            this.labelGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(68, 22);
            this.labelGroup.TabIndex = 36;
            this.labelGroup.Text = "Group:";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLname.Location = new System.Drawing.Point(14, 185);
            this.labelLname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(106, 22);
            this.labelLname.TabIndex = 35;
            this.labelLname.Text = "Last Name:";
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFname.Location = new System.Drawing.Point(14, 129);
            this.labelFname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(107, 22);
            this.labelFname.TabIndex = 34;
            this.labelFname.Text = "First Name:";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(121, 71);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(146, 26);
            this.textBoxID.TabIndex = 33;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelID.Location = new System.Drawing.Point(17, 74);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(105, 22);
            this.labelID.TabIndex = 32;
            this.labelID.Text = "Contact ID:";
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEdit.Location = new System.Drawing.Point(297, 9);
            this.labelEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(177, 32);
            this.labelEdit.TabIndex = 31;
            this.labelEdit.Text = "Edit Contact";
            // 
            // pictureContact
            // 
            this.pictureContact.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureContact.Location = new System.Drawing.Point(459, 182);
            this.pictureContact.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureContact.Name = "pictureContact";
            this.pictureContact.Size = new System.Drawing.Size(236, 152);
            this.pictureContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureContact.TabIndex = 46;
            this.pictureContact.TabStop = false;
            // 
            // EditContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(754, 446);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.pictureContact);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxLname);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.labelPicture);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.labelFname);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelEdit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditContactForm";
            this.Text = "EditContactForm";
            this.Load += new System.EventHandler(this.EditContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.PictureBox pictureContact;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.Label labelPicture;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelEdit;
    }
}