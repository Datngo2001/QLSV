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
                "SELECT * FROM Users WHERE UserName = @User AND Password = @Pass", db.Connection);
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

        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void password_ttip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Username_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Username_textBox.Text.Length != 0)
                {
                    errorProvider1.SetError(Username_textBox, null);
                }
                else
                {
                    errorProvider1.SetError(Username_textBox, "Please enter username!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Password_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Password_textBox.Text.Length != 0)
                {
                    errorProvider2.SetError(Password_textBox, null);
                }
                else
                {
                    errorProvider2.SetError(Password_textBox, "Please enter password!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
