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
            loadProfile();

            this.ReloadComboBox();
            group_cb.SelectedIndex = -1;
            remove_cb.SelectedIndex = -1;
        }

        private void ReloadComboBox()
        {
            group_cb.DataSource = group.GetAllGroup();
            group_cb.ValueMember = "id";
            group_cb.DisplayMember = "name";
            group_cb.SelectedItem = 0;

            remove_cb.DataSource = group.GetAllGroup();
            remove_cb.ValueMember = "id";
            remove_cb.DisplayMember = "name";
            remove_cb.SelectedItem = 0;

            group_cb.Text = "";
            remove_cb.Text = "";
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

                if (!(group.CheckGroupExist(name)))
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
                int idx = group_cb.SelectedIndex;
                int id = Convert.ToInt32(group.GetAllGroup().Rows[idx][0]);
                string name = textBoxNewName.Text.Trim();
                int user_id = CurrentUser.Id;

                if (!(group.CheckGroupExist(name)))
                {
                    if (group.UpdateGroup(id, name, user_id))
                    {
                        MessageBox.Show("Edit Successfully", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxNewName.Text = "";
                        group_cb.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("You are not the owner of this group!", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Error!", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                int idx = remove_cb.SelectedIndex;
                if (idx < 0) return;
                int id = Convert.ToInt32(group.GetAllGroup().Rows[idx][0]);
                int user_id = CurrentUser.Id;

                if (group.DeleteGroup(id, user_id))
                {
                    MessageBox.Show("Remove Successfully", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    remove_cb.Text = "";
                }
                else
                {
                    MessageBox.Show("You are not the owner of this group!", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            EditProfileForm editProfileForm = new EditProfileForm();
            editProfileForm.ShowDialog();
            try
            {
                labelName.Text = editProfileForm.fname_tb.Text + editProfileForm.lname_tb.Text;
                pictureBoxContact.Image = editProfileForm.pictureBox.Image;
            }
            catch (Exception)
            {
                return;
            }
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
            group_cb.Text = "";
            remove_cb.Text = "";
            try
            {
                loadProfile();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void logout_llb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentUser.Avatar = null;
            CurrentUser.fname = "";
            CurrentUser.lname = "";
            CurrentUser.Id = 0;
            CurrentUser.UserName = "";
            CurrentUser.isAdmin = false;
            Program.logout();
        }
        private void loadProfile()
        {
            int id = CurrentUser.Id;

            labelWelcome.Text = "Welcome Back (" +
                                    CurrentUser.UserName +
                                    ")";
            labelName.Text = CurrentUser.fname + CurrentUser.lname;
            pictureBoxContact.Image = CurrentUser.Avatar;
        }
    }
}
