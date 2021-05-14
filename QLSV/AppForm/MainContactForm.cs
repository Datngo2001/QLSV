using System;
using System.Windows.Forms;
using QLSV.Entity;
using QLSV.AppForm.ContactForm;
using QLSV.Utility;

namespace QLSV.AppForm
{
    public partial class MainContactForm : Form
    {
        Contact contact = new Contact();
        User user = new User();
        Group group = new Group();
        public MainContactForm()
        {
            InitializeComponent();
        }

        private void MainContactForm_Load(object sender, EventArgs e)
        {
            int id = CurrentUser.Id;

            labelWelcome.Text = "Welcome Back (" +
                                    user.GetUserByID(id).Rows[0]["username"].ToString().Trim() +
                                    ")";
            labelName.Text = user.GetUserFullNameByID(id);

            //if (user.GetUserByID(id).Rows[0]["pic"] != System.DBNull.Value)
            //    pictureBoxContact.Image = new Picture().ByteArrToImage((byte[])user.GetUserByID(id).Rows[0]["pic"]);

            pictureBoxContact.Image = CurrentUser.Avatar;

            this.ReloadComboBox();
            comboBoxSelected.SelectedIndex = -1;
            comboBoxSelected2.SelectedIndex = -1;
        }

        private void ReloadComboBox()
        {
            comboBoxSelected.DataSource = group.GetAllGroup();
            comboBoxSelected.ValueMember = "id";
            comboBoxSelected.DisplayMember = "name";
            comboBoxSelected.SelectedItem = 0;

            comboBoxSelected2.DataSource = group.GetAllGroup();
            comboBoxSelected2.ValueMember = "id";
            comboBoxSelected2.DisplayMember = "name";
            comboBoxSelected2.SelectedItem = 0;

            comboBoxSelected.Text = "";
            comboBoxSelected2.Text = "";
        }

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm();
            addContactForm.ShowDialog();
        }

        private void buttonEditContact_Click(object sender, EventArgs e)
        {
            EditContactForm editContactForm = new EditContactForm();
            editContactForm.ShowDialog();
        }

        private void buttonSelectContact_Click(object sender, EventArgs e)
        {
            SelectContactForm selectContactForm = new SelectContactForm();
            selectContactForm.ShowDialog();
            textBoxContactID.Text = selectContactForm.ContactID.ToString();
        }

        private void buttonRemoveContact_Click(object sender, EventArgs e)
        {
            if (textBoxContactID.Text.Trim() == "")
            {
                MessageBox.Show("Empty Field", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = Convert.ToInt32(textBoxContactID.Text.Trim());

                if (contact.DeleteContact(id))
                {
                    MessageBox.Show("Delete Successfully", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxContactID.Text = "";
                }
                else
                {
                    MessageBox.Show("Not Found Contact", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void buttonShowList_Click(object sender, EventArgs e)
        {
            ShowFullContactForm showFullContactForm = new ShowFullContactForm();
            showFullContactForm.ShowDialog();
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxGroupName.Text;
                int user_id = CurrentUser.Id;

                if (!(group.CheckGroupExist(name, "add")))
                {
                    if (group.InsertGroup(name, user_id))
                    {
                        MessageBox.Show("Insert Successfully", "Insert Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxGroupName.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error", "Insert Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Group Already Exists", "Insert Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                refresh();
            }
            catch
            {
                MessageBox.Show("Empty Field", "Insert Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw;
            }
        }

        private void buttonEditGroup_Click(object sender, EventArgs e)
        {
            try
            {
                int idx = comboBoxSelected.SelectedIndex;
                int id = Convert.ToInt32(group.GetAllGroup().Rows[idx][0]);
                string name = textBoxNewName.Text.Trim();
                int user_id = CurrentUser.Id;

                if (!(group.CheckGroupExist(name, "edit")))
                {
                    if (group.UpdateGroup(id, name, user_id))
                    {
                        MessageBox.Show("Edit Successfully", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxNewName.Text = "";
                        comboBoxSelected.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Group Already Exists", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                refresh();
            }
            catch
            {
                MessageBox.Show("Empty Field", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw;
            }
        }

        private void buttonRemoveGroup_Click(object sender, EventArgs e)
        {
            try
            {
                int idx = comboBoxSelected2.SelectedIndex;
                if (idx < 0) return;
                int id = Convert.ToInt32(group.GetAllGroup().Rows[idx][0]);
                int user_id = CurrentUser.Id;

                if (group.DeleteGroup(id, user_id))
                {
                    MessageBox.Show("Remove Successfully", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxSelected2.Text = "";
                }
                else
                {
                    MessageBox.Show("Error", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                refresh();
            }
            catch
            {
                MessageBox.Show("Empty Field", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw;
            }
        }

        private void linkLabelEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabelRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            this.ReloadComboBox();
            textBoxContactID.Text = "";
            textBoxGroupName.Text = "";
            textBoxNewName.Text = "";
            comboBoxSelected.Text = "";
            comboBoxSelected2.Text = "";
        }
    }
}
