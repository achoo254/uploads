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
    class KSNB_KhoChoXuLyDAO
    {
        private dbConnectionMySQL conn = new dbConnectionMySQL();
        public DataTable LayTonKhoChoXuLyDAO(string thang, string nam, int nguoitao_id)
        {
            string query = string.Format("select cxl.tensp, cxl.lo, cxl.handung, cxl.soluong, cxl.khochoxuly, cxl.ngaybcsl, cxl.sobcsl, cxl.lydo, u.fullname from ksnb_khochoxuly as cxl inner join users as u on u.id = cxl.nguoitao_id where month(cxl.ngaycapnhat) = @thang and year(cxl.ngaycapnhat) = @nam and nguoitao_id = @nguoitao_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[3];
            MySqlParameters[0] = new MySqlParameter("@thang", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(thang);
            MySqlParameters[1] = new MySqlParameter("@nam", MySqlDbType.VarChar);
            MySqlParameters[1].Value = Convert.ToString(nam);
            MySqlParameters[2] = new MySqlParameter("@nguoitao_id", MySqlDbType.Int32);
            MySqlParameters[2].Value = Convert.ToString(nguoitao_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }
        public void ThemKhoChoXuLyDAO(string masp, string tensp, string dvt, string hamluong, string lo, string handung, double soluong, string khochoxuly, string ngaybcsl, string ngaychuyenkho, string sobcsl, string trungtamchuyen, string lydo, string huongxuly, string ngaycapnhat, int nguoitao_id)
        {
            string query = string.Format("insert into ksnb_khochoxuly (masp, tensp, dvt, hamluong, lo, handung, soluong, khochoxuly, ngaybcsl, ngaychuyenkho, sobcsl, trungtamchuyen, lydo, huongxuly, ngaycapnhat, nguoitao_id) values (@masp, @tensp, @dvt, @hamluong, @lo, @handung, @soluong, @khochoxuly, @ngaybcsl, @ngaychuyenkho, @sobcsl, @trungtamchuyen, @lydo, @huongxuly, @ngaycapnhat, @nguoitao_id)");
            MySqlParameter[] MySqlParameters = new MySqlParameter[16];
            MySqlParameters[0] = new MySqlParameter("@masp", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(masp);
            MySqlParameters[1] = new MySqlParameter("@tensp", MySqlDbType.VarChar);
            MySqlParameters[1].Value = Convert.ToString(tensp);
            MySqlParameters[2] = new MySqlParameter("@dvt", MySqlDbType.VarChar);
            MySqlParameters[2].Value = Convert.ToString(dvt);
            MySqlParameters[3] = new MySqlParameter("@hamluong", MySqlDbType.VarChar);
            MySqlParameters[3].Value = Convert.ToString(hamluong);
            MySqlParameters[4] = new MySqlParameter("@lo", MySqlDbType.VarChar);
            MySqlParameters[4].Value = Convert.ToString(lo);
            MySqlParameters[5] = new MySqlParameter("@handung", MySqlDbType.Date);
            MySqlParameters[5].Value = Convert.ToString(handung);
            MySqlParameters[6] = new MySqlParameter("@soluong", MySqlDbType.Double);
            MySqlParameters[6].Value = Convert.ToString(soluong);
            MySqlParameters[7] = new MySqlParameter("@khochoxuly", MySqlDbType.VarChar);
            MySqlParameters[7].Value = Convert.ToString(khochoxuly);
            MySqlParameters[8] = new MySqlParameter("@ngaybcsl", MySqlDbType.Date);
            MySqlParameters[8].Value = Convert.ToString(ngaybcsl);
            MySqlParameters[9] = new MySqlParameter("@ngaychuyenkho", MySqlDbType.Date);
            MySqlParameters[9].Value = Convert.ToString(ngaychuyenkho);
            MySqlParameters[10] = new MySqlParameter("@sobcsl", MySqlDbType.VarChar);
            MySqlParameters[10].Value = Convert.ToString(sobcsl);
            MySqlParameters[11] = new MySqlParameter("@trungtamchuyen", MySqlDbType.VarChar);
            MySqlParameters[11].Value = Convert.ToString(trungtamchuyen);
            MySqlParameters[12] = new MySqlParameter("@lydo", MySqlDbType.VarChar);
            MySqlParameters[12].Value = Convert.ToString(lydo);
            MySqlParameters[13] = new MySqlParameter("@huongxuly", MySqlDbType.VarChar);
            MySqlParameters[13].Value = Convert.ToString(huongxuly);
            MySqlParameters[14] = new MySqlParameter("@ngaycapnhat", MySqlDbType.Date);
            MySqlParameters[14].Value = Convert.ToString(ngaycapnhat);
            MySqlParameters[15] = new MySqlParameter("@nguoitao_id", MySqlDbType.Int32);
            MySqlParameters[15].Value = Convert.ToString(nguoitao_id);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }
        public void XoaKhoChoXuLyTheoIdThanhVienDAO(string thang, string nam, int nguoitao_id)
        {
            string query = string.Format("delete from ksnb_khochoxuly where month(ngaycapnhat) = @thang and year(ngaycapnhat) = @nam and nguoitao_id = @nguoitao_id");
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
