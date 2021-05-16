
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.score_ch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.score_ch)).BeginInit();
            this.SuspendLayout();
            // 
            // score_ch
            // 
            chartArea1.Name = "ChartArea1";
            this.score_ch.ChartAreas.Add(chartArea1);
            this.score_ch.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.score_ch.Legends.Add(legend1);
            this.score_ch.Location = new System.Drawing.Point(0, 0);
            this.score_ch.Name = "score_ch";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.score_ch.Series.Add(series1);
            this.score_ch.Size = new System.Drawing.Size(507, 505);
            this.score_ch.TabIndex = 0;
            this.score_ch.Text = "chart1";
            // 
            // AvarageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 505);
            this.Controls.Add(this.score_ch);
            this.Name = "AvarageScore";
            this.Text = "AvarageScore";
            this.Load += new System.EventHandler(this.AvarageScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.score_ch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart score_ch;
    }
}