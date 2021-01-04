using MySql.Data.MySqlClient;
using NhacViecWinform.DAL;
using System.Data;

namespace NhacViecWinform.DAO
{
    internal class HoSoDAO
    {
        private dbConnectionMySQL conn = new dbConnectionMySQL();

        public DataTable LayDanhSachHoSoDAO()
        {
            string query = string.Format("select id, ten from test_hoso");
            MySqlParameter[] sqlParameters = new MySqlParameter[0];
            return conn.ExecuteSqlString(query, sqlParameters);
        }
    }
}