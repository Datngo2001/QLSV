
namespace QLSV.AppForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.genderChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalStudent_lb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.male_lb = new System.Windows.Forms.Label();
            this.malePercent_lb = new System.Windows.Forms.Label();
            this.female_lb = new System.Windows.Forms.Label();
            this.femalePercent_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.genderChart)).BeginInit();
            this.SuspendLayout();
            // 
            // genderChart
            // 
            chartArea2.Name = "ChartArea1";
            this.genderChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.genderChart.Legends.Add(legend2);
            this.genderChart.Location = new System.Drawing.Point(17, 133);
            this.genderChart.Name = "genderChart";
            this.genderChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.genderChart.Series.Add(series2);
            this.genderChart.Size = new System.Drawing.Size(601, 396);
            this.genderChart.TabIndex = 0;
            this.genderChart.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Student:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 646);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngô Minh Đạt 19110115";
            // 
            // male_lb
            // 
            this.male_lb.AutoSize = true;
            this.male_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_lb.Location = new System.Drawing.Point(210, 80);
            this.male_lb.Name = "male_lb";
            this.male_lb.Size = new System.Drawing.Size(72, 29);
            this.male_lb.TabIndex = 5;
            this.male_lb.Text = "Male:";
            // 
            // malePercent_lb
            // 
            this.malePercent_lb.AutoSize = true;
            this.malePercent_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malePercent_lb.Location = new System.Drawing.Point(288, 80);
            this.malePercent_lb.Name = "malePercent_lb";
            this.malePercent_lb.Size = new System.Drawing.Size(79, 29);
            this.malePercent_lb.TabIndex = 5;
            this.malePercent_lb.Text = "label4";
            // 
            // female_lb
            // 
            this.female_lb.AutoSize = true;
            this.female_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female_lb.Location = new System.Drawing.Point(401, 80);
            this.female_lb.Name = "female_lb";
            this.female_lb.Size = new System.Drawing.Size(101, 29);
            this.female_lb.TabIndex = 5;
            this.female_lb.Text = "Female:";
            // 
            // femalePercent_lb
            // 
            this.femalePercent_lb.AutoSize = true;
            this.femalePercent_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femalePercent_lb.Location = new System.Drawing.Point(508, 80);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalStudent_lb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalStudent_lb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label male_lb;
        private System.Windows.Forms.Label malePercent_lb;
        private System.Windows.Forms.Label female_lb;
        private System.Windows.Forms.Label femalePercent_lb;
    }
}