﻿using QLSV.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Entity
{
    class Score
    {
        private float studentScore;
        public int StudentID { get; set; }
        public int CourseID { get; set; }
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
        public bool AddThisScore()
        {
            DataBase mydb = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Score (student_id, course_id, student_score, description)" +
                    "VALUES (@student_id, @course_id, @student_score, @description)", mydb.Connection);

                command.Parameters.Add("@student_id", SqlDbType.NVarChar).Value = StudentID;
                command.Parameters.Add("@course_id", SqlDbType.Int).Value = CourseID;
                command.Parameters.Add("@student_score", SqlDbType.Float).Value = StudentScore;
                command.Parameters.Add("@description", SqlDbType.Text).Value = Description;

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
        public bool UpdateThisScore()
        {
            DataBase dataBase = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand(
                    "UPDATE Score" +
                    " SET " +
                    "student_score = @student_score," +
                    "description = @description," +
                    " WHERE student_id = @student_id and course_id = @course_id"
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
        public bool RemoveThisScore()
        {
            DataBase dataBase = new DataBase();
            try
            {
                SqlCommand command = new SqlCommand(
                    "DELETE FROM Score" +
                    " WHERE student_id = @student_id and course_id = @course_id", dataBase.Connection);
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


    }
}