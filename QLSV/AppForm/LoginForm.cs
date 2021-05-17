using System;
using System.Windows.Forms;
using QLSV.Entity;

namespace QLSV.AppForm
{
    public partial class LoginForm : Form
    {
        User user;
        public LoginForm()
        {
            InitializeComponent();
            user = new User();
        }
        private void Login_button_Click(object sender, EventArgs e)
        {
            if (student_rbtn.Checked == true)
            {
                var studentmanager = new studentManager();
                if (studentmanager.login(Username_textBox.Text, Password_textBox.Text))
                {
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(human_rbtn.Checked == true)
            {
                if (user.login(Username_textBox.Text, Password_textBox.Text))
                {
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                    username_eprd.SetError(Username_textBox, null);
                }
                else
                {
                    username_eprd.SetError(Username_textBox, "Please enter username!");
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
                    password_eprd.SetError(Password_textBox, null);
                }
                else
                {
                    password_eprd.SetError(Password_textBox, "Please enter password!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void student_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if(student_rbtn.Checked == true)
            {
                register_lb.Visible = false;
            }
            else
            {
                register_lb.Visible = true;
            }
        }
    }
}
