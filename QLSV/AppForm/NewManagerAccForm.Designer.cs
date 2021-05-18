
namespace QLSV.AppForm
{
    partial class NewManagerAccForm
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
            this.reEnter_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.reEnter_lb = new System.Windows.Forms.Label();
            this.password_lb = new System.Windows.Forms.Label();
            this.username_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reEnter_tb
            // 
            this.reEnter_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reEnter_tb.Location = new System.Drawing.Point(264, 161);
            this.reEnter_tb.Name = "reEnter_tb";
            this.reEnter_tb.PasswordChar = '*';
            this.reEnter_tb.Size = new System.Drawing.Size(302, 35);
            this.reEnter_tb.TabIndex = 3;
            // 
            // password_tb
            // 
            this.password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tb.Location = new System.Drawing.Point(265, 104);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(302, 35);
            this.password_tb.TabIndex = 2;
            // 
            // username_tb
            // 
            this.username_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_tb.Location = new System.Drawing.Point(265, 41);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(302, 35);
            this.username_tb.TabIndex = 1;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_btn.Location = new System.Drawing.Point(75, 226);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(173, 57);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.OrangeRed;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel_btn.Location = new System.Drawing.Point(382, 226);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(173, 57);
            this.cancel_btn.TabIndex = 5;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // reEnter_lb
            // 
            this.reEnter_lb.AutoSize = true;
            this.reEnter_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reEnter_lb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reEnter_lb.Location = new System.Drawing.Point(17, 161);
            this.reEnter_lb.Name = "reEnter_lb";
            this.reEnter_lb.Size = new System.Drawing.Size(242, 29);
            this.reEnter_lb.TabIndex = 3;
            this.reEnter_lb.Text = "Re-enter password:";
            // 
            // password_lb
            // 
            this.password_lb.AutoSize = true;
            this.password_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.password_lb.Location = new System.Drawing.Point(124, 107);
            this.password_lb.Name = "password_lb";
            this.password_lb.Size = new System.Drawing.Size(135, 29);
            this.password_lb.TabIndex = 4;
            this.password_lb.Text = "Password:";
            // 
            // username_lb
            // 
            this.username_lb.AutoSize = true;
            this.username_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.username_lb.Location = new System.Drawing.Point(120, 44);
            this.username_lb.Name = "username_lb";
            this.username_lb.Size = new System.Drawing.Size(139, 29);
            this.username_lb.TabIndex = 5;
            this.username_lb.Text = "Username:";
            // 
            // NewManagerAccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(633, 328);
            this.Controls.Add(this.reEnter_tb);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.reEnter_lb);
            this.Controls.Add(this.password_lb);
            this.Controls.Add(this.username_lb);
            this.Name = "NewManagerAccForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add a new manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reEnter_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label reEnter_lb;
        private System.Windows.Forms.Label password_lb;
        private System.Windows.Forms.Label username_lb;
    }
}