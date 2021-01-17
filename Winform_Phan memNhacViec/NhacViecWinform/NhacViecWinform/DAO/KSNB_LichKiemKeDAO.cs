using MySql.Data.MySqlClient;
using NhacViecWinform.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoTroNhacViecWinform.DAO
{
    class KSNB_LichKiemKeDAO
    {
        private dbConnectionMySQL conn = new dbConnectionMySQL();
        public DataTable LayLichKiemKeDAO(string thang, string nam, int nguoitao_id)
        {
            string query = string.Format("select lkk.trungtam, lkk.tenkho, lkk.thoigiankiemke, lkk.ngaykiemke, lkk.phongtiem_tong, lkk.phongtiem_nghi, lkk.phongtiem_kiemsang, u.fullname from ksnb_lichkiemke as lkk inner join users as u on u.id = lkk.nguoitao_id where month(lkk.ngaycapnhat) = @thang and year(lkk.ngaycapnhat) = @nam and nguoitao_id = @nguoitao_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[3];
            MySqlParameters[0] = new MySqlParameter("@thang", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(thang);
            MySqlParameters[1] = new MySqlParameter("@nam", MySqlDbType.VarChar);
            MySqlParameters[1].Value = Convert.ToString(nam);
            MySqlParameters[2] = new MySqlParameter("@nguoitao_id", MySqlDbType.Int32);
            MySqlParameters[2].Value = Convert.ToString(nguoitao_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }
        public void ThemLichKiemKeDAO(string trungtam, string tenkho, string thoigiankiemke, string ngaykiemke, int phongtiem_tong, int phongtiem_nghi, int phongtiem_kiemsang, string nhanvien_chinh, string nhanvien_phu, string khoangcach, string ngaycapnhat, int nguoitao_id)
        {
            string query = string.Format("insert into ksnb_lichkiemke (trungtam, tenkho, thoigiankiemke, ngaykiemke, phongtiem_tong, phongtiem_nghi, phongtiem_kiemsang, nhanvien_chinh, nhanvien_phu, khoangcach, ngaycapnhat, nguoitao_id) values (@trungtam, @tenkho, @thoigiankiemke, @ngaykiemke, @phongtiem_tong, @phongtiem_nghi, @phongtiem_kiemsang, @nhanvien_chinh, @nhanvien_phu, @khoangcach, @ngaycapnhat, @nguoitao_id)");
            MySqlParameter[] MySqlParameters = new MySqlParameter[12];
            MySqlParameters[0] = new MySqlParameter("@trungtam", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(trungtam);
            MySqlParameters[1] = new MySqlParameter("@tenkho", MySqlDbType.VarChar);
            MySqlParameters[1].Value = Convert.ToString(tenkho);
            MySqlParameters[2] = new MySqlParameter("@thoigiankiemke", MySqlDbType.VarChar);
            MySqlParameters[2].Value = Convert.ToString(thoigiankiemke);
            MySqlParameters[3] = new MySqlParameter("@ngaykiemke", MySqlDbType.Date);
            MySqlParameters[3].Value = Convert.ToString(ngaykiemke);
            MySqlParameters[4] = new MySqlParameter("@phongtiem_tong", MySqlDbType.Int32);
            MySqlParameters[4].Value = Convert.ToString(phongtiem_tong);
            MySqlParameters[5] = new MySqlParameter("@phongtiem_nghi", MySqlDbType.Int32);
            MySqlParameters[5].Value = Convert.ToString(phongtiem_nghi);
            MySqlParameters[6] = new MySqlParameter("@phongtiem_kiemsang", MySqlDbType.Int32);
            MySqlParameters[6].Value = Convert.ToString(phongtiem_kiemsang);
            MySqlParameters[7] = new MySqlParameter("@nhanvien_chinh", MySqlDbType.VarChar);
            MySqlParameters[7].Value = Convert.ToString(nhanvien_chinh);
            MySqlParameters[8] = new MySqlParameter("@nhanvien_phu", MySqlDbType.VarChar);
            MySqlParameters[8].Value = Convert.ToString(nhanvien_phu);
            MySqlParameters[9] = new MySqlParameter("@khoangcach", MySqlDbType.VarChar);
            MySqlParameters[9].Value = Convert.ToString(khoangcach);
            MySqlParameters[10] = new MySqlParameter("@ngaycapnhat", MySqlDbType.Date);
            MySqlParameters[10].Value = Convert.ToString(ngaycapnhat);
            MySqlParameters[11] = new MySqlParameter("@nguoitao_id", MySqlDbType.Int32);
            MySqlParameters[11].Value = Convert.ToString(nguoitao_id);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }
        public void XoaLichKiemKeTheoIdThanhVienDAO(string thang, string nam, int nguoitao_id)
        {
            string query = string.Format("delete from ksnb_lichkiemke where month(ngaycapnhat) = @thang and year(ngaycapnhat) = @nam and nguoitao_id = @nguoitao_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[3];
            MySqlParameters[0] = new MySqlParameter("@thang", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(thang);
            MySqlParameters[1] = new MySqlParameter("@nam", MySqlDbType.VarChar);
            MySqlParameters[1].Value = Convert.ToString(nam);
            MySqlParameters[2] = new MySqlParameter("@nguoitao_id", MySqlDbType.Int32);
            MySqlParameters[2].Value = Convert.ToString(nguoitao_id);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }
    }
}
