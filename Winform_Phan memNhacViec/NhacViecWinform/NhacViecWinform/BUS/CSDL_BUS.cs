using HoTroNhacViecWinform.DAO;

namespace HoTroNhacViecWinform.BUS
{
    internal class CSDL_BUS
    {
        private CSDL_DAO CSDL_DAO = new CSDL_DAO();

        public void ThemThongTinBoPhanCSDLBUS(string ten)
        {
            CSDL_DAO.ThemThongTinBoPhanCSDLDAO(ten);
        }

        public void SuaThongTinBoPhanCSDLBUS(string tencu, string tenmoi)
        {
            CSDL_DAO.SuaThongTinBoPhanCSDLDAO(tencu, tenmoi);
        }

        public bool XemThongTinBoPhanTonTaiBUS(string ten)
        {
            if (string.IsNullOrEmpty(CSDL_DAO.XemThongTinBoPhanTonTaiDAO(ten)))
            {
                return true;
            }
            return false;
        }

        public void ThemThongTintrungtamCSDLBUS(string ten)
        {
            CSDL_DAO.ThemThongTintrungtamCSDLDAO(ten);
        }

        public void SuaThongTintrungtamCSDLBUS(string tencu, string tenmoi)
        {
            CSDL_DAO.SuaThongTintrungtamCSDLDAO(tencu, tenmoi);
        }

        public bool XemThongTintrungtamTonTaiBUS(string ten)
        {
            if (string.IsNullOrEmpty(CSDL_DAO.XemThongTintrungtamTonTaiDAO(ten)))
            {
                return true;
            }
            return false;
        }

        public void ThemThongTinchucdanhCSDLBUS(string ten)
        {
            CSDL_DAO.ThemThongTinchucdanhCSDLDAO(ten);
        }

        public void SuaThongTinchucdanhCSDLBUS(string tencu, string tenmoi)
        {
            CSDL_DAO.SuaThongTinchucdanhCSDLDAO(tencu, tenmoi);
        }

        public bool XemThongTinchucdanhTonTaiBUS(string ten)
        {
            if (string.IsNullOrEmpty(CSDL_DAO.XemThongTinchucdanhTonTaiDAO(ten)))
            {
                return true;
            }
            return false;
        }

        public void ThemThongTindanhmucCSDLBUS(string ten)
        {
            CSDL_DAO.ThemThongTindanhmucCSDLDAO(ten);
        }

        public void SuaThongTindanhmucCSDLBUS(string tencu, string tenmoi)
        {
            CSDL_DAO.SuaThongTindanhmucCSDLDAO(tencu, tenmoi);
        }

        public bool XemThongTindanhmucTonTaiBUS(string ten)
        {
            if (string.IsNullOrEmpty(CSDL_DAO.XemThongTindanhmucTonTaiDAO(ten)))
            {
                return true;
            }
            return false;
        }

        public void ThemThongTinhosoCSDLBUS(string ten)
        {
            CSDL_DAO.ThemThongTinhosoCSDLDAO(ten);
        }

        public void SuaThongTinhosoCSDLBUS(string tencu, string tenmoi)
        {
            CSDL_DAO.SuaThongTinhosoCSDLDAO(tencu, tenmoi);
        }

        public bool XemThongTinhosoTonTaiBUS(string ten)
        {
            if (string.IsNullOrEmpty(CSDL_DAO.XemThongTinhosoTonTaiDAO(ten)))
            {
                return true;
            }
            return false;
        }
    }
}