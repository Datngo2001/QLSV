using QLSV.Entity;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLSV.AppForm.StudentsForm
{
    public partial class EditDeleteStudentForm : Form
    {
        Student student;
        public EditDeleteStudentForm()
        {
            InitializeComponent();
            student = new Student();
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            string filepath = null;
            OpenFileDialog ofdImages = new OpenFileDialog();
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                filepath = ofdImages.FileName;
            }
            student_pcb.Image = Image.FromFile(filepath.ToString());
            student_pcb.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Find_Click(object sender, EventArgs e)
        {
            try
            {
                if (student.getByID(Convert.ToInt32(Id_tb.Text)) == true)
                {
                    LoadData();
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
                Student student = new Student()
                {
                    ID = Convert.ToInt32(Id_tb.Text),
                    Fname = FirstName_tb.Text,
                    Lname = LastName_tb.Text,
                    Bdate = BirthDay_picker.Value,
                    Address = Address_rtb.Text,
                    Phone = Phone_tb.Text,
                    Picture = student_pcb.Image
                };
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
                    if (student.DeleteThisStudent() == true)
                    {
                        MessageBox.Show("Complete", "Delete complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR", "Delete fails", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                if (student.getByPhone(Phone_tb.Text) == true)
                {
                    LoadData();
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

        public void LoadData()
        {
            try
            {
                Id_tb.Text = student.ID.ToString();
                FirstName_tb.Text = student.Fname;
                LastName_tb.Text = student.Lname;
                BirthDay_picker.Value = student.Bdate;

                if (student.Gender == 'M')
                {
                    male_rbtn.Checked = true;
                }
                else if (student.Gender == 'F')
                {
                    female_rbtn.Checked = true;
                }

                Phone_tb.Text = student.Phone;
                Address_rtb.Text = student.Address;
                student_pcb.Image = student.Picture;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        private void EditDeleteStudentForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public bool InputStudent(int id)
        {
            try
            {
                student = new Student();
                if(student.getByID(id) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void courses_btn_Click(object sender, EventArgs e)
        {
            AddStudentToCoursesForm addStudentToCoursesForm = new AddStudentToCoursesForm();
            addStudentToCoursesForm.currId = Id_tb.Text.Trim();
            addStudentToCoursesForm.Show();
        }
    }
}
