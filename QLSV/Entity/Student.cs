using System;
using System.IO;
using QLSV.Data;
using System.Data.SqlClient;
using System.Data;

namespace QLSV.Entity
{
    class Student
    {
        public int ID { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public DateTime Bdate { get; set; }
        public bool Gender { get; set; } // true = male, false = female
        public string Phone { get; set; }
        public string Address { get; set; }
        public MemoryStream Picture { get; set; }
        public Student(int id = 0, string fname = "", string lname = "", 
            DateTime date = default, bool gender = true, string phone = "", string address = "", MemoryStream picture = default)
        {
            ID = id;
            Fname = fname;
            Lname = lname;
            Bdate = date;
            Gender = gender;
            Phone = phone;
            Address = address;
            Picture = picture;
        }
        public bool insertStudent(int id, string fname, string lname, DateTime date, bool gender, string phone, string address, MemoryStream picture)
        {
            DataBase mydb = new DataBase();
            SqlCommand command = new SqlCommand("INSERT INTO std (id, fname, Iname, bdate, gender, phone, " +
                "VALUES (@id, @fn, @ln, @bdt, @gd, @phn, @adrs, @pic)", mydb.Connection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = date;
            command.Parameters.Add("@gd", SqlDbType.Bit).Value = gender;
            command.Parameters.Add("@ohn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
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
        public bool insertStudent()
        {
            return insertStudent(ID, Fname, Lname, Bdate, Gender, Phone, Address, Picture);
        }
    }
}
