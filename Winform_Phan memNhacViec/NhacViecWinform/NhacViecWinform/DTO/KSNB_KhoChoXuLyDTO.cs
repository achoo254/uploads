using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoTroNhacViecWinform.DTO
{
    class KSNB_KhoChoXuLyDTO
    {
        int id;
        string masp;
        string tensp;
        string dvt;
        string hamluong;
        string lo;
        string handung;
        double soluong;
        string khochoxuly;
        string ngaybcsl;
        string ngaychuyenkho;
        string sobcsl;
        string trungtamchuyen;
        string lydo;
        string huongxuly;
        string ngaycapnhat;
        int nguoitao_id;

        public int Id { get => id; set => id = value; }
        public string Masp { get => masp; set => masp = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public string Dvt { get => dvt; set => dvt = value; }
        public string Hamluong { get => hamluong; set => hamluong = value; }
        public string Lo { get => lo; set => lo = value; }
        public string Handung { get => handung; set => handung = value; }
        public double Soluong { get => soluong; set => soluong = value; }
        public string Khochoxuly { get => khochoxuly; set => khochoxuly = value; }
        public string Ngaybcsl { get => ngaybcsl; set => ngaybcsl = value; }
        public string Ngaychuyenkho { get => ngaychuyenkho; set => ngaychuyenkho = value; }
        public string Sobcsl { get => sobcsl; set => sobcsl = value; }
        public string Trungtamchuyen { get => trungtamchuyen; set => trungtamchuyen = value; }
        public string Lydo { get => lydo; set => lydo = value; }
        public string Huongxuly { get => huongxuly; set => huongxuly = value; }
        public string Ngaycapnhat { get => ngaycapnhat; set => ngaycapnhat = value; }
        public int Nguoitao_id { get => nguoitao_id; set => nguoitao_id = value; }
    }
}
