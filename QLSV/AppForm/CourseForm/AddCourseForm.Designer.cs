
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
            this.label_lb = new System.Windows.Forms.Label();
            this.period_lb = new System.Windows.Forms.Label();
            this.desrciption_lb = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.label_tb = new System.Windows.Forms.TextBox();
            this.description_tb = new System.Windows.Forms.RichTextBox();
            this.period_ud = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.semester_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.period_ud)).BeginInit();
            this.SuspendLayout();
            // 
            // label_lb
            // 
            this.label_lb.AutoSize = true;
            this.label_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_lb.Location = new System.Drawing.Point(91, 30);
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
            this.period_lb.Location = new System.Drawing.Point(75, 150);
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
            this.desrciption_lb.Location = new System.Drawing.Point(23, 222);
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
            this.add_btn.Location = new System.Drawing.Point(113, 380);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(333, 66);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "ADD COURSE";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label_tb
            // 
            this.label_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tb.Location = new System.Drawing.Point(179, 27);
            this.label_tb.Name = "label_tb";
            this.label_tb.Size = new System.Drawing.Size(333, 35);
            this.label_tb.TabIndex = 2;
            // 
            // description_tb
            // 
            this.description_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_tb.Location = new System.Drawing.Point(179, 219);
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(333, 96);
            this.description_tb.TabIndex = 3;
            this.description_tb.Text = "";
            // 
            // period_ud
            // 
            this.period_ud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_ud.Location = new System.Drawing.Point(179, 144);
            this.period_ud.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.period_ud.Name = "period_ud";
            this.period_ud.Size = new System.Drawing.Size(120, 35);
            this.period_ud.TabIndex = 5;
            this.period_ud.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.Font = new System.Drawing.Font("Arial", 13F);
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Location = new System.Drawing.Point(179, 82);
            this.comboBoxSemester.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(76, 39);
            this.comboBoxSemester.TabIndex = 14;
            // 
            // semester_lb
            // 
            this.semester_lb.AutoSize = true;
            this.semester_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.semester_lb.Location = new System.Drawing.Point(41, 85);
            this.semester_lb.Name = "semester_lb";
            this.semester_lb.Size = new System.Drawing.Size(132, 29);
            this.semester_lb.TabIndex = 13;
            this.semester_lb.Text = "Semester:";
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(564, 477);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.semester_lb);
            this.Controls.Add(this.period_ud);
            this.Controls.Add(this.description_tb);
            this.Controls.Add(this.label_tb);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.desrciption_lb);
            this.Controls.Add(this.period_lb);
            this.Controls.Add(this.label_lb);
            this.Name = "AddCourseForm";
            this.Text = "AddCourseForm";
            this.Load += new System.EventHandler(this.AddCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.period_ud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_lb;
        private System.Windows.Forms.Label period_lb;
        private System.Windows.Forms.Label desrciption_lb;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox label_tb;
        private System.Windows.Forms.RichTextBox description_tb;
        private System.Windows.Forms.NumericUpDown period_ud;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.Label semester_lb;
    }
}