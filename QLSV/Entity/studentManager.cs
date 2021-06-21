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
    //DAT
    class studentManager
    {
        DataBase dataBase;
        public studentManager()
        {
            dataBase = new DataBase();
        }
        //tạo proceduce
        public bool login(string username, string password)
        {
            try
            {
                if (CurrentUser.isManager == true)
                {
                    dataBase.Connection = new SqlConnection
                        (@"Data Source=LAPTOP-CGKU0T3D;Initial Catalog=SinhVien;User ID=QLSV_Manager;Password=123");
                }
                else if (CurrentUser.isContact == true)
                {
                    dataBase.Connection = new SqlConnection
                        (@"Data Source=LAPTOP-CGKU0T3D;Initial Catalog=SinhVien;User ID=QLSV_Contact;Password=123");
                }

                ProgressDialog progress = new ProgressDialog();
                progress.Show();

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                dataBase.openConnection();
                SqlCommand cm = new SqlCommand(
                    "exec login_studentManager @User, @Pass", dataBase.Connection);
                cm.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
                cm.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;
                adapter.SelectCommand = cm;

                progress.Bar.Value = 50;

                adapter.Fill(table);

                progress.Bar.Value = 100;

                dataBase.closeConnection();

                progress.Close();

                if (table.Rows.Count > 0)
                {
                    CurrentUser.UserName = table.Rows[0]["username"].ToString().Trim();
                    CurrentUser.isAdmin = true;
                    return true;
                }
                else
                {
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
        //tạo function
        public bool CheckUserName(string username)
        {
            try
            {
                SqlCommand checkCommand = new SqlCommand(
                    "select CheckUserName_studentManager(@username)"
                    , dataBase.Connection);
                checkCommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                dataBase.openConnection();
                if ((bool)checkCommand.ExecuteScalar() == true)
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
                dataBase.closeConnection();
            }
        }
        //tạo function
        public bool CheckPassword(string password)
        {
            try
            {
                SqlCommand checkCommand = new SqlCommand(
                    "SELECT CheckPassword_studentManager(@User, @Pass)"
                    , dataBase.Connection);
                checkCommand.Parameters.Add("@User", SqlDbType.NVarChar).Value = CurrentUser.UserName;
                checkCommand.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = password;
                dataBase.openConnection();
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
                dataBase.closeConnection();
            }
        }
        //tạo proceduce
        public bool addNewAccount(string username, string password)
        {
            try
            {
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                dataBase.openConnection();
                SqlCommand cm = new SqlCommand(
                    "exec addNewAccount_studentManager @User, @Pass", dataBase.Connection);
                cm.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
                cm.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;
                if(cm.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
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
