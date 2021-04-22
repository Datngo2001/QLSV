﻿using System;
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
        }

        void ReloadListBoxData()
        {
            listBoxCourse.DataSource = course.GetAllCourses();
            listBoxCourse.ValueMember = "id";
            listBoxCourse.DisplayMember = "label";
            listBoxCourse.SelectedItem = 0;
            labelTotalCourse.Text = ("Total Course: " + course.TotalCourse());
        }

        void ShowData(int idx)
        {
            DataRow dataRow = course.GetAllCourses().Rows[idx];
            listBoxCourse.SelectedIndex = idx;
            textBoxID.Text = dataRow.ItemArray[0].ToString();
            textBoxLabel.Text = dataRow.ItemArray[1].ToString();
            numericUpDown1.Value = int.Parse(dataRow.ItemArray[2].ToString());
            textBoxDescription.Text = dataRow.ItemArray[3].ToString();
        }

        private void listBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView dataRowView = (DataRowView)listBoxCourse.SelectedItem;
            index = listBoxCourse.SelectedIndex;
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
            int id = Convert.ToInt32(textBoxID.Text);
            string label = textBoxLabel.Text;
            int hour = (int)numericUpDown1.Value;
            string description = textBoxDescription.Text;

            if (course.UpdateCourse(id, label, hour, description))
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
                int id = Convert.ToInt32(textBoxID.Text);

                if ((MessageBox.Show("Are you sure to delete course?", "Remove course", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    if (course.DeleteCourse(id))
                    {
                        textBoxID.Text = "";
                        textBoxLabel.Text = "";
                        textBoxDescription.Text = "";
                        numericUpDown1.Value = 0;
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
    }
}