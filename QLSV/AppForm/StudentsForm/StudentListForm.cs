using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using QLSV.Data;
using System.IO;
using QLSV.Entity;

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

                SqlCommand command = new SqlCommand("SELECT * FROM Students_info");
                Student student = new Student();
                DataTable table = student.getByComand(command);

                progress.Bar.Value = 50;

                dataGridView1.RowTemplate.Height = 80;

                table = student.StudentsTableNaming(table);

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
    }
}
