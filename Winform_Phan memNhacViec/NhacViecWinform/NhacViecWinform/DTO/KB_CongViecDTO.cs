namespace NhacViecWinform.DTO
{
    internal class KB_CongViecDTO
    {
        private int id;
        private string tieude;
        private string mota;
        private string ngaytao;
        private string kb_congviec_chitiet_id;
        private int kb_nguoigui_id;
        private string kb_nguoinhan_id;
        private int kb_nhan_id;
        private int kb_trangthai_id;

        public int Id { get => id; set => id = value; }
        public string Tieude { get => tieude; set => tieude = value; }
        public string Mota { get => mota; set => mota = value; }
        public string Ngaytao { get => ngaytao; set => ngaytao = value; }
        public string Kb_congviec_chitiet_id { get => kb_congviec_chitiet_id; set => kb_congviec_chitiet_id = value; }
        public int Kb_nguoigui_id { get => kb_nguoigui_id; set => kb_nguoigui_id = value; }
        public string Kb_nguoinhan_id { get => kb_nguoinhan_id; set => kb_nguoinhan_id = value; }
        public int Kb_nhan_id { get => kb_nhan_id; set => kb_nhan_id = value; }
        public int Kb_trangthai_id { get => kb_trangthai_id; set => kb_trangthai_id = value; }
    }
}