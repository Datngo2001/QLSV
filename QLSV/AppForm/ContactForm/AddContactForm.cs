using QLSV.Entity;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QLSV.AppForm.ContactForm
{
    public partial class AddContactForm : Form
    {
        Contact contact = new Contact();
        Group group = new Group();

        public AddContactForm()
        {
            InitializeComponent();
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            comboBoxGroup.DataSource = group.GetAllGroup();
            comboBoxGroup.ValueMember = "id";
            comboBoxGroup.DisplayMember = "name";
            comboBoxGroup.SelectedItem = 0;
            comboBoxGroup.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string fname = textBoxFname.Text.Trim();
            string lname = textBoxLname.Text.Trim();
            int _group = (int)comboBoxGroup.SelectedValue;
            string phone = textBoxPhone.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string address = textBoxAddress.Text.Trim();
            int user_id = CurrentUser.Id;
            Image pic = pictureContact.Image;

            if (verif())
            {
                if (contact.InsertContact(fname, lname, _group, phone, email, address, pic, user_id))
                {
                    MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ClearText();
                }
                else
                {
                    MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool verif()
        {
            if ((textBoxFname.Text.Trim() == "")
                || (textBoxLname.Text.Trim() == "")
                || (comboBoxGroup.Text.Trim() == "")
                || (textBoxPhone.Text.Trim() == "")
                || (textBoxEmail.Text.Trim() == "")
                || (textBoxAddress.Text.Trim() == "")
                || (pictureContact.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureContact.Image = Image.FromFile(opf.FileName);
                pictureContact.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void ClearText()
        {
            textBoxFname.Text = "";
            textBoxLname.Text = "";
            textBoxAddress.Text = "";
            textBoxEmail.Text = "";
            textBoxPhone.Text = "";
            comboBoxGroup.Text = "";
            pictureContact.Image = null;
        }

    }
}
