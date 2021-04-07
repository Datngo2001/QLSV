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
            Statistic statistic = new Statistic();
            int total = statistic.totalStudent();
            totalStudent_lb.Text = total.ToString();
            DataSet genderData = statistic.femaleMaleAmount();
            genderChart.DataSource = genderData;

            genderChart.Series.Add("genderAmount");
            genderChart.Series["genderAmount"].XValueMember = "gender";
            genderChart.Series["genderAmount"].YValueMembers = "amount";
            genderChart.Titles.Add("Gender Chart");
            genderChart.Series.RemoveAt(0);

            int female = statistic.femaleAmount();
            int male = statistic.maleAmount();
            malePercent_lb.Text = ((male * 100.0) / total).ToString() + "%";
            femalePercent_lb.Text = ((female * 100.0) / total).ToString() + "%";
        }
    }
}
