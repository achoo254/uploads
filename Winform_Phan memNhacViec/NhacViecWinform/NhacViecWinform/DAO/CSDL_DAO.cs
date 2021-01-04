using MySql.Data.MySqlClient;
using NhacViecWinform.DAL;
using System;

namespace HoTroNhacViecWinform.DAO
{
    internal class CSDL_DAO
    {
        private dbConnectionMySQL conn = new dbConnectionMySQL();

        public void ThemThongTinBoPhanCSDLDAO(string ten)
        {
            string query = string.Format("insert bophan(ten) select @ten where not exists (select ten from bophan where ten = @ten limit 1)");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@ten", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(ten);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public void SuaThongTinBoPhanCSDLDAO(string tencu, string tenmoi)
        {
            string query = string.Format("update bophan set ten = @tenmoi where ten = @tencu");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@tencu", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(tencu);
            MySqlParameters[1] = new MySqlParameter("@tenmoi", MySqlDbType.VarChar);
            MySqlParameters[1].Value = Convert.ToString(tenmoi);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public string XemThongTinBoPhanTonTaiDAO(string ten)
        {
            string ketqua;
            string query = string.Format("select ten from bophan where ten = @ten");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@ten", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(ten);
            ketqua = conn.ExecuteScalarString(query, MySqlParameters);
            return ketqua;
        }

        public void ThemThongTintrungtamCSDLDAO(string ten)
        {
            string query = string.Format("insert trungtam(ten) select @ten where not exists (select ten from trungtam where ten = @ten limit 1)");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@ten", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(ten);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public void SuaThongTintrungtamCSDLDAO(string tencu, string tenmoi)
        {
            string query = string.Format("update trungtam set ten = @tenmoi where ten = @tencu");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@tencu", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(tencu);
            MySqlParameters[1] = new MySqlParameter("@tenmoi", MySqlDbType.VarChar);
            MySqlParameters[1].Value = Convert.ToString(tenmoi);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public string XemThongTintrungtamTonTaiDAO(string ten)
        {
            string ketqua;
            string query = string.Format("select ten from trungtam where ten = @ten");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@ten", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(ten);
            ketqua = conn.ExecuteScalarString(query, MySqlParameters);
            return ketqua;
        }

        public void ThemThongTinchucdanhCSDLDAO(string ten)
        {
            string query = string.Format("insert chucdanh(ten) select @ten where not exists (select ten from chucdanh where ten = @ten limit 1)");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@ten", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(ten);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public void SuaThongTinchucdanhCSDLDAO(string tencu, string tenmoi)
        {
            string query = string.Format("update chucdanh set ten = @tenmoi where ten = @tencu");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@tencu", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(tencu);
            MySqlParameters[1] = new MySqlParameter("@tenmoi", MySqlDbType.VarChar);
            MySqlParameters[1].Value = Convert.ToString(tenmoi);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public string XemThongTinchucdanhTonTaiDAO(string ten)
        {
            string ketqua;
            string query = string.Format("select ten from chucdanh where ten = @ten");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@ten", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(ten);
            ketqua = conn.ExecuteScalarString(query, MySqlParameters);
            return ketqua;
        }

        public void ThemThongTindanhmucCSDLDAO(string ten)
        {
            string query = string.Format("insert category(ten) select @ten where not exists (select ten from category where ten = @ten limit 1)");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@ten", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(ten);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public void SuaThongTindanhmucCSDLDAO(string tencu, string tenmoi)
        {
            string query = string.Format("update category set ten = @tenmoi where ten = @tencu");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@tencu", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(tencu);
            MySqlParameters[1] = new MySqlParameter("@tenmoi", MySqlDbType.VarChar);
            MySqlParameters[1].Value = Convert.ToString(tenmoi);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public string XemThongTindanhmucTonTaiDAO(string ten)
        {
            string ketqua;
            string query = string.Format("select ten from category where ten = @ten");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@ten", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(ten);
            ketqua = conn.ExecuteScalarString(query, MySqlParameters);
            return ketqua;
        }

        public void ThemThongTinhosoCSDLDAO(string ten)
        {
            string query = string.Format("insert test_hoso(ten) select @ten where not exists (select ten from test_hoso where ten = @ten limit 1)");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@ten", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(ten);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public void SuaThongTinhosoCSDLDAO(string tencu, string tenmoi)
        {
            string query = string.Format("update test_hoso set ten = @tenmoi where ten = @tencu");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@tencu", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(tencu);
            MySqlParameters[1] = new MySqlParameter("@tenmoi", MySqlDbType.VarChar);
            MySqlParameters[1].Value = Convert.ToString(tenmoi);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public string XemThongTinhosoTonTaiDAO(string ten)
        {
            string ketqua;
            string query = string.Format("select ten from test_hoso where ten = @ten");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@ten", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(ten);
            ketqua = conn.ExecuteScalarString(query, MySqlParameters);
            return ketqua;
        }
    }
}