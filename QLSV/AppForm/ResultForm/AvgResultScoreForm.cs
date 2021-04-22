using System;
using System.Windows.Forms;
using QLSV.Entity;

namespace QLSV.AppForm.ResultForm
{
    public partial class AvgResultScoreForm : Form
    {
        Student student;
        Score score;
        public AvgResultScoreForm()
        {
            InitializeComponent();
            student = new Student();
            score = new Score();
        }

        private void AvgResultScoreForm_Load(object sender, EventArgs e)
        {
            showResult_dgv.DataSource = score.MakeStudentScoreResultTable();
        }

        private void search_btn_Click_1(object sender, EventArgs e)
        {
            var students = student.findByHint(search_tb.Text);
            showResult_dgv.DataSource = students;

        }
    }
}
