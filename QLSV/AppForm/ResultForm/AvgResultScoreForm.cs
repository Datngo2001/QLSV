using System;
using System.Windows.Forms;
using QLSV.Entity;

namespace QLSV.AppForm.ResultForm
{
    public partial class AvgResultScoreForm : Form
    {
        Student student;
        Score score;
        public AvgResultScoreForm()
        {
            InitializeComponent();
            student = new Student();
            score = new Score();
        }

        private void AvgResultScoreForm_Load(object sender, EventArgs e)
        {
            showResult_dgv.DataSource = score.MakeStudentScoreResultTable();
        }

        private void search_btn_Click_1(object sender, EventArgs e)
        {
            var students = student.findIdFname(search_tb.Text);
            showResult_dgv.DataSource = students;

        }

        private void print_btn_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveFile_btn_Click(object sender, EventArgs e)
        {
            Report report = new Report()
            {
                Title = "Student Score Report",
                Table = (System.Data.DataTable)showResult_dgv.DataSource
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
    }
}
