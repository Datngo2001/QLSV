using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
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
            PrintDialog print = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            print.Document = printDoc;
            print.AllowSelection = true;
            print.AllowSomePages = true;
            if (print.ShowDialog() == DialogResult.OK) printDoc.Print();
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
                    report.ToExcelReport(savefile.FileName);
                    MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cancel_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            DataTable scoreTable = (DataTable)showResult_dgv.DataSource;
            List<DataRow> dataRows = new List<DataRow>();
            foreach (DataRow row in scoreTable.Rows)
            {
                if (search_tb.Text.Contains(row["Id"].ToString().Trim()) 
                    | search_tb.Text.Contains(row["Firt Name"].ToString().Trim())
                    | search_tb.Text.Contains(row["Last Name"].ToString().Trim()))
                {
                    dataRows.Add(row);
                }
            }
            DataTable resultTable = new DataTable();
            foreach (DataColumn column in scoreTable.Columns)
            {
                resultTable.Columns.Add().ColumnName = column.ColumnName;
            }
            foreach (DataRow row in dataRows)
            {
                resultTable.Rows.Add().ItemArray = row.ItemArray;
            }
            showResult_dgv.DataSource = resultTable;
        }

        private void refresh_llb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showResult_dgv.DataSource = score.MakeStudentScoreResultTable();
        }
    }
}
