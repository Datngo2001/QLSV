﻿
namespace QLSV.AppForm.CourseForm
{
    partial class RemoveCourseForm
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
            this.enterID_lb = new System.Windows.Forms.Label();
            this.idSearch_tb = new System.Windows.Forms.TextBox();
            this.remove_btn = new System.Windows.Forms.Button();
            this.description_tb = new System.Windows.Forms.RichTextBox();
            this.label_tb = new System.Windows.Forms.TextBox();
            this.description_lb = new System.Windows.Forms.Label();
            this.period_lb = new System.Windows.Forms.Label();
            this.label_lb = new System.Windows.Forms.Label();
            this.id_lb = new System.Windows.Forms.Label();
            this.period_tb = new System.Windows.Forms.TextBox();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enterID_lb
            // 
            this.enterID_lb.AutoSize = true;
            this.enterID_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterID_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enterID_lb.Location = new System.Drawing.Point(25, 35);
            this.enterID_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterID_lb.Name = "enterID_lb";
            this.enterID_lb.Size = new System.Drawing.Size(175, 20);
            this.enterID_lb.TabIndex = 0;
            this.enterID_lb.Text = "Enter the Course ID:";
            // 
            // idSearch_tb
            // 
            this.idSearch_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idSearch_tb.Location = new System.Drawing.Point(195, 35);
            this.idSearch_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idSearch_tb.Name = "idSearch_tb";
            this.idSearch_tb.Size = new System.Drawing.Size(235, 26);
            this.idSearch_tb.TabIndex = 1;
            this.idSearch_tb.TextChanged += new System.EventHandler(this.idSearch_tb_TextChanged);
            // 
            // remove_btn
            // 
            this.remove_btn.BackColor = System.Drawing.Color.Red;
            this.remove_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.remove_btn.Location = new System.Drawing.Point(443, 35);
            this.remove_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(126, 26);
            this.remove_btn.TabIndex = 2;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = false;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // description_tb
            // 
            this.description_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_tb.Location = new System.Drawing.Point(194, 215);
            this.description_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.description_tb.Name = "description_tb";
            this.description_tb.ReadOnly = true;
            this.description_tb.Size = new System.Drawing.Size(236, 98);
            this.description_tb.TabIndex = 12;
            this.description_tb.Text = "";
            // 
            // label_tb
            // 
            this.label_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tb.Location = new System.Drawing.Point(195, 131);
            this.label_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.label_tb.Name = "label_tb";
            this.label_tb.ReadOnly = true;
            this.label_tb.Size = new System.Drawing.Size(235, 26);
            this.label_tb.TabIndex = 10;
            // 
            // description_lb
            // 
            this.description_lb.AutoSize = true;
            this.description_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.description_lb.Location = new System.Drawing.Point(89, 217);
            this.description_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.description_lb.Name = "description_lb";
            this.description_lb.Size = new System.Drawing.Size(105, 20);
            this.description_lb.TabIndex = 5;
            this.description_lb.Text = "Description:";
            // 
            // period_lb
            // 
            this.period_lb.AutoSize = true;
            this.period_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.period_lb.Location = new System.Drawing.Point(125, 178);
            this.period_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.period_lb.Name = "period_lb";
            this.period_lb.Size = new System.Drawing.Size(65, 20);
            this.period_lb.TabIndex = 6;
            this.period_lb.Text = "Period:";
            // 
            // label_lb
            // 
            this.label_lb.AutoSize = true;
            this.label_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_lb.Location = new System.Drawing.Point(134, 133);
            this.label_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_lb.Name = "label_lb";
            this.label_lb.Size = new System.Drawing.Size(58, 20);
            this.label_lb.TabIndex = 7;
            this.label_lb.Text = "Label:";
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.id_lb.Location = new System.Drawing.Point(99, 94);
            this.id_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(95, 20);
            this.id_lb.TabIndex = 8;
            this.id_lb.Text = "Course ID:";
            // 
            // period_tb
            // 
            this.period_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_tb.Location = new System.Drawing.Point(194, 176);
            this.period_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.period_tb.Name = "period_tb";
            this.period_tb.ReadOnly = true;
            this.period_tb.Size = new System.Drawing.Size(68, 26);
            this.period_tb.TabIndex = 13;
            // 
            // id_tb
            // 
            this.id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_tb.Location = new System.Drawing.Point(194, 92);
            this.id_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.id_tb.Name = "id_tb";
            this.id_tb.ReadOnly = true;
            this.id_tb.Size = new System.Drawing.Size(236, 26);
            this.id_tb.TabIndex = 13;
            // 
            // RemoveCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(609, 361);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.period_tb);
            this.Controls.Add(this.description_tb);
            this.Controls.Add(this.label_tb);
            this.Controls.Add(this.description_lb);
            this.Controls.Add(this.period_lb);
            this.Controls.Add(this.label_lb);
            this.Controls.Add(this.id_lb);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.idSearch_tb);
            this.Controls.Add(this.enterID_lb);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RemoveCourseForm";
            this.Text = "Remove a course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterID_lb;
        private System.Windows.Forms.TextBox idSearch_tb;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.RichTextBox description_tb;
        private System.Windows.Forms.TextBox label_tb;
        private System.Windows.Forms.Label description_lb;
        private System.Windows.Forms.Label period_lb;
        private System.Windows.Forms.Label label_lb;
        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.TextBox period_tb;
        private System.Windows.Forms.TextBox id_tb;
    }
}