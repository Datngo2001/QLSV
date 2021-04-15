using QLSV.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.AppForm.ScoreForm
{
    public partial class RemoveScoreForm : Form
    {
        Score score;
        public RemoveScoreForm()
        {
            InitializeComponent();
            score = new Score();
        }

        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            loadScore();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            score.StudentID = Convert.ToInt32(score_dgv.CurrentRow.Cells[0].Value);
            score.CourseID = Convert.ToInt32(score_dgv.CurrentRow.Cells[1].Value);
            if (score.RemoveThisScore())
            {
                MessageBox.Show("Complete!");
                this.loadScore();
            }
            else
            {
                MessageBox.Show("ERROR!");
            }
        }
        private void loadScore()
        {
            score_dgv.DataSource = score.getAllScore();
        }
    }
}
