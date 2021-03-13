using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLSV.Data;

namespace QLSV.AppForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void Login_button_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            db.openConnection();
            SqlCommand cm = new SqlCommand(
                "SELECT * FROM Students WHERE UserName = @User AND Password = @Pass", db.Connection);
            cm.Parameters.Add("@User", SqlDbType.VarChar).Value = Username_textBox.Text;
            cm.Parameters.Add("@Pass", SqlDbType.VarChar).Value = Password_textBox.Text;
            adapter.SelectCommand = cm;
            adapter.Fill(table);
            db.closeConnection();
            if (table.Rows.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
