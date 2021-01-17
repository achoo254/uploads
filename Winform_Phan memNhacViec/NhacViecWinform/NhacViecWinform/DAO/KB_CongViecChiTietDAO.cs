using MySql.Data.MySqlClient;
using NhacViecWinform.DAL;
using System;
using System.Data;

namespace NhacViecWinform.DAO
{
    internal class KB_CongViecChiTietDAO
    {
        private dbConnectionMySQL conn = new dbConnectionMySQL();

        public void TaoCongViecChiTietDAO(string congviecchitiet, string ngay_tao, int nguoigui_id, byte hoanthanh)
        {
            string query = string.Format("insert into kb_congviec_chitiet (tieude, ngay_tao, nguoigui_id, hoanthanh) values (@congviecchitiet, @ngay_tao, @nguoigui_id, @hoanthanh)");
            MySqlParameter[] MySqlParameters = new MySqlParameter[4];
            MySqlParameters[0] = new MySqlParameter("@congviecchitiet", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(congviecchitiet);
            MySqlParameters[1] = new MySqlParameter("@ngay_tao", MySqlDbType.DateTime);
            MySqlParameters[1].Value = Convert.ToString(ngay_tao);
            MySqlParameters[2] = new MySqlParameter("@nguoigui_id", MySqlDbType.Int32);
            MySqlParameters[2].Value = Convert.ToString(nguoigui_id);
            MySqlParameters[3] = new MySqlParameter("@hoanthanh", MySqlDbType.Byte);
            MySqlParameters[3].Value = Convert.ToString(hoanthanh);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public void CapNhatCongViecChiTietDAO(int id, string congviecchitiet)
        {
            string query = string.Format("update kb_congviec_chitiet set tieude = @congviecchitiet where id = @id)");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(id);
            MySqlParameters[1] = new MySqlParameter("@congviecchitiet", MySqlDbType.VarChar);
            MySqlParameters[1].Value = Convert.ToString(congviecchitiet);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public DataTable LayCongViecChiTietTheoNguoiGuiDAO(int nguoigui_id, string ngay_tao)
        {
            string query = string.Format("SELECT group_concat(id) as 'id' from kb_congviec_chitiet where nguoigui_id = @nguoigui_id and ngay_tao = @ngay_tao");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@nguoigui_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(nguoigui_id);
            MySqlParameters[1] = new MySqlParameter("@ngay_tao", MySqlDbType.DateTime);
            MySqlParameters[1].Value = Convert.ToString(ngay_tao);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable HienThiCongViecDaNhanTrongCapNhatCongViecDAO(string nguoinhan_id, int congviec_id)
        {
            string query = string.Format("SELECT ct.hoanthanh, ct.id, ct.tieude, u.fullname  FROM kb_congviec_chitiet as ct inner join kb_congviec as cv on cv.kb_nguoigui_id = ct.nguoigui_id and find_in_set(ct.id, cv.kb_congviec_chitiet_id) and find_in_set(@nguoinhan_id, cv.kb_nguoinhan_id) and cv.id = @congviec_id left join users as u on ct.nguoihoanthanh_id = u.id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@nguoinhan_id", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(nguoinhan_id);
            MySqlParameters[1] = new MySqlParameter("@congviec_id", MySqlDbType.Int32);
            MySqlParameters[1].Value = Convert.ToString(congviec_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable HienThiThongTinCongViecTrongCapNhatCongViecDAO(int congviec_id)
        {
            string query = string.Format("SELECT cv.tieude, mota, kb_nhan_id, kb_nguoinhan_id FROM kb_congviec as cv where cv.id = @congviec_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@congviec_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(congviec_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable HienThiThanhVienNhanTrongCapNhatCongViecDAO(string nguoinhan_id)
        {
            string query = string.Format("SELECT u.id, fullname, bp.ten as tenbophan, cd.ten as tenchucdanh FROM users as u inner join bophan as bp on u.bophan_id = bp.id inner join chucdanh as cd on u.chucdanh_id = cd.id where find_in_set(u.id, @nguoinhan_id)");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@nguoinhan_id", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(nguoinhan_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public void ThucHienCongViecChiTietDAO(int congviecchitiet_id, byte thuchien, int nguoithuchien_id)
        {
            string query = string.Format("update kb_congviec_chitiet set hoanthanh = @thuchien, nguoihoanthanh_id = @nguoithuchien_id where id = @congviecchitiet_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[3];
            MySqlParameters[0] = new MySqlParameter("@congviecchitiet_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(congviecchitiet_id);
            MySqlParameters[1] = new MySqlParameter("@thuchien", MySqlDbType.Byte);
            MySqlParameters[1].Value = Convert.ToString(thuchien);
            MySqlParameters[2] = new MySqlParameter("@nguoithuchien_id", MySqlDbType.Int32);
            MySqlParameters[2].Value = Convert.ToString(nguoithuchien_id);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public void CapNhatTrangThaiCongViecChiTietDAO(int congviec_id, int trangthai_id, int huycongviec)
        {
            string query = string.Format("update kb_congviec set kb_trangthai_id = @trangthai_id where id = @congviec_id and kb_trangthai_id <> @huycongviec");
            MySqlParameter[] MySqlParameters = new MySqlParameter[3];
            MySqlParameters[0] = new MySqlParameter("@congviec_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(congviec_id);
            MySqlParameters[1] = new MySqlParameter("@trangthai_id", MySqlDbType.Int32);
            MySqlParameters[1].Value = Convert.ToString(trangthai_id);
            MySqlParameters[2] = new MySqlParameter("@huycongviec", MySqlDbType.Int32);
            MySqlParameters[2].Value = Convert.ToString(huycongviec);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public int DemSoCongViecChiTietDaThucHienDAO(int congviec_id, byte thuchien)
        {
            int demso = 0;
            string query = string.Format("select count(ct.hoanthanh) from kb_congviec as cv inner join kb_congviec_chitiet as ct on find_in_set(ct.id, kb_congviec_chitiet_id) where ct.hoanthanh = @thuchien and cv.id = @congviec_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@congviec_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(congviec_id);
            MySqlParameters[1] = new MySqlParameter("@thuchien", MySqlDbType.Byte);
            MySqlParameters[1].Value = Convert.ToString(thuchien);
            var kiemtra = conn.ExecuteScalarString(query, MySqlParameters);
            if (string.IsNullOrEmpty(kiemtra))
            {
                demso = 0;
            }
            else
            {
                demso = int.Parse(kiemtra);
            }
            return demso;
        }
    }
}