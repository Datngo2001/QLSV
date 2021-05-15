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
                string label = label_tb.Text;
                int period = (int)period_ud.Value;
                string description = description_tb.Text;
                string semester = comboBoxSemester.Text;

                if (period < 10 || period > 15)
                {
                    MessageBox.Show("The course period must be between 10 and 15 week", "Invalid course period", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (comboBoxSemester.Text == "")
                {
                    MessageBox.Show("Invalid Semester", "Invalid course period", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (label.Trim() == "")
                {
                    MessageBox.Show("Add a course name", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (course.CheckCourseName(label))
                {
                    if (course.InsertCourse(label, period, description, semester))
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
            comboBoxSemester.Items.Add("1");
            comboBoxSemester.Items.Add("2");
            comboBoxSemester.Items.Add("3");
        }
    }
}
