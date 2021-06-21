using QLSV.Data;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QLSV.Entity
{
    //THONG
    class Score
    {
        private float studentScore;
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        //tao trigger
        public float StudentScore
        {
            get { return studentScore; }
            set {
                if (value > 10)
                {
                    studentScore = 10;
                }
                else if (value < 0)
                {
                    studentScore = 0;
                }
                else studentScore = value;
            }
        }
        public string Description { get; set; }
        public Score()
        {

        }
        //tạo proceduce
        public bool AddThisScore()
        {
            DataBase mydb = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("exec Add_Score @student_id, @course_id, @student_score, @description", mydb.Connection);

                command.Parameters.Add("@student_id", SqlDbType.NVarChar).Value = StudentID;
                command.Parameters.Add("@course_id", SqlDbType.Int).Value = CourseID;
                command.Parameters.Add("@student_score", SqlDbType.Float).Value = StudentScore;
                command.Parameters.Add("@description", SqlDbType.Text).Value = Description;

                mydb.openConnection();

                try
                {
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
                }

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                mydb.closeConnection();
            }
        }
        //tạo proceduce
        public bool UpdateThisScore()
        {
            DataBase dataBase = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand(
                    "exec Update_Score @student_id, @course_id, @student_score, @description"
                    , dataBase.Connection);
                command.Parameters.Add("@student_id", SqlDbType.NVarChar).Value = StudentID;
                command.Parameters.Add("@course_id", SqlDbType.Int).Value = CourseID;
                command.Parameters.Add("@student_score", SqlDbType.Float).Value = StudentScore;
                command.Parameters.Add("@desciption", SqlDbType.Text).Value = Description;

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
        public bool RemoveThisScore()
        {
            DataBase dataBase = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand(
                    "exec Remove_Score @student_id, @course_id", dataBase.Connection);
                command.Parameters.Add("@student_id", SqlDbType.NVarChar).Value = StudentID;
                command.Parameters.Add("@course_id", SqlDbType.Int).Value = CourseID;

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
        public DataTable getAllScore()
        {
            DataBase dataBase = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("exec GetAll_IdCourseOrder_Score", dataBase.Connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable table = new DataTable();

                dataBase.openConnection();

                adapter.Fill(table);

                dataBase.closeConnection();

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
        public DataTable getALL_IdCourseOrder()
        {
            DataBase db = new DataBase();
            try
            {
                db.openConnection();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.Connection,
                    CommandText = "exec GetAll_IdCourseOrder_Score"
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
        //tao view
        public DataTable getAvg_byStudent()
        {
            DataBase db = new DataBase();
            try
            {
                db.openConnection();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.Connection,
                    CommandText = "exec getAvg_Student_Score"
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
        public DataTable MakeStudentScoreResultTable()
        {
            try
            {
                Student student = new Student();
                Course course = new Course();
                Score score = new Score();

                //create column

                DataTable result = student.getAllBriefInfo();
                result.Columns[0].ColumnName = "Id";
                result.Columns[1].ColumnName = "Firt Name";
                result.Columns[2].ColumnName = "Last Name";

                DataTable coursesLabel = course.allLabel_IdOrder();
                DataTable scores = score.getALL_IdCourseOrder();
                DataTable avgScore = score.getAvg_byStudent();

                for (int i = 0; i < coursesLabel.Rows.Count; i++)
                {
                    result.Columns.Add(coursesLabel.Rows[i][1].ToString().Trim());
                }

                result.Columns.Add("Result");

                //test empty
                if (scores.Rows.Count < 1) return result;

                //fill score to table 
                int scoreRow = 0;
                for (int row = 0; row < result.Rows.Count; row++)
                {
                    try
                    {
                        int courseIndex = 0;
                        while (result.Rows[row][0].ToString().Trim() == scores.Rows[scoreRow][0].ToString().Trim())
                        {
                            result.Rows[row][courseIndex + 3] = scores.Rows[scoreRow][2].ToString().Trim();
                            courseIndex++;
                            scoreRow++;
                            if (scoreRow > scores.Rows.Count - 1)
                            {
                                break;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                // fill avg score
                int avgIndex = 0;
                for (int row = 0; row < result.Rows.Count; row++)
                {
                    try
                    {
                        if(result.Rows[row]["Id"].ToString().Trim() == avgScore.Rows[avgIndex][0].ToString().Trim())
                        {
                            result.Rows[row][result.Columns.Count - 1]
                                 = avgScore.Rows[avgIndex][1].ToString().Trim();
                            avgIndex++;
                        }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //tao function
        public bool isExisted()
        {
            DataBase mydb = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("select [dbo].IsExisted_Score (@student_id, @course_id)", mydb.Connection);

                command.Parameters.Add("@student_id", SqlDbType.NVarChar).Value = StudentID;
                command.Parameters.Add("@course_id", SqlDbType.Int).Value = CourseID;

                mydb.openConnection();

                return (bool)command.ExecuteScalar();
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
        //tao function
        public int getPassNumber()
        {
            DataBase db = new DataBase();
            try
            {
                db.openConnection();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.Connection,
                    CommandText = "select [dbo].getPassNumber_Score()"
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
        //tao fuction
        public int getFailNumber()
        {
            DataBase db = new DataBase();
            try
            {
                db.openConnection();
                SqlCommand command = new SqlCommand()
                {
                    Connection = db.Connection,
                    CommandText = "select [dbo].getFailNumber_Score()"
                };

                int result = 0;
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
        //public DataTable get
    }
}
