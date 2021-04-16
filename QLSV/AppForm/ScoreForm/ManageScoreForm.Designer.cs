
namespace QLSV.AppForm.ScoreForm
{
    partial class ManageScoreForm
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
            this.score_tb = new System.Windows.Forms.TextBox();
            this.cource_cb = new System.Windows.Forms.ComboBox();
            this.description_tb = new System.Windows.Forms.RichTextBox();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.description_lb = new System.Windows.Forms.Label();
            this.score_lb = new System.Windows.Forms.Label();
            this.cource_lb = new System.Windows.Forms.Label();
            this.id_lb = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.avg_btn = new System.Windows.Forms.Button();
            this.showStudent_btn = new System.Windows.Forms.Button();
            this.showScore_btn = new System.Windows.Forms.Button();
            this.show_dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.show_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // score_tb
            // 
            this.score_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_tb.Location = new System.Drawing.Point(228, 125);
            this.score_tb.Name = "score_tb";
            this.score_tb.Size = new System.Drawing.Size(206, 35);
            this.score_tb.TabIndex = 14;
            // 
            // cource_cb
            // 
            this.cource_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cource_cb.FormattingEnabled = true;
            this.cource_cb.Location = new System.Drawing.Point(228, 69);
            this.cource_cb.Name = "cource_cb";
            this.cource_cb.Size = new System.Drawing.Size(333, 37);
            this.cource_cb.TabIndex = 13;
            // 
            // description_tb
            // 
            this.description_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_tb.Location = new System.Drawing.Point(228, 176);
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(333, 145);
            this.description_tb.TabIndex = 12;
            this.description_tb.Text = "";
            // 
            // id_tb
            // 
            this.id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_tb.Location = new System.Drawing.Point(228, 14);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(206, 35);
            this.id_tb.TabIndex = 11;
            // 
            // description_lb
            // 
            this.description_lb.AutoSize = true;
            this.description_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.description_lb.Location = new System.Drawing.Point(44, 176);
            this.description_lb.Name = "description_lb";
            this.description_lb.Size = new System.Drawing.Size(178, 32);
            this.description_lb.TabIndex = 7;
            this.description_lb.Text = "Description:";
            // 
            // score_lb
            // 
            this.score_lb.AutoSize = true;
            this.score_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.score_lb.Location = new System.Drawing.Point(119, 125);
            this.score_lb.Name = "score_lb";
            this.score_lb.Size = new System.Drawing.Size(103, 32);
            this.score_lb.TabIndex = 8;
            this.score_lb.Text = "Score:";
            // 
            // cource_lb
            // 
            this.cource_lb.AutoSize = true;
            this.cource_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cource_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cource_lb.Location = new System.Drawing.Point(7, 69);
            this.cource_lb.Name = "cource_lb";
            this.cource_lb.Size = new System.Drawing.Size(215, 32);
            this.cource_lb.TabIndex = 9;
            this.cource_lb.Text = "Select Course:";
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_lb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.id_lb.Location = new System.Drawing.Point(55, 14);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(167, 32);
            this.id_lb.TabIndex = 10;
            this.id_lb.Text = "Student ID:";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Lime;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_btn.Location = new System.Drawing.Point(92, 372);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(173, 66);
            this.add_btn.TabIndex = 15;
            this.add_btn.Text = "Add Score";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.BackColor = System.Drawing.Color.Red;
            this.remove_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.remove_btn.Location = new System.Drawing.Point(310, 372);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(173, 66);
            this.remove_btn.TabIndex = 16;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = false;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // avg_btn
            // 
            this.avg_btn.BackColor = System.Drawing.Color.Blue;
            this.avg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avg_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.avg_btn.Location = new System.Drawing.Point(92, 494);
            this.avg_btn.Name = "avg_btn";
            this.avg_btn.Size = new System.Drawing.Size(391, 92);
            this.avg_btn.TabIndex = 17;
            this.avg_btn.Text = "Average Score By Course";
            this.avg_btn.UseVisualStyleBackColor = false;
            // 
            // showStudent_btn
            // 
            this.showStudent_btn.Location = new System.Drawing.Point(793, 16);
            this.showStudent_btn.Name = "showStudent_btn";
            this.showStudent_btn.Size = new System.Drawing.Size(192, 36);
            this.showStudent_btn.TabIndex = 18;
            this.showStudent_btn.Text = "Show Student";
            this.showStudent_btn.UseVisualStyleBackColor = true;
            this.showStudent_btn.Click += new System.EventHandler(this.showStudent_btn_Click);
            // 
            // showScore_btn
            // 
            this.showScore_btn.Location = new System.Drawing.Point(1122, 16);
            this.showScore_btn.Name = "showScore_btn";
            this.showScore_btn.Size = new System.Drawing.Size(192, 36);
            this.showScore_btn.TabIndex = 18;
            this.showScore_btn.Text = "Show Score";
            this.showScore_btn.UseVisualStyleBackColor = true;
            this.showScore_btn.Click += new System.EventHandler(this.showScore_btn_Click);
            // 
            // show_dgv
            // 
            this.show_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_dgv.Location = new System.Drawing.Point(626, 69);
            this.show_dgv.Name = "show_dgv";
            this.show_dgv.RowHeadersWidth = 62;
            this.show_dgv.RowTemplate.Height = 28;
            this.show_dgv.Size = new System.Drawing.Size(781, 553);
            this.show_dgv.TabIndex = 19;
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1419, 634);
            this.Controls.Add(this.show_dgv);
            this.Controls.Add(this.showScore_btn);
            this.Controls.Add(this.showStudent_btn);
            this.Controls.Add(this.avg_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.score_tb);
            this.Controls.Add(this.cource_cb);
            this.Controls.Add(this.description_tb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.description_lb);
            this.Controls.Add(this.score_lb);
            this.Controls.Add(this.cource_lb);
            this.Controls.Add(this.id_lb);
            this.Name = "ManageScoreForm";
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.show_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox score_tb;
        private System.Windows.Forms.ComboBox cource_cb;
        private System.Windows.Forms.RichTextBox description_tb;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Label description_lb;
        private System.Windows.Forms.Label score_lb;
        private System.Windows.Forms.Label cource_lb;
        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button avg_btn;
        private System.Windows.Forms.Button showStudent_btn;
        private System.Windows.Forms.Button showScore_btn;
        private System.Windows.Forms.DataGridView show_dgv;
    }
}