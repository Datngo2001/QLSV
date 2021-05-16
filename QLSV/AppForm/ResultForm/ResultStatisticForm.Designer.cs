
namespace QLSV.AppForm.ResultForm
{
    partial class ResultStatisticForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.course_pn = new System.Windows.Forms.Panel();
            this.score_ch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.byCourse_lb = new System.Windows.Forms.Label();
            this.passFail_pn = new System.Windows.Forms.Panel();
            this.passFail_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.byResult_lb = new System.Windows.Forms.Label();
            this.course_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.score_ch)).BeginInit();
            this.passFail_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passFail_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // course_pn
            // 
            this.course_pn.Controls.Add(this.score_ch);
            this.course_pn.Controls.Add(this.byCourse_lb);
            this.course_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.course_pn.Location = new System.Drawing.Point(0, 0);
            this.course_pn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.course_pn.Name = "course_pn";
            this.course_pn.Size = new System.Drawing.Size(708, 266);
            this.course_pn.TabIndex = 3;
            // 
            // score_ch
            // 
            chartArea1.Name = "ChartArea1";
            this.score_ch.ChartAreas.Add(chartArea1);
            this.score_ch.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.score_ch.Legends.Add(legend1);
            this.score_ch.Location = new System.Drawing.Point(0, 44);
            this.score_ch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.score_ch.Name = "score_ch";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.score_ch.Series.Add(series1);
            this.score_ch.Size = new System.Drawing.Size(708, 222);
            this.score_ch.TabIndex = 3;
            this.score_ch.Text = "chart1";
            // 
            // byCourse_lb
            // 
            this.byCourse_lb.Dock = System.Windows.Forms.DockStyle.Top;
            this.byCourse_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byCourse_lb.ForeColor = System.Drawing.Color.Aqua;
            this.byCourse_lb.Location = new System.Drawing.Point(0, 0);
            this.byCourse_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.byCourse_lb.Name = "byCourse_lb";
            this.byCourse_lb.Size = new System.Drawing.Size(708, 44);
            this.byCourse_lb.TabIndex = 2;
            this.byCourse_lb.Text = "Course Avg Score";
            this.byCourse_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passFail_pn
            // 
            this.passFail_pn.Controls.Add(this.passFail_chart);
            this.passFail_pn.Controls.Add(this.byResult_lb);
            this.passFail_pn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passFail_pn.Location = new System.Drawing.Point(0, 266);
            this.passFail_pn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passFail_pn.Name = "passFail_pn";
            this.passFail_pn.Size = new System.Drawing.Size(708, 302);
            this.passFail_pn.TabIndex = 4;
            // 
            // passFail_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.passFail_chart.ChartAreas.Add(chartArea2);
            this.passFail_chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.passFail_chart.Legends.Add(legend2);
            this.passFail_chart.Location = new System.Drawing.Point(0, 44);
            this.passFail_chart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passFail_chart.Name = "passFail_chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.passFail_chart.Series.Add(series2);
            this.passFail_chart.Size = new System.Drawing.Size(708, 258);
            this.passFail_chart.TabIndex = 4;
            this.passFail_chart.Text = "chart1";
            // 
            // byResult_lb
            // 
            this.byResult_lb.Dock = System.Windows.Forms.DockStyle.Top;
            this.byResult_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byResult_lb.ForeColor = System.Drawing.Color.Aqua;
            this.byResult_lb.Location = new System.Drawing.Point(0, 0);
            this.byResult_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.byResult_lb.Name = "byResult_lb";
            this.byResult_lb.Size = new System.Drawing.Size(708, 44);
            this.byResult_lb.TabIndex = 3;
            this.byResult_lb.Text = "Pass and Fail";
            this.byResult_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultStatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(708, 568);
            this.Controls.Add(this.passFail_pn);
            this.Controls.Add(this.course_pn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ResultStatisticForm";
            this.Text = "ResultStatisticForm";
            this.Load += new System.EventHandler(this.ResultStatisticForm_Load);
            this.course_pn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.score_ch)).EndInit();
            this.passFail_pn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passFail_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel course_pn;
        private System.Windows.Forms.DataVisualization.Charting.Chart score_ch;
        private System.Windows.Forms.Label byCourse_lb;
        private System.Windows.Forms.Panel passFail_pn;
        private System.Windows.Forms.DataVisualization.Charting.Chart passFail_chart;
        private System.Windows.Forms.Label byResult_lb;
    }
}