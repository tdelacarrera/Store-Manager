using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace TKG
{
    internal class AuditController
    {

        public void Insert(Audit audit)
        {
            Connection connection = new Connection();
            connection.Connect().Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO Audit (date, hour, action) VALUES(CURRENT_DATE, CURRENT_TIME, @action)";
                cmd.Connection = connection.connection;
                cmd.Parameters.Add("@action", MySqlDbType.VarChar).Value = audit.Action;
                cmd.ExecuteNonQuery();
                connection.connection.Close();
            }
        }
        public DataTable GetAllRows()
        {
            DataTable dt = new DataTable();
            Connection connection = new Connection();
            String sql = "SELECT id_audit as Id_auditor, date as Fecha, hour as Hora, action as Accion from audit";
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, connection.Connect());
            mda.Fill(dt);
            return dt;
        }
        public DataTable filter(String search_value)
        {
            DataTable dt = new DataTable();
            Connection connection = new Connection();
            string sql = "SELECT id_audit as Id_auditor, date as Fecha, hour as Hora, action as Accion from audit where id_audit like ('%" + search_value +"%')";
            MySqlDataAdapter mda = new MySqlDataAdapter(sql, connection.Connect());
            mda.Fill(dt);
            return dt;
        }
    }
}