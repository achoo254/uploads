namespace HoTroNhacViecWinform.DTO
{
    internal class TrungTamDTO
    {
        private int id;
        private string trungtam;
        private string diachi;
        private string kho_phongtiem;

        public int Id { get => id; set => id = value; }
        public string Trungtam { get => trungtam; set => trungtam = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Kho_phongtiem { get => kho_phongtiem; set => kho_phongtiem = value; }
    }
}