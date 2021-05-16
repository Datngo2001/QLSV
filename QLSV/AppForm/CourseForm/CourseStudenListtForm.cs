using System;
using System.Drawing.Printing;
using System.Windows.Forms;
using QLSV.Entity;

namespace QLSV.AppForm.CourseForm
{
    public partial class CourseStudenListtForm : Form
    {
        public int courseId;
        public string courseLabel;
        public string courseSemester;
        Course course;
        Report report;

        public CourseStudenListtForm()
        {
            InitializeComponent();
        }

        private void CourseStudenListtForm_Load(object sender, EventArgs e)
        {
            course = new Course();

            student_dgv.DataSource = course.studentsInCourse(courseId);

            courseName_lb.Text += courseLabel;
            semester_lb.Text += courseSemester;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Report report = new Report()
            {
                Title = courseLabel,
                Table = (System.Data.DataTable)student_dgv.DataSource
            };

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Report";
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx|Excel files(.xlsx) |*.xlsx";


            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                if (savefile.FileName.EndsWith("docx") == true)
                {
                    report.toWordReport(savefile.FileName);
                    MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (savefile.FileName.EndsWith("xlsx") == true)
                {
                    //ExportToExcel(showResult_dgv, savefile.FileName);
                    MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            print.Document = printDoc;
            print.AllowSelection = true;
            print.AllowSomePages = true;
            if (print.ShowDialog() == DialogResult.OK) printDoc.Print();

        }
    }
}
