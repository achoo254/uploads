using MySql.Data.MySqlClient;
using NhacViecWinform.DAL;
using System;
using System.Data;

namespace NhacViecWinform.DAO
{
    internal class HuongDanDAO
    {
        private dbConnectionMySQL conn = new dbConnectionMySQL();

        public DataTable LayHuongDanBaoCaoTheoPhanLoaiDAO(string phanloai_baocao, string phanloai_danhmuc)
        {
            string query = string.Format("select hd.id, tieude, phanloai_baocao, phanloai_danhmuc, chitiet, ngaytao, ngaycapnhat, taikhoan_id, u.fullname from huongdan as hd inner join users as u on u.id = hd.taikhoan_id where phanloai_baocao = @phanloai_baocao and phanloai_danhmuc = @phanloai_danhmuc order by ngaycapnhat DESC");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@phanloai_baocao", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(phanloai_baocao);
            MySqlParameters[1] = new MySqlParameter("@phanloai_danhmuc", MySqlDbType.VarChar);
            MySqlParameters[1].Value = Convert.ToString(phanloai_danhmuc);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable LayHuongDanBaoCaoTheoIdDAO(int huongdan_id)
        {
            string query = string.Format("select hd.id, tieude, phanloai_baocao, phanloai_danhmuc, chitiet, ngaytao, ngaycapnhat, taikhoan_id, u.fullname from huongdan as hd inner join users as u on u.id = hd.taikhoan_id where hd.id = @huongdan_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@huongdan_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(huongdan_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public void TaoHuongDanMoiDAO(string tieude, string phanloai_baocao, string phanloai_danhmuc, string chitiet, string ngaytao, string ngaycapnhat, int taikhoan_id)
        {
            string query = string.Format("insert into huongdan (tieude, phanloai_baocao, phanloai_danhmuc, chitiet, ngaytao, ngaycapnhat, taikhoan_id) values (@tieude, @phanloai_baocao, @phanloai_danhmuc, @chitiet, @ngaytao, @ngaycapnhat, @taikhoan_id)");
            MySqlParameter[] MySqlParameters = new MySqlParameter[7];
            MySqlParameters[0] = new MySqlParameter("@tieude", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(tieude);
            MySqlParameters[1] = new MySqlParameter("@phanloai_baocao", MySqlDbType.VarChar);
            MySqlParameters[1].Value = Convert.ToString(phanloai_baocao);
            MySqlParameters[2] = new MySqlParameter("@phanloai_danhmuc", MySqlDbType.VarChar);
            MySqlParameters[2].Value = Convert.ToString(phanloai_danhmuc);
            MySqlParameters[3] = new MySqlParameter("@chitiet", MySqlDbType.MediumText);
            MySqlParameters[3].Value = Convert.ToString(chitiet);
            MySqlParameters[4] = new MySqlParameter("@ngaytao", MySqlDbType.Date);
            MySqlParameters[4].Value = Convert.ToString(ngaytao);
            MySqlParameters[5] = new MySqlParameter("@taikhoan_id", MySqlDbType.Int32);
            MySqlParameters[5].Value = Convert.ToString(taikhoan_id);
            MySqlParameters[6] = new MySqlParameter("@ngaycapnhat", MySqlDbType.Date);
            MySqlParameters[6].Value = Convert.ToString(ngaycapnhat);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public void SuaHuongDanDAO(int id, string tieude, string phanloai_baocao, string phanloai_danhmuc, string chitiet, string ngaycapnhat, int taikhoan_id)
        {
            string query = string.Format("update huongdan set tieude = @tieude , phanloai_baocao = @phanloai_baocao, phanloai_danhmuc = @phanloai_danhmuc, chitiet = @chitiet, ngaycapnhat = @ngaycapnhat where taikhoan_id = @taikhoan_id and id = @id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[7];
            MySqlParameters[0] = new MySqlParameter("@tieude", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(tieude);
            MySqlParameters[1] = new MySqlParameter("@phanloai_baocao", MySqlDbType.VarChar);
            MySqlParameters[1].Value = Convert.ToString(phanloai_baocao);
            MySqlParameters[2] = new MySqlParameter("@phanloai_danhmuc", MySqlDbType.VarChar);
            MySqlParameters[2].Value = Convert.ToString(phanloai_danhmuc);
            MySqlParameters[3] = new MySqlParameter("@chitiet", MySqlDbType.MediumText);
            MySqlParameters[3].Value = Convert.ToString(chitiet);
            MySqlParameters[4] = new MySqlParameter("@ngaycapnhat", MySqlDbType.Date);
            MySqlParameters[4].Value = Convert.ToString(ngaycapnhat);
            MySqlParameters[5] = new MySqlParameter("@taikhoan_id", MySqlDbType.Int32);
            MySqlParameters[5].Value = Convert.ToString(taikhoan_id);
            MySqlParameters[6] = new MySqlParameter("@id", MySqlDbType.Int32);
            MySqlParameters[6].Value = Convert.ToString(id);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }
    }
}