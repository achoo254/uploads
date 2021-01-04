namespace NhacViecWinform.DTO
{
    internal class LienHeNhomDTO
    {
        private int id;
        private string tieude;
        private int nguoitao_id;
        private string nguoinhan_id;
        private byte thongbao;

        public int Id { get => id; set => id = value; }
        public string Tieude { get => tieude; set => tieude = value; }
        public int Nguoitao_id { get => nguoitao_id; set => nguoitao_id = value; }
        public string Nguoinhan_id { get => nguoinhan_id; set => nguoinhan_id = value; }
        public byte Thongbao { get => thongbao; set => thongbao = value; }
    }
}