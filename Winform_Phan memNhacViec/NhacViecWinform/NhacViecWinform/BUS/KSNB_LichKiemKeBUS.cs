using HoTroNhacViecWinform.DAO;
using HoTroNhacViecWinform.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoTroNhacViecWinform.BUS
{
    class KSNB_LichKiemKeBUS
    {
        KSNB_LichKiemKeDAO KSNB_LichKiemKeDAO = new KSNB_LichKiemKeDAO();
        KSNB_LichKiemKeDTO KSNB_LichKiemKeDTO = new KSNB_LichKiemKeDTO();
        public DataTable LayLichKiemKeBUS(string thang, string nam, int nguoitao_id)
        {
            return KSNB_LichKiemKeDAO.LayLichKiemKeDAO(thang, nam, nguoitao_id);
        }
        public void ThemLichKiemKeBUS(string trungtam, string tenkho, string thoigiankiemke, string ngaykiemke, int phongtiem_tong, int phongtiem_nghi, int phongtiem_kiemsang, string nhanvien_chinh, string nhanvien_phu, string khoangcach, string ngaycapnhat, int nguoitao_id)
        {
            KSNB_LichKiemKeDTO.Trungtam = trungtam;
            KSNB_LichKiemKeDTO.Tenkho = tenkho;
            KSNB_LichKiemKeDTO.Thoigiankiemke = thoigiankiemke;
            KSNB_LichKiemKeDTO.Ngaykiemke = ngaykiemke;
            KSNB_LichKiemKeDTO.Phongtiem_tong = phongtiem_tong;
            KSNB_LichKiemKeDTO.Phongtiem_nghi = phongtiem_nghi;
            KSNB_LichKiemKeDTO.Phongtiem_kiemsang = phongtiem_kiemsang;
            KSNB_LichKiemKeDTO.Nhanvien_chinh = nhanvien_chinh;
            KSNB_LichKiemKeDTO.Nhanvien_phu = nhanvien_phu;
            KSNB_LichKiemKeDTO.Khoangcach = khoangcach;
            KSNB_LichKiemKeDTO.Ngaycapnhat = ngaycapnhat;
            KSNB_LichKiemKeDTO.Nguoitao_id = nguoitao_id;

            KSNB_LichKiemKeDAO.ThemLichKiemKeDAO(KSNB_LichKiemKeDTO.Trungtam, KSNB_LichKiemKeDTO.Tenkho, KSNB_LichKiemKeDTO.Thoigiankiemke, KSNB_LichKiemKeDTO.Ngaykiemke, KSNB_LichKiemKeDTO.Phongtiem_tong, KSNB_LichKiemKeDTO.Phongtiem_nghi, KSNB_LichKiemKeDTO.Phongtiem_kiemsang, KSNB_LichKiemKeDTO.Nhanvien_chinh, KSNB_LichKiemKeDTO.Nhanvien_phu, KSNB_LichKiemKeDTO.Khoangcach, KSNB_LichKiemKeDTO.Ngaycapnhat, KSNB_LichKiemKeDTO.Nguoitao_id);
        }
        public void XoaLichKiemKeTheoIdThanhVienBUS(string thang, string nam, int nguoitao_id)
        {
            KSNB_LichKiemKeDAO.XoaLichKiemKeTheoIdThanhVienDAO(thang, nam, nguoitao_id);
        }
    }
}
