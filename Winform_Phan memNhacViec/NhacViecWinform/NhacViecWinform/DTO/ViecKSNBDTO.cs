namespace NhacViecWinform.DTO
{
    internal class ViecKSNBDTO
    {
        private int id;
        private string trungtam;
        private string baocaonxt;
        private string hosocxlksnb;
        private string phieuchuyenkhoqas;
        private string phieuhuyqas;
        private string hosohuy;
        private string baocaosailech;
        private string ngaytao;
        private string phutrach;
        private int phutrach_id;
        private int trungtam_id;
        private int taikhoan_phutrach_id;

        public int Id { get => id; set => id = value; }
        public string Trungtam { get => trungtam; set => trungtam = value; }
        public string Baocaonxt { get => baocaonxt; set => baocaonxt = value; }
        public string Hosocxlksnb { get => hosocxlksnb; set => hosocxlksnb = value; }
        public string Phieuchuyenkhoqas { get => phieuchuyenkhoqas; set => phieuchuyenkhoqas = value; }
        public string Phieuhuyqas { get => phieuhuyqas; set => phieuhuyqas = value; }
        public string Hosohuy { get => hosohuy; set => hosohuy = value; }
        public string Baocaosailech { get => baocaosailech; set => baocaosailech = value; }
        public string Ngaytao { get => ngaytao; set => ngaytao = value; }
        public int Phutrach_id { get => phutrach_id; set => phutrach_id = value; }
        public int Trungtam_id { get => trungtam_id; set => trungtam_id = value; }
        public int Taikhoan_phutrach_id { get => taikhoan_phutrach_id; set => taikhoan_phutrach_id = value; }
        public string Phutrach { get => phutrach; set => phutrach = value; }
    }
}