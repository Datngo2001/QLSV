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
            show_dgv.DataSource = course.getAvgScoreByCourse();
        }
    }
}
