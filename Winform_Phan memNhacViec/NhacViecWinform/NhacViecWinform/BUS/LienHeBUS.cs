using NhacViecWinform.DAO;
using NhacViecWinform.DTO;
using System.Data;

namespace NhacViecWinform.BUS
{
    internal class LienHeBUS
    {
        private LienHeDAO LienHeDAO = new LienHeDAO();
        private LienHeDTO LienHeDTO = new LienHeDTO();

        public DataTable LayNoiDungLienheTheoNhomBUS(int lienhe_nhom_id, string khoa)
        {
            LienHeDTO.Lienhe_nhom_id = lienhe_nhom_id;
            LienHeDTO.Khoa = khoa;
            return LienHeDAO.LayNoiDungLienheTheoNhomDAO(LienHeDTO.Lienhe_nhom_id, khoa);
        }

        public void GuiTinNhanBUS(string noidung, int nguoigui_id, int lienhe_nhom_id, string ngaygui, string tennguoigui, string khoa)
        {
            LienHeDTO.Noidung = noidung;
            LienHeDTO.Nguoigui_id = nguoigui_id;
            LienHeDTO.Lienhe_nhom_id = lienhe_nhom_id;
            LienHeDTO.Ngaygui = ngaygui;
            LienHeDTO.Khoa = khoa;

            LienHeDAO.GuiTinNhanDAO(LienHeDTO.Noidung, LienHeDTO.Nguoigui_id, LienHeDTO.Lienhe_nhom_id, LienHeDTO.Ngaygui, tennguoigui, khoa);
        }

        public void KhoaTinNhanBUS(int lienhe_nhom_id, string khoa, int nguoigui_id)
        {
            LienHeDTO.Lienhe_nhom_id = lienhe_nhom_id;
            LienHeDTO.Khoa = khoa;
            LienHeDTO.Nguoigui_id = nguoigui_id;

            LienHeDAO.KhoaTinNhanDAO(LienHeDTO.Lienhe_nhom_id, LienHeDTO.Khoa, LienHeDTO.Nguoigui_id);
        }
    }
}