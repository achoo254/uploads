using MySql.Data.MySqlClient;
using NhacViecWinform.DAL;
using System;
using System.Data;

namespace NhacViecWinform.DAO
{
    internal class TonDongDAO
    {
        private dbConnectionMySQL conn = new dbConnectionMySQL();

        public DataTable LayDanhSachTrungTamDAO()
        {
            string query = string.Format("select id, ten from trungtam");
            MySqlParameter[] MySqlParameters = new MySqlParameter[0];
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable LayDanhSachTonDongDAO()
        {
            string query = string.Format("select td.id as 'tondong_id', tt.id as 'trungtam_id', tt.ten, tenkho, ngayhoso, tenvacxin, nguyennhan, hoantat, fullname from test_tondong as td inner join trungtam as tt on td.trungtam_id = tt.id inner join test_hoso as hs on td.hoso_id = hs.id inner join users as u on u.id = td.nguoitao_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[0];
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable LayDanhSachTonDongChiTietDAO(int tondong_id)
        {
            string query = string.Format("select td.id as 'tondong_id', tt.id as 'trungtam_id', tt.ten, tenkho, ngayhoso, tenvacxin, nguyennhan, hoso_id, hoantat, nguoitao_id from test_tondong as td inner join trungtam as tt on td.trungtam_id = tt.id where td.id = @tondong_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@tondong_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(tondong_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable ThemTonDongDAO(int trungtam_id, string tenkho, string ngayhoso, string tenvacxin, string nguyennhan, byte hoantat, int hoso_id, int nguoitao_id)
        {
            string query = string.Format("insert into test_tondong (trungtam_id, tenkho, ngayhoso, tenvacxin, nguyennhan, hoantat, hoso_id, nguoitao_id) values (@trungtam_id, @tenkho, @ngayhoso, @tenvacxin, @nguyennhan, @hoantat, @hoso_id, @nguoitao_id)");
            MySqlParameter[] MySqlParameters = new MySqlParameter[8];
            MySqlParameters[0] = new MySqlParameter("@trungtam_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(trungtam_id);
            MySqlParameters[1] = new MySqlParameter("@tenkho", MySqlDbType.Text);
            MySqlParameters[1].Value = Convert.ToString(tenkho);
            MySqlParameters[2] = new MySqlParameter("@ngayhoso", MySqlDbType.Date);
            MySqlParameters[2].Value = Convert.ToString(ngayhoso);
            MySqlParameters[3] = new MySqlParameter("@tenvacxin", MySqlDbType.Text);
            MySqlParameters[3].Value = Convert.ToString(tenvacxin);
            MySqlParameters[4] = new MySqlParameter("@nguyennhan", MySqlDbType.Text);
            MySqlParameters[4].Value = Convert.ToString(nguyennhan);
            MySqlParameters[5] = new MySqlParameter("@hoantat", MySqlDbType.Byte);
            MySqlParameters[5].Value = Convert.ToByte(hoantat);
            MySqlParameters[6] = new MySqlParameter("@hoso_id", MySqlDbType.Int32);
            MySqlParameters[6].Value = Convert.ToString(hoso_id);
            MySqlParameters[7] = new MySqlParameter("@nguoitao_id", MySqlDbType.Int32);
            MySqlParameters[7].Value = Convert.ToString(nguoitao_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable SuaTonDongDAO(int tondong_id, int trungtam_id, string tenkho, string ngayhoso, string tenvacxin, string nguyennhan, byte hoantat, int hoso_id, int nguoisua_id)
        {
            string query = string.Format("update test_tondong set trungtam_id = @trungtam_id, tenkho = @tenkho, ngayhoso = @ngayhoso, hoantat = @hoantat, tenvacxin = @tenvacxin, nguyennhan = @nguyennhan, hoso_id = @hoso_id, nguoitao_id = @nguoisua_id where id = @tondong_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[9];
            MySqlParameters[0] = new MySqlParameter("@trungtam_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(trungtam_id);
            MySqlParameters[1] = new MySqlParameter("@tenkho", MySqlDbType.Text);
            MySqlParameters[1].Value = Convert.ToString(tenkho);
            MySqlParameters[2] = new MySqlParameter("@ngayhoso", MySqlDbType.Date);
            MySqlParameters[2].Value = Convert.ToString(ngayhoso);
            MySqlParameters[3] = new MySqlParameter("@tenvacxin", MySqlDbType.Text);
            MySqlParameters[3].Value = Convert.ToString(tenvacxin);
            MySqlParameters[4] = new MySqlParameter("@nguyennhan", MySqlDbType.Text);
            MySqlParameters[4].Value = Convert.ToString(nguyennhan);
            MySqlParameters[5] = new MySqlParameter("@tondong_id", MySqlDbType.Int32);
            MySqlParameters[5].Value = Convert.ToString(tondong_id);
            MySqlParameters[6] = new MySqlParameter("@hoantat", MySqlDbType.Byte);
            MySqlParameters[6].Value = Convert.ToByte(hoantat);
            MySqlParameters[7] = new MySqlParameter("@hoso_id", MySqlDbType.Int32);
            MySqlParameters[7].Value = Convert.ToString(hoso_id);
            MySqlParameters[8] = new MySqlParameter("@nguoisua_id", MySqlDbType.Int32);
            MySqlParameters[8].Value = Convert.ToString(nguoisua_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }
    }
}