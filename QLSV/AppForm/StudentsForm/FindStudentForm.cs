using QLSV.Data;
using QLSV.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSV.AppForm.StudentsForm
{
    public partial class FindStudentForm : Form
    {
        public FindStudentForm()
        {
            InitializeComponent();
        }
        private void FindStudentForm_Load(object sender, EventArgs e)
        {
            findStudentsByHint(searchInput_tb.Text);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            findStudentsByHint(searchInput_tb.Text);
        }

        public void findStudentsByHint(string hint)
        {
            try
            {
                Student student = new Student();
                DataTable table = student.findByHint(hint);
                table = student.StudentsTableNaming(table);

                dataGridView1.RowTemplate.Height = 80;
                dataGridView1.DataSource = table;
                dataGridView1.ReadOnly = true;
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[7];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
