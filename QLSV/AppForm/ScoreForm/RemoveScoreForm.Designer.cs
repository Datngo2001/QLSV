﻿
namespace QLSV.AppForm.ScoreForm
{
    partial class RemoveScoreForm
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
            this.score_dgv = new System.Windows.Forms.DataGridView();
            this.remove_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.score_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // score_dgv
            // 
            this.score_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.score_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.score_dgv.Location = new System.Drawing.Point(8, 8);
            this.score_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.score_dgv.Name = "score_dgv";
            this.score_dgv.RowHeadersWidth = 62;
            this.score_dgv.RowTemplate.Height = 28;
            this.score_dgv.Size = new System.Drawing.Size(517, 227);
            this.score_dgv.TabIndex = 0;
            // 
            // remove_btn
            // 
            this.remove_btn.BackColor = System.Drawing.Color.Red;
            this.remove_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.remove_btn.Location = new System.Drawing.Point(184, 248);
            this.remove_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(149, 36);
            this.remove_btn.TabIndex = 1;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = false;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngô Minh Đạt 19110115";
            // 
            // RemoveScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.score_dgv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RemoveScoreForm";
            this.Text = "RemoveScoreForm";
            this.Load += new System.EventHandler(this.RemoveScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.score_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView score_dgv;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Label label5;
    }
}