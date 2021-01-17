using MySql.Data.MySqlClient;
using NhacViecWinform.DAL;
using System;
using System.Data;

namespace NhacViecWinform.DAO
{
    internal class ViecKSNBDAO
    {
        private dbConnectionMySQL conn = new dbConnectionMySQL();

        public DataTable LayDanhSachTrungTamDAO()
        {
            string query = string.Format("select id, ten from trungtam");
            MySqlParameter[] MySqlParameters = new MySqlParameter[0];
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable ThemDanhSachTrungTamDAO(string phutrach, int trungtam_id, int taikhoan_phutrach_id)
        {
            string query = string.Format("insert into test_phutrach (phutrach, trungtam_id, taikhoan_phutrach_id) values (@phutrach, @trungtam_id, @taikhoan_phutrach_id)");
            MySqlParameter[] MySqlParameters = new MySqlParameter[3];
            MySqlParameters[0] = new MySqlParameter("@phutrach", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(phutrach);
            MySqlParameters[1] = new MySqlParameter("@trungtam_id", MySqlDbType.Int32);
            MySqlParameters[1].Value = Convert.ToString(trungtam_id);
            MySqlParameters[2] = new MySqlParameter("@taikhoan_phutrach_id", MySqlDbType.Int32);
            MySqlParameters[2].Value = Convert.ToString(taikhoan_phutrach_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable LayDanhSachPhuTrachTrungTamDAO()
        {
            string query = string.Format("SELECT tt.ten, u.fullname, pt.phutrach FROM test_phutrach as pt inner join trungtam as tt on tt.id = pt.trungtam_id inner join users as u on u.id = taikhoan_phutrach_id order by u.fullname, tt.ten, pt.phutrach");
            MySqlParameter[] MySqlParameters = new MySqlParameter[0];
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable CapNhatPhuTrachTrungTamDAO(string phutrach, int trungtam_id, int taikhoan_phutrach_id)
        {
            string query = string.Format("update test_phutrach set phutrach = @phutrach where trungtam_id = @trungtam_id and taikhoan_phutrach_id = @taikhoan_phutrach_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[3];
            MySqlParameters[0] = new MySqlParameter("@phutrach", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(phutrach);
            MySqlParameters[1] = new MySqlParameter("@trungtam_id", MySqlDbType.Int32);
            MySqlParameters[1].Value = Convert.ToString(trungtam_id);
            MySqlParameters[2] = new MySqlParameter("@taikhoan_phutrach_id", MySqlDbType.Int32);
            MySqlParameters[2].Value = Convert.ToString(taikhoan_phutrach_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }
        public void XoaPhuTrachTrungTamDAO(int trungtam_id, int taikhoan_phutrach_id)
        {
            string query = string.Format("delete from test_phutrach where trungtam_id = @trungtam_id and taikhoan_phutrach_id = @taikhoan_phutrach_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@taikhoan_phutrach_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(taikhoan_phutrach_id);
            MySqlParameters[1] = new MySqlParameter("@trungtam_id", MySqlDbType.Int32);
            MySqlParameters[1].Value = Convert.ToString(trungtam_id);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public string LayDanhSachTrungTrungTamDAO(int trungtam_id, int taikhoan_phutrach_id)
        {
            string layid;
            string query = string.Format("select id from test_phutrach as pt where pt.trungtam_id = @trungtam_id and taikhoan_phutrach_id = @taikhoan_phutrach_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@trungtam_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(trungtam_id);
            MySqlParameters[1] = new MySqlParameter("@taikhoan_phutrach_id", MySqlDbType.Int32);
            MySqlParameters[1].Value = Convert.ToString(taikhoan_phutrach_id);
            layid = conn.ExecuteScalarString(query, MySqlParameters);
            return layid;
        }

        public string KiemTraDanhSachTrungTrungTamDAO(int trungtam_id, int taikhoan_phutrach_id)
        {
            string layid;
            string query = string.Format("select id from test_phutrach as pt where pt.trungtam_id = @trungtam_id and taikhoan_phutrach_id = @taikhoan_phutrach_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@trungtam_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(trungtam_id);
            MySqlParameters[1] = new MySqlParameter("@taikhoan_phutrach_id", MySqlDbType.Int32);
            MySqlParameters[1].Value = Convert.ToString(taikhoan_phutrach_id);
            layid = conn.ExecuteScalarString(query, MySqlParameters);
            return layid;
        }

        public string KiemTraDanhSachTrungTrungTamVaPhuTrachDAO(string phutrach, int trungtam_id)
        {
            string layid;
            string query = string.Format("select id from test_phutrach as pt where pt.trungtam_id = @trungtam_id and pt.phutrach = @phutrach");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@phutrach", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(phutrach);
            MySqlParameters[1] = new MySqlParameter("@trungtam_id", MySqlDbType.Int32);
            MySqlParameters[1].Value = Convert.ToString(trungtam_id);
            layid = conn.ExecuteScalarString(query, MySqlParameters);
            return layid;
        }

        public DataTable LayTrungTamDAO(string ngaytao, int taikhoan_phutrach_id)
        {
            string query = string.Format("select ROW_NUMBER() OVER (ORDER BY tt.id) as 'STT', tt.id as 'id', pt.id as 'phutrach_id', tt.ten, phutrach, baocaonxt, hosocxlksnb,phieuchuyenkhoqas,phieuhuyqas, hosohuy, baocaosailech from trungtam as tt left join test_congviec as cv on cv.phutrach_id = (select pt.id from test_phutrach as pt where tt.id = pt.trungtam_id and pt.taikhoan_phutrach_id = @taikhoan_phutrach_id) and cv.ngaytao = @ngaytao inner join test_phutrach as pt on pt.taikhoan_phutrach_id = @taikhoan_phutrach_id and pt.trungtam_id = tt.id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@ngaytao", MySqlDbType.Date);
            MySqlParameters[0].Value = Convert.ToString(ngaytao);
            MySqlParameters[1] = new MySqlParameter("@taikhoan_phutrach_id", MySqlDbType.Int32);
            MySqlParameters[1].Value = Convert.ToString(taikhoan_phutrach_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable LayLichSuTrungTamPhuTrachDAO(string ngaytao, int taikhoan_phutrach_id)
        {
            string query = string.Format("select ROW_NUMBER() OVER (ORDER BY tt.id) as 'STT', tt.ten, phutrach, baocaonxt, hosocxlksnb,phieuchuyenkhoqas,phieuhuyqas, hosohuy, baocaosailech from trungtam as tt left join test_congviec as cv on cv.phutrach_id = (select pt.id from test_phutrach as pt where tt.id = pt.trungtam_id and pt.taikhoan_phutrach_id = @taikhoan_phutrach_id) and cv.ngaytao = @ngaytao inner join test_phutrach as pt on pt.taikhoan_phutrach_id = @taikhoan_phutrach_id and pt.trungtam_id = tt.id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@ngaytao", MySqlDbType.Date);
            MySqlParameters[0].Value = Convert.ToString(ngaytao);
            MySqlParameters[1] = new MySqlParameter("@taikhoan_phutrach_id", MySqlDbType.Int32);
            MySqlParameters[1].Value = Convert.ToString(taikhoan_phutrach_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable LayCongViecNgayCuDAO(string ngaytao, int taikhoan_phutrach_id)
        {
            string query = string.Format("select ROW_NUMBER() OVER (ORDER BY tt.id) as 'STT', tt.id as 'id', pt.id as 'phutrach_id', tt.ten, phutrach, replace(baocaonxt, 'Z', '') as 'baocaonxt', replace(hosocxlksnb, 'Z', '') as 'hosocxlksnb', replace(phieuchuyenkhoqas, 'Z', '') as 'phieuchuyenkhoqas', replace(phieuhuyqas, 'Z', '') as 'phieuhuyqas', replace(hosohuy, 'Z', '') as 'hosohuy', replace(baocaosailech, 'Z', '') as 'baocaosailech' from trungtam as tt left join test_congviec as cv on cv.phutrach_id = (select pt.id from test_phutrach as pt where tt.id = pt.trungtam_id and pt.taikhoan_phutrach_id = @taikhoan_phutrach_id) and cv.ngaytao = @ngaytao inner join test_phutrach as pt on pt.taikhoan_phutrach_id = @taikhoan_phutrach_id and pt.trungtam_id = tt.id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@ngaytao", MySqlDbType.Date);
            MySqlParameters[0].Value = Convert.ToString(ngaytao);
            MySqlParameters[1] = new MySqlParameter("@taikhoan_phutrach_id", MySqlDbType.Int32);
            MySqlParameters[1].Value = Convert.ToString(taikhoan_phutrach_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public void TaoCongViecHangNgayDAO(string baocaonxt, string hosocxlksnb, string phieuchuyenkhoqas, string phieuhuyqas, string hosohuy, string baocaosailech, string ngaytao, int phutrach_id)
        {
            string query = string.Format("insert into test_congviec (baocaonxt, hosocxlksnb, phieuchuyenkhoqas, phieuhuyqas, hosohuy, baocaosailech, ngaytao, phutrach_id)" +
                "values (@baocaonxt, @hosocxlksnb, @phieuchuyenkhoqas, @phieuhuyqas, @hosohuy, @baocaosailech, @ngaytao, @phutrach_id)");
            MySqlParameter[] MySqlParameters = new MySqlParameter[8];
            MySqlParameters[0] = new MySqlParameter("@phutrach_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(phutrach_id);
            MySqlParameters[1] = new MySqlParameter("@baocaonxt", MySqlDbType.Text);
            MySqlParameters[1].Value = Convert.ToString(baocaonxt);
            MySqlParameters[2] = new MySqlParameter("@hosocxlksnb", MySqlDbType.Text);
            MySqlParameters[2].Value = Convert.ToString(hosocxlksnb);
            MySqlParameters[3] = new MySqlParameter("@phieuchuyenkhoqas", MySqlDbType.Text);
            MySqlParameters[3].Value = Convert.ToString(phieuchuyenkhoqas);
            MySqlParameters[4] = new MySqlParameter("@phieuhuyqas", MySqlDbType.Text);
            MySqlParameters[4].Value = Convert.ToString(phieuhuyqas);
            MySqlParameters[5] = new MySqlParameter("@hosohuy", MySqlDbType.Text);
            MySqlParameters[5].Value = Convert.ToString(hosohuy);
            MySqlParameters[6] = new MySqlParameter("@baocaosailech", MySqlDbType.Text);
            MySqlParameters[6].Value = Convert.ToString(baocaosailech);
            MySqlParameters[7] = new MySqlParameter("@ngaytao", MySqlDbType.Date);
            MySqlParameters[7].Value = Convert.ToString(ngaytao);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public string KiemTraTonTaiNgayTao(string ngaytao, int phutrach_id)
        {
            string layngay;
            string query = string.Format("select * from test_congviec where ngaytao = @ngaytao and phutrach_id = @phutrach_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@phutrach_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(phutrach_id);
            MySqlParameters[1] = new MySqlParameter("@ngaytao", MySqlDbType.Date);
            MySqlParameters[1].Value = Convert.ToString(ngaytao);
            layngay = conn.ExecuteScalarString(query, MySqlParameters);
            return layngay;
        }

        public string KiemTraPhuTrach(int phutrach_id, int taikhoan_phutrach_id)
        {
            string layid;
            string query = string.Format("select phutrach from test_phutrach as pt where pt.id = @phutrach_id and pt.taikhoan_phutrach_id = @taikhoan_phutrach_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@phutrach_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(phutrach_id);
            MySqlParameters[1] = new MySqlParameter("@taikhoan_phutrach_id", MySqlDbType.Int32);
            MySqlParameters[1].Value = Convert.ToString(taikhoan_phutrach_id);
            layid = conn.ExecuteScalarString(query, MySqlParameters);
            return layid;
        }

        public void CapNhatCongViecHangNgayDAO(string baocaonxt, string hosocxlksnb, string phieuchuyenkhoqas, string phieuhuyqas, string hosohuy, string baocaosailech, string ngaytao, int phutrach_id)
        {
            string query = string.Format("update test_congviec set " +
                "baocaonxt = @baocaonxt, hosocxlksnb = @hosocxlksnb, phieuchuyenkhoqas = @phieuchuyenkhoqas, phieuhuyqas = @phieuhuyqas, hosohuy = @hosohuy, baocaosailech = @baocaosailech where ngaytao = @ngaytao and phutrach_id = @phutrach_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[8];
            MySqlParameters[0] = new MySqlParameter("@phutrach_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(phutrach_id);
            MySqlParameters[1] = new MySqlParameter("@baocaonxt", MySqlDbType.Text);
            MySqlParameters[1].Value = Convert.ToString(baocaonxt);
            MySqlParameters[2] = new MySqlParameter("@hosocxlksnb", MySqlDbType.Text);
            MySqlParameters[2].Value = Convert.ToString(hosocxlksnb);
            MySqlParameters[3] = new MySqlParameter("@phieuchuyenkhoqas", MySqlDbType.Text);
            MySqlParameters[3].Value = Convert.ToString(phieuchuyenkhoqas);
            MySqlParameters[4] = new MySqlParameter("@phieuhuyqas", MySqlDbType.Text);
            MySqlParameters[4].Value = Convert.ToString(phieuhuyqas);
            MySqlParameters[5] = new MySqlParameter("@hosohuy", MySqlDbType.Text);
            MySqlParameters[5].Value = Convert.ToString(hosohuy);
            MySqlParameters[6] = new MySqlParameter("@baocaosailech", MySqlDbType.Text);
            MySqlParameters[6].Value = Convert.ToString(baocaosailech);
            MySqlParameters[7] = new MySqlParameter("@ngaytao", MySqlDbType.Date);
            MySqlParameters[7].Value = Convert.ToString(ngaytao);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }
    }
}