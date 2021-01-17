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
    class KSNB_KhoChoXuLyBUS
    {
        KSNB_KhoChoXuLyDAO KSNB_KhoChoXuLyDAO = new KSNB_KhoChoXuLyDAO();
        KSNB_KhoChoXuLyDTO KSNB_KhoChoXuLyDTO = new KSNB_KhoChoXuLyDTO();
        public DataTable LayTonKhoChoXuLyBUS(string thang, string nam, int nguoitao_id)
        {
            return KSNB_KhoChoXuLyDAO.LayTonKhoChoXuLyDAO(thang, nam, nguoitao_id);
        }
        public void ThemKhoChoXuLyBUS(string masp, string tensp, string dvt, string hamluong, string lo, string handung, double soluong, string khochoxuly, string ngaybcsl, string ngaychuyenkho, string sobcsl, string trungtamchuyen, string lydo, string huongxuly, string ngaycapnhat, int nguoitao_id)
        {
            KSNB_KhoChoXuLyDTO.Masp = masp;
            KSNB_KhoChoXuLyDTO.Tensp = tensp;
            KSNB_KhoChoXuLyDTO.Dvt = dvt;
            KSNB_KhoChoXuLyDTO.Hamluong = hamluong;
            KSNB_KhoChoXuLyDTO.Lo = lo;
            KSNB_KhoChoXuLyDTO.Handung = handung;
            KSNB_KhoChoXuLyDTO.Soluong = soluong;
            KSNB_KhoChoXuLyDTO.Khochoxuly = khochoxuly;
            KSNB_KhoChoXuLyDTO.Ngaybcsl = ngaybcsl;
            KSNB_KhoChoXuLyDTO.Ngaychuyenkho = ngaychuyenkho;
            KSNB_KhoChoXuLyDTO.Sobcsl = sobcsl;
            KSNB_KhoChoXuLyDTO.Trungtamchuyen = trungtamchuyen;
            KSNB_KhoChoXuLyDTO.Lydo = lydo;
            KSNB_KhoChoXuLyDTO.Huongxuly = huongxuly;
            KSNB_KhoChoXuLyDTO.Ngaycapnhat = ngaycapnhat;
            KSNB_KhoChoXuLyDTO.Nguoitao_id = nguoitao_id;

            KSNB_KhoChoXuLyDAO.ThemKhoChoXuLyDAO(KSNB_KhoChoXuLyDTO.Masp, KSNB_KhoChoXuLyDTO.Tensp, KSNB_KhoChoXuLyDTO.Dvt, KSNB_KhoChoXuLyDTO.Hamluong, KSNB_KhoChoXuLyDTO.Lo, KSNB_KhoChoXuLyDTO.Handung, KSNB_KhoChoXuLyDTO.Soluong, KSNB_KhoChoXuLyDTO.Khochoxuly, KSNB_KhoChoXuLyDTO.Ngaybcsl, KSNB_KhoChoXuLyDTO.Ngaychuyenkho, KSNB_KhoChoXuLyDTO.Sobcsl, KSNB_KhoChoXuLyDTO.Trungtamchuyen, KSNB_KhoChoXuLyDTO.Lydo, KSNB_KhoChoXuLyDTO.Huongxuly, KSNB_KhoChoXuLyDTO.Ngaycapnhat, KSNB_KhoChoXuLyDTO.Nguoitao_id);
        }
        public void XoaKhoChoXuLyTheoIdThanhVienBUS(string thang, string nam, int nguoitao_id)
        {
            KSNB_KhoChoXuLyDAO.XoaKhoChoXuLyTheoIdThanhVienDAO(thang, nam, nguoitao_id);
        }
    }
}
