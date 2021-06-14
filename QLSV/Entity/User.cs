﻿using QLSV.AppForm;
using QLSV.Data;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System;

namespace QLSV.Entity
{
    //DAT
    class User
    {
        DataBase db = new DataBase();
        //tạo proceduce
        public bool login(string Username, string Password)
        {
            ProgressDialog progress = new ProgressDialog();
            progress.Show();

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            db.openConnection();
            SqlCommand cm = new SqlCommand(
                "SELECT * FROM Users WHERE UserName = @User AND Password = @Pass", db.Connection);
            cm.Parameters.Add("@User", SqlDbType.VarChar).Value = Username;
            cm.Parameters.Add("@Pass", SqlDbType.VarChar).Value = Password;
            adapter.SelectCommand = cm;

            progress.Bar.Value = 50;

            adapter.Fill(table);

            progress.Bar.Value = 100;

            db.closeConnection();

            progress.Close();

            if (table.Rows.Count > 0)
            {
                //load info
                CurrentUser.Id = Convert.ToInt32(table.Rows[0]["id"].ToString().Trim());
                CurrentUser.fname = table.Rows[0]["fname"].ToString().Trim();
                CurrentUser.lname = table.Rows[0]["lname"].ToString().Trim();
                CurrentUser.UserName = table.Rows[0]["UserName"].ToString().Trim();
                if(table.Rows[0]["pic"] != System.DBNull.Value)
                {
                    CurrentUser.Avatar = new Picture().ByteArrToImage((byte[])table.Rows[0]["pic"]);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        //tạo proceduce
        public bool signin(string Username, string Password, string fname, string lname, Image image)
        {
            try
            {
                if (CheckUserName(Username) == true)
                {
                    SqlCommand insertCommand = new SqlCommand(
                    "INSERT INTO Users (UserName, Password, fname, lname, pic)" +
                    "VALUES (@username, @password, @fname, @lname, @pic)"
                    , db.Connection);

                    db.openConnection();

                    insertCommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = Username;
                    insertCommand.Parameters.Add("@password", SqlDbType.NVarChar).Value = Password;
                    insertCommand.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
                    insertCommand.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
                    insertCommand.Parameters.Add("@pic", SqlDbType.Image).Value = new Picture(image).toByteArray();

                    if (insertCommand.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
                throw;
            }
            finally
            {
                db.closeConnection();
            }
        }
        //tạo function
        public bool CheckUserName(string username)
        {
            try
            {
                SqlCommand checkCommand = new SqlCommand(
                    "SELECT * FROM Users " +
                    "WHERE UserName = @username"
                    , db.Connection);
                checkCommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                db.openConnection();
                if(checkCommand.ExecuteScalar()  == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (System.Exception)
            {

                throw;
            }
            finally
            {
                db.closeConnection();
            }
        }
        //tạo function
        public bool CheckPassword(string password)
        {
            try
            {
                SqlCommand checkCommand = new SqlCommand(
                    "SELECT * FROM Users " +
                    "where UserName = @User AND Password = @Pass"
                    , db.Connection);
                checkCommand.Parameters.Add("@User", SqlDbType.NVarChar).Value = CurrentUser.UserName;
                checkCommand.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = password;
                db.openConnection();
                if (checkCommand.ExecuteScalar() != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (System.Exception)
            {

                throw;
            }
            finally
            {
                db.closeConnection();
            }

        }
        //tạo proceduce
        public bool editProfile(int id, string Password, string fname, string lname, Image image)
        {
            try
            {
                SqlCommand insertCommand = new SqlCommand(
                    "UPDATE Users SET " +
                    "Password = @password, " +
                    "fname = @fname, " +
                    "lname = @lname, " +
                    "pic = @pic " +
                    "WHERE id = @id"
                    , db.Connection);


                db.openConnection();

                insertCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
                insertCommand.Parameters.Add("@password", SqlDbType.NVarChar).Value = Password;
                insertCommand.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
                insertCommand.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
                insertCommand.Parameters.Add("@pic", SqlDbType.Image).Value = new Picture(image).toByteArray();

                if (insertCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
                throw;
            }
            finally
            {
                db.closeConnection();
            }
        }
        //tạo proceduce
        public bool editProfile(int id, string fname, string lname, Image image)
        {
            try
            {
                SqlCommand insertCommand = new SqlCommand(
                    "UPDATE Users SET " +
                    "fname = @fname, " +
                    "lname = @lname, " +
                    "pic = @pic " +
                    "WHERE id = @id"
                    , db.Connection);


                db.openConnection();

                insertCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
                insertCommand.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
                insertCommand.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
                insertCommand.Parameters.Add("@pic", SqlDbType.Image).Value = new Picture(image).toByteArray();

                if (insertCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
                throw;
            }
            finally
            {
                db.closeConnection();
            }
        }
        //tạo proceduce
        public DataTable GetUserByID(int id)
        {
            try
            {
                db.openConnection();
                SqlCommand command = new SqlCommand($"SELECT * FROM [Users] WHERE id = @id", db.Connection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Users");
                db.closeConnection();

                DataTable table = dataSet.Tables["Users"];
                return table;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //tạo proceduce
        public string GetUserFullNameByID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT CONCAT(TRIM(lname), ' ', TRIM(fname)) FROM [Users] WHERE id = @id",
                                                db.Connection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table.Rows[0][0].ToString().Trim();
        }
        //tao view
        public DataTable getJoinedGroup(int user_id)
        {
            try
            {
                db.openConnection();
                SqlCommand command = new SqlCommand($"SELECT [Group].id, [Group].name, [Group].user_id" +
                    $" FROM [Group] inner join Contact on [Group].id = Contact.[group]" +
                    $" WHERE Contact.[user_id] = @user_id", db.Connection);
                command.Parameters.Add("@user_id", SqlDbType.Int).Value = user_id;
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
        }
    }
}
