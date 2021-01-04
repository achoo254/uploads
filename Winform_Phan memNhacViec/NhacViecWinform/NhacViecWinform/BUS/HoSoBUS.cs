using NhacViecWinform.DAO;

namespace NhacViecWinform.BUS
{
    internal class HoSoBUS
    {
        private HoSoDAO HoSoDAO = new HoSoDAO();

        public object LayDanhSachHoSoBUS()
        {
            return HoSoDAO.LayDanhSachHoSoDAO();
        }
    }
}