﻿
namespace QLSV.AppForm
{
    partial class MainContactForm
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
            this.comboBoxSelected2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonRemoveGroup = new System.Windows.Forms.Button();
            this.comboBoxSelected = new System.Windows.Forms.ComboBox();
            this.buttonEditGroup = new System.Windows.Forms.Button();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.labelNewGroup = new System.Windows.Forms.Label();
            this.labelSelectGoup = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.labelGroupID = new System.Windows.Forms.Label();
            this.buttonShowList = new System.Windows.Forms.Button();
            this.labelContact = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabelRefresh = new System.Windows.Forms.LinkLabel();
            this.linkLabelEdit = new System.Windows.Forms.LinkLabel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureBoxContact = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRemoveContact = new System.Windows.Forms.Button();
            this.buttonSelectContact = new System.Windows.Forms.Button();
            this.textBoxContactID = new System.Windows.Forms.TextBox();
            this.labelContactID = new System.Windows.Forms.Label();
            this.buttonEditContact = new System.Windows.Forms.Button();
            this.buttonAddContact = new System.Windows.Forms.Button();
            this.labelGroup = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContact)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSelected2
            // 
            this.comboBoxSelected2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.comboBoxSelected2.FormattingEnabled = true;
            this.comboBoxSelected2.Location = new System.Drawing.Point(234, 19);
            this.comboBoxSelected2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSelected2.Name = "comboBoxSelected2";
            this.comboBoxSelected2.Size = new System.Drawing.Size(205, 39);
            this.comboBoxSelected2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select Group:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBoxSelected2);
            this.groupBox5.Controls.Add(this.buttonRemoveGroup);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(597, 535);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(595, 88);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            // 
            // buttonRemoveGroup
            // 
            this.buttonRemoveGroup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveGroup.Location = new System.Drawing.Point(447, 14);
            this.buttonRemoveGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRemoveGroup.Name = "buttonRemoveGroup";
            this.buttonRemoveGroup.Size = new System.Drawing.Size(142, 48);
            this.buttonRemoveGroup.TabIndex = 15;
            this.buttonRemoveGroup.Text = "Remove";
            this.buttonRemoveGroup.UseVisualStyleBackColor = true;
            this.buttonRemoveGroup.Click += new System.EventHandler(this.buttonRemoveGroup_Click);
            // 
            // comboBoxSelected
            // 
            this.comboBoxSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.comboBoxSelected.FormattingEnabled = true;
            this.comboBoxSelected.Location = new System.Drawing.Point(234, 19);
            this.comboBoxSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSelected.Name = "comboBoxSelected";
            this.comboBoxSelected.Size = new System.Drawing.Size(205, 39);
            this.comboBoxSelected.TabIndex = 15;
            // 
            // buttonEditGroup
            // 
            this.buttonEditGroup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditGroup.Location = new System.Drawing.Point(447, 46);
            this.buttonEditGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditGroup.Name = "buttonEditGroup";
            this.buttonEditGroup.Size = new System.Drawing.Size(142, 48);
            this.buttonEditGroup.TabIndex = 12;
            this.buttonEditGroup.Text = "Edit";
            this.buttonEditGroup.UseVisualStyleBackColor = true;
            this.buttonEditGroup.Click += new System.EventHandler(this.buttonEditGroup_Click);
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewName.Location = new System.Drawing.Point(234, 76);
            this.textBoxNewName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(205, 38);
            this.textBoxNewName.TabIndex = 14;
            // 
            // labelNewGroup
            // 
            this.labelNewGroup.AutoSize = true;
            this.labelNewGroup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewGroup.Location = new System.Drawing.Point(29, 76);
            this.labelNewGroup.Name = "labelNewGroup";
            this.labelNewGroup.Size = new System.Drawing.Size(195, 26);
            this.labelNewGroup.TabIndex = 13;
            this.labelNewGroup.Text = "Enter New Name:";
            // 
            // labelSelectGoup
            // 
            this.labelSelectGoup.AutoSize = true;
            this.labelSelectGoup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectGoup.Location = new System.Drawing.Point(70, 22);
            this.labelSelectGoup.Name = "labelSelectGoup";
            this.labelSelectGoup.Size = new System.Drawing.Size(154, 26);
            this.labelSelectGoup.TabIndex = 12;
            this.labelSelectGoup.Text = "Select Group:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxSelected);
            this.groupBox4.Controls.Add(this.buttonEditGroup);
            this.groupBox4.Controls.Add(this.textBoxNewName);
            this.groupBox4.Controls.Add(this.labelNewGroup);
            this.groupBox4.Controls.Add(this.labelSelectGoup);
            this.groupBox4.Location = new System.Drawing.Point(597, 386);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(595, 131);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonAddGroup);
            this.groupBox3.Controls.Add(this.textBoxGroupName);
            this.groupBox3.Controls.Add(this.labelGroupID);
            this.groupBox3.Location = new System.Drawing.Point(599, 279);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(595, 82);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddGroup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddGroup.Location = new System.Drawing.Point(443, 22);
            this.buttonAddGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(142, 38);
            this.buttonAddGroup.TabIndex = 14;
            this.buttonAddGroup.Text = "Add";
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroupName.Location = new System.Drawing.Point(232, 22);
            this.textBoxGroupName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(205, 38);
            this.textBoxGroupName.TabIndex = 13;
            // 
            // labelGroupID
            // 
            this.labelGroupID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGroupID.AutoSize = true;
            this.labelGroupID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroupID.Location = new System.Drawing.Point(9, 30);
            this.labelGroupID.Name = "labelGroupID";
            this.labelGroupID.Size = new System.Drawing.Size(217, 26);
            this.labelGroupID.TabIndex = 12;
            this.labelGroupID.Text = "Enter Group Name:";
            // 
            // buttonShowList
            // 
            this.buttonShowList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonShowList.Location = new System.Drawing.Point(15, 575);
            this.buttonShowList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonShowList.Name = "buttonShowList";
            this.buttonShowList.Size = new System.Drawing.Size(551, 48);
            this.buttonShowList.TabIndex = 19;
            this.buttonShowList.Text = "Show Full List Contact";
            this.buttonShowList.UseVisualStyleBackColor = true;
            this.buttonShowList.Click += new System.EventHandler(this.buttonShowList_Click);
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelContact.Location = new System.Drawing.Point(2, 187);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(271, 69);
            this.labelContact.TabIndex = 14;
            this.labelContact.Text = "Contact";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.linkLabelRefresh);
            this.groupBox1.Controls.Add(this.linkLabelEdit);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelWelcome);
            this.groupBox1.Controls.Add(this.pictureBoxContact);
            this.groupBox1.Location = new System.Drawing.Point(-2, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1210, 158);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "||";
            // 
            // linkLabelRefresh
            // 
            this.linkLabelRefresh.ActiveLinkColor = System.Drawing.Color.Silver;
            this.linkLabelRefresh.AutoSize = true;
            this.linkLabelRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRefresh.LinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabelRefresh.Location = new System.Drawing.Point(322, 114);
            this.linkLabelRefresh.Name = "linkLabelRefresh";
            this.linkLabelRefresh.Size = new System.Drawing.Size(97, 29);
            this.linkLabelRefresh.TabIndex = 16;
            this.linkLabelRefresh.TabStop = true;
            this.linkLabelRefresh.Text = "Refresh";
            this.linkLabelRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRefresh_LinkClicked);
            // 
            // linkLabelEdit
            // 
            this.linkLabelEdit.ActiveLinkColor = System.Drawing.Color.Silver;
            this.linkLabelEdit.AutoSize = true;
            this.linkLabelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelEdit.LinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabelEdit.Location = new System.Drawing.Point(159, 114);
            this.linkLabelEdit.Name = "linkLabelEdit";
            this.linkLabelEdit.Size = new System.Drawing.Size(127, 29);
            this.linkLabelEdit.TabIndex = 15;
            this.linkLabelEdit.TabStop = true;
            this.linkLabelEdit.Text = "Edit ptofile";
            this.linkLabelEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEdit_LinkClicked);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(200, 66);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(159, 36);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Full Name";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(159, 40);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(105, 26);
            this.labelWelcome.TabIndex = 13;
            this.labelWelcome.Text = "Welcome";
            // 
            // pictureBoxContact
            // 
            this.pictureBoxContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBoxContact.Location = new System.Drawing.Point(17, 24);
            this.pictureBoxContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxContact.Name = "pictureBoxContact";
            this.pictureBoxContact.Size = new System.Drawing.Size(119, 111);
            this.pictureBoxContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxContact.TabIndex = 0;
            this.pictureBoxContact.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRemoveContact);
            this.groupBox2.Controls.Add(this.buttonSelectContact);
            this.groupBox2.Controls.Add(this.textBoxContactID);
            this.groupBox2.Controls.Add(this.labelContactID);
            this.groupBox2.Location = new System.Drawing.Point(14, 335);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(551, 230);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // buttonRemoveContact
            // 
            this.buttonRemoveContact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRemoveContact.Location = new System.Drawing.Point(297, 146);
            this.buttonRemoveContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRemoveContact.Name = "buttonRemoveContact";
            this.buttonRemoveContact.Size = new System.Drawing.Size(248, 46);
            this.buttonRemoveContact.TabIndex = 7;
            this.buttonRemoveContact.Text = "Remove Contact";
            this.buttonRemoveContact.UseVisualStyleBackColor = true;
            this.buttonRemoveContact.Click += new System.EventHandler(this.buttonRemoveContact_Click);
            // 
            // buttonSelectContact
            // 
            this.buttonSelectContact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSelectContact.Location = new System.Drawing.Point(297, 75);
            this.buttonSelectContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSelectContact.Name = "buttonSelectContact";
            this.buttonSelectContact.Size = new System.Drawing.Size(248, 46);
            this.buttonSelectContact.TabIndex = 6;
            this.buttonSelectContact.Text = "Select Contact";
            this.buttonSelectContact.UseVisualStyleBackColor = true;
            this.buttonSelectContact.Click += new System.EventHandler(this.buttonSelectContact_Click);
            // 
            // textBoxContactID
            // 
            this.textBoxContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContactID.Location = new System.Drawing.Point(12, 75);
            this.textBoxContactID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxContactID.Name = "textBoxContactID";
            this.textBoxContactID.Size = new System.Drawing.Size(277, 38);
            this.textBoxContactID.TabIndex = 1;
            // 
            // labelContactID
            // 
            this.labelContactID.AutoSize = true;
            this.labelContactID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactID.Location = new System.Drawing.Point(7, 22);
            this.labelContactID.Name = "labelContactID";
            this.labelContactID.Size = new System.Drawing.Size(198, 26);
            this.labelContactID.TabIndex = 0;
            this.labelContactID.Text = "Enter Contact ID:";
            // 
            // buttonEditContact
            // 
            this.buttonEditContact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonEditContact.Location = new System.Drawing.Point(242, 279);
            this.buttonEditContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEditContact.Name = "buttonEditContact";
            this.buttonEditContact.Size = new System.Drawing.Size(187, 48);
            this.buttonEditContact.TabIndex = 17;
            this.buttonEditContact.Text = "Edit";
            this.buttonEditContact.UseVisualStyleBackColor = true;
            this.buttonEditContact.Click += new System.EventHandler(this.buttonEditContact_Click);
            // 
            // buttonAddContact
            // 
            this.buttonAddContact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAddContact.Location = new System.Drawing.Point(14, 279);
            this.buttonAddContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddContact.Name = "buttonAddContact";
            this.buttonAddContact.Size = new System.Drawing.Size(187, 48);
            this.buttonAddContact.TabIndex = 16;
            this.buttonAddContact.Text = "Add";
            this.buttonAddContact.UseVisualStyleBackColor = true;
            this.buttonAddContact.Click += new System.EventHandler(this.buttonAddContact_Click);
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelGroup.Location = new System.Drawing.Point(596, 187);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(227, 69);
            this.labelGroup.TabIndex = 15;
            this.labelGroup.Text = "Group";
            // 
            // MainContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1206, 631);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonShowList);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonEditContact);
            this.Controls.Add(this.buttonAddContact);
            this.Controls.Add(this.labelGroup);
            this.Name = "MainContactForm";
            this.Text = "MainContactForm";
            this.Load += new System.EventHandler(this.MainContactForm_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContact)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelected2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonRemoveGroup;
        private System.Windows.Forms.ComboBox comboBoxSelected;
        private System.Windows.Forms.Button buttonEditGroup;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label labelNewGroup;
        private System.Windows.Forms.Label labelSelectGoup;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonShowList;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabelRefresh;
        private System.Windows.Forms.LinkLabel linkLabelEdit;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.PictureBox pictureBoxContact;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRemoveContact;
        private System.Windows.Forms.Button buttonSelectContact;
        public System.Windows.Forms.TextBox textBoxContactID;
        private System.Windows.Forms.Label labelContactID;
        private System.Windows.Forms.Button buttonEditContact;
        private System.Windows.Forms.Button buttonAddContact;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.Label labelGroupID;
    }
}