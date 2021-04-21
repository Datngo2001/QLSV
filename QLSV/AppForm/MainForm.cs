using System;
using System.Windows.Forms;
using QLSV.AppForm.StudentsForm;
using QLSV.AppForm.CourseForm;
using QLSV.AppForm.ScoreForm;

namespace QLSV.AppForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
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

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentsForm manageStudents = new ManageStudentsForm();
            manageStudents.Show();
        }

        private void aDDCOURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.Show();
        }

        private void eDITCOURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm editCourseForm = new EditCourseForm();
            editCourseForm.Show();
        }

        private void rEMVCECOURSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm removeCourseForm = new RemoveCourseForm();
            removeCourseForm.Show();
        }

        private void aDDSCOREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm AddScoreForm = new AddScoreForm();
            AddScoreForm.Show();
        }

        private void rEMOVESCOREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm removeScoreForm = new RemoveScoreForm();
            removeScoreForm.Show();
        }

        private void mANAGESCOREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm manageScore = new ManageScoreForm();
            manageScore.Show();
        }

        private void mANAGECOURCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm manageCourseForm = new ManageCourseForm();
            manageCourseForm.Show();
        }
    }
}
