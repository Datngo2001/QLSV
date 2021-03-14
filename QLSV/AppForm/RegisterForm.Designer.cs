
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
            this.SuspendLayout();
            // 
            // username_lb
            // 
            this.username_lb.AutoSize = true;
            this.username_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.username_lb.Location = new System.Drawing.Point(115, 107);
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
            this.password_lb.Location = new System.Drawing.Point(119, 170);
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
            this.reEnter_lb.Location = new System.Drawing.Point(12, 224);
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
            this.cancel_btn.Location = new System.Drawing.Point(373, 335);
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
            this.signin_btn.Location = new System.Drawing.Point(66, 335);
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
            this.username_tb.Location = new System.Drawing.Point(260, 104);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(302, 35);
            this.username_tb.TabIndex = 2;
            // 
            // password_tb
            // 
            this.password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tb.Location = new System.Drawing.Point(260, 167);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(302, 35);
            this.password_tb.TabIndex = 2;
            // 
            // reEnter_tb
            // 
            this.reEnter_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reEnter_tb.Location = new System.Drawing.Point(260, 224);
            this.reEnter_tb.Name = "reEnter_tb";
            this.reEnter_tb.Size = new System.Drawing.Size(302, 35);
            this.reEnter_tb.TabIndex = 2;
            // 
            // register_lb
            // 
            this.register_lb.AutoSize = true;
            this.register_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.register_lb.Location = new System.Drawing.Point(209, 27);
            this.register_lb.Name = "register_lb";
            this.register_lb.Size = new System.Drawing.Size(176, 46);
            this.register_lb.TabIndex = 3;
            this.register_lb.Text = "Register";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(608, 410);
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
    }
}