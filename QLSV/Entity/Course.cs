using System;
using QLSV.Data;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace QLSV.Entity
{
    //THIEN
    class Course
    {
        private int period;

        public int Id { get; set; }
        public string Label { get; set; }
        //tạo trigger
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
        //tạo proceduce
        public bool AddThisCourse()
        {
            DataBase mydb = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("exec InsertCourse @label, @period, @desciption, @semester", mydb.Connection);

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
        //tạo proceduce
        public bool UpdateThisCourse()
        {
            DataBase dataBase = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand(
                    "exec UpdateCourses @ID, @label, @period, @description, @semester"
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
        //tạo proceduce
        public bool RemoveThisCourse()
        {
            DataBase dataBase = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand(
                    "exec RemoveCourse @ID", dataBase.Connection);
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
            catch (Exception e)
            {

                throw;
            }
            finally
            {
                dataBase.closeConnection();
            }
        }
        //tạo proceduce
        public List<int> GetAllId()
        {
            List<int> result = new List<int>();
            DataBase dataBase = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("exec GetAllId_Course", dataBase.Connection);
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
        //tạo proceduce
        public Course getByID(int Id)
        {
            DataBase dataBase = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("exec getByID_Course @id", dataBase.Connection);
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
                    Description = table.Rows[0][3].ToString(),
                    Semester = table.Rows[0][4].ToString()
                };

                this.Id = Convert.ToInt32(table.Rows[0][0].ToString());
                this.Label = table.Rows[0][1].ToString();
                this.Period = Convert.ToInt32(table.Rows[0][2].ToString());
                this.Description = table.Rows[0][3].ToString();
                this.Semester = table.Rows[0][4].ToString();

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
        //tạo proceduce
        public DataTable GetAll_ID_label()
        {
            DataBase dataBase = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("exec GetAll_ID_label", dataBase.Connection);
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
        //tạo proceduce
        public bool InsertCourse(string label, int period, string description, string semester)
        {
            DataBase db = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("exec InsertCourse @label, @period, @description, @semester", db.Connection);

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
        //tạo function
        public bool CheckCourseName(string courseName)
        {
            DataBase db = new DataBase();
            try
            {
                db.openConnection();

                SqlCommand command = new SqlCommand("select [dbo].CheckCourseName(@cName)", db.Connection);

                command.Parameters.Add("@cName", SqlDbType.VarChar).Value = courseName;

                return (bool)command.ExecuteScalar();
            }
            catch (Exception)
            {
                return true;
                throw;
            }
            finally
            {
                db.closeConnection();
            }
        }
        //tạo proceduce
        public bool RemoveCourse(int id)
        {
            DataBase db = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("exec RemoveCourse @ID", db.Connection);
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
        //tạo proceduce
        public bool UpdateCourse(int id, string label, int period, string description, string semester)
        {
            DataBase db = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand(
                    "exec UpdateCourse @ID, @label, @period, @description, @semester"
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
        //tạo proceduce
        public bool DeleteCourse(int id)
        {
            DataBase db = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("exec DeleteCourse @id",
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
        //tạo proceduce
        public DataTable GetAllCourses()
        {
            try
            {
                string query = "exec GetAllCourses";
                return this.GetTable(query);
            }
            catch (Exception)
            {
                throw;
            }
        }
        //tạo proceduce
        public DataTable GetCourseByID(int id)
        {
            try
            {
                string query = $"exec GetCourseByID {id}";
                return this.GetTable(query);
            }
            catch (Exception)
            {
                throw;
            }
        }
        //tạo function
        public int TotalCourse()
        {
            DataBase db = new DataBase();
            try
            {
                db.openConnection();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.Connection,
                    CommandText = "select [dbo].TotalCourse()"
                };
                int result;
                try
                {
                    result = (int)command.ExecuteScalar();
                }
                catch (Exception)
                {
                    return 0;
                }
                db.closeConnection();

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
        //tạo proceduce
        public DataTable getAvgScoreByCourse()
        {
            DataBase db = new DataBase();
            try
            {
                db.openConnection();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.Connection,
                    CommandText = "exec getAvgScoreByCourse"
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
        //tạo proceduce
        public DataTable allLabel_IdOrder()
        {
            DataBase db = new DataBase();
            try
            {
                db.openConnection();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.Connection,
                    CommandText = "exec allLabel_IdOrder"
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
        //tạo proceduce
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
                    CommandText = "exec GetCourseBySemester @semester"
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
        //tạo function
        public int GetIdByLabel(string label)
        {
            DataBase db = new DataBase();
            try
            {
                db.openConnection();
                SqlCommand command = new SqlCommand("select GetIdByLabel(@label)", db.Connection);
                command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
                int result;
                try
                {
                    result = (int)command.ExecuteScalar();
                }
                catch (Exception)
                {
                    return 0;
                }
                db.closeConnection();

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
        //tao view
        public DataTable studentsInCourse(int id)
        {
            DataBase db = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("exec getStudentsInCourse @id", db.Connection);
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
