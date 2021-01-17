namespace NhacViecWinform.DTO
{
    internal class LienHeDTO
    {
        private int id;
        private string noidung;
        private int nguoigui_id;
        private int lienhe_nhom_id;
        private string ngaygui;
        private string khoa;

        public int Nguoigui_id { get => nguoigui_id; set => nguoigui_id = value; }
        public int Lienhe_nhom_id { get => lienhe_nhom_id; set => lienhe_nhom_id = value; }
        public string Ngaygui { get => ngaygui; set => ngaygui = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public int Id { get => id; set => id = value; }
        public string Noidung { get => noidung; set => noidung = value; }
    }
}