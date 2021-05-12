using System;
using System.Drawing;
using System.Windows.Forms;
using QLSV.Entity;

namespace QLSV.AppForm
{
    public partial class RegisterForm : Form
    {
        User user;
        public RegisterForm()
        {
            InitializeComponent();
            user = new User();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            if(password_tb.Text == reEnter_tb.Text)
            {
                if(user.CheckUserName(username_tb.Text) == true)
                {
                    if(user.signin(username_tb.Text, password_tb.Text, id_tb.Text, fname_tb.Text, lname_tb.Text, pictureBox.Image) == true)
                    {
                        MessageBox.Show("Complete!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Username is existed!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Password is not match!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            string filepath = null;
            OpenFileDialog ofdImages = new OpenFileDialog();
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                filepath = ofdImages.FileName;
            }
            pictureBox.Image = Image.FromFile(filepath.ToString());
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
