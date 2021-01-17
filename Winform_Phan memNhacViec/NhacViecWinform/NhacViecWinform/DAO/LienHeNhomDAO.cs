using MySql.Data.MySqlClient;
using NhacViecWinform.DAL;
using System;
using System.Data;

namespace NhacViecWinform.DAO
{
    internal class LienHeNhomDAO
    {
        private dbConnectionMySQL conn = new dbConnectionMySQL();

        public DataTable LayTatCaThanhVienNhanNhomDAO(int nguoitao_id)
        {
            string query = string.Format("select u.id, concat(u.fullname, ' - ', bp.ten) as fullname from users as u inner join bophan as bp on bp.id = u.bophan_id where u.id <> @nguoitao_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@nguoitao_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(nguoitao_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable LayTatCaNhomNeuTrongNhomDAO(string nguoinhan_id, int nguoigui_id)
        {
            string query = string.Format("select id, tieude, thongbao, nguoinhan_id FROM lienhe_nhom where find_in_set(@nguoigui_id, replace(nguoinhan_id, ' ' ,'')) or nguoitao_id = @nguoigui_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@nguoinhan_id", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(nguoinhan_id);
            MySqlParameters[1] = new MySqlParameter("@nguoigui_id", MySqlDbType.Int32);
            MySqlParameters[1].Value = Convert.ToString(nguoigui_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable ThemNhomMoiDAO(string tieude, int nguoitao_id, string nguoinhan_id, byte thongbao)
        {
            string query = string.Format("insert into lienhe_nhom (tieude, nguoitao_id, nguoinhan_id, thongbao) values (@tieude, @nguoitao_id, @nguoinhan_id, @thongbao)");
            MySqlParameter[] MySqlParameters = new MySqlParameter[4];
            MySqlParameters[0] = new MySqlParameter("@tieude", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(tieude);
            MySqlParameters[1] = new MySqlParameter("@nguoitao_id", MySqlDbType.Int32);
            MySqlParameters[1].Value = Convert.ToString(nguoitao_id);
            MySqlParameters[2] = new MySqlParameter("@nguoinhan_id", MySqlDbType.VarChar);
            MySqlParameters[2].Value = Convert.ToString(nguoinhan_id);
            MySqlParameters[3] = new MySqlParameter("@thongbao", MySqlDbType.Byte);
            MySqlParameters[3].Value = Convert.ToString(thongbao);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public void CapNhatThongBaoDAO(int lienhe_nhom_id, byte thongbao)
        {
            string query = string.Format("update lienhe_nhom set thongbao = @thongbao where id = @lienhe_nhom_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@lienhe_nhom_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(lienhe_nhom_id);
            MySqlParameters[1] = new MySqlParameter("@thongbao", MySqlDbType.Byte);
            MySqlParameters[1].Value = Convert.ToString(thongbao);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public DataTable LayHienThiThanhVienNhomTheoIdDAO(int lienhe_nhom_id)
        {
            string query = string.Format("select lhn.id, u.fullname from users as u inner join lienhe_nhom as lhn on find_in_set(u.id, replace(lhn.nguoinhan_id, ' ','')) where lhn.id = @lienhe_nhom_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@lienhe_nhom_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(lienhe_nhom_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }
    }
}