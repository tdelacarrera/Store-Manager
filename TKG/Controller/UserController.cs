using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections;


namespace TKG
{
    internal class UserController
    {

        public void Insert(User user)
        {
            Connection connection = new Connection();
            connection.Connect().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO User (name, email, rut, username, password, state, User_type_id_user_type) VALUES(@name, @email, @rut, @username, @password, @state, @User_type_id_user_type)";
                cmd.Connection = connection.connection;
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = user.Name;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = user.Email;
                cmd.Parameters.Add("@rut", MySqlDbType.VarChar).Value = user.Rut;
                cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = user.Username;
                cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = user.Password;
                cmd.Parameters.Add("@state", MySqlDbType.Int32).Value = user.State;
                cmd.Parameters.Add("@User_type_id_user_type", MySqlDbType.Int32).Value = user.User_type_id;
                cmd.ExecuteNonQuery();
                connection.connection.Close();
            }
        }


        public void Delete(int id)
        {
            Connection connection = new Connection();
            connection.Connect().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE User SET state = 0 WHERE id_user = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection.connection;
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                cmd.ExecuteNonQuery();
                connection.connection.Close();
            }
        }
        public void Modify(User user)
        {
            Connection connection = new Connection();
            connection.Connect().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE User SET name = @name, email = @email, rut = @rut, username = @username, password = @password, state = @state, User_type_id_user_type = @User_type_id_user_type WHERE id_user = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection.connection;
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = user.Id;
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = user.Name;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = user.Email;
                cmd.Parameters.Add("@rut", MySqlDbType.VarChar).Value = user.Rut;
                cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = user.Username;
                cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = user.Password;
                cmd.Parameters.Add("@state", MySqlDbType.Int32).Value = user.State;
                cmd.Parameters.Add("@User_type_id_user_type", MySqlDbType.Int32).Value = user.User_type_id;
                cmd.ExecuteNonQuery();
                connection.connection.Close();

            }
        }
        public DataTable GetAllRows()
        {
            DataTable dt = new DataTable();
            Connection connection = new Connection();
            String sql = "SELECT id_user as Id_usuario, username as Usuario, name as Nombre,email,rut as Rut,state as Estado,User_type_id_user_type as Id_tipo_usuario from User  WHERE state = 1 AND username != 'admin'";
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, connection.Connect());
            mda.Fill(dt);
            return dt;
        }
        public bool Login(String username, String password)
         {
             MySqlDataReader reader;
             Connection connection = new Connection();
             connection.Connect().Open();
             using (MySqlCommand cmd = new MySqlCommand())
             {
                 cmd.CommandText = "SELECT * from User WHERE username = @username AND password = @password AND state = 1";
                 cmd.CommandType = CommandType.Text;
                 cmd.Connection = connection.connection;
                 cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                 cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
                 cmd.ExecuteNonQuery();
                 reader = cmd.ExecuteReader();
            }
             if (reader.HasRows)
             {
                connection.connection.Close();
                return true;
             }
             else
             {
                connection.connection.Close();
                return false;

             }
         }

            public DataTable filter(String search_username)
        {
            DataTable dt = new DataTable();
            Connection connection = new Connection();
            string sql = "SELECT id_user as Id_usuario, username as Usuario, name as Nombre,email,rut as Rut,state as Estado,User_type_id_user_type as Id_tipo_usuario from User WHERE username like ('%" + search_username + "%')  AND state = 1";
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, connection.Connect());
            mda.Fill(dt);
            return dt;
        }
        public bool Exists(String username)
        {
            Connection connection = new Connection();
            connection.Connect().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT count(*) from User WHERE username = @username  AND state = 1";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection.connection;
                cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                if (Convert.ToInt32(cmd.ExecuteScalar()) >= 1)
                {
                    connection.connection.Close();
                    return true;
                }
                else
                {
                    connection.connection.Close();
                    return false;
                }

            }

        }
        public int GetId(String username)
        {
            ArrayList data = new ArrayList();
            MySqlDataReader reader;
            Connection connection = new Connection();
            connection.Connect().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT id_user from user WHERE username = @username";
                cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection.connection;
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
            }
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    data.Add(reader.GetValue(0));
                }
                connection.connection.Close();
                return Convert.ToInt32(data[0]);
            }
            else
            {
                connection.connection.Close();
                return -1;

            }
        }
        public int GetUserType(String username)
        {
            ArrayList data = new ArrayList();
            MySqlDataReader reader;
            Connection connection = new Connection();
            connection.Connect().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT User_type_id_user_type from user WHERE username = @username";
                cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection.connection;
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
            }
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    data.Add(reader.GetValue(0));
                }
                connection.connection.Close();
                return Convert.ToInt32(data[0]);
            }
            else
            {
                connection.connection.Close();
                return -1;

            }
        }
    }
}
