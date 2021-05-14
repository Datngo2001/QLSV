
namespace QLSV.AppForm
{
    partial class RegisterForm
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
            this.username_lb = new System.Windows.Forms.Label();
            this.password_lb = new System.Windows.Forms.Label();
            this.reEnter_lb = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.signin_btn = new System.Windows.Forms.Button();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.reEnter_tb = new System.Windows.Forms.TextBox();
            this.register_lb = new System.Windows.Forms.Label();
            this.lname_tb = new System.Windows.Forms.TextBox();
            this.fname_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.upload_btn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // username_lb
            // 
            this.username_lb.AutoSize = true;
            this.username_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.username_lb.Location = new System.Drawing.Point(120, 438);
            this.username_lb.Name = "username_lb";
            this.username_lb.Size = new System.Drawing.Size(139, 29);
            this.username_lb.TabIndex = 0;
            this.username_lb.Text = "Username:";
            // 
            // password_lb
            // 
            this.password_lb.AutoSize = true;
            this.password_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.password_lb.Location = new System.Drawing.Point(124, 501);
            this.password_lb.Name = "password_lb";
            this.password_lb.Size = new System.Drawing.Size(135, 29);
            this.password_lb.TabIndex = 0;
            this.password_lb.Text = "Password:";
            // 
            // reEnter_lb
            // 
            this.reEnter_lb.AutoSize = true;
            this.reEnter_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reEnter_lb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reEnter_lb.Location = new System.Drawing.Point(17, 555);
            this.reEnter_lb.Name = "reEnter_lb";
            this.reEnter_lb.Size = new System.Drawing.Size(242, 29);
            this.reEnter_lb.TabIndex = 0;
            this.reEnter_lb.Text = "Re-enter password:";
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel_btn.Location = new System.Drawing.Point(382, 620);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(173, 57);
            this.cancel_btn.TabIndex = 1;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_Click);
            // 
            // signin_btn
            // 
            this.signin_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.signin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signin_btn.Location = new System.Drawing.Point(75, 620);
            this.signin_btn.Name = "signin_btn";
            this.signin_btn.Size = new System.Drawing.Size(173, 57);
            this.signin_btn.TabIndex = 1;
            this.signin_btn.Text = "Sign in";
            this.signin_btn.UseVisualStyleBackColor = false;
            this.signin_btn.Click += new System.EventHandler(this.signin_Click);
            // 
            // username_tb
            // 
            this.username_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tb.Location = new System.Drawing.Point(265, 435);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(302, 35);
            this.username_tb.TabIndex = 2;
            // 
            // password_tb
            // 
            this.password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tb.Location = new System.Drawing.Point(265, 498);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(302, 35);
            this.password_tb.TabIndex = 2;
            // 
            // reEnter_tb
            // 
            this.reEnter_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reEnter_tb.Location = new System.Drawing.Point(264, 555);
            this.reEnter_tb.Name = "reEnter_tb";
            this.reEnter_tb.PasswordChar = '*';
            this.reEnter_tb.Size = new System.Drawing.Size(302, 35);
            this.reEnter_tb.TabIndex = 2;
            // 
            // register_lb
            // 
            this.register_lb.AutoSize = true;
            this.register_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.register_lb.Location = new System.Drawing.Point(214, 11);
            this.register_lb.Name = "register_lb";
            this.register_lb.Size = new System.Drawing.Size(176, 46);
            this.register_lb.TabIndex = 3;
            this.register_lb.Text = "Register";
            // 
            // lname_tb
            // 
            this.lname_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lname_tb.Location = new System.Drawing.Point(264, 146);
            this.lname_tb.Name = "lname_tb";
            this.lname_tb.Size = new System.Drawing.Size(301, 35);
            this.lname_tb.TabIndex = 18;
            // 
            // fname_tb
            // 
            this.fname_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fname_tb.Location = new System.Drawing.Point(264, 95);
            this.fname_tb.Name = "fname_tb";
            this.fname_tb.Size = new System.Drawing.Size(302, 35);
            this.fname_tb.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(106, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(103, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "First Name:";
            // 
            // upload_btn
            // 
            this.upload_btn.Location = new System.Drawing.Point(264, 384);
            this.upload_btn.Name = "upload_btn";
            this.upload_btn.Size = new System.Drawing.Size(303, 35);
            this.upload_btn.TabIndex = 22;
            this.upload_btn.Text = "Upload Image";
            this.upload_btn.UseVisualStyleBackColor = true;
            this.upload_btn.Click += new System.EventHandler(this.upload_btn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox.Location = new System.Drawing.Point(265, 196);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(302, 182);
            this.pictureBox.TabIndex = 21;
            this.pictureBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(146, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "Picture:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(613, 726);
            this.Controls.Add(this.upload_btn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lname_tb);
            this.Controls.Add(this.fname_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.register_lb);
            this.Controls.Add(this.reEnter_tb);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.signin_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.reEnter_lb);
            this.Controls.Add(this.password_lb);
            this.Controls.Add(this.username_lb);
            this.Name = "RegisterForm";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_lb;
        private System.Windows.Forms.Label password_lb;
        private System.Windows.Forms.Label reEnter_lb;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button signin_btn;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.TextBox reEnter_tb;
        private System.Windows.Forms.Label register_lb;
        private System.Windows.Forms.TextBox lname_tb;
        private System.Windows.Forms.TextBox fname_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button upload_btn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label8;
    }
}