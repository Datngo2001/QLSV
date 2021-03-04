using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLSV.Data
{
    class DataBase
    {
        protected SqlConnection connection = new SqlConnection
            (@"Data Source=LAPTOP-CGKU0T3D;Initial Catalog=SinhVien;Integrated Security=True");
        public SqlConnection Connection
        {
            get { return connection; }
        }
        public void openConnection()
        {
            if ((connection.State == ConnectionState.Closed))
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if ((connection.State == ConnectionState.Open))
            {
                connection.Close();
            }
        }
    }
}
