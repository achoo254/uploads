using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoTroNhacViecWinform.DTO
{
    class KSNB_LichKiemKeDTO
    {
        int id;
        string trungtam;
        string tenkho;
        string thoigiankiemke;
        string ngaykiemke;
        int phongtiem_tong;
        int phongtiem_nghi;
        int phongtiem_kiemsang;
        string nhanvien_chinh;
        string nhanvien_phu;
        string khoangcach;
        string ngaycapnhat;
        int nguoitao_id;

        public int Id { get => id; set => id = value; }
        public string Trungtam { get => trungtam; set => trungtam = value; }
        public string Tenkho { get => tenkho; set => tenkho = value; }
        public string Thoigiankiemke { get => thoigiankiemke; set => thoigiankiemke = value; }
        public string Ngaykiemke { get => ngaykiemke; set => ngaykiemke = value; }
        public int Phongtiem_tong { get => phongtiem_tong; set => phongtiem_tong = value; }
        public int Phongtiem_nghi { get => phongtiem_nghi; set => phongtiem_nghi = value; }
        public int Phongtiem_kiemsang { get => phongtiem_kiemsang; set => phongtiem_kiemsang = value; }
        public string Ngaycapnhat { get => ngaycapnhat; set => ngaycapnhat = value; }
        public int Nguoitao_id { get => nguoitao_id; set => nguoitao_id = value; }
        public string Nhanvien_chinh { get => nhanvien_chinh; set => nhanvien_chinh = value; }
        public string Nhanvien_phu { get => nhanvien_phu; set => nhanvien_phu = value; }
        public string Khoangcach { get => khoangcach; set => khoangcach = value; }
    }
}
