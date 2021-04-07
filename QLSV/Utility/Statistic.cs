using QLSV.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Utility
{
    class Statistic
    {
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
                adapter.Fill(data, "Gender Amount");
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
    }
}
