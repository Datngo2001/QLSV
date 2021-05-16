
namespace QLSV.AppForm
{
    partial class EditProfileForm
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
            this.upload_btn = new System.Windows.Forms.Button();
            this.picture_lb = new System.Windows.Forms.Label();
            this.lname_tb = new System.Windows.Forms.TextBox();
            this.fname_tb = new System.Windows.Forms.TextBox();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.lname_lb = new System.Windows.Forms.Label();
            this.fname_lb = new System.Windows.Forms.Label();
            this.id_lb = new System.Windows.Forms.Label();
            this.profile_lb = new System.Windows.Forms.Label();
            this.reEnter_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.saveChange_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.reEnter_lb = new System.Windows.Forms.Label();
            this.password_lb = new System.Windows.Forms.Label();
            this.username_lb = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // upload_btn
            // 
            this.upload_btn.Location = new System.Drawing.Point(292, 428);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Size = new System.Drawing.Size(303, 35);
            this.upload_btn.TabIndex = 40;
            this.upload_btn.Text = "Upload Image";
            this.upload_btn.UseVisualStyleBackColor = true;
            this.upload_btn.Click += new System.EventHandler(this.upload_btn_Click);
            // 
            // picture_lb
            // 
            this.picture_lb.AutoSize = true;
            this.picture_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.picture_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picture_lb.Location = new System.Drawing.Point(174, 240);
            this.picture_lb.Name = "picture_lb";
            this.picture_lb.Size = new System.Drawing.Size(102, 29);
            this.picture_lb.TabIndex = 38;
            this.picture_lb.Text = "Picture:";
            // 
            // lname_tb
            // 
            this.lname_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lname_tb.Location = new System.Drawing.Point(292, 190);
            this.lname_tb.Name = "lname_tb";
            this.lname_tb.Size = new System.Drawing.Size(301, 35);
            this.lname_tb.TabIndex = 37;
            // 
            // fname_tb
            // 
            this.fname_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fname_tb.Location = new System.Drawing.Point(292, 139);
            this.fname_tb.Name = "fname_tb";
            this.fname_tb.Size = new System.Drawing.Size(302, 35);
            this.fname_tb.TabIndex = 36;
            // 
            // id_tb
            // 
            this.id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.id_tb.Location = new System.Drawing.Point(293, 87);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(302, 35);
            this.id_tb.TabIndex = 35;
            this.id_tb.Text = " ";
            // 
            // lname_lb
            // 
            this.lname_lb.AutoSize = true;
            this.lname_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lname_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lname_lb.Location = new System.Drawing.Point(134, 191);
            this.lname_lb.Name = "lname_lb";
            this.lname_lb.Size = new System.Drawing.Size(144, 29);
            this.lname_lb.TabIndex = 34;
            this.lname_lb.Text = "Last Name:";
            // 
            // fname_lb
            // 
            this.fname_lb.AutoSize = true;
            this.fname_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.fname_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fname_lb.Location = new System.Drawing.Point(131, 140);
            this.fname_lb.Name = "fname_lb";
            this.fname_lb.Size = new System.Drawing.Size(148, 29);
            this.fname_lb.TabIndex = 33;
            this.fname_lb.Text = "First Name:";
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.id_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.id_lb.Location = new System.Drawing.Point(132, 87);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(141, 29);
            this.id_lb.TabIndex = 32;
            this.id_lb.Text = "Student ID:";
            // 
            // profile_lb
            // 
            this.profile_lb.AutoSize = true;
            this.profile_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profile_lb.Location = new System.Drawing.Point(202, 9);
            this.profile_lb.Name = "profile_lb";
            this.profile_lb.Size = new System.Drawing.Size(241, 46);
            this.profile_lb.TabIndex = 31;
            this.profile_lb.Text = "Your Profile";
            // 
            // reEnter_tb
            // 
            this.reEnter_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reEnter_tb.Location = new System.Drawing.Point(292, 599);
            this.reEnter_tb.Name = "reEnter_tb";
            this.reEnter_tb.PasswordChar = '*';
            this.reEnter_tb.Size = new System.Drawing.Size(302, 35);
            this.reEnter_tb.TabIndex = 30;
            // 
            // password_tb
            // 
            this.password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tb.Location = new System.Drawing.Point(293, 542);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(302, 35);
            this.password_tb.TabIndex = 29;
            // 
            // username_tb
            // 
            this.username_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tb.Location = new System.Drawing.Point(293, 479);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(302, 35);
            this.username_tb.TabIndex = 28;
            // 
            // saveChange_btn
            // 
            this.saveChange_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.saveChange_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChange_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveChange_btn.Location = new System.Drawing.Point(103, 664);
            this.saveChange_btn.Name = "saveChange_btn";
            this.saveChange_btn.Size = new System.Drawing.Size(251, 57);
            this.saveChange_btn.TabIndex = 27;
            this.saveChange_btn.Text = "Save Change";
            this.saveChange_btn.UseVisualStyleBackColor = false;
            this.saveChange_btn.Click += new System.EventHandler(this.saveChange_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel_btn.Location = new System.Drawing.Point(410, 664);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(173, 57);
            this.cancel_btn.TabIndex = 26;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // reEnter_lb
            // 
            this.reEnter_lb.AutoSize = true;
            this.reEnter_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reEnter_lb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reEnter_lb.Location = new System.Drawing.Point(45, 599);
            this.reEnter_lb.Name = "reEnter_lb";
            this.reEnter_lb.Size = new System.Drawing.Size(242, 29);
            this.reEnter_lb.TabIndex = 24;
            this.reEnter_lb.Text = "Re-enter password:";
            // 
            // password_lb
            // 
            this.password_lb.AutoSize = true;
            this.password_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.password_lb.Location = new System.Drawing.Point(152, 545);
            this.password_lb.Name = "password_lb";
            this.password_lb.Size = new System.Drawing.Size(135, 29);
            this.password_lb.TabIndex = 25;
            this.password_lb.Text = "Password:";
            // 
            // username_lb
            // 
            this.username_lb.AutoSize = true;
            this.username_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.username_lb.Location = new System.Drawing.Point(148, 482);
            this.username_lb.Name = "username_lb";
            this.username_lb.Size = new System.Drawing.Size(139, 29);
            this.username_lb.TabIndex = 23;
            this.username_lb.Text = "Username:";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox.Location = new System.Drawing.Point(293, 240);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(302, 182);
            this.pictureBox.TabIndex = 39;
            this.pictureBox.TabStop = false;
            // 
            // EditProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(651, 729);
            this.Controls.Add(this.upload_btn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.picture_lb);
            this.Controls.Add(this.lname_tb);
            this.Controls.Add(this.fname_tb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.lname_lb);
            this.Controls.Add(this.fname_lb);
            this.Controls.Add(this.id_lb);
            this.Controls.Add(this.profile_lb);
            this.Controls.Add(this.reEnter_tb);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.saveChange_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.reEnter_lb);
            this.Controls.Add(this.password_lb);
            this.Controls.Add(this.username_lb);
            this.Name = "EditProfileForm";
            this.Text = "EditProfileForm";
            this.Load += new System.EventHandler(this.EditProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upload_btn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label picture_lb;
        private System.Windows.Forms.TextBox lname_tb;
        private System.Windows.Forms.TextBox fname_tb;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Label lname_lb;
        private System.Windows.Forms.Label fname_lb;
        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.Label profile_lb;
        private System.Windows.Forms.TextBox reEnter_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.Button saveChange_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label reEnter_lb;
        private System.Windows.Forms.Label password_lb;
        private System.Windows.Forms.Label username_lb;
    }
}