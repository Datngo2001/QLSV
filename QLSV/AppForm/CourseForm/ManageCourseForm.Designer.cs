namespace QLSV.AppForm.CourseForm
{
    partial class ManageCourseForm
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
            this.description_tb = new System.Windows.Forms.Label();
            this.period_lb = new System.Windows.Forms.Label();
            this.label_lb = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.label_tb = new System.Windows.Forms.TextBox();
            this.description_rtb = new System.Windows.Forms.TextBox();
            this.period_ud = new System.Windows.Forms.NumericUpDown();
            this.first_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.previous_btn = new System.Windows.Forms.Button();
            this.last_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.course_lstb = new System.Windows.Forms.ListBox();
            this.totalCourse_lb = new System.Windows.Forms.Label();
            this.semester_lb = new System.Windows.Forms.Label();
            this.semester_cb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.period_ud)).BeginInit();
            this.SuspendLayout();
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.id_lb.Location = new System.Drawing.Point(189, 38);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(56, 36);
            this.id_lb.TabIndex = 0;
            this.id_lb.Text = "ID:";
            // 
            // description_tb
            // 
            this.description_tb.AutoSize = true;
            this.description_tb.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_tb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.description_tb.Location = new System.Drawing.Point(66, 309);
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(182, 36);
            this.description_tb.TabIndex = 1;
            this.description_tb.Text = "Description:";
            // 
            // period_lb
            // 
            this.period_lb.AutoSize = true;
            this.period_lb.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_lb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.period_lb.Location = new System.Drawing.Point(28, 178);
            this.period_lb.Name = "period_lb";
            this.period_lb.Size = new System.Drawing.Size(231, 36);
            this.period_lb.TabIndex = 2;
            this.period_lb.Text = "Hours Number:";
            // 
            // label_lb
            // 
            this.label_lb.AutoSize = true;
            this.label_lb.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_lb.Location = new System.Drawing.Point(146, 105);
            this.label_lb.Name = "label_lb";
            this.label_lb.Size = new System.Drawing.Size(100, 36);
            this.label_lb.TabIndex = 3;
            this.label_lb.Text = "Label:";
            // 
            // id_tb
            // 
            this.id_tb.Font = new System.Drawing.Font("Arial", 13F);
            this.id_tb.Location = new System.Drawing.Point(266, 38);
            this.id_tb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(330, 37);
            this.id_tb.TabIndex = 4;
            // 
            // label_tb
            // 
            this.label_tb.Font = new System.Drawing.Font("Arial", 13F);
            this.label_tb.Location = new System.Drawing.Point(266, 105);
            this.label_tb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label_tb.Name = "label_tb";
            this.label_tb.Size = new System.Drawing.Size(330, 37);
            this.label_tb.TabIndex = 5;
            // 
            // description_rtb
            // 
            this.description_rtb.Font = new System.Drawing.Font("Arial", 13F);
            this.description_rtb.Location = new System.Drawing.Point(266, 309);
            this.description_rtb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.description_rtb.Multiline = true;
            this.description_rtb.Name = "description_rtb";
            this.description_rtb.Size = new System.Drawing.Size(330, 199);
            this.description_rtb.TabIndex = 6;
            // 
            // period_ud
            // 
            this.period_ud.Font = new System.Drawing.Font("Arial", 13F);
            this.period_ud.Location = new System.Drawing.Point(270, 178);
            this.period_ud.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.period_ud.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.period_ud.Name = "period_ud";
            this.period_ud.Size = new System.Drawing.Size(109, 37);
            this.period_ud.TabIndex = 7;
            // 
            // first_btn
            // 
            this.first_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.first_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.first_btn.Location = new System.Drawing.Point(200, 607);
            this.first_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.first_btn.Name = "first_btn";
            this.first_btn.Size = new System.Drawing.Size(112, 54);
            this.first_btn.TabIndex = 8;
            this.first_btn.Text = "<<";
            this.first_btn.UseVisualStyleBackColor = false;
            this.first_btn.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.next_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.next_btn.Location = new System.Drawing.Point(425, 607);
            this.next_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(101, 54);
            this.next_btn.TabIndex = 9;
            this.next_btn.Text = ">";
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // previous_btn
            // 
            this.previous_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.previous_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.previous_btn.Location = new System.Drawing.Point(318, 607);
            this.previous_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.previous_btn.Name = "previous_btn";
            this.previous_btn.Size = new System.Drawing.Size(101, 54);
            this.previous_btn.TabIndex = 10;
            this.previous_btn.Text = "<";
            this.previous_btn.UseVisualStyleBackColor = false;
            this.previous_btn.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // last_btn
            // 
            this.last_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.last_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.last_btn.Location = new System.Drawing.Point(532, 607);
            this.last_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.last_btn.Name = "last_btn";
            this.last_btn.Size = new System.Drawing.Size(105, 54);
            this.last_btn.TabIndex = 11;
            this.last_btn.Text = ">>";
            this.last_btn.UseVisualStyleBackColor = false;
            this.last_btn.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Lime;
            this.add_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(200, 687);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(261, 54);
            this.add_btn.TabIndex = 12;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.edit_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.edit_btn.ForeColor = System.Drawing.Color.White;
            this.edit_btn.Location = new System.Drawing.Point(266, 518);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(330, 59);
            this.edit_btn.TabIndex = 13;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.BackColor = System.Drawing.Color.Red;
            this.remove_btn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.remove_btn.ForeColor = System.Drawing.Color.White;
            this.remove_btn.Location = new System.Drawing.Point(467, 687);
            this.remove_btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(170, 54);
            this.remove_btn.TabIndex = 14;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = false;
            this.remove_btn.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // course_lstb
            // 
            this.course_lstb.Font = new System.Drawing.Font("Arial", 14F);
            this.course_lstb.FormattingEnabled = true;
            this.course_lstb.ItemHeight = 32;
            this.course_lstb.Location = new System.Drawing.Point(754, 55);
            this.course_lstb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.course_lstb.Name = "course_lstb";
            this.course_lstb.Size = new System.Drawing.Size(500, 548);
            this.course_lstb.TabIndex = 17;
            // 
            // totalCourse_lb
            // 
            this.totalCourse_lb.AutoSize = true;
            this.totalCourse_lb.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.totalCourse_lb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.totalCourse_lb.Location = new System.Drawing.Point(747, 639);
            this.totalCourse_lb.Name = "totalCourse_lb";
            this.totalCourse_lb.Padding = new System.Windows.Forms.Padding(28, 12, 28, 12);
            this.totalCourse_lb.Size = new System.Drawing.Size(278, 61);
            this.totalCourse_lb.TabIndex = 18;
            this.totalCourse_lb.Text = "Total Course:";
            this.totalCourse_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // semester_lb
            // 
            this.semester_lb.AutoSize = true;
            this.semester_lb.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester_lb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.semester_lb.Location = new System.Drawing.Point(86, 251);
            this.semester_lb.Name = "semester_lb";
            this.semester_lb.Size = new System.Drawing.Size(159, 36);
            this.semester_lb.TabIndex = 2;
            this.semester_lb.Text = "Semester:";
            // 
            // semester_cb
            // 
            this.semester_cb.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester_cb.FormattingEnabled = true;
            this.semester_cb.Location = new System.Drawing.Point(266, 248);
            this.semester_cb.Name = "semester_cb";
            this.semester_cb.Size = new System.Drawing.Size(113, 39);
            this.semester_cb.TabIndex = 19;
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1344, 755);
            this.Controls.Add(this.semester_cb);
            this.Controls.Add(this.totalCourse_lb);
            this.Controls.Add(this.course_lstb);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.last_btn);
            this.Controls.Add(this.previous_btn);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.first_btn);
            this.Controls.Add(this.period_ud);
            this.Controls.Add(this.description_rtb);
            this.Controls.Add(this.label_tb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.label_lb);
            this.Controls.Add(this.semester_lb);
            this.Controls.Add(this.period_lb);
            this.Controls.Add(this.description_tb);
            this.Controls.Add(this.id_lb);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "ManageCourseForm";
            this.Text = "ManageCourseForm";
            this.Load += new System.EventHandler(this.ManageCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.period_ud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.Label description_tb;
        private System.Windows.Forms.Label period_lb;
        private System.Windows.Forms.Label label_lb;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.TextBox label_tb;
        private System.Windows.Forms.TextBox description_rtb;
        private System.Windows.Forms.NumericUpDown period_ud;
        private System.Windows.Forms.Button first_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button previous_btn;
        private System.Windows.Forms.Button last_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Label totalCourse_lb;
        private System.Windows.Forms.ListBox course_lstb;
        private System.Windows.Forms.Label semester_lb;
        private System.Windows.Forms.ComboBox semester_cb;
    }
}