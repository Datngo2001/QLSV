using System;
using System.Windows.Forms;
using QLSV.Entity;

namespace QLSV.AppForm.CourseForm
{
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Course course = new Course();
                int id = Convert.ToInt32(id_tb.Text);
                string label = label_tb.Text;
                int period = (int)period_ud.Value;
                string description = description_tb.Text;
                string semester = comboBoxSemester.Text;

                if (period < 1 || period > 24)
                {
                    MessageBox.Show("The course period must be between 1 and 24 hours", "Invalid course period", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (comboBoxSemester.Text == "")
                {
                    MessageBox.Show("Invalid Semester", "Invalid course period", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (label.Trim() == "")
                {
                    MessageBox.Show("Add a course name", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (course.CheckCourseName(label, id))
                {
                    if (course.InsertCourse(id, label, period, description, semester))
                    {
                        MessageBox.Show("New course inserted", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Course not inserted", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("This course name already exists", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            int year = 2019;
            for (int i = 0; i < 10; i++)
            {
                comboBoxSemester.Items.Add($"{year}-{year + 1}");
                year += 1;
            }
        }
    }
}
