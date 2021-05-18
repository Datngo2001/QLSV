 using System;
using System.Drawing;
using System.Windows.Forms;
using QLSV.Entity;

namespace QLSV.AppForm
{
    public partial class EditProfileForm : Form
    {
        User user;
        public EditProfileForm()
        {
            InitializeComponent();
            user = new User();
        }

        private void saveChange_btn_Click(object sender, EventArgs e)
        {
            if(username_tb.Text == ""){
                MessageBox.Show("Username can not empty complete!");
                return;
            }
            if(password_tb.Text == "")
            {
                if (user.editProfile(CurrentUser.Id, fname_tb.Text, lname_tb.Text, pictureBox.Image))
                {
                    MessageBox.Show("Edit complete!");
                }
                else
                {
                    MessageBox.Show("Something wrong!");
                    return;
                }
                return;
            }
            if (password_tb.Text == reEnter_tb.Text)
            {
                if (user.editProfile(CurrentUser.Id, password_tb.Text, fname_tb.Text, lname_tb.Text, pictureBox.Image))
                {
                    MessageBox.Show("Edit complete!");
                }
                else
                {
                    MessageBox.Show("Something wrong!");
                    return;
                }
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void EditProfileForm_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            ConfirmPasswordForm confirmPasswordForm = new ConfirmPasswordForm();
            confirmPasswordForm.ShowDialog();
            if(confirmPasswordForm.DialogResult == DialogResult.Yes)
            {
                this.Visible = true;
                username_tb.Text = CurrentUser.UserName;
                fname_tb.Text = CurrentUser.fname;
                lname_tb.Text = CurrentUser.lname;
                pictureBox.Image = CurrentUser.Avatar;
            }
            else
            {
                this.Close();
            }
        }
    }
}
