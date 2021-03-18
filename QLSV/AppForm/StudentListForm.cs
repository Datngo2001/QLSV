using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using QLSV.Data;
using System.IO;

namespace QLSV.AppForm
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
                editDelete.Id_tb.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
                editDelete.FirstName_tb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
                editDelete.LastName_tb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
                editDelete.BirthDay_picker.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
                if (dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() == "M")
                {
                    editDelete.male_rbtn.Checked = true;
                }
                else if (dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() == "F")
                {
                    editDelete.female_rbtn.Checked = true;
                }
                editDelete.Phone_tb.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString().Trim();
                editDelete.Address_rtb.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString().Trim();
                byte[] byteImage = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
                MemoryStream stream = new MemoryStream(byteImage);
                editDelete.pictureBox1.Image = Image.FromStream(stream);
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
    }
}
