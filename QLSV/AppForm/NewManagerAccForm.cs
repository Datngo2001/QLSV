using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.Entity;

namespace QLSV.AppForm
{
    public partial class NewManagerAccForm : Form
    {
        studentManager manager;
        public NewManagerAccForm()
        {
            InitializeComponent();
            manager = new studentManager();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            ConfirmPasswordForm confirmPasswordForm = new ConfirmPasswordForm();
            if(confirmPasswordForm.ShowDialog() == DialogResult.Yes)
            {
                if (password_tb.Text != reEnter_tb.Text)
                {
                    MessageBox.Show("Password not match!");
                    return;
                }
                if(manager.CheckUserName(username_tb.Text) == false)
                {
                    MessageBox.Show("Username existed!");
                    return;
                }

                if(manager.addNewAccount(username_tb.Text, password_tb.Text) == true)
                {
                    MessageBox.Show("Add complete!");
                }
                else
                {
                    MessageBox.Show("Something wrong!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
