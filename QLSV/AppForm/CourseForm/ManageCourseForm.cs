using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QLSV.Entity;

namespace QLSV.AppForm.CourseForm
{
    public partial class ManageCourseForm : Form
    {
        Course course = new Course();
        int index = 0;

        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            ReloadListBoxData();
            semester_cb.Items.Add("1");
            semester_cb.Items.Add("2");
            semester_cb.Items.Add("3");

            course_lstb.SelectedIndexChanged += new System.EventHandler(this.listBoxCourse_SelectedIndexChanged);
            course_lstb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.course_lstb_MouseDoubleClick);

            ShowData(course_lstb.SelectedIndex);
        }

        void ReloadListBoxData()
        {
            course_lstb.DataSource = course.GetAllCourses();
            course_lstb.ValueMember = "id";
            course_lstb.DisplayMember = "label";
            course_lstb.SelectedItem = 0;
            totalCourse_lb.Text = ("Total Course: " + course.TotalCourse());
        }

        void ShowData(int idx)
        {
            DataRow dataRow;
            try
            {
                dataRow = course.GetAllCourses().Rows[idx];
            }
            catch (Exception)
            {
                return;
            }
            course_lstb.SelectedIndex = idx;
            id_tb.Text = dataRow["Id"].ToString().Trim();
            label_tb.Text = dataRow["label"].ToString().Trim();
            period_ud.Value = int.Parse(dataRow.ItemArray[2].ToString());
            description_rtb.Text = dataRow.ItemArray[3].ToString().Trim();
            semester_cb.Text = dataRow["semester"].ToString().Trim();
        }

        private void listBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView dataRowView = (DataRowView)course_lstb.SelectedItem;
            index = course_lstb.SelectedIndex;
            ShowData(index);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.ShowDialog();
            ReloadListBoxData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(id_tb.Text);
            string label = label_tb.Text;
            int hour = (int)period_ud.Value;
            string description = description_rtb.Text;
            string semester = semester_cb.Text; 

            if (course.UpdateCourse(id, label, hour, description, semester))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(id_tb.Text);

                if ((MessageBox.Show("Are you sure to delete course?", "Remove course", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    if (course.RemoveCourse(id))
                    {
                        id_tb.Text = "";
                        label_tb.Text = "";
                        description_rtb.Text = "";
                        period_ud.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Course not deleted", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Valid ID", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            index = 0;
            ReloadListBoxData();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            index = 0;
            ShowData(index);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (index < course.GetAllCourses().Rows.Count - 1)
            {
                index += 1;
                ShowData(index);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index -= 1;
                ShowData(index);
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            index = course.GetAllCourses().Rows.Count - 1;
            ShowData(index);
        }
        private void course_lstb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CourseStudenListtForm courseStudenListt = new CourseStudenListtForm();
            courseStudenListt.courseId = Convert.ToInt32(id_tb.Text.Trim());
            courseStudenListt.courseLabel = label_tb.Text;
            courseStudenListt.courseSemester = semester_cb.Text;
            courseStudenListt.Show();
        }
    }
}
