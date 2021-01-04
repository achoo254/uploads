using MySql.Data.MySqlClient;
using NhacViecWinform.DAL;
using System;
using System.Data;

namespace NhacViecWinform.DAO
{
    internal class ChucDanhDAO
    {
        private dbConnectionMySQL conn = new dbConnectionMySQL();

        public DataTable LayChucDanhTheoIdDAO(int id)
        {
            string query = string.Format("select * from chucdanh where id = @id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable LayTatCaChucDanhDAO()
        {
            string query = string.Format("select * from chucdanh");
            MySqlParameter[] MySqlParameters = new MySqlParameter[0];
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable LayChucDanhTheoIdTaiKhoanDAO(int taikhoan_id)
        {
            string query = string.Format("select cd.id, cd.ten from chucdanh as cd inner join users as u on u.chucdanh_id = cd.id where u.id = @taikhoan_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@taikhoan_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(taikhoan_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }
    }
}