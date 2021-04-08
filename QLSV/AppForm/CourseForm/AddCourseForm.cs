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
                Course course = new Course()
                {
                    Id = Convert.ToInt32(id_tb.Text),
                    Label = label_tb.Text,
                    Period = Convert.ToInt32(period_tb.Text),
                    Description = description_tb.Text
                };
                if (course.AddCourse())
                {
                    MessageBox.Show("Succses!");
                }
                else
                {
                    MessageBox.Show("Failse!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
