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

namespace QLSV.AppForm.StudentsForm
{
    public partial class AddStudentToCoursesForm : Form
    {
        public string currId;
        Course course;
        Student student;
        Stack<int> selectedCourceAdded;

        public AddStudentToCoursesForm()
        {
            InitializeComponent();
        }
        private void AddCourseToStudent_Load(object sender, EventArgs e)
        {
            course = new Course();
            student = new Student();
            selectedCourceAdded = new Stack<int>();

            for (int i = 0; i < student.GetAllStudent().Rows.Count; i++)
            {
                id_cb.Items.Add(student.GetAllStudent().Rows[i].ItemArray[0]);
            }

            LoadComboBox();

            id_cb.Text = currId;

            comboBoxSemester.Items.Add("1");
            comboBoxSemester.Items.Add("2");
            comboBoxSemester.Items.Add("3");
            comboBoxSemester.SelectedIndex = 0;

            LoadListBox();

            comboBoxSemester.SelectedIndexChanged += new System.EventHandler(this.comboBoxSemester_SelectedIndexChanged);
            id_cb.SelectedIndexChanged += new System.EventHandler(this.id_cb_SelectedIndexChanged);
        }
        private void LoadComboBox()
        {
            id_cb.DataSource = student.getAllBriefInfo();
            id_cb.DisplayMember = "ID";
            id_cb.ValueMember = "ID";
        }
        private void LoadListBox()
        {
            selectedCourse_lstb.Items.Clear();
            if (id_cb.Text.Length == 0) return;
            var source = student.GetSelectedCourses(Convert.ToInt32(id_cb.Text.Trim()));
            foreach (DataRow row in source.Rows)
            {
                selectedCourse_lstb.Items.Add(row["label"]);
            }

            availableCourse_lstb.Items.Clear();
            source = course.GetCourseBySemester(comboBoxSemester.Text.Trim());
            foreach (DataRow row in source.Rows)
            {
                availableCourse_lstb.Items.Add(row["label"]);
            }
            for (int i = 0; i < availableCourse_lstb.Items.Count; i++)
            {
                if (selectedCourse_lstb.Items.Contains(availableCourse_lstb.Items[i]))
                {
                    availableCourse_lstb.Items.Remove(availableCourse_lstb.Items[i]);
                }
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (availableCourse_lstb.SelectedItem == null) return;
            int index = selectedCourse_lstb.Items.Add(availableCourse_lstb.SelectedItem);
            selectedCourceAdded.Push(index);
            availableCourse_lstb.Items.Remove(availableCourse_lstb.SelectedItem);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            while (selectedCourceAdded.Count > 0)
            {
                string label = selectedCourse_lstb.GetItemText(selectedCourse_lstb.Items[selectedCourceAdded.Pop()]);
                int id = course.GetIdByLabel(label);
                student.InsertSelectedCourse(id_cb.GetItemText(id_cb.SelectedItem), id);
            }
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            foreach (var item in availableCourse_lstb.Items)
            {
                int index = selectedCourse_lstb.Items.Add(item);
                selectedCourceAdded.Push(index);
            }
            availableCourse_lstb.Items.Clear();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            if (selectedCourceAdded.Count == 0) return;
            int index = selectedCourceAdded.Pop();
            availableCourse_lstb.Items.Add(selectedCourse_lstb.Items[index]);
            selectedCourse_lstb.Items.RemoveAt(index);
        }

        private void removeAll_btn_Click(object sender, EventArgs e)
        {
            while(selectedCourceAdded.Count > 0)
            {
                int index = selectedCourceAdded.Pop();
                availableCourse_lstb.Items.Add(selectedCourse_lstb.Items[index]);
                selectedCourse_lstb.Items.RemoveAt(index);
            }
        }

        private void comboBoxSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListBox();
        }

        private void id_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListBox();
        }

    }
}
