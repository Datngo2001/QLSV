using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLSV.Entity;

namespace QLSV
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                ID = Convert.ToInt32(id_tb.Text),
                Fname = fname_tx.Text,
                Lname = lname_tb.Text,
                Bdate = bdate_picker.Value,
                Gender = male_rbtn.Checked, //checked == true ==> true == male
                Phone = phone_tb.Text,
                Address = address_rtb.Text,
                //Picture = pictureBox.Image
            };
            student.insertStudent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            string fileName;
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileName = dlg.FileName;
            }
        }
    }
}
