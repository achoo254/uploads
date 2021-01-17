using MySql.Data.MySqlClient;
using NhacViecWinform.DAL;
using System;
using System.Data;

namespace HoTroNhacViecWinform.DAO
{
    internal class TrungTamDAO
    {
        private dbConnectionMySQL conn = new dbConnectionMySQL();

        public DataTable LayTatCaTrungTamDAO()
        {
            string query = string.Format("select * from trungtam");
            MySqlParameter[] MySqlParameters = new MySqlParameter[0];
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable LayTrungTamTheoIdDAO(int id)
        {
            string query = string.Format("select * from trungtam where id = @id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable LayTrungTamTheoIdTaiKhoanDAO(int taikhoan_id)
        {
            string query = string.Format("select tt.id, tt.ten from trungtam as tt inner join users as u on u.trungtam_id = tt.id where u.id = @taikhoan_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@taikhoan_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(taikhoan_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }
    }
}