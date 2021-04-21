using System;
using QLSV.Data;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace QLSV.Entity
{
    class Course
    {
        private int period;

        public int Id { get; set; }
        public string Label { get; set; }
        public int Period
        {
            get { return period; }
            set
            {
                if (period < 10)
                {
                    this.period = 10;
                }
                else
                {
                    this.period = value;
                }
            }
        }
        public string Description { get; set; }
        public bool AddThisCourse()
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
        public bool UpdateThisCourse()
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
                command.Parameters.Add("@description", SqlDbType.Text).Value = Description;
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
        public bool RemoveThisCourse()
        {
            DataBase dataBase = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand(
                    "DELETE FROM Courses" +
                    " WHERE Id = @id", dataBase.Connection);
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
        public DataTable GetAll_ID_label()
        {
            DataBase dataBase = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("Select id, label From Courses", dataBase.Connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();

                dataBase.openConnection();

                adapter.Fill(table);

                return table;
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
        public bool InsertCourse(int id, string label, int period, string description)
        {
            DataBase db = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Course (id, label, period, description) "
                                  + "VALUES (@id, @label, @period, @description)", db.Connection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@label", SqlDbType.VarChar).Value = label;
                command.Parameters.Add("@period", SqlDbType.Int).Value = period;
                command.Parameters.Add("@description", SqlDbType.Text).Value = description;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    db.closeConnection();
                    return true;
                }
                else
                {
                    db.closeConnection();
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                db.closeConnection();
            }
        }

        public bool CheckCourseName(string courseName, int courseID = 0)
        {
            DataBase db = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Course WHERE label=@cName and id<>@cID", db.Connection);

                command.Parameters.Add("@cName", SqlDbType.VarChar).Value = courseName;
                command.Parameters.Add("@cID", SqlDbType.Int).Value = courseID;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                db.closeConnection();
            }
        }

        public bool RemoveCourse(int id)
        {
            DataBase db = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM Course WHERE id = @id", db.Connection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    db.closeConnection();
                    return true;
                }
                else
                {
                    db.closeConnection();
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                db.closeConnection();
            }
        }

        public bool UpdateCourse(int id, string label, int period, string description)
        {
            DataBase db = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE Course" +
                    " SET " +
                    "label = @label," +
                    "period = @period," +
                    "description = @description" +
                    " WHERE id = @ID"
                    , db.Connection);

                command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
                command.Parameters.Add("@period", SqlDbType.Int).Value = period;
                command.Parameters.Add("@description", SqlDbType.Text).Value = description;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    db.closeConnection();
                    return true;
                }
                else
                {
                    db.closeConnection();
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                db.closeConnection();
            }
        }

        public bool DeleteCourse(int id)
        {
            DataBase db = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM Course " +
                                    "where id=@id",
                                    db.Connection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    db.closeConnection();
                    return true;
                }
                else
                {
                    db.closeConnection();
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                db.closeConnection();
            }
        }

        public DataTable GetTable(string query)
        {
            DataBase db = new DataBase();
            try
            {

                db.openConnection();
                SqlCommand command = new SqlCommand(query, db.Connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Course");
                db.closeConnection();

                DataTable table = dataSet.Tables["Course"];
                return table;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.closeConnection();
            }
        }

        public DataTable GetAllCourses()
        {
            DataBase db = new DataBase();
            try
            {
                string query = "SELECT * FROM Course";
                return this.GetTable(query);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.closeConnection();
            }
        }

        public DataTable GetCourseByID(int id)
        {
            DataBase db = new DataBase();
            try
            {
                string query = $"SELECT * FROM Course WHERE id = {id}";
                return this.GetTable(query);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.closeConnection();
            }

        }

        public int TotalCourse()
        {
            DataBase db = new DataBase();
            try
            {
                DataTable table = this.GetAllCourses();
                return table.Rows.Count;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.closeConnection();
            }

        }
    }
}
