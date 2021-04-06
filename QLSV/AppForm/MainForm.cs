using System;
using System.Windows.Forms;
using QLSV.AppForm.StudentsForm;

namespace QLSV.AppForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addStudent_Clicked(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentListForm studentListForm = new StudentListForm();
            studentListForm.Show();
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditDeleteStudentForm editDeleteStudentForm = new EditDeleteStudentForm();
            editDeleteStudentForm.Show();
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticForm staticForm = new StaticForm();
            staticForm.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintForm printForm = new PrintForm();
            printForm.Show();
        }
    }
}
