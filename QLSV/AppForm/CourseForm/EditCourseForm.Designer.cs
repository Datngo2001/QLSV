
namespace QLSV.AppForm.CourseForm
{
    partial class EditCourseForm
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
            this.select_lb = new System.Windows.Forms.Label();
            this.label_lb = new System.Windows.Forms.Label();
            this.period_lb = new System.Windows.Forms.Label();
            this.description_lb = new System.Windows.Forms.Label();
            this.select_cb = new System.Windows.Forms.ComboBox();
            this.label_tb = new System.Windows.Forms.TextBox();
            this.period_ud = new System.Windows.Forms.NumericUpDown();
            this.description_tb = new System.Windows.Forms.RichTextBox();
            this.edit_btn = new System.Windows.Forms.Button();
            this.semester_tb = new System.Windows.Forms.TextBox();
            this.semester_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.period_ud)).BeginInit();
            this.SuspendLayout();
            // 
            // select_lb
            // 
            this.select_lb.AutoSize = true;
            this.select_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.select_lb.Location = new System.Drawing.Point(41, 69);
            this.select_lb.Name = "select_lb";
            this.select_lb.Size = new System.Drawing.Size(185, 29);
            this.select_lb.TabIndex = 0;
            this.select_lb.Text = "Select Course:";
            // 
            // label_lb
            // 
            this.label_lb.AutoSize = true;
            this.label_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_lb.Location = new System.Drawing.Point(140, 134);
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
            this.period_lb.Location = new System.Drawing.Point(127, 200);
            this.period_lb.Name = "period_lb";
            this.period_lb.Size = new System.Drawing.Size(98, 29);
            this.period_lb.TabIndex = 0;
            this.period_lb.Text = "Period:";
            // 
            // description_lb
            // 
            this.description_lb.AutoSize = true;
            this.description_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.description_lb.Location = new System.Drawing.Point(73, 309);
            this.description_lb.Name = "description_lb";
            this.description_lb.Size = new System.Drawing.Size(153, 29);
            this.description_lb.TabIndex = 0;
            this.description_lb.Text = "Description:";
            // 
            // select_cb
            // 
            this.select_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_cb.FormattingEnabled = true;
            this.select_cb.Location = new System.Drawing.Point(232, 66);
            this.select_cb.Name = "select_cb";
            this.select_cb.Size = new System.Drawing.Size(351, 37);
            this.select_cb.TabIndex = 1;
            this.select_cb.SelectedIndexChanged += new System.EventHandler(this.select_cb_SelectedIndexChanged);
            // 
            // label_tb
            // 
            this.label_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tb.Location = new System.Drawing.Point(232, 131);
            this.label_tb.Name = "label_tb";
            this.label_tb.Size = new System.Drawing.Size(351, 35);
            this.label_tb.TabIndex = 2;
            // 
            // period_ud
            // 
            this.period_ud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_ud.Location = new System.Drawing.Point(232, 198);
            this.period_ud.Name = "period_ud";
            this.period_ud.Size = new System.Drawing.Size(113, 35);
            this.period_ud.TabIndex = 3;
            // 
            // description_tb
            // 
            this.description_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_tb.Location = new System.Drawing.Point(232, 306);
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(352, 148);
            this.description_tb.TabIndex = 4;
            this.description_tb.Text = "";
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.Blue;
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.ForeColor = System.Drawing.Color.White;
            this.edit_btn.Location = new System.Drawing.Point(157, 498);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(344, 67);
            this.edit_btn.TabIndex = 5;
            this.edit_btn.Text = "Save Change";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // semester_tb
            // 
            this.semester_tb.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester_tb.Location = new System.Drawing.Point(232, 251);
            this.semester_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.semester_tb.Name = "semester_tb";
            this.semester_tb.Size = new System.Drawing.Size(351, 37);
            this.semester_tb.TabIndex = 14;
            // 
            // semester_lb
            // 
            this.semester_lb.AutoSize = true;
            this.semester_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.semester_lb.Location = new System.Drawing.Point(93, 256);
            this.semester_lb.Name = "semester_lb";
            this.semester_lb.Size = new System.Drawing.Size(132, 29);
            this.semester_lb.TabIndex = 0;
            this.semester_lb.Text = "Semester:";
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(639, 610);
            this.Controls.Add(this.semester_tb);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.description_tb);
            this.Controls.Add(this.period_ud);
            this.Controls.Add(this.label_tb);
            this.Controls.Add(this.select_cb);
            this.Controls.Add(this.description_lb);
            this.Controls.Add(this.semester_lb);
            this.Controls.Add(this.period_lb);
            this.Controls.Add(this.label_lb);
            this.Controls.Add(this.select_lb);
            this.Name = "EditCourseForm";
            this.Text = "EditCourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.period_ud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label select_lb;
        private System.Windows.Forms.Label label_lb;
        private System.Windows.Forms.Label period_lb;
        private System.Windows.Forms.Label description_lb;
        private System.Windows.Forms.ComboBox select_cb;
        private System.Windows.Forms.TextBox label_tb;
        private System.Windows.Forms.NumericUpDown period_ud;
        private System.Windows.Forms.RichTextBox description_tb;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.TextBox semester_tb;
        private System.Windows.Forms.Label semester_lb;
    }
}