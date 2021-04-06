using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLSV.Data;
using QLSV.Entity;

namespace QLSV.Utility
{
    class SearchCenter
    {
        public DataTable findByHint(string hint)
        {
            try
            {
                DataBase dataBase = new DataBase();
                SqlCommand command = new SqlCommand(
                    "SELECT * FROM Students_info WHERE CONCAT(fname, lname, address) LIKE '%" +
                    hint
                    + "%'", dataBase.Connection);

                dataBase.openConnection();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                dataBase.closeConnection();

                return table;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable searchStudentID(string ID){
            try
            {
                DataBase dataBase = new DataBase();
                SqlCommand command = new SqlCommand(
                    "SELECT id, fname, lname, bdate, gender, phone, address, picture FROM Students_info WHERE id = @ID", dataBase.Connection);
                command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID;
                dataBase.openConnection();

                DataTable table = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter()
                {
                    SelectCommand = command
                };

                adapter.Fill(table);

                dataBase.closeConnection();

                return table;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable searchStudentPhone(string phone)
        {
            try
            {
                DataBase dataBase = new DataBase();
                SqlCommand command = new SqlCommand(
                    "SELECT id, fname, lname, bdate, gender, phone, address, picture FROM Students_info WHERE phone = @Phone", dataBase.Connection);
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = phone;
                dataBase.openConnection();
                Student student = new Student();
                DataTable table = student.getStudents(command);

                dataBase.closeConnection();

                return table;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
