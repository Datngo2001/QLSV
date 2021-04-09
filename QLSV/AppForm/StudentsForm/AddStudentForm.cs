using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using QLSV.Entity;

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
            if(student.InsertThisStudent() == true)
            {
                MessageBox.Show("Add Complete", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ClearAllText(this);
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
            pictureBox.Image = Image.FromFile(filepath.ToString());
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
            foreach (Control c in con.Controls)
            {
                if (c is RichTextBox)
                    ((RichTextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }
    }
}
