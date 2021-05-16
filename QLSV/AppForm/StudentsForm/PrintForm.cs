using QLSV.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using QLSV.Entity;

namespace QLSV.AppForm.StudentsForm
{
    public partial class PrintForm : Form
    {
        private System.Data.DataTable Table { get; set; }
        public PrintForm()
        {
            InitializeComponent();
        }
        private void PrintForm_Load(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            SqlCommand command = new SqlCommand("SELECT * FROM Students_info", dataBase.Connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            Table = new System.Data.DataTable();
            adapter.Fill(Table);
            Table = new Student().StudentsTableNaming(Table);

            dataView_gv.RowTemplate.Height = 80;
            dataView_gv.RowTemplate.Resizable = DataGridViewTriState.True;
            dataView_gv.DataSource = Table;
            dataView_gv.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataView_gv.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataView_gv.AllowUserToAddRows = false;
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

            //PrintDialog pDlg = new PrintDialog();
            //PrintDocument pDoc = (PrintDocument)report.getWordDocument();
            //pDlg.Document = pDoc;
            //pDlg.AllowSelection = true;
            //pDlg.AllowSomePages = true;
            //if (pDlg.ShowDialog() == DialogResult.OK)
            //{
            //    pDoc.Print();
            //}
            //else
            //{
            //    MessageBox.Show("Đã hủy in");
            //}
        }
        private void check_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase db = new DataBase();
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = db.Connection
                };

                string cmdText = "";

                if (all_rBtn.Checked)
                {
                    cmdText = "Select * From Students_info";
                }
                else if (male_rBtn.Checked)
                {
                    cmdText += "Select * From Students_info Where gender = 'M'";
                }
                else if (female_rBtn.Checked)
                {
                    cmdText += "Select * From Students_info Where gender = 'F'";
                }
                
                if(all_rBtn.Checked == true & yes_rbtn.Checked == true)
                {
                    cmdText += " Where bdate > @date1 and bdate < @date2";
                    cmd.CommandText = cmdText;
                    cmd.Parameters.Add("@date1", SqlDbType.NVarChar).Value = dateEnd1_dtp.Value.ToString();
                    cmd.Parameters.Add("@date2", SqlDbType.NVarChar).Value = dateEnd2_dtp.Value.ToString();
                }
                else if (all_rBtn.Checked == false & yes_rbtn.Checked == true)
                {
                    cmdText += " and bdate > @date1 and bdate < @date2";
                    cmd.CommandText = cmdText;
                    cmd.Parameters.Add("@date1", SqlDbType.NVarChar).Value = dateEnd1_dtp.Value.ToString();
                    cmd.Parameters.Add("@date2", SqlDbType.NVarChar).Value = dateEnd2_dtp.Value.ToString();
                }
                else
                {
                    cmd.CommandText = cmdText;
                }

                db.openConnection();

                Table = new System.Data.DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(Table);
                Table = new Student().StudentsTableNaming(Table);

                db.closeConnection();

                dataView_gv.RowTemplate.Height = 80;
                dataView_gv.RowTemplate.Resizable = DataGridViewTriState.True;
                dataView_gv.DataSource = Table;
                dataView_gv.ReadOnly = true;
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)dataView_gv.Columns[7];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataView_gv.AllowUserToAddRows = false;

                dataView_gv.Refresh();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void yes_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if(yes_rbtn.Checked == true)
            {
                dateEnd1_dtp.Enabled = true;
                dateEnd2_dtp.Enabled = true;
            }
            else
            {
                dateEnd1_dtp.Enabled = false;
                dateEnd2_dtp.Enabled = false;
            }
        }
        private void Sevefile_btn_Click(object sender, EventArgs e)
        {
            Report report = new Report()
            {
                Title = "Student List Report",
                Table = (System.Data.DataTable)dataView_gv.DataSource
            };

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx|Excel files(.xlsx) |*.xlsx";


            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                if(savefile.FileName.EndsWith("docx") == true)
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
    }
}
