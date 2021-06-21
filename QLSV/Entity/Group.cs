using System.Data;
using System.Data.SqlClient;
using QLSV.Data;

namespace QLSV.Entity
{
    //THONG
    class Group
    {
        DataBase db = new DataBase();
        //tạo proceduce
        public bool InsertGroup(string name, int user_id)
        {
            SqlCommand command = new SqlCommand("exec InsertUser_Group @name, @user_id", db.Connection);

            command.Parameters.Add("@name", SqlDbType.Text).Value = name;
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
        public bool UpdateGroup(int id, string name, int user_id)
        {
            SqlCommand command = new SqlCommand("exec UpdateUser_Group @name, @user_id, @id",
                                                db.Connection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.Text).Value = name;
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
        public bool DeleteGroup(int id, int user_id)
        {
            try
            {
                SqlCommand deleteCmd = new SqlCommand("exec DeleteUser_Group @id, @user_id", db.Connection);
                deleteCmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                deleteCmd.Parameters.Add("@user_id", SqlDbType.Int).Value = user_id;

                db.openConnection();

                if (deleteCmd.ExecuteNonQuery() > 0)
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
            catch (System.Exception)
            {

                throw;
            }
        }
        //tạo function
        public bool CheckGroupExist(string name)
        {
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = db.Connection;
                command.CommandText = "SELECT [dbo].CheckGroupExist_Group(@name)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

                return (bool)command.ExecuteScalar();
            }
            catch (System.Exception)
            {
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
            adapter.Fill(dataSet, "Group");
            db.closeConnection();

            DataTable table = dataSet.Tables["Group"];
            return table;
        }
        //tạo proceduce
        public DataTable GetAllGroup()
        {
            string query = "exec GetAll_Group";
            return this.GetTable(query);
        }
        //tạo proceduce
        public DataTable getAllContactInGroup(int id)
        {
            db.openConnection();
            SqlCommand command = new SqlCommand("exec GetAllContact_Group @id", db.Connection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            db.closeConnection();

            return table;
        }
    }
}
