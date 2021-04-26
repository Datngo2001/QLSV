using System.Windows.Forms;
using QLSV.Entity;

namespace QLSV.AppForm.ScoreForm
{
    public partial class AvarageScore : Form
    {
        public AvarageScore()
        {
            InitializeComponent();
            Course course = new Course();
            score_ch.Series.RemoveAt(0);
            score_ch.DataSource = course.getAvgScoreByCourse();
            score_ch.Series.Add("Average Score");
            score_ch.Series["Average Score"].XValueMember = "label";
            score_ch.Series["Average Score"].YValueMembers = "AverageGrade";
            score_ch.Titles.Add("Average Score per Cource Chart");
        }
    }
}
