using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV.AppForm;
using QLSV.Data;

namespace QLSV.Entity
{
    class studentManager
    {
        DataBase dataBase;
        public studentManager()
        {
            dataBase = new DataBase();
        }
        public bool login(string username, string password)
        {
            ProgressDialog progress = new ProgressDialog();
            progress.Show();

            DataBase db = new DataBase();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            db.openConnection();
            SqlCommand cm = new SqlCommand(
                "SELECT * FROM studentManager WHERE userName = @User AND password = @Pass", db.Connection);
            cm.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            cm.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;
            adapter.SelectCommand = cm;

            progress.Bar.Value = 50;

            adapter.Fill(table);

            progress.Bar.Value = 100;

            db.closeConnection();

            progress.Close();

            if (table.Rows.Count > 0)
            {
                CurrentUser.isAdmin = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
