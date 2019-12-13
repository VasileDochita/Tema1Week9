using System.Data.SqlClient;

namespace Tema1Week9
{
    public class ConnectionManager
    {
        private static SqlConnection connection = null;

        private ConnectionManager() { }

        

        public static SqlConnection GetConnection()
        {
            if (connection == null)
            {
                string connectionString = ConnectionManager.ConnectionString["week9t1"].ConnectionString;

               

                connection = new SqlConnection(connectionString);
                connection.Open();
            }

            return connection;
        }
    }
}
