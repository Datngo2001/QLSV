using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using QLSV.Data;
using System.IO;

namespace QLSV.AppForm.StudentsForm
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            OpenEdit();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            ShowList();
        }

        private bool ShowList()
        {
            try
            {
                ProgressDialog progress = new ProgressDialog();
                progress.Show();

                DataBase dataBase = new DataBase();
                dataBase.openConnection();
                SqlCommand command = new SqlCommand("SELECT * FROM Students_info", dataBase.Connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Students_info");
                dataBase.closeConnection();

                progress.Bar.Value = 50;

                dataGridView1.RowTemplate.Height = 80;
                DataTable table = dataSet.Tables["Students_info"];

                table.Columns[0].ColumnName = "ID";
                table.Columns[1].ColumnName = "First name";
                table.Columns[2].ColumnName = "Last name";
                table.Columns[3].ColumnName = "Birthdate";
                table.Columns[4].ColumnName = "Gender";
                table.Columns[5].ColumnName = "Phone";
                table.Columns[6].ColumnName = "Adress";
                table.Columns[7].ColumnName = "Picture";

                dataGridView1.DataSource = table;
                dataGridView1.ReadOnly = true;
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[7];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridView1.AllowUserToAddRows = false;

                progress.Bar.Value = 50;

                progress.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
                throw;
            }
        }
        private bool OpenEdit()
        {
            try
            {
                EditDeleteStudentForm editDelete = new EditDeleteStudentForm();
                editDelete.InputStudent(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim()));
                editDelete.Show();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
                throw;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
