using QLSV.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.Utility;

namespace QLSV.AppForm.StudentsForm
{
    public partial class StaticForm : Form
    {
        public StaticForm()
        {
            InitializeComponent();
        }

        private void StaticForm_Load(object sender, EventArgs e)
        {
            StudentStatistic statistic = new StudentStatistic();
            int total = statistic.totalStudent();
            totalStudent_lb.Text = total.ToString();

            int female = statistic.femaleAmount();
            int male = statistic.maleAmount();
            malePercent_lb.Text = ((male * 100.0) / total).ToString() + "%";
            femalePercent_lb.Text = ((female * 100.0) / total).ToString() + "%";

            var seri = genderChart.Series.Add("genderAmount");
            seri.IsValueShownAsLabel = true;
            seri.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            seri.Points.AddXY("Male", (male * 100.0) / total);
            seri.Points.AddXY("Female", (female * 100.0) / total);
            genderChart.Titles.Add("Gender Chart");
            genderChart.Series.RemoveAt(0);
        }
    }
}
