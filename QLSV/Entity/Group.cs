using System.Data;
using System.Data.SqlClient;
using QLSV.Data;

namespace QLSV.Entity
{
    class Group
    {
        DataBase db = new DataBase();

        public bool InsertGroup(string name, int user_id)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Group] (name, user_id) " +
                                                "VALUES (@name, @user_id)", db.Connection);

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

        public bool UpdateGroup(int id, string name, int user_id)
        {
            SqlCommand command = new SqlCommand("UPDATE [Group] " +
                                                "SET " +
                                                "name=@name " +
                                                "WHERE id=@id " +
                                                "AND user_id=@user_id ",
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

        public bool DeleteGroup(int id, int user_id)
        {
            try
            {
                SqlCommand command1 = new SqlCommand("DELETE FROM Contact WHERE [group] = 1", db.Connection);
                command1.Parameters.Add("@id", SqlDbType.Int).Value = id;

                SqlCommand command2 = new SqlCommand("DELETE FROM [Group] WHERE id=@id AND user_id=@user_id", db.Connection);
                command2.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command2.Parameters.Add("@user_id", SqlDbType.Int).Value = user_id;

                db.openConnection();

                command1.ExecuteNonQuery();

                if (command2.ExecuteNonQuery() == 1)
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

        public bool CheckGroupExist(string name, string operation)
        {
            try
            {
                string query = "";
                SqlCommand command = new SqlCommand();

                if (operation == "add")
                {
                    query = "SELECT * FROM [Group] WHERE CAST(name AS NVARCHAR) = @name";
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                }
                else if (operation == "edit")
                {
                    query = "SELECT * FROM [Group] WHERE CAST(name AS NVARCHAR) = @name";
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                }

                command.Connection = db.Connection;
                command.CommandText = query;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
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

        public DataTable GetAllGroup()
        {
            string query = "SELECT * FROM [Group]";
            return this.GetTable(query);
        }
    }
}
