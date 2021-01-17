namespace NhacViecWinform.DTO
{
    internal class KB_CongViecChiTietDTO
    {
        private int id;
        private string tieude;
        private string ngay_tao;
        private int nguoigui_id;
        private byte hoanthanh;
        private int nguoihoanthanh_id;

        public int Id { get => id; set => id = value; }
        public string Tieude { get => tieude; set => tieude = value; }
        public string Ngay_tao { get => ngay_tao; set => ngay_tao = value; }
        public int Nguoigui_id { get => nguoigui_id; set => nguoigui_id = value; }
        public byte Hoanthanh { get => hoanthanh; set => hoanthanh = value; }
        public int Nguoihoanthanh_id { get => nguoihoanthanh_id; set => nguoihoanthanh_id = value; }
    }
}