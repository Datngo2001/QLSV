
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
            this.remove_cb = new System.Windows.Forms.ComboBox();
            this.selectGroup_lb = new System.Windows.Forms.Label();
            this.remove_gb = new System.Windows.Forms.GroupBox();
            this.buttonRemoveGroup = new System.Windows.Forms.Button();
            this.group_cb = new System.Windows.Forms.ComboBox();
            this.buttonEditGroup = new System.Windows.Forms.Button();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.labelNewGroup = new System.Windows.Forms.Label();
            this.labelSelectGoup = new System.Windows.Forms.Label();
            this.editGroup_gb = new System.Windows.Forms.GroupBox();
            this.addGroup_gb = new System.Windows.Forms.GroupBox();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.labelGroupID = new System.Windows.Forms.Label();
            this.buttonShowList = new System.Windows.Forms.Button();
            this.labelContact = new System.Windows.Forms.Label();
            this.head_gb = new System.Windows.Forms.GroupBox();
            this.spliter_lb = new System.Windows.Forms.Label();
            this.linkLabelRefresh = new System.Windows.Forms.LinkLabel();
            this.linkLabelEdit = new System.Windows.Forms.LinkLabel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureBoxContact = new System.Windows.Forms.PictureBox();
            this.idContact_gb = new System.Windows.Forms.GroupBox();
            this.buttonRemoveContact = new System.Windows.Forms.Button();
            this.buttonSelectContact = new System.Windows.Forms.Button();
            this.textBoxContactID = new System.Windows.Forms.TextBox();
            this.labelContactID = new System.Windows.Forms.Label();
            this.buttonEditContact = new System.Windows.Forms.Button();
            this.buttonAddContact = new System.Windows.Forms.Button();
            this.labelGroup = new System.Windows.Forms.Label();
            this.logout_llb = new System.Windows.Forms.LinkLabel();
            this.remove_gb.SuspendLayout();
            this.editGroup_gb.SuspendLayout();
            this.addGroup_gb.SuspendLayout();
            this.head_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContact)).BeginInit();
            this.idContact_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // remove_cb
            // 
            this.remove_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.remove_cb.FormattingEnabled = true;
            this.remove_cb.Location = new System.Drawing.Point(234, 18);
            this.remove_cb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.remove_cb.Name = "remove_cb";
            this.remove_cb.Size = new System.Drawing.Size(205, 39);
            this.remove_cb.TabIndex = 16;
            // 
            // selectGroup_lb
            // 
            this.selectGroup_lb.AutoSize = true;
            this.selectGroup_lb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectGroup_lb.Location = new System.Drawing.Point(70, 23);
            this.selectGroup_lb.Name = "selectGroup_lb";
            this.selectGroup_lb.Size = new System.Drawing.Size(154, 26);
            this.selectGroup_lb.TabIndex = 13;
            this.selectGroup_lb.Text = "Select Group:";
            // 
            // remove_gb
            // 
            this.remove_gb.Controls.Add(this.remove_cb);
            this.remove_gb.Controls.Add(this.buttonRemoveGroup);
            this.remove_gb.Controls.Add(this.selectGroup_lb);
            this.remove_gb.Location = new System.Drawing.Point(597, 535);
            this.remove_gb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.remove_gb.Name = "remove_gb";
            this.remove_gb.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.remove_gb.Size = new System.Drawing.Size(596, 88);
            this.remove_gb.TabIndex = 23;
            this.remove_gb.TabStop = false;
            // 
            // buttonRemoveGroup
            // 
            this.buttonRemoveGroup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveGroup.Location = new System.Drawing.Point(447, 14);
            this.buttonRemoveGroup.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonRemoveGroup.Name = "buttonRemoveGroup";
            this.buttonRemoveGroup.Size = new System.Drawing.Size(142, 48);
            this.buttonRemoveGroup.TabIndex = 15;
            this.buttonRemoveGroup.Text = "Remove";
            this.buttonRemoveGroup.UseVisualStyleBackColor = true;
            this.buttonRemoveGroup.Click += new System.EventHandler(this.buttonRemoveGroup_Click);
            // 
            // group_cb
            // 
            this.group_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.group_cb.FormattingEnabled = true;
            this.group_cb.Location = new System.Drawing.Point(234, 18);
            this.group_cb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.group_cb.Name = "group_cb";
            this.group_cb.Size = new System.Drawing.Size(205, 39);
            this.group_cb.TabIndex = 15;
            // 
            // buttonEditGroup
            // 
            this.buttonEditGroup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditGroup.Location = new System.Drawing.Point(447, 46);
            this.buttonEditGroup.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            this.textBoxNewName.Location = new System.Drawing.Point(234, 75);
            this.textBoxNewName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(205, 38);
            this.textBoxNewName.TabIndex = 14;
            // 
            // labelNewGroup
            // 
            this.labelNewGroup.AutoSize = true;
            this.labelNewGroup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewGroup.Location = new System.Drawing.Point(28, 75);
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
            // editGroup_gb
            // 
            this.editGroup_gb.Controls.Add(this.group_cb);
            this.editGroup_gb.Controls.Add(this.buttonEditGroup);
            this.editGroup_gb.Controls.Add(this.textBoxNewName);
            this.editGroup_gb.Controls.Add(this.labelNewGroup);
            this.editGroup_gb.Controls.Add(this.labelSelectGoup);
            this.editGroup_gb.Location = new System.Drawing.Point(597, 386);
            this.editGroup_gb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.editGroup_gb.Name = "editGroup_gb";
            this.editGroup_gb.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.editGroup_gb.Size = new System.Drawing.Size(596, 131);
            this.editGroup_gb.TabIndex = 22;
            this.editGroup_gb.TabStop = false;
            // 
            // addGroup_gb
            // 
            this.addGroup_gb.Controls.Add(this.buttonAddGroup);
            this.addGroup_gb.Controls.Add(this.textBoxGroupName);
            this.addGroup_gb.Controls.Add(this.labelGroupID);
            this.addGroup_gb.Location = new System.Drawing.Point(598, 278);
            this.addGroup_gb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.addGroup_gb.Name = "addGroup_gb";
            this.addGroup_gb.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.addGroup_gb.Size = new System.Drawing.Size(596, 82);
            this.addGroup_gb.TabIndex = 21;
            this.addGroup_gb.TabStop = false;
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddGroup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddGroup.Location = new System.Drawing.Point(442, 22);
            this.buttonAddGroup.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            this.textBoxGroupName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(205, 38);
            this.textBoxGroupName.TabIndex = 13;
            // 
            // labelGroupID
            // 
            this.labelGroupID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGroupID.AutoSize = true;
            this.labelGroupID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroupID.Location = new System.Drawing.Point(9, 29);
            this.labelGroupID.Name = "labelGroupID";
            this.labelGroupID.Size = new System.Drawing.Size(217, 26);
            this.labelGroupID.TabIndex = 12;
            this.labelGroupID.Text = "Enter Group Name:";
            // 
            // buttonShowList
            // 
            this.buttonShowList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonShowList.Location = new System.Drawing.Point(15, 575);
            this.buttonShowList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonShowList.Name = "buttonShowList";
            this.buttonShowList.Size = new System.Drawing.Size(550, 48);
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
            this.labelContact.Location = new System.Drawing.Point(2, 188);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(271, 69);
            this.labelContact.TabIndex = 14;
            this.labelContact.Text = "Contact";
            // 
            // head_gb
            // 
            this.head_gb.BackColor = System.Drawing.Color.MediumTurquoise;
            this.head_gb.Controls.Add(this.spliter_lb);
            this.head_gb.Controls.Add(this.logout_llb);
            this.head_gb.Controls.Add(this.linkLabelRefresh);
            this.head_gb.Controls.Add(this.linkLabelEdit);
            this.head_gb.Controls.Add(this.labelName);
            this.head_gb.Controls.Add(this.labelWelcome);
            this.head_gb.Controls.Add(this.pictureBoxContact);
            this.head_gb.Location = new System.Drawing.Point(-2, 8);
            this.head_gb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.head_gb.Name = "head_gb";
            this.head_gb.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.head_gb.Size = new System.Drawing.Size(1210, 158);
            this.head_gb.TabIndex = 13;
            this.head_gb.TabStop = false;
            // 
            // spliter_lb
            // 
            this.spliter_lb.AutoSize = true;
            this.spliter_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spliter_lb.Location = new System.Drawing.Point(288, 114);
            this.spliter_lb.Name = "spliter_lb";
            this.spliter_lb.Size = new System.Drawing.Size(27, 29);
            this.spliter_lb.TabIndex = 17;
            this.spliter_lb.Text = "||";
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
            this.pictureBoxContact.Location = new System.Drawing.Point(16, 25);
            this.pictureBoxContact.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBoxContact.Name = "pictureBoxContact";
            this.pictureBoxContact.Size = new System.Drawing.Size(118, 111);
            this.pictureBoxContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxContact.TabIndex = 0;
            this.pictureBoxContact.TabStop = false;
            // 
            // idContact_gb
            // 
            this.idContact_gb.Controls.Add(this.buttonRemoveContact);
            this.idContact_gb.Controls.Add(this.buttonSelectContact);
            this.idContact_gb.Controls.Add(this.textBoxContactID);
            this.idContact_gb.Controls.Add(this.labelContactID);
            this.idContact_gb.Location = new System.Drawing.Point(14, 335);
            this.idContact_gb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.idContact_gb.Name = "idContact_gb";
            this.idContact_gb.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.idContact_gb.Size = new System.Drawing.Size(550, 229);
            this.idContact_gb.TabIndex = 18;
            this.idContact_gb.TabStop = false;
            // 
            // buttonRemoveContact
            // 
            this.buttonRemoveContact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRemoveContact.Location = new System.Drawing.Point(297, 146);
            this.buttonRemoveContact.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            this.buttonSelectContact.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            this.textBoxContactID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxContactID.Name = "textBoxContactID";
            this.textBoxContactID.Size = new System.Drawing.Size(277, 38);
            this.textBoxContactID.TabIndex = 1;
            // 
            // labelContactID
            // 
            this.labelContactID.AutoSize = true;
            this.labelContactID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactID.Location = new System.Drawing.Point(8, 22);
            this.labelContactID.Name = "labelContactID";
            this.labelContactID.Size = new System.Drawing.Size(198, 26);
            this.labelContactID.TabIndex = 0;
            this.labelContactID.Text = "Enter Contact ID:";
            // 
            // buttonEditContact
            // 
            this.buttonEditContact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonEditContact.Location = new System.Drawing.Point(242, 278);
            this.buttonEditContact.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonEditContact.Name = "buttonEditContact";
            this.buttonEditContact.Size = new System.Drawing.Size(188, 48);
            this.buttonEditContact.TabIndex = 17;
            this.buttonEditContact.Text = "Edit";
            this.buttonEditContact.UseVisualStyleBackColor = true;
            this.buttonEditContact.Click += new System.EventHandler(this.buttonEditContact_Click);
            // 
            // buttonAddContact
            // 
            this.buttonAddContact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAddContact.Location = new System.Drawing.Point(14, 278);
            this.buttonAddContact.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonAddContact.Name = "buttonAddContact";
            this.buttonAddContact.Size = new System.Drawing.Size(188, 48);
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
            this.labelGroup.Location = new System.Drawing.Point(596, 188);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(227, 69);
            this.labelGroup.TabIndex = 15;
            this.labelGroup.Text = "Group";
            // 
            // logout_llb
            // 
            this.logout_llb.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.logout_llb.AutoSize = true;
            this.logout_llb.BackColor = System.Drawing.Color.MediumTurquoise;
            this.logout_llb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_llb.LinkColor = System.Drawing.Color.Black;
            this.logout_llb.Location = new System.Drawing.Point(1099, 114);
            this.logout_llb.Name = "logout_llb";
            this.logout_llb.Size = new System.Drawing.Size(87, 29);
            this.logout_llb.TabIndex = 16;
            this.logout_llb.TabStop = true;
            this.logout_llb.Text = "Logout";
            this.logout_llb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logout_llb_LinkClicked);
            // 
            // MainContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1206, 631);
            this.Controls.Add(this.remove_gb);
            this.Controls.Add(this.editGroup_gb);
            this.Controls.Add(this.addGroup_gb);
            this.Controls.Add(this.buttonShowList);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.head_gb);
            this.Controls.Add(this.idContact_gb);
            this.Controls.Add(this.buttonEditContact);
            this.Controls.Add(this.buttonAddContact);
            this.Controls.Add(this.labelGroup);
            this.Name = "MainContactForm";
            this.Text = "MainContactForm";
            this.Load += new System.EventHandler(this.MainContactForm_Load);
            this.remove_gb.ResumeLayout(false);
            this.remove_gb.PerformLayout();
            this.editGroup_gb.ResumeLayout(false);
            this.editGroup_gb.PerformLayout();
            this.addGroup_gb.ResumeLayout(false);
            this.addGroup_gb.PerformLayout();
            this.head_gb.ResumeLayout(false);
            this.head_gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContact)).EndInit();
            this.idContact_gb.ResumeLayout(false);
            this.idContact_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox remove_cb;
        private System.Windows.Forms.Label selectGroup_lb;
        private System.Windows.Forms.GroupBox remove_gb;
        private System.Windows.Forms.Button buttonRemoveGroup;
        private System.Windows.Forms.ComboBox group_cb;
        private System.Windows.Forms.Button buttonEditGroup;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label labelNewGroup;
        private System.Windows.Forms.Label labelSelectGoup;
        private System.Windows.Forms.GroupBox editGroup_gb;
        private System.Windows.Forms.GroupBox addGroup_gb;
        private System.Windows.Forms.Button buttonShowList;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.GroupBox head_gb;
        private System.Windows.Forms.Label spliter_lb;
        private System.Windows.Forms.LinkLabel linkLabelRefresh;
        private System.Windows.Forms.LinkLabel linkLabelEdit;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.PictureBox pictureBoxContact;
        private System.Windows.Forms.GroupBox idContact_gb;
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
        private System.Windows.Forms.LinkLabel logout_llb;
    }
}