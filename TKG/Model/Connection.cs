using MySql.Data.MySqlClient;

namespace TKG
{
    internal class Connection
    {
        public MySqlConnection connection;
        public MySqlConnection Connect()
        {
            try
            {
                string host = "127.0.0.1";
                string db = "tkg";
                string user = "root";
                string password = "";
                string login = "server = " + host + "; user id = " + user + "; database = " + db + "; password = " + password;

                connection = new MySqlConnection(login);
                return connection;
            }
            catch (MySqlException e)
            {
                return null;

            }
        }
    }
}