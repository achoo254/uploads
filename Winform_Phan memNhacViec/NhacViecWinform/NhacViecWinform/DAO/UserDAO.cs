using MySql.Data.MySqlClient;
using NhacViecWinform.DAL;
using System;
using System.Data;

namespace NhacViecWinform.DAO
{
    internal class UserDAO
    {
        private dbConnectionMySQL conn = new dbConnectionMySQL();

        public DataTable LayTatCaThanhVienDAO()
        {
            string query = string.Format("SELECT u.id, username, fullname, roles, email, phone, bp.ten as tenbophan, cd.ten as tenchucdanh, hinhanh FROM users as u inner join bophan as bp on u.bophan_id = bp.id inner join chucdanh as cd on u.chucdanh_id = cd.id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[0];
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable LayThanhVienTheoIdDAO(int id)
        {
            string query = string.Format("SELECT u.id, bophan_id, chucdanh_id , username, fullname, bp.ten as tenbophan, cd.ten as tenchucdanh, phone, roles, email FROM users as u inner join bophan as bp on u.bophan_id = bp.id inner join chucdanh as cd on u.chucdanh_id = cd.id where u.id = @id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable LayTatCaThongTinTheoIdDAO(int user_id)
        {
            string query = string.Format("select * from users where id = @user_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@user_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(user_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public void TaoTaiKhoanDAO(string username, string password, string fullname, string roles,
            string email, double phone, int bophan_id, int chucdanh_id, int trungtam_id)
        {
            string query = string.Format("insert into users (username, password, fullname, " +
                "roles, email, phone, bophan_id, chucdanh_id, trungtam_id)" +
                "values (@username, @password, @fullname, @roles, @email, @phone, @bophan_id, @chucdanh_id, @trungtam_id)");
            MySqlParameter[] MySqlParameters = new MySqlParameter[9];
            MySqlParameters[0] = new MySqlParameter("@username", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(username);
            MySqlParameters[1] = new MySqlParameter("@password", MySqlDbType.VarChar);
            MySqlParameters[1].Value = Convert.ToString(password);
            MySqlParameters[2] = new MySqlParameter("@fullname", MySqlDbType.VarChar);
            MySqlParameters[2].Value = Convert.ToString(fullname);
            MySqlParameters[3] = new MySqlParameter("@roles", MySqlDbType.VarChar);
            MySqlParameters[3].Value = Convert.ToString(roles);
            MySqlParameters[4] = new MySqlParameter("@email", MySqlDbType.VarChar);
            MySqlParameters[4].Value = Convert.ToString(email);
            MySqlParameters[5] = new MySqlParameter("@phone", MySqlDbType.Int32);
            MySqlParameters[5].Value = Convert.ToDouble(phone);
            MySqlParameters[6] = new MySqlParameter("@bophan_id", MySqlDbType.Int32);
            MySqlParameters[6].Value = Convert.ToDouble(bophan_id);
            MySqlParameters[7] = new MySqlParameter("@chucdanh_id", MySqlDbType.Int32);
            MySqlParameters[7].Value = Convert.ToDouble(chucdanh_id);
            MySqlParameters[8] = new MySqlParameter("@trungtam_id", MySqlDbType.Int32);
            MySqlParameters[8].Value = Convert.ToDouble(trungtam_id);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public void CapNhatTaiKhoanDAO(int user_id, string password, string fullname,
          string email, double phone, int bophan_id, int chucdanh_id, int trungtam_id)
        {
            string query = string.Format("update users set password = @password , fullname = @fullname, email = @email, phone = @phone, bophan_id = @bophan_id, chucdanh_id = @chucdanh_id, trungtam_id = @trungtam_id where id = @user_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[8];
            MySqlParameters[0] = new MySqlParameter("@user_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(user_id);
            MySqlParameters[1] = new MySqlParameter("@password", MySqlDbType.VarChar);
            MySqlParameters[1].Value = Convert.ToString(password);
            MySqlParameters[2] = new MySqlParameter("@fullname", MySqlDbType.VarChar);
            MySqlParameters[2].Value = Convert.ToString(fullname);
            MySqlParameters[3] = new MySqlParameter("@email", MySqlDbType.VarChar);
            MySqlParameters[3].Value = Convert.ToString(email);
            MySqlParameters[4] = new MySqlParameter("@phone", MySqlDbType.Int32);
            MySqlParameters[4].Value = Convert.ToDouble(phone);
            MySqlParameters[5] = new MySqlParameter("@bophan_id", MySqlDbType.Int32);
            MySqlParameters[5].Value = Convert.ToDouble(bophan_id);
            MySqlParameters[6] = new MySqlParameter("@chucdanh_id", MySqlDbType.Int32);
            MySqlParameters[6].Value = Convert.ToDouble(chucdanh_id);
            MySqlParameters[7] = new MySqlParameter("@trungtam_id", MySqlDbType.Int32);
            MySqlParameters[7].Value = Convert.ToDouble(trungtam_id);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public string LoginUserDAO(string username, string password)
        {
            String Password = password;
            string query = string.Format("select password from users where username = @username AND password = @password");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@username", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(username);
            MySqlParameters[1] = new MySqlParameter("@password", MySqlDbType.VarChar);
            MySqlParameters[1].Value = Convert.ToString(password);
            Password = conn.ExecuteScalarString(query, MySqlParameters);
            return Password;
        }

        public string SelectIDUserLoginDAO(string username)
        {
            string id;
            string query = string.Format("select id from users where username = @username");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@username", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(username);
            id = conn.ExecuteScalarString(query, MySqlParameters);
            return id;
        }

        public string SelectEmailUserLoginDAO(string email)
        {
            string query = string.Format("select email from users where email = @email");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@email", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(email);
            email = conn.ExecuteScalarString(query, MySqlParameters);
            return email;
        }

        public string SelectFullnameUserLoginDAO(int user_id)
        {
            string fullname = "";
            string query = string.Format("select fullname from users where id = @user_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@user_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(user_id);
            fullname = conn.ExecuteScalarString(query, MySqlParameters);
            return fullname;
        }

        public DataTable GetUserDAO()
        {
            string query = string.Format("select id, fullname from users");
            MySqlParameter[] MySqlParameters = new MySqlParameter[0];
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public string HienThiTenNguoiGiaoDAO(int user_create_id)
        {
            string fullname = "";
            string query = string.Format("select u.fullname from users as u where id = @user_create_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@user_create_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(user_create_id);
            fullname = conn.ExecuteScalarString(query, MySqlParameters);
            return fullname;
        }

        public string HienThiTenNguoiNhanDAO(int user_recipent_id)
        {
            string fullname = "";
            string query = string.Format("select u.fullname from users as u where id = @user_recipent_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@user_recipent_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(user_recipent_id);
            fullname = conn.ExecuteScalarString(query, MySqlParameters);
            return fullname;
        }

        public DataTable LayThongTinCacThanhVienDAO()
        {
            string query = string.Format("SELECT tt.ten, u.fullname, bp.ten as bophan, cd.ten as chucdanh, u.email, u.phone FROM users as u inner join trungtam as tt on u.trungtam_id = tt.id inner join bophan as bp on u.bophan_id = bp.id inner join chucdanh as cd on u.chucdanh_id = cd.id order by bp.ten, u.fullname asc");
            MySqlParameter[] MySqlParameters = new MySqlParameter[0];
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public DataTable LayThongTinCacThanhVienPhuTrachDAO(string phanquyen)
        {
            string query = string.Format("SELECT u.id, tt.ten, u.fullname, bp.ten as bophan, cd.ten as chucdanh, u.email, u.phone, roles FROM users as u inner join trungtam as tt on u.trungtam_id = tt.id inner join bophan as bp on u.bophan_id = bp.id inner join chucdanh as cd on u.chucdanh_id = cd.id where find_in_set(@phanquyen, u.roles) = 0 order by bp.ten, u.fullname asc");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@phanquyen", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(phanquyen);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        public void CapNhatPhanQuyenTaiKhoanDAO(int thanhvien_id, string phanquyen)
        {
            string query = string.Format("update users set roles = @phanquyen where id = @thanhvien_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@thanhvien_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(thanhvien_id);
            MySqlParameters[1] = new MySqlParameter("@phanquyen", MySqlDbType.VarChar);
            MySqlParameters[1].Value = Convert.ToString(phanquyen);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }
    }
}