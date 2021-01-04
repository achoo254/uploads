namespace NhacViecWinform.DTO
{
    internal class HuongDanDTO
    {
        private int id;
        private string tieude;
        private string phanloai_baocao;
        private string phanloai_danhmuc;
        private string chitiet;
        private string ngaytao;
        private string ngaycapnhat;
        private int taikhoan_id;

        public int Id { get => id; set => id = value; }
        public string Tieude { get => tieude; set => tieude = value; }
        public string Phanloai_baocao { get => phanloai_baocao; set => phanloai_baocao = value; }
        public string Phanloai_danhmuc { get => phanloai_danhmuc; set => phanloai_danhmuc = value; }
        public string Chitiet { get => chitiet; set => chitiet = value; }
        public string Ngaytao { get => ngaytao; set => ngaytao = value; }
        public int Taikhoan_id { get => taikhoan_id; set => taikhoan_id = value; }
        public string Ngaycapnhat { get => ngaycapnhat; set => ngaycapnhat = value; }
    }
}