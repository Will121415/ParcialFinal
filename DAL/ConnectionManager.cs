using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ConnectionManager
    {
        internal SqlConnection SqlConnection;

        public ConnectionManager(string connectionString)
        {
            SqlConnection = new SqlConnection(connectionString);
        }


        public void OpenConnection()
        {
             SqlConnection.Open();
        }
        
        public void CloseConnection()
        {
            SqlConnection.Close();
        }
    }
}
