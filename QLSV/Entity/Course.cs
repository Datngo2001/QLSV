using System;
using QLSV.Data;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace QLSV.Entity
{
    class Course
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public int Period { get; set; }
        public string Description { get; set; }
        public bool AddCourse()
        {
            DataBase mydb = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Courses (Id, label, period, description)" +
                    "VALUES (@Id, @label, @period, @desciption)", mydb.Connection);

                command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                command.Parameters.Add("@label", SqlDbType.NVarChar).Value = Label;
                command.Parameters.Add("@period", SqlDbType.Int).Value = Period;
                command.Parameters.Add("@desciption", SqlDbType.Text).Value = Description;

                mydb.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    mydb.closeConnection();
                    return true;
                }
                else
                {
                    mydb.closeConnection();
                    return false;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                mydb.closeConnection();
            }
        }
        public bool UpdateCourse()
        {
            DataBase dataBase = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE Courses" +
                    " SET " +
                    "label = @label," +
                    "period = @period," +
                    "description = @description" +
                    " WHERE id = @ID"
                    , dataBase.Connection);
                command.Parameters.Add("@label", SqlDbType.NVarChar).Value = Label;
                command.Parameters.Add("@period", SqlDbType.Int).Value = Period;
                command.Parameters.Add("@Bdate", SqlDbType.Text).Value = Description;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = Id;

                dataBase.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    dataBase.closeConnection();
                    return true;
                }
                else
                {
                    dataBase.closeConnection();
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dataBase.closeConnection();
            }
        }

        public List<int> GetAllId()
        {
            List<int> result = new List<int>();
            DataBase dataBase = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("Select id From Courses", dataBase.Connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();

                dataBase.openConnection();

                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    result.Add(Convert.ToInt32(row[0].ToString()));
                }

                return result;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dataBase.closeConnection();
            }
        }
        public Course getByID(int Id)
        {
            DataBase dataBase = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("Select * From Courses Where Id = @id", dataBase.Connection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();

                dataBase.openConnection();

                adapter.Fill(table);

                dataBase.closeConnection();

                Course course = new Course()
                {
                    Id = Convert.ToInt32(table.Rows[0][0].ToString()),
                    Label = table.Rows[0][1].ToString(),
                    Period = Convert.ToInt32(table.Rows[0][2].ToString()),
                    Description = table.Rows[0][3].ToString()
                };

                this.Id = Convert.ToInt32(table.Rows[0][0].ToString());
                this.Label = table.Rows[0][1].ToString();
                this.Period = Convert.ToInt32(table.Rows[0][2].ToString());
                this.Description = table.Rows[0][3].ToString();

                return course;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dataBase.closeConnection();
            }
        }
    }
}
