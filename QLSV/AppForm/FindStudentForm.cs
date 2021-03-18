using QLSV.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.AppForm
{
    public partial class FindStudentForm : Form
    {
        public FindStudentForm()
        {
            InitializeComponent();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            findByHint(searchInput_tb.Text);
        }

        private void findByHint(string hint)
        {
            try
            {
                

                DataBase dataBase = new DataBase();
                SqlCommand command = new SqlCommand(
                    "SELECT * FROM Students_info WHERE CONCAT(fname, lname, address) LIKE '%@input%'"
                    , dataBase.Connection);
                command.Parameters.Add("@input", SqlDbType.NVarChar).Value = hint;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
