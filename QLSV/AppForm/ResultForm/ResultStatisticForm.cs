using QLSV.Entity;
using QLSV.Utility;
using System;
using System.Windows.Forms;

namespace QLSV.AppForm.ResultForm
{
    public partial class ResultStatisticForm : Form
    {
        public ResultStatisticForm()
        {
            InitializeComponent();
        }

        private void ResultStatisticForm_Load(object sender, EventArgs e)
        {
            Course course = new Course();

            // score_ch
            score_ch.Series.RemoveAt(0);
            var data = course.getAvgScoreByCourse();
            if (data.Rows.Count < 1)
            {
                MessageBox.Show("No score infomation!");
                return;
            }
            score_ch.DataSource = data;
            var seri = score_ch.Series.Add("Average Score");
            seri.XValueMember = "label";
            seri.YValueMembers = "AverageGrade";
            seri.IsValueShownAsLabel = true;
            score_ch.Titles.Add("Average Score per Cource Chart");

            //passFail_chart
            Score score = new Score();
            StudentStatistic statistic = new StudentStatistic();
            int total = statistic.totalStudent();
            int pass = score.getPassNumber();
            int fail = score.getFailNumber();

            passFail_chart.Series.RemoveAt(0);
            seri = passFail_chart.Series.Add("Average Score");
            seri.Points.AddXY("Pass", (pass * 100.0) / total);
            seri.Points.AddXY("Fail", (fail * 100.0) / total);
            seri.IsValueShownAsLabel = true;
            seri.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            passFail_chart.Titles.Add("Pass and fail percent");
        }
    }
}
