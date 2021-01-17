using NhacViecWinform.DAO;
using NhacViecWinform.DTO;
using System;
using System.Data;
using System.Security.Cryptography;

namespace NhacViecWinform.BUS
{
    public class UserBUS
    {
        private UserDAO UserDAO = new UserDAO();
        private UserDTO UserDTO = new UserDTO();
        private MD5 md5Hash = MD5.Create();

        public DataTable LayTatCaThanhVienBUS()
        {
            return UserDAO.LayTatCaThanhVienDAO();
        }

        public UserDTO LayThanhVienTheoIdBUS(int id)
        {
            UserDAO UserDAO = new UserDAO();
            UserDTO UserDTO = new UserDTO();

            DataTable dataTable = new DataTable();
            dataTable = UserDAO.LayThanhVienTheoIdDAO(id);
            foreach (DataRow dr in dataTable.Rows)
            {
                UserDTO.UserID = Int32.Parse(dr["id"].ToString());
                UserDTO.UserName = dr["username"].ToString();
                UserDTO.FullName = dr["fullname"].ToString();
                UserDTO.Phone = double.Parse(dr["phone"].ToString());
                UserDTO.Roles = dr["roles"].ToString();
                UserDTO.EMail = dr["email"].ToString();
                UserDTO.Bophan_id = Int32.Parse(dr["bophan_id"].ToString());
                UserDTO.Chucdanh_id = Int32.Parse(dr["chucdanh_id"].ToString());
            }
            return UserDTO;
        }

        public DataTable LayThanhVienTheoIdChoDatasourceBUS(int id)
        {
            return UserDAO.LayThanhVienTheoIdDAO(id);
        }

        public UserDTO LayTatCaThongTinTheoIdBUS()
        {
            UserDAO UserDAO = new UserDAO();
            UserDTO UserDTO = new UserDTO();

            DataTable dataTable = new DataTable();
            dataTable = UserDAO.LayTatCaThongTinTheoIdDAO(BienToanCuc.UserID);
            foreach (DataRow dr in dataTable.Rows)
            {
                UserDTO.UserID = Int32.Parse(dr["id"].ToString());
                UserDTO.UserName = dr["username"].ToString();
                UserDTO.FullName = dr["fullname"].ToString();
                UserDTO.PassWord = dr["password"].ToString();
                UserDTO.Phone = double.Parse(dr["phone"].ToString());
                UserDTO.Roles = dr["roles"].ToString();
                UserDTO.EMail = dr["email"].ToString();
                UserDTO.Bophan_id = Int32.Parse(dr["bophan_id"].ToString());
                UserDTO.Chucdanh_id = Int32.Parse(dr["chucdanh_id"].ToString());
                UserDTO.Trungtam_id = Int32.Parse(dr["trungtam_id"].ToString());
            }
            return UserDTO;
        }

        public void CreateUserBUS(string UserName, string Password, string FullName, string Email, double Phone, int bophan_id, int chucdanh_id, int trungtam_id)
        {
            UserDTO.UserName = UserName;
            UserDTO.PassWord = Password;
            UserDTO.FullName = FullName;
            UserDTO.Roles = BienToanCuc.RolesUser;
            UserDTO.Phone = Phone;
            UserDTO.EMail = Email;
            UserDTO.Bophan_id = bophan_id;
            UserDTO.Chucdanh_id = chucdanh_id;
            UserDTO.Trungtam_id = trungtam_id;
            string PasswordHash = BienToanCuc.GetMd5Hash(md5Hash, UserDTO.PassWord);
            UserDAO.TaoTaiKhoanDAO(UserDTO.UserName, PasswordHash, UserDTO.FullName, UserDTO.Roles, UserDTO.EMail, UserDTO.Phone, UserDTO.Bophan_id, UserDTO.Chucdanh_id, UserDTO.Trungtam_id);
        }

        public void UpdateUserBUS(string Password, string FullName, string Email, double Phone, int bophan_id, int chucdanh_id, int trungtam_id)
        {
            UserDTO.UserID = BienToanCuc.UserID;
            UserDTO.PassWord = Password;
            UserDTO.FullName = FullName;
            UserDTO.Phone = Phone;
            UserDTO.EMail = Email;
            UserDTO.Bophan_id = bophan_id;
            UserDTO.Chucdanh_id = chucdanh_id;
            UserDTO.Trungtam_id = trungtam_id;
            string PasswordHash = BienToanCuc.GetMd5Hash(md5Hash, UserDTO.PassWord);
            UserDAO.CapNhatTaiKhoanDAO(UserDTO.UserID, PasswordHash, UserDTO.FullName, UserDTO.EMail, UserDTO.Phone, UserDTO.Bophan_id, UserDTO.Chucdanh_id, UserDTO.Trungtam_id);
        }

        public bool LoginUserBUS(string UserName, string Password)
        {
            UserDTO.UserName = UserName;
            UserDTO.PassWord = Password;
            string Hash = BienToanCuc.GetMd5Hash(md5Hash, UserDTO.PassWord);
            string PasswordHash = UserDAO.LoginUserDAO(UserDTO.UserName, Hash);
            if (BienToanCuc.VerifyMd5Hash(md5Hash, UserDTO.PassWord, PasswordHash))
            {
                int id = Convert.ToInt32(UserDAO.SelectIDUserLoginDAO(UserDTO.UserName));
                BienToanCuc.UserID = id;
                BienToanCuc.MatKhauMaHoa = UserDTO.PassWord;

                return true;
            }
            return false;
        }

        public object GetUserBUS()
        {
            return UserDAO.GetUserDAO();
        }

        public string HienThiTenNguoiGiaoBUS(int user_create_id)
        {
            return UserDAO.HienThiTenNguoiGiaoDAO(user_create_id);
        }

        public string HienThiTenNguoiNhanBUS(int user_recipent_id)
        {
            return UserDAO.HienThiTenNguoiNhanDAO(user_recipent_id);
        }

        public bool CheckExistUserBUS(string UserName)
        {
            UserDTO.UserName = UserName;
            if (string.IsNullOrEmpty(UserDAO.SelectIDUserLoginDAO(UserDTO.UserName)))
            {
                return true;
            }
            return false;
        }

        public bool CheckExistEmailBUS(string email)
        {
            UserDTO.EMail = email;
            if (string.IsNullOrEmpty(UserDAO.SelectEmailUserLoginDAO(UserDTO.EMail)))
            {
                return true;
            }
            return false;
        }

        public string SelectFullnameUserBUS()
        {
            return UserDAO.SelectFullnameUserLoginDAO(BienToanCuc.UserID);
        }

        public DataTable LayThongTinCacThanhVienBUS()
        {
            return UserDAO.LayThongTinCacThanhVienDAO();
        }

        public DataTable LayThongTinCacThanhVienPhuTrachBUS(string phanquyen)
        {
            UserDTO.Roles = phanquyen;
            return UserDAO.LayThongTinCacThanhVienPhuTrachDAO(UserDTO.Roles);
        }

        public void CapNhatPhanQuyenTaiKhoanBUS(int thanhvien_id, string phanquyen)
        {
            UserDTO.UserID = thanhvien_id;
            UserDTO.Roles = phanquyen;
            UserDAO.CapNhatPhanQuyenTaiKhoanDAO(UserDTO.UserID, UserDTO.Roles);
        }
    }
}