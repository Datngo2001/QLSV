﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLSV.Entity;

namespace QLSV.AppForm.CourseForm
{
    public partial class EditCourseForm : Form
    {
        Course course;
        public EditCourseForm()
        {
            InitializeComponent();
            course = new Course();

            List<int> listID = course.GetAllId();

            foreach (int item in listID)
            {
                select_cb.Items.Add(item);
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                course.Id = Convert.ToInt32(select_cb.Text);
                course.Label = label_tb.Text;
                course.Description = description_tb.Text;
                course.Period = Convert.ToInt32(period_ud.Value);
                course.Semester = semester_tb.Text;

                if (course.UpdateThisCourse())
                {
                    MessageBox.Show("Success!");
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
        private void select_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(select_cb.Text);
                course.getByID(id);

                semester_tb.Text = course.Semester;
                label_tb.Text = course.Label;
                period_ud.Value = course.Period;
                description_tb.Text = course.Description;
                semester_tb.Text = course.Semester;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
