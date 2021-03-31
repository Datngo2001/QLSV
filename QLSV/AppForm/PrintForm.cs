using QLSV.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.AppForm
{
    public partial class PrintForm : Form
    {
        private DataTable Table { get; set; }
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
            Table = new DataTable();
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

        private void Sevefile_btn_Click(object sender, EventArgs e)
        {

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void no_rbtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
