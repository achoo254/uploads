using MySql.Data.MySqlClient;
using NhacViecWinform.DAL;
using System;
using System.Data;

namespace NhacViecWinform.DAO
{
    internal class KB_CongViecDAO
    {
        private dbConnectionMySQL conn = new dbConnectionMySQL();

        public DataTable ThemTheoBoPhanDAO(int bophan_id)
        {
            string query = string.Format("SELECT u.id, username, fullname, roles, email, phone, bp.ten as tenbophan, cd.ten as tenchucdanh, hinhanh FROM users as u inner join bophan as bp on u.bophan_id = bp.id inner join chucdanh as cd on u.chucdanh_id = cd.id where u.bophan_id = @bophan_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@bophan_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(bophan_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable ThemTheoThanhVienDAO()
        {
            string query = string.Format("SELECT u.id, fullname, bp.ten as tenbophan, cd.ten as tenchucdanh FROM users as u inner join bophan as bp on u.bophan_id = bp.id inner join chucdanh as cd on u.chucdanh_id = cd.id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[0];
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable HienThiCongViecDaGuiDAO(int nguoigui_id)
        {
            string query = string.Format("SELECT tt.id as 'tt_id', tt.tieude as 'tt_tieude', cv.id as 'cv_id', cv.tieude, n.tieude as 'n_tieude', n.ma_mau as ma_mau, cv.ngaytao, u.fullname, (CHAR_LENGTH(kb_congviec_chitiet_id) - CHAR_LENGTH(REPLACE(kb_congviec_chitiet_id, ',', '')) + 1) as 'dem_tongcongviec', (CHAR_LENGTH(kb_nguoinhan_id) - CHAR_LENGTH(REPLACE(kb_nguoinhan_id, ',', '')) + 1) as 'dem_thanhvien' FROM kb_trangthai as tt inner join kb_congviec as cv on tt.id = cv.kb_trangthai_id inner join kb_nhan as n on cv.kb_nhan_id = n.id inner join users as u on u.id = cv.kb_nguoigui_id where cv.kb_nguoigui_id = @nguoigui_id order by tt_id asc");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@nguoigui_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(nguoigui_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable HienThiCongViecDaNhanDAO(string nguoinhan_id)
        {
            string query = string.Format("SELECT tt.id as 'tt_id', tt.tieude as 'tt_tieude', cv.id as 'cv_id', cv.tieude, n.tieude as 'n_tieude', n.ma_mau as ma_mau, cv.ngaytao, u.fullname as 'nguoigui', (CHAR_LENGTH(kb_congviec_chitiet_id) - CHAR_LENGTH(REPLACE(kb_congviec_chitiet_id, ',', '')) + 1) as 'dem_tongcongviec', (CHAR_LENGTH(kb_nguoinhan_id) - CHAR_LENGTH(REPLACE(kb_nguoinhan_id, ',', '')) + 1) as 'dem_thanhvien' FROM kb_trangthai as tt inner join kb_congviec as cv on tt.id = cv.kb_trangthai_id inner join kb_nhan as n on cv.kb_nhan_id = n.id inner join users as u on u.id = cv.kb_nguoigui_id where FIND_IN_SET(@nguoinhan_id, cv.kb_nguoinhan_id) order by tt_id asc");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@nguoinhan_id", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(nguoinhan_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable HienThiCongViecTrongCapNhatCongViecDAO(string nguoinhan_id, int congviec_id)
        {
            string query = string.Format("SELECT tt.id as 'tt_id', tt.tieude as 'tt_tieude', cv.id as 'cv_id', cv.tieude, n.tieude as 'n_tieude', n.ma_mau as ma_mau, (CHAR_LENGTH(kb_congviec_chitiet_id) - CHAR_LENGTH(REPLACE(kb_congviec_chitiet_id, ',', '')) + 1) as 'dem_tongcongviec', (CHAR_LENGTH(kb_nguoinhan_id) - CHAR_LENGTH(REPLACE(kb_nguoinhan_id, ',', '')) + 1) as 'dem_thanhvien' FROM kb_trangthai as tt inner join kb_congviec as cv on tt.id = cv.kb_trangthai_id inner join kb_nhan as n on cv.kb_nhan_id = n.id where FIND_IN_SET(@nguoinhan_id, cv.kb_nguoinhan_id) order by tt_id asc");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@nguoinhan_id", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(nguoinhan_id);
            MySqlParameters[1] = new MySqlParameter("@congviec_id", MySqlDbType.Int32);
            MySqlParameters[1].Value = Convert.ToString(congviec_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public void ThemCongViecDAO(string tieude, string mota, string ngaytao, string congviecchitiet_id, int nguoigui_id, string nguoinhan_id, int nhan_id, int trangthai_id)
        {
            string query = string.Format("insert into kb_congviec (tieude, mota, ngaytao, kb_congviec_chitiet_id, kb_nguoigui_id, kb_nguoinhan_id, kb_nhan_id, kb_trangthai_id) values (@tieude, @mota, @ngaytao, @congviecchitiet_id, @nguoigui_id, @nguoinhan_id, @nhan_id, @trangthai_id)");
            MySqlParameter[] MySqlParameters = new MySqlParameter[8];
            MySqlParameters[0] = new MySqlParameter("@tieude", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(tieude);
            MySqlParameters[1] = new MySqlParameter("@mota", MySqlDbType.MediumText);
            MySqlParameters[1].Value = Convert.ToString(mota);
            MySqlParameters[2] = new MySqlParameter("@ngaytao", MySqlDbType.DateTime);
            MySqlParameters[2].Value = Convert.ToString(ngaytao);
            MySqlParameters[3] = new MySqlParameter("@congviecchitiet_id", MySqlDbType.VarChar);
            MySqlParameters[3].Value = Convert.ToString(congviecchitiet_id);
            MySqlParameters[4] = new MySqlParameter("@nguoigui_id", MySqlDbType.Int32);
            MySqlParameters[4].Value = Convert.ToString(nguoigui_id);
            MySqlParameters[5] = new MySqlParameter("@nguoinhan_id", MySqlDbType.VarChar);
            MySqlParameters[5].Value = Convert.ToString(nguoinhan_id);
            MySqlParameters[6] = new MySqlParameter("@nhan_id", MySqlDbType.Int32);
            MySqlParameters[6].Value = Convert.ToString(nhan_id);
            MySqlParameters[7] = new MySqlParameter("@trangthai_id", MySqlDbType.Int32);
            MySqlParameters[7].Value = Convert.ToString(trangthai_id);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public void SuaCongViecDAO(string tieude, string mota, string ngaytao, string congviecchitiet_id, int nguoigui_id, string nguoinhan_id, int nhan_id)
        {
            string query = string.Format("update kb_congviec as cv_main inner join (select id from kb_congviec where kb_nguoigui_id = @nguoigui_id order by id desc limit 1) as cv on cv_main.id = cv.id set tieude = @tieude, mota = @mota, ngaytao = @ngaytao, kb_congviec_chitiet_id = @congviecchitiet_id, kb_nguoigui_id = @nguoigui_id, kb_nguoinhan_id = @nguoinhan_id, kb_nhan_id = @nhan_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[7];
            MySqlParameters[0] = new MySqlParameter("@tieude", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(tieude);
            MySqlParameters[1] = new MySqlParameter("@mota", MySqlDbType.MediumText);
            MySqlParameters[1].Value = Convert.ToString(mota);
            MySqlParameters[2] = new MySqlParameter("@ngaytao", MySqlDbType.DateTime);
            MySqlParameters[2].Value = Convert.ToString(ngaytao);
            MySqlParameters[3] = new MySqlParameter("@congviecchitiet_id", MySqlDbType.VarChar);
            MySqlParameters[3].Value = Convert.ToString(congviecchitiet_id);
            MySqlParameters[4] = new MySqlParameter("@nguoigui_id", MySqlDbType.Int32);
            MySqlParameters[4].Value = Convert.ToString(nguoigui_id);
            MySqlParameters[5] = new MySqlParameter("@nguoinhan_id", MySqlDbType.VarChar);
            MySqlParameters[5].Value = Convert.ToString(nguoinhan_id);
            MySqlParameters[6] = new MySqlParameter("@nhan_id", MySqlDbType.Int32);
            MySqlParameters[6].Value = Convert.ToString(nhan_id);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }
    }
}