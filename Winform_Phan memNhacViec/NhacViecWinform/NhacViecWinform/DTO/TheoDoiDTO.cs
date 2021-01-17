using System;

namespace NhacViecWinform.DTO
{
    internal class TheoDoiDTO
    {
        private int id;
        private int tondong_id;
        private DateTime ngaytheodoi;
        private string tinhtrang;
        private string huongxuly;

        public int Id { get => id; set => id = value; }
        public int Tondong_id { get => tondong_id; set => tondong_id = value; }
        public DateTime Ngaytheodoi { get => ngaytheodoi; set => ngaytheodoi = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public string Huongxuly { get => huongxuly; set => huongxuly = value; }
    }
}