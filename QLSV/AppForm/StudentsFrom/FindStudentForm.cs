﻿using QLSV.Data;
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
                var searchCenter = new QLSV.Utility.SearchCenter();

                DataTable table = new DataTable();
                table = searchCenter.findByHint(hint);

                table.Columns[0].ColumnName = "ID";
                table.Columns[1].ColumnName = "First name";
                table.Columns[2].ColumnName = "Last name";
                table.Columns[3].ColumnName = "Birthdate";
                table.Columns[4].ColumnName = "Gender";
                table.Columns[5].ColumnName = "Phone";
                table.Columns[6].ColumnName = "Adress";
                table.Columns[7].ColumnName = "Picture";

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
