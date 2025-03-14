using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace TKG
{
    internal class PurchaseController
    {
        public void Insert(Purchase purchase)
        {
            Connection connection = new Connection();
            connection.Connect().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO tkg.Purchase (number, date, hour, User_id_user, User_user_type_id_user_type) VALUES(@number, GETDATE() , CURRENT_TIMESTAMP, @User_id_user, @User_user_type_id_user_type)";
                cmd.Connection = connection.connection;
                cmd.Parameters.Add("@number", MySqlDbType.Int32).Value = purchase.Number;
                cmd.Parameters.Add("@User_id_user", MySqlDbType.Int32).Value = purchase.User_id_user;
                cmd.Parameters.Add("@User_user_type_id_user_type", MySqlDbType.Int32).Value = purchase.User_type;
                cmd.ExecuteNonQuery();
                connection.connection.Close();
            }
        }
        public DataTable GetAllRows()
        {
            DataTable dt = new DataTable();
            Connection connection = new Connection();
            String sql = "SELECT id_purchase as Id_compra, number as Numero_factura, date as Fecha, hour as Hora, User_id_user as Id_usuario, User_user_type_id_user_type as Tipo_usuario from tkg.Purchase";
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, connection.Connect());
            mda.Fill(dt);
            return dt;
        }
        public DataTable filter(String search_value)
        {
            DataTable dt = new DataTable();
            Connection connection = new Connection();
            string sql = "SELECT id_purchase as Id_compra, number as Numero_factura, date as Fecha, hour as Hora, User_id_user as Id_usuario, User_user_type_id_user_type as Tipo_usuario from tkg.Purchase where id_purchase like ('%" + search_value + "%')";
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, connection.Connect());
            mda.Fill(dt);
            return dt;
        }
    }
}
