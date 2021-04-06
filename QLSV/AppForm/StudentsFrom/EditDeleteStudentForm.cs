using QLSV.Data;
using QLSV.Entity;
using QLSV.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.AppForm.StudentsForm
{
    public partial class EditDeleteStudentForm : Form
    {
        public EditDeleteStudentForm()
        {
            InitializeComponent();
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            string filepath = null;
            OpenFileDialog ofdImages = new OpenFileDialog();
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                filepath = ofdImages.FileName;
            }
            pictureBox1.Image = Image.FromFile(filepath.ToString());
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Find_Click(object sender, EventArgs e)
        {
            try
            {
                SearchCenter searchCenter = new SearchCenter();
                DataTable table = searchCenter.searchStudentID(Id_tb.Text);

                if (table.Rows.Count > 0)
                {
                    LoadData(table);
                }
                else
                {
                    MessageBox.Show("not found", "Student not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase dataBase = new DataBase();

                SqlCommand command = new SqlCommand(
                    "UPDATE Students_info" +
                    " SET " +
                    "fname = @Fname," +
                    "lname = @Lname," +
                    "bdate = @Bdate," +
                    "gender = @Gender," +
                    "phone = @Phone," +
                    "address = @Adress," +
                    "picture = @Picture" +
                    " WHERE id = @ID"
                    , dataBase.Connection);
                command.Parameters.Add("@Fname", SqlDbType.NVarChar).Value = FirstName_tb.Text;
                command.Parameters.Add("@Lname", SqlDbType.NVarChar).Value = LastName_tb.Text;
                command.Parameters.Add("@Bdate", SqlDbType.DateTime).Value = BirthDay_picker.Value;
                if (female_rbtn.Checked)
                {
                    command.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = "F";
                }else if (male_rbtn.Checked)
                {
                    command.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = "M";
                }else
                {
                    command.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = "F";
                }
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone_tb.Text;
                command.Parameters.Add("@Adress", SqlDbType.NVarChar).Value = Address_rtb.Text;
                ImageConverter converter = new ImageConverter();
                byte[] image = (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));
                command.Parameters.Add("@Picture", SqlDbType.Image).Value = image;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = Id_tb.Text;

                dataBase.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Complete", "Edit complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR", "Edit fails", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataBase.closeConnection();
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
                throw;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult delete = MessageBox.Show("Are you really want to delete student with id: " + Id_tb.Text, "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delete == DialogResult.Yes)
                {
                    DataBase dataBase = new DataBase();

                    SqlCommand command = new SqlCommand(
                        "DELETE FROM Students_info" +
                        " WHERE ID = @id", dataBase.Connection);
                    command.Parameters.Add("@ID", SqlDbType.Int).Value = Id_tb.Text;

                    dataBase.openConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Complete", "Delete complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR", "Delete fails", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dataBase.closeConnection();
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
                throw;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void findByPhone_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SearchCenter searchCenter = new SearchCenter();
                DataTable table = searchCenter.searchStudentPhone(Phone_tb.Text);

                if (table.Rows.Count > 0)
                {
                    LoadData(table);
                }
                else
                {
                    MessageBox.Show("not found", "Find Student not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
                throw;
            }
        }

        private void firstNameFind_btn_Click(object sender, EventArgs e)
        {
            try
            {
                FindStudentForm findStudentForm = new FindStudentForm();
                findStudentForm.searchInput_tb.Text = FirstName_tb.Text;
                findStudentForm.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void LoadData(DataTable table)
        {
            try
            {
                FirstName_tb.Text = table.Rows[0]["fname"].ToString();
                LastName_tb.Text = table.Rows[0]["lname"].ToString();
                BirthDay_picker.Value = (DateTime)table.Rows[0]["bdate"];

                // gender

                if (table.Rows[0]["gender"].ToString() == "M")
                {
                    male_rbtn.Checked = true;
                }
                else if (table.Rows[0]["gender"].ToString() == "F")
                {
                    female_rbtn.Checked = true;
                }


                Phone_tb.Text = table.Rows[0]["phone"].ToString();
                Address_rtb.Text = table.Rows[0]["address"].ToString();
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
