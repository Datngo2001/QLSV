﻿
namespace QLSV.AppForm.CourseForm
{
    partial class AddCourseForm
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
            this.label_lb = new System.Windows.Forms.Label();
            this.period_lb = new System.Windows.Forms.Label();
            this.desrciption_lb = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.label_tb = new System.Windows.Forms.TextBox();
            this.period_tb = new System.Windows.Forms.TextBox();
            this.description_tb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.id_lb.Location = new System.Drawing.Point(59, 24);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(136, 29);
            this.id_lb.TabIndex = 0;
            this.id_lb.Text = "Course ID:";
            // 
            // label_lb
            // 
            this.label_lb.AutoSize = true;
            this.label_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_lb.Location = new System.Drawing.Point(113, 81);
            this.label_lb.Name = "label_lb";
            this.label_lb.Size = new System.Drawing.Size(85, 29);
            this.label_lb.TabIndex = 0;
            this.label_lb.Text = "Label:";
            // 
            // period_lb
            // 
            this.period_lb.AutoSize = true;
            this.period_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.period_lb.Location = new System.Drawing.Point(97, 151);
            this.period_lb.Name = "period_lb";
            this.period_lb.Size = new System.Drawing.Size(98, 29);
            this.period_lb.TabIndex = 0;
            this.period_lb.Text = "Period:";
            // 
            // desrciption_lb
            // 
            this.desrciption_lb.AutoSize = true;
            this.desrciption_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desrciption_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.desrciption_lb.Location = new System.Drawing.Point(45, 223);
            this.desrciption_lb.Name = "desrciption_lb";
            this.desrciption_lb.Size = new System.Drawing.Size(153, 29);
            this.desrciption_lb.TabIndex = 0;
            this.desrciption_lb.Text = "Description:";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Blue;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_btn.Location = new System.Drawing.Point(179, 364);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(355, 61);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "ADD COURSE";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // id_tb
            // 
            this.id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_tb.Location = new System.Drawing.Point(201, 21);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(251, 35);
            this.id_tb.TabIndex = 2;
            // 
            // label_tb
            // 
            this.label_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tb.Location = new System.Drawing.Point(201, 78);
            this.label_tb.Name = "label_tb";
            this.label_tb.Size = new System.Drawing.Size(505, 35);
            this.label_tb.TabIndex = 2;
            // 
            // period_tb
            // 
            this.period_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_tb.Location = new System.Drawing.Point(201, 148);
            this.period_tb.Name = "period_tb";
            this.period_tb.Size = new System.Drawing.Size(143, 35);
            this.period_tb.TabIndex = 2;
            // 
            // description_tb
            // 
            this.description_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_tb.Location = new System.Drawing.Point(201, 220);
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(333, 96);
            this.description_tb.TabIndex = 3;
            this.description_tb.Text = "";
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.description_tb);
            this.Controls.Add(this.period_tb);
            this.Controls.Add(this.label_tb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.desrciption_lb);
            this.Controls.Add(this.period_lb);
            this.Controls.Add(this.label_lb);
            this.Controls.Add(this.id_lb);
            this.Name = "AddCourseForm";
            this.Text = "AddCourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.Label label_lb;
        private System.Windows.Forms.Label period_lb;
        private System.Windows.Forms.Label desrciption_lb;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.TextBox label_tb;
        private System.Windows.Forms.TextBox period_tb;
        private System.Windows.Forms.RichTextBox description_tb;
    }
}