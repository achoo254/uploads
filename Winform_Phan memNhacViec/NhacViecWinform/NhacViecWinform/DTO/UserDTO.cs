namespace NhacViecWinform.DTO
{
    public class UserDTO
    {
        private int userID;
        private string userName;
        private string passWord;
        private string fullName;
        private string roles;
        private string email;
        private double phone;
        private int bophan_id;
        private int chucdanh_id;
        private string hinhanh;
        private int trungtam_id;

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Roles { get => roles; set => roles = value; }
        public int UserID { get => userID; set => userID = value; }
        public string EMail { get => email; set => email = value; }
        public double Phone { get => phone; set => phone = value; }
        public int Bophan_id { get => bophan_id; set => bophan_id = value; }
        public int Chucdanh_id { get => chucdanh_id; set => chucdanh_id = value; }
        public string Hinhanh { get => hinhanh; set => hinhanh = value; }
        public int Trungtam_id { get => trungtam_id; set => trungtam_id = value; }
    }
}