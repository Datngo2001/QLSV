using QLSV.Entity;
using QLSV.Utility;
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

namespace QLSV.AppForm.ScoreForm
{
    public partial class AddScoreForm : Form
    {
        Course course;
        Student student;
        Score score;
        DataTable labelTable;
        public AddScoreForm()
        {
            InitializeComponent();
            student = new Student();
            score = new Score();
            course = new Course();
        }
        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand()
            {
                CommandText = "SELECT id, fname, lname FROM Students_info"
            };

            studentInfo_dgv.DataSource = student.getByComand(command);

            labelTable = course.GetAll_ID_label();

            foreach (DataRow row in labelTable.Rows)
            {
                cource_cb.Items.Add(row[1].ToString().Trim());
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if(id_tb.Text != "" && cource_cb.SelectedIndex != -1 
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
    }
}
