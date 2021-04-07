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

            Table.Columns[0].ColumnName = "ID";
            Table.Columns[1].ColumnName = "First name";
            Table.Columns[2].ColumnName = "Last name";
            Table.Columns[3].ColumnName = "Birthdate";
            Table.Columns[4].ColumnName = "Gender";
            Table.Columns[5].ColumnName = "Phone";
            Table.Columns[6].ColumnName = "Adress";
            Table.Columns[7].ColumnName = "Picture";

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
            PrintDialog pDlg = new PrintDialog();
            PrintDocument pDoc = new PrintDocument();
            pDoc.DocumentName = "Print Document";
            pDlg.Document = pDoc;
            pDlg.AllowSelection = true;
            pDlg.AllowSomePages = true;
            if (pDlg.ShowDialog() == DialogResult.OK)
            {
                pDoc.Print();
            }
            else
            {
                MessageBox.Show("Đã hủy in");
            }
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
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx|Excel files(.xlsx) |*.xlsx";


            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                if(savefile.FileName.EndsWith("docx") == true)
                {
                    Export_Data_To_Word(dataView_gv, savefile.FileName);
                    MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (savefile.FileName.EndsWith("xlsx") == true)
                {
                    ExportToExcel(dataView_gv, savefile.FileName);
                    MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;

                Document oDoc = new Document();
                oDoc.Application.Visible = true;

                oDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;

                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                Object oMissing = System.Reflection.Missing.Value;
                for (int r = 0; r <= RowCount - 1; r++)
                {
                    oTemp = "";
                    for (int c = 0; c < ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DGV.Rows[r].Cells[c].Value + "\t";
                    }
                    var oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara1.Range.Text = oTemp;
                    oPara1.Range.InsertParagraphAfter();
                    byte[] imgbyte = (byte[])dataView_gv.Rows[r].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    //Image sparePicture = Image.FromStream(ms);
                    Image finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(50, 50)));
                    Clipboard.SetDataObject(finalPic);
                    var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara2.Range.Paste();
                    oPara2.Range.InsertParagraphAfter();
                    oTemp += "\n";
                }
                //save the file
                oDoc.SaveAs2(filename);
            }
        }
        public bool ExportToExcel(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                var excelApp = new Excel.Application();
                // Make the object visible.
                excelApp.Visible = true;

                // Create a new, empty workbook and add it to the collection returned
                // by property Workbooks. The new workbook becomes the active workbook.
                // Add has an optional parameter for specifying a praticular template.
                // Because no argument is sent in this example, Add creates a new workbook.
                excelApp.Workbooks.Add();

                // This example uses a single workSheet. The explicit type casting is
                // removed in a later procedure.
                Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

                workSheet.Cells[1, "A"] = DGV.Columns[0].Name;
                workSheet.Cells[1, "B"] = DGV.Columns[1].Name;
                workSheet.Cells[1, "C"] = DGV.Columns[2].Name;
                workSheet.Cells[1, "D"] = DGV.Columns[3].Name;
                workSheet.Cells[1, "E"] = DGV.Columns[4].Name;
                workSheet.Cells[1, "F"] = DGV.Columns[5].Name;
                workSheet.Cells[1, "G"] = DGV.Columns[6].Name;
                workSheet.Cells[1, "H"] = DGV.Columns[7].Name;

                for (int i = 0; i < DGV.Rows.Count; i++)
                {
                    workSheet.Cells[i + 2, "A"] = DGV.Rows[i].Cells[0].Value;
                    workSheet.Cells[i + 2, "B"] = DGV.Rows[i].Cells[1].Value;
                    workSheet.Cells[i + 2, "C"] = DGV.Rows[i].Cells[2].Value;
                    workSheet.Cells[i + 2, "D"] = DGV.Rows[i].Cells[3].Value;
                    workSheet.Cells[i + 2, "E"] = DGV.Rows[i].Cells[4].Value;
                    workSheet.Cells[i + 2, "F"] = DGV.Rows[i].Cells[5].Value;
                    workSheet.Cells[i + 2, "G"] = DGV.Rows[i].Cells[6].Value;
                }
                workSheet.Columns[1].AutoFit();
                workSheet.Columns[2].AutoFit();
                workSheet.Columns[3].AutoFit();
                workSheet.Columns[4].AutoFit();
                workSheet.Columns[5].AutoFit();
                workSheet.Columns[6].AutoFit();
                workSheet.Columns[7].AutoFit();

                workSheet.SaveAs(filename);

                excelApp.Quit();

                return true;
            }
            return false;
        }
    }
}
