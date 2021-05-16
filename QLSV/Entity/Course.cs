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
        public string Semester { get; set; }
        public bool AddThisCourse()
        {
            DataBase mydb = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Courses (label, period, description, semester)" +
                    "VALUES (@label, @period, @desciption, @semester)", mydb.Connection);

                command.Parameters.Add("@label", SqlDbType.NVarChar).Value = Label;
                command.Parameters.Add("@period", SqlDbType.Int).Value = Period;
                command.Parameters.Add("@desciption", SqlDbType.Text).Value = Description;
                command.Parameters.Add("@semester", SqlDbType.VarChar).Value = Semester;

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
                    "semester = @semester, " +
                    "description = @description" +
                    " WHERE id = @ID"
                    , dataBase.Connection);
                command.Parameters.Add("@label", SqlDbType.NVarChar).Value = Label;
                command.Parameters.Add("@period", SqlDbType.Int).Value = Period;
                command.Parameters.Add("@description", SqlDbType.Text).Value = Description;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = Id;
                command.Parameters.Add("@semester", SqlDbType.VarChar).Value = Semester;

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
                SqlCommand command2 = new SqlCommand("DELETE FROM Student_Courses WHERE courseId = @ID", dataBase.Connection);
                command2.Parameters.Add("@ID", SqlDbType.Int).Value = Id;

                SqlCommand command3 = new SqlCommand("DELETE FROM Score WHERE course_Id = @ID", dataBase.Connection);
                command3.Parameters.Add("@ID", SqlDbType.Int).Value = Id;

                SqlCommand command = new SqlCommand(
                    "DELETE FROM Courses" +
                    " WHERE Id = @ID", dataBase.Connection);
                command.Parameters.Add("@ID", SqlDbType.Int).Value = Id;

                dataBase.openConnection();

                command2.ExecuteNonQuery();

                command3.ExecuteNonQuery();

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
            catch (Exception e)
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
        public bool InsertCourse(string label, int period, string description, string semester)
        {
            DataBase db = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Courses (label, period, description, semester) "
                                  + "VALUES (@label, @period, @description, @semester)", db.Connection);

                command.Parameters.Add("@label", SqlDbType.VarChar).Value = label;
                command.Parameters.Add("@period", SqlDbType.Int).Value = period;
                command.Parameters.Add("@description", SqlDbType.Text).Value = description;
                command.Parameters.Add("@semester", SqlDbType.VarChar).Value = semester;

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
        public bool CheckCourseName(string courseName)
        {
            DataBase db = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Courses WHERE label=@cName", db.Connection);

                command.Parameters.Add("@cName", SqlDbType.VarChar).Value = courseName;

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
                SqlCommand command2 = new SqlCommand("DELETE FROM Student_Courses WHERE courseId = @ID", db.Connection);
                command2.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                SqlCommand command3 = new SqlCommand("DELETE FROM Score WHERE course_Id = @ID", db.Connection);
                command3.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                SqlCommand command = new SqlCommand("DELETE FROM Courses WHERE id = @ID", db.Connection);
                command.Parameters.Add("@ID", SqlDbType.Int).Value = id;

                db.openConnection();

                command2.ExecuteNonQuery();

                command3.ExecuteNonQuery();

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
        public bool UpdateCourse(int id, string label, int period, string description, string semester)
        {
            DataBase db = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE Courses" +
                    " SET " +
                    "label = @label," +
                    "semester = @semester," +
                    "period = @period," +
                    "description = @description" +
                    " WHERE id = @ID"
                    , db.Connection);

                command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
                command.Parameters.Add("@period", SqlDbType.Int).Value = period;
                command.Parameters.Add("@description", SqlDbType.Text).Value = description;
                command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                command.Parameters.Add("@semester", SqlDbType.VarChar).Value = semester;

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
                SqlCommand command = new SqlCommand("DELETE FROM Courses " +
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
                DataTable table = new DataTable();
                adapter.Fill(table);
                db.closeConnection();

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
                string query = "SELECT * FROM Courses";
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
                string query = $"SELECT * FROM Courses WHERE id = {id}";
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
        public DataTable getAvgScoreByCourse()
        {
            DataBase db = new DataBase();
            try
            {
                db.openConnection();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.Connection,
                    CommandText = "SELECT Courses.label, AVG(score.student_score) As AverageGrade " +
                    "FROM Courses, Score " +
                    "WHERE Courses.Id = Score.course_id " +
                    "GROUP BY Courses.label"
                };
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                db.closeConnection();

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
        public DataTable allLabel_IdOrder()
        {
            DataBase db = new DataBase();
            try
            {
                db.openConnection();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.Connection,
                    CommandText = "select Courses.Id, Courses.label " +
                                    "from Courses " +
                                    "order by Courses.Id"
                };
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                db.closeConnection();

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
        public DataTable GetCourseBySemester(string semester)
        {
            semester = semester.Trim();
            DataBase db = new DataBase();
            try
            {
                db.openConnection();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.Connection,
                    CommandText = "SELECT * FROM Courses WHERE semester = @semester"
                };
                command.Parameters.Add("@semester", SqlDbType.NVarChar).Value = semester;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                db.closeConnection();

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
        public int GetIdByLabel(string label)
        {
            DataBase dataBase = new DataBase();
            try
            {
                label = label.Trim();
                SqlCommand command = new SqlCommand("SELECT Id From Courses Where label = @label", dataBase.Connection);
                command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
                dataBase.openConnection();
                int result = Convert.ToInt32(command.ExecuteScalar());
                dataBase.closeConnection();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable studentsInCourse(int id)
        {
            DataBase db = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("select Students_info.ID, fname, lname, bdate " +
                                                    "from Students_info inner join Student_Courses " +
                                                    "on Students_info.ID = Student_Courses.stdId " +
                                                    "where Student_Courses.courseId = @id", db.Connection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable courseStudent = new DataTable();
                db.openConnection();
                adapter.Fill(courseStudent);
                db.closeConnection();

                DataTable result = new DataTable();
                result.Columns.Add().ColumnName = "STT";
                result.Columns.Add().ColumnName = "Id";
                result.Columns.Add().ColumnName = "First Name";
                result.Columns.Add().ColumnName = "Last Name";
                result.Columns.Add().ColumnName = "Birth Date";

                int index = 1;
                foreach (DataRow row in courseStudent.Rows)
                {
                    DataRow resultRow = result.Rows.Add();
                    resultRow["STT"] = index;
                    resultRow["Id"] = row["ID"];
                    resultRow["First Name"] = row["fname"];
                    resultRow["Last Name"] = row["bdate"];
                }
                return result;
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
