using MySql.Data.MySqlClient;
using NhacViecWinform.DAL;
using System;
using System.Data;

namespace NhacViecWinform.DAO
{
    internal class KB_NhanDAO
    {
        private dbConnectionMySQL conn = new dbConnectionMySQL();

        public DataTable LayTatCaNhanDAO()
        {
            string query = string.Format("select * from kb_nhan");
            MySqlParameter[] MySqlParameters = new MySqlParameter[0];
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable LayNhanTheoIdDAO(int nhan_id)
        {
            string query = string.Format("select * from kb_nhan where id = @nhan_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@nhan_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(nhan_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }
    }
}