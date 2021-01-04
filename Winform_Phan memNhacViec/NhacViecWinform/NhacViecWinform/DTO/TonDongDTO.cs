using System;

namespace NhacViecWinform.DTO
{
    internal class TonDongDTO
    {
        private int id;
        private int trungtam_id;
        private string tenkho;
        private DateTime ngayhoso;
        private string tenvacxin;
        private string nguyennhan;
        private byte hoantat;
        private int hoso_id;
        int nguoitao_id;

        public int Id { get => id; set => id = value; }
        public int Trungtam_id { get => trungtam_id; set => trungtam_id = value; }
        public string Tenkho { get => tenkho; set => tenkho = value; }
        public DateTime Ngayhoso { get => ngayhoso; set => ngayhoso = value; }
        public string Tenvacxin { get => tenvacxin; set => tenvacxin = value; }
        public string Nguyennhan { get => nguyennhan; set => nguyennhan = value; }
        public byte Hoantat { get => hoantat; set => hoantat = value; }
        public int Hoso_id { get => hoso_id; set => hoso_id = value; }
        public int Nguoitao_id { get => nguoitao_id; set => nguoitao_id = value; }
    }
}