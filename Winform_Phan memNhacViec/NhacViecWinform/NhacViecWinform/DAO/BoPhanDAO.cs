using MySql.Data.MySqlClient;
using NhacViecWinform.DAL;
using System;
using System.Data;

namespace NhacViecWinform.DAO
{
    internal class BoPhanDAO
    {
        private dbConnectionMySQL conn = new dbConnectionMySQL();

        public DataTable LayTatCaBoPhanDAO()
        {
            string query = string.Format("select * from bophan");
            MySqlParameter[] MySqlParameters = new MySqlParameter[0];
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable LayBoPhanTheoIdDAO(int id)
        {
            string query = string.Format("select * from bophan where id = @id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable LayBoPhanTheoIdTaiKhoanDAO(int taikhoan_id)
        {
            string query = string.Format("select bp.id, bp.ten from bophan as bp inner join users as u on u.bophan_id = bp.id where u.id = @taikhoan_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@taikhoan_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(taikhoan_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }
    }
}