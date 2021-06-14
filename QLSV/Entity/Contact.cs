﻿using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using QLSV.Data;
using QLSV.Entity;

namespace QLSV.Entity
{
    //THIEN
    class Contact
    {
        DataBase db = new DataBase();
        //tạo proceduce
        public bool InsertContact(string fname, string lname, int group, string phone, string email, string address, Image picture, int user_id)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Contact (fname, lname, [group], phone, email, address, picture, user_id) " +
                                                "VALUES (@fname, @lname, @group, @phone, @email, @address, @picture, @user_id)", db.Connection);

            command.Parameters.Add("@fname", SqlDbType.Text).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.Text).Value = lname;
            command.Parameters.Add("@group", SqlDbType.Int).Value = group;
            command.Parameters.Add("@phone", SqlDbType.Text).Value = phone;
            command.Parameters.Add("@email", SqlDbType.Text).Value = email;
            command.Parameters.Add("@address", SqlDbType.Text).Value = address;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = new Picture(picture).toByteArray();
            command.Parameters.Add("@user_id", SqlDbType.Int).Value = user_id;

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
        //tạo proceduce
        public bool UpdateContact(int id, string fname, string lname, string group, string phone, string email, string address, Image picture)
        {
            SqlCommand command = new SqlCommand("UPDATE Contact " +
                                                "SET " +
                                                "fname=@fname," +
                                                "lname=@lname," +
                                                "[group]=@group," +
                                                "phone=@phone," +
                                                "email=@email," +
                                                "address=@address," +
                                                "picture=@picture " +
                                                "WHERE id=@id",
                                                db.Connection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.Text).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.Text).Value = lname;
            command.Parameters.Add("@group", SqlDbType.Text).Value = group;
            command.Parameters.Add("@phone", SqlDbType.Text).Value = phone;
            command.Parameters.Add("@email", SqlDbType.Text).Value = email;
            command.Parameters.Add("@address", SqlDbType.Text).Value = address;
            command.Parameters.Add("@picture", SqlDbType.Image).Value = new Picture(picture).toByteArray();

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
        //tạo proceduce
        public bool DeleteContact(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Contact WHERE id=@id", db.Connection);
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

        public DataTable GetTable(string query)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand(query, db.Connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Contact");
            db.closeConnection();

            DataTable table = dataSet.Tables["Contact"];
            return table;
        }
        //tạo proceduce
        public DataTable SelectContactList()
        {
            string query = "SELECT * FROM Contact";
            return this.GetTable(query);
        }
        //tạo proceduce
        public DataTable GetContactByID(int id)
        {
            string query = $"SELECT * FROM Contact WHERE id = {id}";
            return this.GetTable(query);
        }
        //tạo proceduce
        public DataTable GetContactByGroup(string group)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Contact WHERE CAST([group] AS NVARCHAR) = @group", db.Connection);
            command.Parameters.Add("@group", SqlDbType.NVarChar).Value = group;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //tạo proceduce
        public DataTable getUserContact(int user_id)
        {
            try
            {
                string query = "SELECT * FROM Contact Where user_id = " + user_id.ToString();
                return this.GetTable(query);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
