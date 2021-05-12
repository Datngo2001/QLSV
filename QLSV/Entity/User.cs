using QLSV.AppForm;
using QLSV.Data;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System;

namespace QLSV.Entity
{
    class User
    {
        public bool login(string Username, string Password)
        {
            ProgressDialog progress = new ProgressDialog();
            progress.Show();

            DataBase db = new DataBase();
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
                CurrentUser.Id = table.Rows[0]["id"].ToString();
                CurrentUser.fname = table.Rows[0]["fname"].ToString();
                CurrentUser.lname = table.Rows[0]["lname"].ToString();
                CurrentUser.UserName = table.Rows[0]["UserName"].ToString();
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
        public bool signin(string Username, string Password, string id, string fname, string lname, Image image)
        {
            DataBase db = new DataBase();
            try
            {
                SqlCommand insertCommand = new SqlCommand(
                    "INSERT INTO Users (UserName, Password, id, fname, lname, pic)" +
                    "VALUES (@username, @password, @id, @fname, @lname, @pic)"
                    , db.Connection);


                db.openConnection();

                if (CheckUserName(Username) == true)
                {
                    insertCommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = Username;
                    insertCommand.Parameters.Add("@password", SqlDbType.NVarChar).Value = Password;
                    insertCommand.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
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
        public bool CheckUserName(string username)
        {
            DataBase db = new DataBase();
            try
            {
                SqlCommand checkCommand = new SqlCommand(
                    "SELECT * FROM Users " +
                    "WHERE UserName = @username"
                    , db.Connection);
                checkCommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                db.openConnection();
                if(checkCommand.ExecuteNonQuery() < 1)
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
        public bool CheckPassword(string password)
        {
            DataBase db = new DataBase();
            try
            {
                SqlCommand checkCommand = new SqlCommand(
                    "SELECT * FROM Users " +
                    "where UserName = @User AND Password = @Pass"
                    , db.Connection);
                checkCommand.Parameters.Add("@User", SqlDbType.NVarChar).Value = CurrentUser.UserName;
                checkCommand.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = password;
                db.openConnection();
                if (checkCommand.ExecuteNonQuery() > 1)
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
        public bool editProfile(string Username, string Password, string id, string fname, string lname, Image image)
        {
            return true;
        }
    }
}
