using QLSV.Entity;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QLSV.AppForm.StudentsForm
{
    public partial class ManageStudentsForm : EditDeleteStudentForm
    {
        public ManageStudentsForm()
        {
            InitializeComponent();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            foreach (var control in this.Controls)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
                else if(control is RichTextBox)
                {
                    ((RichTextBox)control).Text = "";
                }
                else if(control is PictureBox)
                {
                    ((PictureBox)control).Image = null;
                }
                else if (control is DataGridView)
                {
                    ((DataGridView)control).DataSource = null;
                }

                var statistic = new QLSV.Utility.Statistic();
                total_lb.Text = "Total student: " + statistic.totalStudent();
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            DataTable table = student.findByHint(Search_tb.Text);
            table = student.StudentsTableNaming(table);

            showResult_dgv.RowTemplate.Height = 80;
            showResult_dgv.DataSource = table;
            showResult_dgv.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)showResult_dgv.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            showResult_dgv.AllowUserToAddRows = false;
        }

        private void showResult_dgv_DoubleClick(object sender, EventArgs e)
        {
            Id_tb.Text = showResult_dgv.CurrentRow.Cells[0].Value.ToString().Trim();
            FirstName_tb.Text = showResult_dgv.CurrentRow.Cells[1].Value.ToString().Trim();
            LastName_tb.Text = showResult_dgv.CurrentRow.Cells[2].Value.ToString().Trim();
            BirthDay_picker.Value = (DateTime)showResult_dgv.CurrentRow.Cells[3].Value;
            if (showResult_dgv.CurrentRow.Cells[4].Value.ToString().Trim() == "M")
            {
                male_rbtn.Checked = true;
            }
            else if (showResult_dgv.CurrentRow.Cells[4].Value.ToString().Trim() == "F")
            {
                female_rbtn.Checked = true;
            }
            Phone_tb.Text = showResult_dgv.CurrentRow.Cells[5].Value.ToString().Trim();
            Address_rtb.Text = showResult_dgv.CurrentRow.Cells[6].Value.ToString().Trim();
            byte[] byteImage = (byte[])showResult_dgv.CurrentRow.Cells[7].Value;
            MemoryStream stream = new MemoryStream(byteImage);
            student_pcb.Image = Image.FromStream(stream);
        }

        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {
            try
            {
                var statistic = new QLSV.Utility.Statistic();
                total_lb.Text += statistic.totalStudent();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
