﻿using QLSV.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.AppForm.ContactForm
{
    public partial class ShowFullContactForm : Form
    {
        Contact contact = new Contact();
        Group group = new Group();

        public ShowFullContactForm()
        {
            InitializeComponent();
        }

        private void ShowFullContactForm_Load(object sender, EventArgs e)
        {
            ShowAllGroup();
        }

        private void linkLabelGroup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowAllGroup();
        }

        private void linkLabelShowAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ShowContact(contact.SelectContactList());
        }

        private void listBoxGroup_DoubleClick(object sender, EventArgs e)
        {
            int idx;
            try
            {
                idx = (int)listBoxGroup.SelectedValue;
            }
            catch (Exception)
            {
                return;
            }
            if (idx < 0) return;
            DataTable allcontact = group.getAllContactInGroup(idx);
            
            this.ShowContact(allcontact);
        }

        private void ShowContact(DataTable table)
        {
            dataGridViewShowAll.DataSource = table;
            dataGridViewShowAll.RowTemplate.Height = 80;
            dataGridViewShowAll.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridViewShowAll.Columns["picture"];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewShowAll.AllowUserToAddRows = false;
        }
        private void ShowAllGroup()
        {
            try
            {
                User user = new User();
                listBoxGroup.DataSource = user.getJoinedGroup(CurrentUser.Id);
                listBoxGroup.ValueMember = "groupId";
                listBoxGroup.DisplayMember = "groupName";
                listBoxGroup.SelectedItem = 0;
            }
            catch (Exception)
            {

            }
        }
    }
}
