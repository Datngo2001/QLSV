
namespace QLSV.AppForm.StudentsForm
{
    partial class ManageStudentsForm
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
            this.dowload = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.showResult_dgv = new System.Windows.Forms.DataGridView();
            this.Search_tb = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.total_lb = new System.Windows.Forms.Label();
            this.genderBtn_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_pcb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showResult_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Id_tb
            // 
            this.Id_tb.Location = new System.Drawing.Point(217, 19);
            this.Id_tb.Text = "0";
            // 
            // FirstName_tb
            // 
            this.FirstName_tb.Location = new System.Drawing.Point(217, 74);
            // 
            // LastName_tb
            // 
            this.LastName_tb.Location = new System.Drawing.Point(217, 150);
            // 
            // Phone_tb
            // 
            this.Phone_tb.Location = new System.Drawing.Point(217, 332);
            // 
            // BirthDay_picker
            // 
            this.BirthDay_picker.Location = new System.Drawing.Point(217, 216);
            // 
            // genderBtn_group
            // 
            this.genderBtn_group.Location = new System.Drawing.Point(217, 262);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 19);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(47, 80);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(47, 150);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(47, 216);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(47, 278);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(47, 335);
            // 
            // findID_btn
            // 
            this.findID_btn.Location = new System.Drawing.Point(408, 19);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(47, 402);
            // 
            // Address_rtb
            // 
            this.Address_rtb.Location = new System.Drawing.Point(217, 402);
            this.Address_rtb.Size = new System.Drawing.Size(301, 85);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(47, 502);
            // 
            // student_pcb
            // 
            this.student_pcb.Location = new System.Drawing.Point(217, 502);
            this.student_pcb.Size = new System.Drawing.Size(301, 234);
            // 
            // Edit
            // 
            this.Edit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Edit.Location = new System.Drawing.Point(52, 794);
            this.Edit.Size = new System.Drawing.Size(257, 45);
            // 
            // Remove
            // 
            this.Remove.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Remove.Location = new System.Drawing.Point(315, 794);
            this.Remove.Size = new System.Drawing.Size(168, 45);
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(217, 743);
            this.Upload.Size = new System.Drawing.Size(151, 40);
            // 
            // findByPhone_btn
            // 
            this.findByPhone_btn.Location = new System.Drawing.Point(408, 332);
            // 
            // firstNameFind_btn
            // 
            this.firstNameFind_btn.Location = new System.Drawing.Point(408, 74);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Cancel.Location = new System.Drawing.Point(663, 794);
            this.Cancel.Size = new System.Drawing.Size(168, 45);
            // 
            // dowload
            // 
            this.dowload.Location = new System.Drawing.Point(374, 742);
            this.dowload.Name = "dowload";
            this.dowload.Size = new System.Drawing.Size(144, 41);
            this.dowload.TabIndex = 26;
            this.dowload.Text = "Download";
            this.dowload.UseVisualStyleBackColor = true;
            // 
            // reset_btn
            // 
            this.reset_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.reset_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.reset_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reset_btn.Location = new System.Drawing.Point(489, 794);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(168, 45);
            this.reset_btn.TabIndex = 26;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(669, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(377, 29);
            this.label9.TabIndex = 27;
            this.label9.Text = "Search Fname Lname Address:";
            // 
            // showResult_dgv
            // 
            this.showResult_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showResult_dgv.Location = new System.Drawing.Point(674, 74);
            this.showResult_dgv.Name = "showResult_dgv";
            this.showResult_dgv.RowHeadersWidth = 62;
            this.showResult_dgv.RowTemplate.Height = 28;
            this.showResult_dgv.Size = new System.Drawing.Size(1001, 662);
            this.showResult_dgv.TabIndex = 28;
            this.showResult_dgv.DoubleClick += new System.EventHandler(this.showResult_dgv_DoubleClick);
            // 
            // Search_tb
            // 
            this.Search_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_tb.Location = new System.Drawing.Point(1052, 16);
            this.Search_tb.Name = "Search_tb";
            this.Search_tb.Size = new System.Drawing.Size(502, 35);
            this.Search_tb.TabIndex = 29;
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(1571, 16);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(104, 35);
            this.search_btn.TabIndex = 30;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // total_lb
            // 
            this.total_lb.AutoSize = true;
            this.total_lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.total_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.total_lb.Location = new System.Drawing.Point(1241, 776);
            this.total_lb.Name = "total_lb";
            this.total_lb.Size = new System.Drawing.Size(215, 32);
            this.total_lb.TabIndex = 31;
            this.total_lb.Text = "Total Student: ";
            // 
            // ManageStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1701, 851);
            this.Controls.Add(this.total_lb);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.Search_tb);
            this.Controls.Add(this.showResult_dgv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.dowload);
            this.Name = "ManageStudentsForm";
            this.Text = "Ngo Minh Dat 19110115";
            this.Load += new System.EventHandler(this.ManageStudentsForm_Load);
            this.Controls.SetChildIndex(this.Id_tb, 0);
            this.Controls.SetChildIndex(this.FirstName_tb, 0);
            this.Controls.SetChildIndex(this.LastName_tb, 0);
            this.Controls.SetChildIndex(this.Phone_tb, 0);
            this.Controls.SetChildIndex(this.BirthDay_picker, 0);
            this.Controls.SetChildIndex(this.genderBtn_group, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.findID_btn, 0);
            this.Controls.SetChildIndex(this.findByPhone_btn, 0);
            this.Controls.SetChildIndex(this.firstNameFind_btn, 0);
            this.Controls.SetChildIndex(this.Address_rtb, 0);
            this.Controls.SetChildIndex(this.student_pcb, 0);
            this.Controls.SetChildIndex(this.Edit, 0);
            this.Controls.SetChildIndex(this.Remove, 0);
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.Upload, 0);
            this.Controls.SetChildIndex(this.dowload, 0);
            this.Controls.SetChildIndex(this.reset_btn, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.showResult_dgv, 0);
            this.Controls.SetChildIndex(this.Search_tb, 0);
            this.Controls.SetChildIndex(this.search_btn, 0);
            this.Controls.SetChildIndex(this.total_lb, 0);
            this.genderBtn_group.ResumeLayout(false);
            this.genderBtn_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_pcb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showResult_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dowload;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView showResult_dgv;
        private System.Windows.Forms.TextBox Search_tb;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label total_lb;
    }
}