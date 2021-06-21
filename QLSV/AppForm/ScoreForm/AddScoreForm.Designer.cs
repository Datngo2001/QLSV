
namespace QLSV.AppForm.ScoreForm
{
    partial class AddScoreForm
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
            this.cource_lb = new System.Windows.Forms.Label();
            this.score_lb = new System.Windows.Forms.Label();
            this.description_lb = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.description_tb = new System.Windows.Forms.RichTextBox();
            this.cource_cb = new System.Windows.Forms.ComboBox();
            this.score_tb = new System.Windows.Forms.TextBox();
            this.studentInfo_dgv = new System.Windows.Forms.DataGridView();
            this.add_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfo_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.id_lb.Location = new System.Drawing.Point(40, 10);
            this.id_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(112, 24);
            this.id_lb.TabIndex = 0;
            this.id_lb.Text = "Student ID:";
            // 
            // cource_lb
            // 
            this.cource_lb.AutoSize = true;
            this.cource_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cource_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cource_lb.Location = new System.Drawing.Point(8, 46);
            this.cource_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cource_lb.Name = "cource_lb";
            this.cource_lb.Size = new System.Drawing.Size(147, 24);
            this.cource_lb.TabIndex = 0;
            this.cource_lb.Text = "Select Course:";
            // 
            // score_lb
            // 
            this.score_lb.AutoSize = true;
            this.score_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.score_lb.Location = new System.Drawing.Point(83, 83);
            this.score_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.score_lb.Name = "score_lb";
            this.score_lb.Size = new System.Drawing.Size(71, 24);
            this.score_lb.TabIndex = 0;
            this.score_lb.Text = "Score:";
            // 
            // description_lb
            // 
            this.description_lb.AutoSize = true;
            this.description_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.description_lb.Location = new System.Drawing.Point(33, 116);
            this.description_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.description_lb.Name = "description_lb";
            this.description_lb.Size = new System.Drawing.Size(121, 24);
            this.description_lb.TabIndex = 0;
            this.description_lb.Text = "Description:";
            // 
            // id_tb
            // 
            this.id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_tb.Location = new System.Drawing.Point(155, 10);
            this.id_tb.Margin = new System.Windows.Forms.Padding(2);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(139, 26);
            this.id_tb.TabIndex = 3;
            // 
            // description_tb
            // 
            this.description_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_tb.Location = new System.Drawing.Point(155, 116);
            this.description_tb.Margin = new System.Windows.Forms.Padding(2);
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(223, 96);
            this.description_tb.TabIndex = 4;
            this.description_tb.Text = "";
            // 
            // cource_cb
            // 
            this.cource_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cource_cb.FormattingEnabled = true;
            this.cource_cb.Location = new System.Drawing.Point(155, 46);
            this.cource_cb.Margin = new System.Windows.Forms.Padding(2);
            this.cource_cb.Name = "cource_cb";
            this.cource_cb.Size = new System.Drawing.Size(223, 28);
            this.cource_cb.TabIndex = 5;
            // 
            // score_tb
            // 
            this.score_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_tb.Location = new System.Drawing.Point(155, 83);
            this.score_tb.Margin = new System.Windows.Forms.Padding(2);
            this.score_tb.Name = "score_tb";
            this.score_tb.Size = new System.Drawing.Size(139, 26);
            this.score_tb.TabIndex = 6;
            // 
            // studentInfo_dgv
            // 
            this.studentInfo_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentInfo_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentInfo_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentInfo_dgv.Location = new System.Drawing.Point(438, 8);
            this.studentInfo_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.studentInfo_dgv.Name = "studentInfo_dgv";
            this.studentInfo_dgv.RowHeadersWidth = 62;
            this.studentInfo_dgv.RowTemplate.Height = 28;
            this.studentInfo_dgv.Size = new System.Drawing.Size(465, 274);
            this.studentInfo_dgv.TabIndex = 7;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Lime;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_btn.Location = new System.Drawing.Point(155, 228);
            this.add_btn.Margin = new System.Windows.Forms.Padding(2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(222, 43);
            this.add_btn.TabIndex = 8;
            this.add_btn.Text = "Add Score";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(911, 292);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.studentInfo_dgv);
            this.Controls.Add(this.score_tb);
            this.Controls.Add(this.cource_cb);
            this.Controls.Add(this.description_tb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.description_lb);
            this.Controls.Add(this.score_lb);
            this.Controls.Add(this.cource_lb);
            this.Controls.Add(this.id_lb);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddScoreForm";
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentInfo_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.Label cource_lb;
        private System.Windows.Forms.Label score_lb;
        private System.Windows.Forms.Label description_lb;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.RichTextBox description_tb;
        private System.Windows.Forms.ComboBox cource_cb;
        private System.Windows.Forms.TextBox score_tb;
        private System.Windows.Forms.DataGridView studentInfo_dgv;
        private System.Windows.Forms.Button add_btn;
    }
}