using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using QLSV.Entity;
using QLSV.Utility;

namespace QLSV.AppForm.StudentsForm
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
                Phone = phone_tb.Text,
                Address = address_rtb.Text,
                Picture = pictureBox.Image
            };
            if (female_rbtn.Checked)
            {
                student.Gender = 'F';
            }else if (male_rbtn.Checked)
            {
                student.Gender = 'M';
            }
            if (student.isExistId(Convert.ToInt32(id_tb.Text)))
            {
                MessageBox.Show("Id is existed!");
                return;
            }
            if (student.InsertThisStudent() == true)
            {
                MessageBox.Show("Add Complete", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                new FormTool().ClearForm(this); 
            }
            else
            {
                MessageBox.Show("Add Fail", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            try
            {
                pictureBox.Image = Image.FromFile(filepath.ToString());
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {

            }
        }

        private void check_btn_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            if (student.isExistId(Convert.ToInt32(id_tb.Text)))
            {
                MessageBox.Show("Id is existed!");
            }
            else
            {
                MessageBox.Show("OK");
            }
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void phone_lb_Click(object sender, EventArgs e)
        {

        }

        private void lname_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void fname_tx_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void fname_lb_Click(object sender, EventArgs e)
        {

        }

        private void male_rbtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
