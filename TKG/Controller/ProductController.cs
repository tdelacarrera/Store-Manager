using System;
using System.Data;
using MySql.Data.MySqlClient;


namespace TKG
{
    internal class ProductController
    {
        public void Insert(Product product)
        {
            Connection connection = new Connection();
            connection.Connect().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO tkg.product (name, price, stock, state, Product_family_id_product_family) VALUES(@name, @price, @stock, @state, @Product_family_id_product_family)";
                cmd.Connection = connection.connection;
                cmd.Parameters.Add("@Product_family_id_product_family", MySqlDbType.VarChar).Value = product.Product_family_id;
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = product.Name;
                cmd.Parameters.Add("@price", MySqlDbType.Int32).Value = product.Price;
                cmd.Parameters.Add("@stock", MySqlDbType.Int32).Value = product.Stock;
                cmd.Parameters.Add("@state", MySqlDbType.VarChar).Value = product.State;
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
                cmd.CommandText = "UPDATE tkg.product SET state = 0 WHERE id_product = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection.connection;
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                cmd.ExecuteNonQuery();
                connection.connection.Close();
            }
        }
        public void Modify(Product product) {
            Connection connection = new Connection();
            connection.Connect().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE tkg.product SET name = @name, price = @price, stock = @stock, state = @state, Product_family_id_product_family = @Product_family_id_product_family  WHERE id_product = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection.connection;
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = product.Id;
                cmd.Parameters.Add("@Product_family_id_product_family", MySqlDbType.Int32).Value = product.Product_family_id;
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = product.Name;
                cmd.Parameters.Add("@price", MySqlDbType.Int32).Value = product.Price;
                cmd.Parameters.Add("@stock", MySqlDbType.Int32).Value = product.Stock;
                cmd.Parameters.Add("@state", MySqlDbType.VarChar).Value = product.State;
                cmd.ExecuteNonQuery();
                connection.connection.Close();
            }
        }
        public DataTable GetAllRows() {
            DataTable dt = new DataTable();
            Connection connection = new Connection();
            String sql = "SELECT id_product as Id_producto, name as Nombre, price as Precio, stock as Stock, state as Estado, Product_family_id_product_family as Id_familia_producto from tkg.product WHERE state = 1";
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, connection.Connect());
            mda.Fill(dt);
            return dt;
        }
        public DataTable filter(String search_name) {
            DataTable dt = new DataTable();
            Connection connection = new Connection();
            string sql = "SELECT id_product as Id_producto, name as Nombre, price as Precio, stock as Stock, state as Estado, Product_family_id_product_family as Id_familia_producto from tkg.product where name like ('%" + search_name + "%') AND state = 1";
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
                cmd.CommandText = "SELECT count(*) from tkg.product WHERE name = @name AND state = 1";
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
        public bool ExistsByProductFamilyId(int id)
        {
            Connection connection = new Connection();
            connection.Connect().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT count(*) from tkg.product WHERE Product_family_id_product_family = @Product_family_id_product_family AND state = 1";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection.connection;
                cmd.Parameters.Add("@Product_family_id_product_family", MySqlDbType.Int32).Value = id;
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
        public void Update_stock(int id, int amount) {
            Connection connection = new Connection();
            connection.Connect().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE tkg.product set stock += @amount  WHERE id_product = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection.connection;
                cmd.Parameters.Add("@amount", MySqlDbType.Int32).Value = amount;
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                cmd.ExecuteNonQuery();
                connection.connection.Close();
            }
        }
    }
}
