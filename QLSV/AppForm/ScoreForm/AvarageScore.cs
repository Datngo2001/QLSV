using System.Windows.Forms;
using QLSV.Entity;

namespace QLSV.AppForm.ScoreForm
{
    public partial class AvarageScore : Form
    {
        public AvarageScore()
        {
            InitializeComponent();
        }
        private void AvarageScore_Load(object sender, System.EventArgs e)
        {
            Course course = new Course();
            score_ch.Series.RemoveAt(0);
            var data = course.getAvgScoreByCourse();
            if (data.Rows.Count < 1)
            {
                MessageBox.Show("No score infomation!");
                return;
            }
            score_ch.DataSource = data;
            score_ch.Series.Add("Average Score");
            score_ch.Series["Average Score"].XValueMember = "label";
            score_ch.Series["Average Score"].YValueMembers = "AverageGrade";
            score_ch.Series["Average Score"].IsValueShownAsLabel = true;
            score_ch.Titles.Add("Average Score per Cource Chart");

        }
    }
}
