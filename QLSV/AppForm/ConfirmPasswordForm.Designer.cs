
namespace QLSV.AppForm
{
    partial class ConfirmPasswordForm
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
            this.tittle_lb = new System.Windows.Forms.Label();
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tittle_lb
            // 
            this.tittle_lb.AutoSize = true;
            this.tittle_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tittle_lb.Location = new System.Drawing.Point(153, 50);
            this.tittle_lb.Name = "tittle_lb";
            this.tittle_lb.Size = new System.Drawing.Size(327, 40);
            this.tittle_lb.TabIndex = 0;
            this.tittle_lb.Text = "Confirm Password";
            // 
            // pass_tb
            // 
            this.pass_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_tb.Location = new System.Drawing.Point(183, 156);
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.PasswordChar = '*';
            this.pass_tb.Size = new System.Drawing.Size(253, 35);
            this.pass_tb.TabIndex = 1;
            // 
            // confirm_btn
            // 
            this.confirm_btn.BackColor = System.Drawing.Color.LawnGreen;
            this.confirm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirm_btn.Location = new System.Drawing.Point(235, 256);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(134, 69);
            this.confirm_btn.TabIndex = 2;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseVisualStyleBackColor = false;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // ConfirmPasswordForm
            // 
            this.AcceptButton = this.confirm_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(609, 388);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.tittle_lb);
            this.Name = "ConfirmPasswordForm";
            this.Text = "ConfirmPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tittle_lb;
        private System.Windows.Forms.TextBox pass_tb;
        private System.Windows.Forms.Button confirm_btn;
    }
}