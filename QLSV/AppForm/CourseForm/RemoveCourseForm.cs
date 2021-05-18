using System;
using System.Windows.Forms;
using QLSV.Entity;

namespace QLSV.AppForm.CourseForm
{
    public partial class RemoveCourseForm : Form
    {
        Course course;
        public RemoveCourseForm()
        {
            InitializeComponent();
            course = new Course();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            if (idSearch_tb.Text == "") return;
            try
            {
                course.Id = Convert.ToInt32(idSearch_tb.Text);

                DialogResult delete = MessageBox.Show("Are you really want to delete student with id: " + course.Id, "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                {
                    if (course.RemoveThisCourse())
                    {
                        MessageBox.Show("Success!");
                    }
                    else
                    {
                        MessageBox.Show("Failse!");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void idSearch_tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (idSearch_tb.Text != "")
                {
                    try
                    {
                        course.getByID(Convert.ToInt32(idSearch_tb.Text));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Not Found!");
                        return;
                    }
                    id_tb.Text = course.Id.ToString();
                    label_tb.Text = course.Label;
                    period_tb.Text = course.Period.ToString();
                    description_tb.Text = course.Description;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
