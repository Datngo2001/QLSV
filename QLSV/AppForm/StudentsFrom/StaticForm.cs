using QLSV.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.AppForm.StudentsForm
{
    public partial class StaticForm : Form
    {
        public StaticForm()
        {
            InitializeComponent();
        }

        private void StaticForm_Load(object sender, EventArgs e)
        {
            int total = totalStudent();
            totalStudent_lb.Text = total.ToString();
            DataSet genderData = femaleMaleAmount();
            genderChart.DataSource = genderData;

            genderChart.Series.Add("genderAmount");
            genderChart.Series["genderAmount"].XValueMember = "gender";
            genderChart.Series["genderAmount"].YValueMembers = "amount";
            genderChart.Titles.Add("Gender Chart");
            genderChart.Series.RemoveAt(0);

            int female = femaleAmount();
            int male = maleAmount();
            malePercent_lb.Text = ((male * 100.0) / total).ToString() + "%";
            femalePercent_lb.Text = ((female * 100.0) / total).ToString() + "%";
        }
        public int totalStudent()
        {
            try
            {
                DataBase dataBase = new DataBase();
                SqlCommand command = new SqlCommand(
                    "SELECT count(ID) FROM Students_info", dataBase.Connection);
                dataBase.openConnection();
                int total = (int)command.ExecuteScalar();
                dataBase.closeConnection();
                return total;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataSet femaleMaleAmount()
        {
            try
            {
                DataBase dataBase = new DataBase();
                SqlCommand command = new SqlCommand(
                    "SELECT gender, count(ID) as amount " +
                    "FROM Students_info " +
                    "GROUP BY gender", dataBase.Connection);
                dataBase.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet data = new DataSet();
                adapter.Fill(data, "Gender Amont");
                dataBase.closeConnection();
                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int maleAmount()
        {
            try
            {
                DataBase dataBase = new DataBase();
                SqlCommand command = new SqlCommand(
                    "SELECT count(ID) as amount " +
                    "FROM Students_info " +
                    "WHERE gender = 'M'", dataBase.Connection);
                dataBase.openConnection();
                int result = (int)command.ExecuteScalar();
                dataBase.closeConnection();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int femaleAmount()
        {
            try
            {
                DataBase dataBase = new DataBase();
                SqlCommand command = new SqlCommand(
                    "SELECT count(ID) as amount " +
                    "FROM Students_info " +
                    "WHERE gender = 'F'", dataBase.Connection);
                dataBase.openConnection();
                int result = (int)command.ExecuteScalar();
                dataBase.closeConnection();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
