using QLSV.Entity;
using QLSV.Utility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSV.AppForm.ScoreForm
{
    public partial class ManageScoreForm : Form
    {
        Course course;
        Student student;
        Score score;
        DataTable labelTable;
        SqlCommand getAllStudent;
        public ManageScoreForm()
        {
            InitializeComponent();
            student = new Student();
            score = new Score();
            course = new Course();
        }

        private void ManageScoreForm_Load(object sender, System.EventArgs e)
        {
            getAllStudent = new SqlCommand()
            {
                CommandText = "SELECT id, fname, lname FROM Students_info"
            };

            show_dgv.DataSource = student.getByComand(getAllStudent);
            show_dgv.AllowUserToAddRows = false;

            labelTable = course.GetAll_ID_label();

            foreach (DataRow row in labelTable.Rows)
            {
                cource_cb.Items.Add(row[1].ToString().Trim());
            }
        }

        private void add_btn_Click(object sender, System.EventArgs e)
        {
            if (id_tb.Text != "" && cource_cb.SelectedIndex != -1
                && description_tb.Text != "" && score_tb.Text != "")
            {
                score.StudentID = Convert.ToInt32(id_tb.Text);
                score.StudentScore = (float)Convert.ToDouble(score_tb.Text);
                score.Description = description_tb.Text;
                score.CourseID = Convert.ToInt32(labelTable.Rows[cource_cb.SelectedIndex][0].ToString());

                if (score.AddThisScore())
                {
                    MessageBox.Show("Complete!");
                }

                new FormTool().ClearText(this);
            }
            else
            {
                MessageBox.Show("Make sure you fill all gap!");
            }

        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            score.StudentID = Convert.ToInt32(id_tb.Text);
            score.CourseID = Convert.ToInt32(labelTable.Rows[cource_cb.SelectedIndex][0].ToString());
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
            show_dgv.DataSource = score.getAllScore();
        }

        private void showStudent_btn_Click(object sender, EventArgs e)
        {
            show_dgv.DataSource = student.getByComand(getAllStudent);
        }

        private void showScore_btn_Click(object sender, EventArgs e)
        {
            show_dgv.DataSource = score.getAllScore();
        }

        private void avg_btn_Click(object sender, EventArgs e)
        {
            AvarageScore avarageScore = new AvarageScore();
            avarageScore.Show();
        } 
    }
}
