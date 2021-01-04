using MySql.Data.MySqlClient;
using NhacViecWinform.DAL;
using System;
using System.Data;

namespace NhacViecWinform.DAO
{
    internal class TheoDoiDAO
    {
        private dbConnectionMySQL conn = new dbConnectionMySQL();

        public DataTable LayDanhSachTheoDoiDAO(int tondong_id)
        {
            string query = string.Format("select td.id, td.tondong_id, td.ngaytheodoi, td.tinhtrang, td.huongxuly from test_theodoi as td where td.tondong_id = @tondong_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@tondong_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(tondong_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public string LayNgayTheoDoiDAO(int tondong_id, string ngaytheodoi)
        {
            string query = string.Format("select ngaytheodoi from test_theodoi where tondong_id = @tondong_id and ngaytheodoi = @ngaytheodoi");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@tondong_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(tondong_id);
            MySqlParameters[1] = new MySqlParameter("@ngaytheodoi", MySqlDbType.Date);
            MySqlParameters[1].Value = Convert.ToString(ngaytheodoi);
            var check = conn.ExecuteScalarString(query, MySqlParameters);
            return check;
        }
        public DataTable LayTinhTrangHuongXuLyMoiNhatTheoDoiDAO(int tondong_id)
        {
            string query = string.Format("select tinhtrang, huongxuly from test_theodoi where tondong_id = @tondong_id order by ngaytheodoi desc limit 1");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@tondong_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(tondong_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable ThemTheoDoiDAO(int tondong_id, string ngaytheodoi, string tinhtrang, string huongxuly)
        {
            string query = string.Format("insert into test_theodoi (tondong_id, ngaytheodoi, tinhtrang, huongxuly) values (@tondong_id, @ngaytheodoi, @tinhtrang, @huongxuly)");
            MySqlParameter[] MySqlParameters = new MySqlParameter[4];
            MySqlParameters[0] = new MySqlParameter("@tondong_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(tondong_id);
            MySqlParameters[1] = new MySqlParameter("@tinhtrang", MySqlDbType.Text);
            MySqlParameters[1].Value = Convert.ToString(tinhtrang);
            MySqlParameters[2] = new MySqlParameter("@ngaytheodoi", MySqlDbType.Date);
            MySqlParameters[2].Value = Convert.ToString(ngaytheodoi);
            MySqlParameters[3] = new MySqlParameter("@huongxuly", MySqlDbType.Text);
            MySqlParameters[3].Value = Convert.ToString(huongxuly);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable SuaTheoDoiDAO(int tondong_id, string ngaytheodoi, string tinhtrang, string huongxuly)
        {
            string query = string.Format("update test_theodoi set ngaytheodoi = @ngaytheodoi, tinhtrang = @tinhtrang, huongxuly = @huongxuly where tondong_id = @tondong_id and ngaytheodoi = @ngaytheodoi");
            MySqlParameter[] MySqlParameters = new MySqlParameter[4];
            MySqlParameters[0] = new MySqlParameter("@tondong_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(tondong_id);
            MySqlParameters[1] = new MySqlParameter("@tinhtrang", MySqlDbType.Text);
            MySqlParameters[1].Value = Convert.ToString(tinhtrang);
            MySqlParameters[2] = new MySqlParameter("@huongxuly", MySqlDbType.Text);
            MySqlParameters[2].Value = Convert.ToString(huongxuly);
            MySqlParameters[3] = new MySqlParameter("@ngaytheodoi", MySqlDbType.Date);
            MySqlParameters[3].Value = Convert.ToString(ngaytheodoi);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }
    }
}