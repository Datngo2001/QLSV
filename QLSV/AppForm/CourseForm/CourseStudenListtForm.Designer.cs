
namespace QLSV.AppForm.CourseForm
{
    partial class CourseStudenListtForm
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
            this.label_pn = new System.Windows.Forms.Panel();
            this.semester_lb = new System.Windows.Forms.Label();
            this.courseName_lb = new System.Windows.Forms.Label();
            this.print_pn = new System.Windows.Forms.Panel();
            this.save_btn = new System.Windows.Forms.Button();
            this.print_btn = new System.Windows.Forms.Button();
            this.student_dgv = new System.Windows.Forms.DataGridView();
            this.label_pn.SuspendLayout();
            this.print_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label_pn
            // 
            this.label_pn.Controls.Add(this.semester_lb);
            this.label_pn.Controls.Add(this.courseName_lb);
            this.label_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_pn.Location = new System.Drawing.Point(0, 0);
            this.label_pn.Margin = new System.Windows.Forms.Padding(2);
            this.label_pn.Name = "label_pn";
            this.label_pn.Size = new System.Drawing.Size(593, 47);
            this.label_pn.TabIndex = 14;
            // 
            // semester_lb
            // 
            this.semester_lb.AutoSize = true;
            this.semester_lb.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester_lb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.semester_lb.Location = new System.Drawing.Point(416, 12);
            this.semester_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.semester_lb.Name = "semester_lb";
            this.semester_lb.Size = new System.Drawing.Size(122, 26);
            this.semester_lb.TabIndex = 13;
            this.semester_lb.Text = "Semester: ";
            // 
            // courseName_lb
            // 
            this.courseName_lb.AutoSize = true;
            this.courseName_lb.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseName_lb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.courseName_lb.Location = new System.Drawing.Point(35, 12);
            this.courseName_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.courseName_lb.Name = "courseName_lb";
            this.courseName_lb.Size = new System.Drawing.Size(164, 26);
            this.courseName_lb.TabIndex = 12;
            this.courseName_lb.Text = "Course Name: ";
            // 
            // print_pn
            // 
            this.print_pn.Controls.Add(this.save_btn);
            this.print_pn.Controls.Add(this.print_btn);
            this.print_pn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.print_pn.Location = new System.Drawing.Point(0, 317);
            this.print_pn.Margin = new System.Windows.Forms.Padding(2);
            this.print_pn.Name = "print_pn";
            this.print_pn.Size = new System.Drawing.Size(593, 48);
            this.print_pn.TabIndex = 15;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Red;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(170, 5);
            this.save_btn.Margin = new System.Windows.Forms.Padding(2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(106, 41);
            this.save_btn.TabIndex = 0;
            this.save_btn.Text = "Save as";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // print_btn
            // 
            this.print_btn.BackColor = System.Drawing.Color.Red;
            this.print_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.ForeColor = System.Drawing.Color.White;
            this.print_btn.Location = new System.Drawing.Point(310, 5);
            this.print_btn.Margin = new System.Windows.Forms.Padding(2);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(106, 41);
            this.print_btn.TabIndex = 0;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // student_dgv
            // 
            this.student_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.student_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.student_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.student_dgv.Location = new System.Drawing.Point(0, 47);
            this.student_dgv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.student_dgv.Name = "student_dgv";
            this.student_dgv.RowHeadersWidth = 51;
            this.student_dgv.RowTemplate.Height = 24;
            this.student_dgv.Size = new System.Drawing.Size(593, 270);
            this.student_dgv.TabIndex = 16;
            // 
            // CourseStudenListtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(593, 365);
            this.Controls.Add(this.student_dgv);
            this.Controls.Add(this.print_pn);
            this.Controls.Add(this.label_pn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CourseStudenListtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Student List";
            this.Load += new System.EventHandler(this.CourseStudenListtForm_Load);
            this.label_pn.ResumeLayout(false);
            this.label_pn.PerformLayout();
            this.print_pn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.student_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel label_pn;
        private System.Windows.Forms.Label semester_lb;
        private System.Windows.Forms.Label courseName_lb;
        private System.Windows.Forms.Panel print_pn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button print_btn;
        public System.Windows.Forms.DataGridView student_dgv;
    }
}