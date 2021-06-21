using QLSV.Entity;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QLSV.Utility;
using System.IO;

namespace QLSV.AppForm.ContactForm
{
    public partial class EditContactForm : Form
    {
        Contact contact = new Contact();
        Group group = new Group();

        public EditContactForm()
        {
            InitializeComponent();
        }

        private void EditContactForm_Load(object sender, EventArgs e)
        {
            group_cb.DataSource = group.GetAllGroup();
            group_cb.ValueMember = "id";
            group_cb.DisplayMember = "name";
            group_cb.SelectedItem = -1;
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SelectContactForm selectContactForm = new SelectContactForm();
            selectContactForm.ShowDialog();

            int id = selectContactForm.ContactID;

            if (id != 0)
            {
                try
                {
                    DataTable table = contact.GetContactByID(id);

                    textBoxID.Text = id.ToString();
                    textBoxFname.Text = table.Rows[0][1].ToString().Trim();
                    textBoxLname.Text = table.Rows[0][2].ToString().Trim();
                    group_cb.SelectedValue = table.Rows[0][3].ToString().Trim();
                    textBoxPhone.Text = table.Rows[0][4].ToString().Trim();
                    textBoxEmail.Text = table.Rows[0][5].ToString().Trim();
                    textBoxAddress.Text = table.Rows[0][7].ToString().Trim();

                    pictureContact.Image = new Picture().ByteArrToImage((byte[])table.Rows[0][6]);
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message, "Find Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxID.Text.Trim());
            string fname = textBoxFname.Text.Trim();
            string lname = textBoxLname.Text.Trim();
            string _group = group_cb.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string address = textBoxAddress.Text.Trim();
            int user_id = CurrentUser.Id;
            Image picture = pictureContact.Image;

            if (contact.UpdateContact(id, fname, lname, _group, phone, email, address, picture))
            {
                MessageBox.Show("Complete", "Edit complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ClearText();
            }
            else
            {
                MessageBox.Show("Error", "Edit fails", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearText()
        {
            textBoxID.Text = "";
            textBoxFname.Text = "";
            textBoxLname.Text = "";
            textBoxAddress.Text = "";
            textBoxEmail.Text = "";
            textBoxPhone.Text = "";
            group_cb.Text = "";
            pictureContact.Image = null;
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
