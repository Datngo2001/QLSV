using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
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
            ImageConverter imgCon = new ImageConverter();
            Student student = new Student()
            {
                ID = Convert.ToInt32(id_tb.Text),
                Fname = fname_tx.Text,
                Lname = lname_tb.Text,
                Bdate = bdate_picker.Value,
                Gender = male_rbtn.Checked, //checked == true ==> true == male
                Phone = phone_tb.Text,
                Address = address_rtb.Text,
                Picture = new MemoryStream((byte[])imgCon.ConvertTo(pictureBox.Image, typeof(byte[])))
            };
            if(student.insertStudent() == true)
            {
                MessageBox.Show("Add Complete", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Add Complete", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
