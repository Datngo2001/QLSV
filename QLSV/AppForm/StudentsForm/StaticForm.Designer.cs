﻿
namespace QLSV.AppForm.StudentsForm
{
    partial class StaticForm
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
            this.genderChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gender_lb = new System.Windows.Forms.Label();
            this.totalStd_lb = new System.Windows.Forms.Label();
            this.totalStudent_lb = new System.Windows.Forms.Label();
            this.male_lb = new System.Windows.Forms.Label();
            this.malePercent_lb = new System.Windows.Forms.Label();
            this.female_lb = new System.Windows.Forms.Label();
            this.femalePercent_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.genderChart)).BeginInit();
            this.SuspendLayout();
            // 
            // genderChart
            // 
            chartArea1.Name = "ChartArea1";
            this.genderChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.genderChart.Legends.Add(legend1);
            this.genderChart.Location = new System.Drawing.Point(12, 231);
            this.genderChart.Name = "genderChart";
            this.genderChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.genderChart.Series.Add(series1);
            this.genderChart.Size = new System.Drawing.Size(601, 396);
            this.genderChart.TabIndex = 0;
            this.genderChart.Text = "chart1";
            // 
            // gender_lb
            // 
            this.gender_lb.AutoSize = true;
            this.gender_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_lb.Location = new System.Drawing.Point(12, 80);
            this.gender_lb.Name = "gender_lb";
            this.gender_lb.Size = new System.Drawing.Size(100, 29);
            this.gender_lb.TabIndex = 1;
            this.gender_lb.Text = "Gender:";
            // 
            // totalStd_lb
            // 
            this.totalStd_lb.AutoSize = true;
            this.totalStd_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStd_lb.Location = new System.Drawing.Point(12, 27);
            this.totalStd_lb.Name = "totalStd_lb";
            this.totalStd_lb.Size = new System.Drawing.Size(162, 29);
            this.totalStd_lb.TabIndex = 2;
            this.totalStd_lb.Text = "Total Student:";
            // 
            // totalStudent_lb
            // 
            this.totalStudent_lb.AutoSize = true;
            this.totalStudent_lb.BackColor = System.Drawing.Color.Aqua;
            this.totalStudent_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalStudent_lb.Location = new System.Drawing.Point(189, 19);
            this.totalStudent_lb.Name = "totalStudent_lb";
            this.totalStudent_lb.Size = new System.Drawing.Size(102, 37);
            this.totalStudent_lb.TabIndex = 3;
            this.totalStudent_lb.Text = "label3";
            // 
            // male_lb
            // 
            this.male_lb.AutoSize = true;
            this.male_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_lb.Location = new System.Drawing.Point(255, 84);
            this.male_lb.Name = "male_lb";
            this.male_lb.Size = new System.Drawing.Size(72, 29);
            this.male_lb.TabIndex = 5;
            this.male_lb.Text = "Male:";
            // 
            // malePercent_lb
            // 
            this.malePercent_lb.AutoSize = true;
            this.malePercent_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malePercent_lb.Location = new System.Drawing.Point(333, 84);
            this.malePercent_lb.Name = "malePercent_lb";
            this.malePercent_lb.Size = new System.Drawing.Size(79, 29);
            this.malePercent_lb.TabIndex = 5;
            this.malePercent_lb.Text = "label4";
            // 
            // female_lb
            // 
            this.female_lb.AutoSize = true;
            this.female_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female_lb.Location = new System.Drawing.Point(255, 159);
            this.female_lb.Name = "female_lb";
            this.female_lb.Size = new System.Drawing.Size(101, 29);
            this.female_lb.TabIndex = 5;
            this.female_lb.Text = "Female:";
            // 
            // femalePercent_lb
            // 
            this.femalePercent_lb.AutoSize = true;
            this.femalePercent_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femalePercent_lb.Location = new System.Drawing.Point(362, 159);
            this.femalePercent_lb.Name = "femalePercent_lb";
            this.femalePercent_lb.Size = new System.Drawing.Size(79, 29);
            this.femalePercent_lb.TabIndex = 5;
            this.femalePercent_lb.Text = "label4";
            // 
            // StaticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 688);
            this.Controls.Add(this.femalePercent_lb);
            this.Controls.Add(this.female_lb);
            this.Controls.Add(this.malePercent_lb);
            this.Controls.Add(this.male_lb);
            this.Controls.Add(this.totalStudent_lb);
            this.Controls.Add(this.totalStd_lb);
            this.Controls.Add(this.gender_lb);
            this.Controls.Add(this.genderChart);
            this.Name = "StaticForm";
            this.Text = "StaticForm";
            this.Load += new System.EventHandler(this.StaticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genderChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart genderChart;
        private System.Windows.Forms.Label gender_lb;
        private System.Windows.Forms.Label totalStd_lb;
        private System.Windows.Forms.Label totalStudent_lb;
        private System.Windows.Forms.Label male_lb;
        private System.Windows.Forms.Label malePercent_lb;
        private System.Windows.Forms.Label female_lb;
        private System.Windows.Forms.Label femalePercent_lb;
    }
}