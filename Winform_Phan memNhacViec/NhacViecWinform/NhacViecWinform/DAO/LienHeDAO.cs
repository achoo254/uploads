using MySql.Data.MySqlClient;
using NhacViecWinform.DAL;
using System;
using System.Data;

namespace NhacViecWinform.DAO
{
    internal class LienHeDAO
    {
        private dbConnectionMySQL conn = new dbConnectionMySQL();

        public DataTable LayNoiDungLienheTheoNhomDAO(int lienhe_nhom_id, string khoa_nguoigui_id)
        {
            string query = string.Format("SELECT u.id as nguoigui_id, lh.id, noidung, ngaygui, DATE_FORMAT(ngaygui,'%H:%i') as giogui, khoa FROM lienhe as lh inner join users as u on u.id = lh.nguoigui_id inner join lienhe_nhom as lhn on lh.lienhe_nhom_id = lhn.id where lienhe_nhom_id = @lienhe_nhom_id and find_in_set(@khoa_nguoigui_id, khoa)  = 0");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@lienhe_nhom_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(lienhe_nhom_id);
            MySqlParameters[1] = new MySqlParameter("@khoa_nguoigui_id", MySqlDbType.VarChar);
            MySqlParameters[1].Value = Convert.ToString(khoa_nguoigui_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable GuiTinNhanDAO(string noidung, int nguoigui_id, int lienhe_nhom_id, string ngaygui, string tennguoigui, string khoa)
        {
            string query = string.Format("insert into lienhe (noidung, nguoigui_id, lienhe_nhom_id, ngaygui, khoa) values (concat(@tennguoigui, '\n',@noidung), @nguoigui_id, @lienhe_nhom_id, @ngaygui, @khoa)");
            MySqlParameter[] MySqlParameters = new MySqlParameter[6];
            MySqlParameters[0] = new MySqlParameter("@noidung", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(noidung);
            MySqlParameters[1] = new MySqlParameter("@nguoigui_id", MySqlDbType.Int32);
            MySqlParameters[1].Value = Convert.ToString(nguoigui_id);
            MySqlParameters[2] = new MySqlParameter("@lienhe_nhom_id", MySqlDbType.Int32);
            MySqlParameters[2].Value = Convert.ToString(lienhe_nhom_id);
            MySqlParameters[3] = new MySqlParameter("@ngaygui", MySqlDbType.DateTime);
            MySqlParameters[3].Value = Convert.ToString(ngaygui);
            MySqlParameters[4] = new MySqlParameter("@tennguoigui", MySqlDbType.VarChar);
            MySqlParameters[4].Value = Convert.ToString(tennguoigui);
            MySqlParameters[5] = new MySqlParameter("@khoa", MySqlDbType.Text);
            MySqlParameters[5].Value = Convert.ToString(khoa);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable KhoaTinNhanDAO(int lienhe_nhom_id, string khoa, int nguoigui_id)
        {
            string query = string.Format("update lienhe set khoa = CONCAT_WS('',khoa, ',', @khoa) where lienhe_nhom_id = @lienhe_nhom_id and ngaygui <= now()");
            MySqlParameter[] MySqlParameters = new MySqlParameter[3];
            MySqlParameters[0] = new MySqlParameter("@lienhe_nhom_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(lienhe_nhom_id);
            MySqlParameters[1] = new MySqlParameter("@khoa", MySqlDbType.Text);
            MySqlParameters[1].Value = Convert.ToString(khoa);
            MySqlParameters[2] = new MySqlParameter("@nguoigui_id", MySqlDbType.Int32);
            MySqlParameters[2].Value = Convert.ToString(nguoigui_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }
    }
}