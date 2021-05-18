using System;
using QLSV.Data;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace QLSV.Entity
{
    class Student
    {
        private DateTime bdate;
        public int ID { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public DateTime Bdate
        {
            get { return Convert.ToDateTime(this.bdate.ToShortDateString()); }
            set { this.bdate = Convert.ToDateTime(value.ToShortDateString()); } 
        }
        public char Gender { get; set; } 
        public string Phone { get; set; }
        public string Address { get; set; }
        public Image Picture { get; set; }
        public Student()
        {
            Bdate = default;
        }
        public bool getByID(int id)
        {
            DataBase dataBase = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand(
                    "SELECT id, fname, lname, bdate, gender, phone, address, picture FROM Students_info WHERE id = @ID", dataBase.Connection);
                command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;
                dataBase.openConnection();

                DataTable table = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter()
                {
                    SelectCommand = command
                };

                adapter.Fill(table);

                if(table.Rows.Count > 0)
                {
                    ID = Convert.ToInt32(table.Rows[0]["Id"].ToString().Trim());
                    Fname = table.Rows[0]["fname"].ToString();
                    Lname = table.Rows[0]["lname"].ToString();
                    Bdate = (DateTime)table.Rows[0]["bdate"];
                    Gender = (table.Rows[0]["gender"].ToString().Trim())[0];
                    Phone = table.Rows[0]["phone"].ToString();
                    Address = table.Rows[0]["address"].ToString();
                    byte[] arr = (byte[])table.Rows[0]["picture"];
                    Picture = new Picture().ByteArrToImage(arr);

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
                return false;
                throw;
            }
            finally
            {
                dataBase.closeConnection();
            }
        }
        public int isExistId(int id)
        {
            DataBase dataBase = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand(
                    "SELECT id, fname, lname, bdate, gender, phone, address, picture FROM Students_info WHERE id = @ID", dataBase.Connection);
                command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;
                dataBase.openConnection();

                DataTable table = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter()
                {
                    SelectCommand = command
                };

                adapter.Fill(table);

                return table.Rows.Count;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
            finally
            {
                dataBase.closeConnection();
            }
        }
        public bool getByPhone(string phone)
        {
            DataBase dataBase = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand(
                    "SELECT id, fname, lname, bdate, gender, phone, address, picture FROM Students_info WHERE phone = @phone", dataBase.Connection);
                command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
                dataBase.openConnection();

                DataTable table = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter()
                {
                    SelectCommand = command
                };

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    ID = Convert.ToInt32(table.Rows[0]["Id"].ToString().Trim());
                    Fname = table.Rows[0]["fname"].ToString();
                    Lname = table.Rows[0]["lname"].ToString();
                    Bdate = (DateTime)table.Rows[0]["bdate"];
                    Gender = (table.Rows[0]["gender"].ToString().Trim())[0];
                    Phone = table.Rows[0]["phone"].ToString();
                    Address = table.Rows[0]["address"].ToString();
                    byte[] arr = (byte[])table.Rows[0]["picture"];
                    Picture = new Picture().ByteArrToImage(arr);

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
                dataBase.closeConnection();
                return false;
                throw;
            }
            finally
            {
                dataBase.closeConnection();
            }
        }
        public DataTable getByComand(SqlCommand command)
        {
            DataBase dataBase = new DataBase();
            try
            {
                command.Connection = dataBase.Connection;
                dataBase.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable(); adapter.Fill(table);
                dataBase.closeConnection();
                return table;
            }
            catch (Exception)
            {
                dataBase.closeConnection();
                throw;
            }
            finally
            {
                dataBase.closeConnection();
            }
        }
        public DataTable findByHint(string hint)
        {
            DataBase dataBase = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand(
                    "SELECT * FROM Students_info WHERE CONCAT(fname, lname, address) LIKE '%" +
                    hint
                    + "%'", dataBase.Connection);

                dataBase.openConnection();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                table = StudentsTableNaming(table);

                dataBase.closeConnection();

                return table;
            }
            catch (Exception)
            {
                dataBase.closeConnection();
                throw;
            }
            finally
            {
                dataBase.closeConnection();
            }
        }
        public DataTable findIdFname(string hint)
        {
            DataBase dataBase = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand(
                    "SELECT * FROM Students_info WHERE CONCAT(ID, fname, lname) LIKE '%" +
                    hint
                    + "%'", dataBase.Connection);

                dataBase.openConnection();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);

                table = StudentsTableNaming(table);

                dataBase.closeConnection();

                return table;
            }
            catch (Exception)
            {
                dataBase.closeConnection();
                throw;
            }
            finally
            {
                dataBase.closeConnection();
            }
        }
        public bool InsertThisStudent()
        {
            DataBase mydb = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Students_info (ID, fname, lname, bdate, gender, phone, address, picture)" +
                "VALUES (@id, @fn, @ln, @bdt, @gd, @phn, @adrs, @pic)", mydb.Connection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@fn", SqlDbType.VarChar).Value = Fname;
                command.Parameters.Add("@ln", SqlDbType.VarChar).Value = Lname;
                command.Parameters.Add("@bdt", SqlDbType.Date).Value = Bdate;
                command.Parameters.Add("@gd", SqlDbType.VarChar).Value = Gender;
                command.Parameters.Add("@phn", SqlDbType.VarChar).Value = Phone;
                command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = Address;
                command.Parameters.Add("@pic", SqlDbType.Image).Value = new Picture(this.Picture).toByteArray();

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
                return false;
                throw;
            }
            finally
            {
                mydb.closeConnection();
            }
        }
        public bool UpdateThisStudent()
        {
            DataBase dataBase = new DataBase();
            try
            {
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
                command.Parameters.Add("@Fname", SqlDbType.NVarChar).Value = Fname;
                command.Parameters.Add("@Lname", SqlDbType.NVarChar).Value = Lname;
                command.Parameters.Add("@Bdate", SqlDbType.Date).Value = Bdate;
                command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone;
                command.Parameters.Add("@Adress", SqlDbType.NVarChar).Value = Address;
                command.Parameters.Add("@Picture", SqlDbType.Image).Value = new Picture(this.Picture).toByteArray();
                command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                command.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;

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
                return false;
                throw;
            }
            finally
            {
                dataBase.closeConnection();
            }
        }
        public bool DeleteThisStudent()
        {
            DataBase dataBase = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand(
                    "DELETE FROM Students_info" +
                    " WHERE ID = @id", dataBase.Connection);
                command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

                dataBase.openConnection();
                if(command.ExecuteNonQuery() == 1)
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
                return false;
                throw;
            }
            finally
            {
                dataBase.closeConnection();
            }
        }
        public DataTable StudentsTableNaming(DataTable table)
        {
            try
            {
                table.Columns[0].ColumnName = "ID";
                table.Columns[1].ColumnName = "First name";
                table.Columns[2].ColumnName = "Last name";
                table.Columns[3].ColumnName = "Birthdate";
                table.Columns[4].ColumnName = "Gender";
                table.Columns[5].ColumnName = "Phone";
                table.Columns[6].ColumnName = "Adress";
                table.Columns[7].ColumnName = "Picture";

                return table;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable getAllBriefInfo()
        {
            DataBase db = new DataBase();
            try
            {
                db.openConnection();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.Connection,
                    CommandText = "SELECT ID, fname, lname FROM Students_info"
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
        public DataTable GetAllStudent()
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM Students_info";
                return this.getByComand(command);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable GetSelectedCourses(int id)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Student_Courses " +
                                                    "inner join Courses on Student_Courses.courseId = Courses.Id " +
                                                    "WHERE stdId=@id");
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                return this.getByComand(command);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool CheckValidCourse(string selectedCourse, string currCourse)
        {
            if (selectedCourse.Contains(currCourse))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool InsertSelectedCourse(string id, int course)
        {
            DataBase db = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("Insert into Student_Courses (stdId, courseId) " +
                                                     "values (@stdId, @courseId)", db.Connection);

                command.Parameters.Add("@stdId", SqlDbType.Int).Value = id;
                command.Parameters.Add("@courseId", SqlDbType.Int).Value = course;

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

                throw;
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
}