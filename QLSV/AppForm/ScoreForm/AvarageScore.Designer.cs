
namespace QLSV.AppForm.ScoreForm
{
    partial class AvarageScore
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.score_ch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.score_ch)).BeginInit();
            this.SuspendLayout();
            // 
            // score_ch
            // 
            chartArea2.Name = "ChartArea1";
            this.score_ch.ChartAreas.Add(chartArea2);
            this.score_ch.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.score_ch.Legends.Add(legend2);
            this.score_ch.Location = new System.Drawing.Point(0, 0);
            this.score_ch.Name = "score_ch";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.score_ch.Series.Add(series2);
            this.score_ch.Size = new System.Drawing.Size(507, 505);
            this.score_ch.TabIndex = 0;
            this.score_ch.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ngô Minh Đạt 19110115";
            // 
            // AvarageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 505);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.score_ch);
            this.Name = "AvarageScore";
            this.Text = "AvarageScore";
            ((System.ComponentModel.ISupportInitialize)(this.score_ch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart score_ch;
        private System.Windows.Forms.Label label5;
    }
}