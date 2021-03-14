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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase db = new DataBase();

                SqlCommand insertCommand = new SqlCommand(
                    "INSERT INTO Users " +
                        "UserName," +
                        "Password " +
                    "VALUES" +
                        "UserName = @username, " +
                        "Password = @password"
                    , db.Connection);

                SqlCommand checkCommand = new SqlCommand(
                    "SELECT * FROM Users " +
                    "WHERE UserName = @username"
                    , db.Connection);
                checkCommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = username_lb.Text;

                db.openConnection();

                if (checkCommand.ExecuteNonQuery() < 1)
                {
                    if (password_tb.Text == reEnter_tb.Text)
                    {
                        insertCommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = username_lb.Text;
                        insertCommand.Parameters.Add("@password", SqlDbType.NVarChar).Value = password_lb.Text;
                        if (insertCommand.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Register complete", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your password is not unified", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Your username has been used", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                db.closeConnection();

            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
                throw;
            }
        }
    }
}
