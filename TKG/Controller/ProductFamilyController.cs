using System;
using System.Data;
using System.Collections;
using MySql.Data.MySqlClient;

namespace TKG
{
    internal class ProductFamilyController
    {
        public void Insert(ProductFamily productFamily)
        {
            Connection connection = new Connection();
            connection.Connect().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO tkg.Product_family (name, state) VALUES(@name, @state)";
                cmd.Connection = connection.connection;
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = productFamily.Name;
                cmd.Parameters.Add("@state", MySqlDbType.Int32).Value = productFamily.State;
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
                cmd.CommandText = "UPDATE tkg.Product_family SET state = 0 WHERE id_product_family = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection.connection;
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                cmd.ExecuteNonQuery();
                connection.connection.Close();
            }
        }
        public void Modify(ProductFamily productFamily)
        {
            Connection connection = new Connection();
            connection.Connect().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE tkg.Product_family SET name = @name, state = @state WHERE id_product_family = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection.connection;
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = productFamily.Id;
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = productFamily.Name;
                cmd.Parameters.Add("@state", MySqlDbType.Int32).Value = productFamily.State;
                cmd.ExecuteNonQuery();
                connection.connection.Close();

            }
        }
        public DataTable GetAllRows()
        {
            DataTable dt = new DataTable();
            Connection connection = new Connection();
            String sql = "SELECT id_product_family as Id_familia_producto, name as Nombre, state as Estado from tkg.Product_family WHERE state = 1";
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, connection.Connect());
            mda.Fill(dt);
            return dt;
        }
        public ArrayList GetAllNames()
        {
            ArrayList data = new ArrayList();
            MySqlDataReader reader;
            Connection connection = new Connection();
            connection.Connect().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT name from tkg.Product_family WHERE state = 1";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection.connection;
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
            }
            if (reader.HasRows)
            {
                while (reader.Read()) {
                    data.Add(reader.GetValue(0));
                }
                connection.connection.Close();
                return data;
            }
            else
            {
                connection.connection.Close();
                return data;

            }
        }
        public ArrayList GetName(int id)
        {
            ArrayList data = new ArrayList();
            MySqlDataReader reader;
            Connection connection = new Connection();
            connection.Connect().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT name from tkg.Product_family WHERE id_product_family = @id";
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
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
                return data;
            }
            else
            {
                connection.connection.Close();
                return data;

            }
        }
        public ArrayList GetId(String name)
        {
            ArrayList data = new ArrayList();
            MySqlDataReader reader;
            Connection connection = new Connection();
            connection.Connect().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT id_product_family from tkg.Product_family WHERE name = @name";
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
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
                return data;
            }
            else
            {
                connection.connection.Close();
                return data;

            }
        }
        public DataTable filter(String search_name)
        {
            DataTable dt = new DataTable();
            Connection connection = new Connection();
            string sql = "SELECT id_product_family as Id_familia_producto, name as Nombre, state as Estado from tkg.Product_family where name like ('%" + search_name + "%') AND state = 1";
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, connection.Connect());
            mda.Fill(dt);
            return dt;
        }
        public bool Exists(String name)
        {
            Connection connection = new Connection();
            connection.Connect().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT count(*) from tkg.Product_family WHERE name = @name AND state = 1";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection.connection;
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
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
    }
}
