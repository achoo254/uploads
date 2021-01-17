using NhacViecWinform.DAO;
using NhacViecWinform.DTO;
using System.Data;

namespace NhacViecWinform.BUS
{
    internal class KB_NhanBUS
    {
        private KB_NhanDAO NhanDAO = new KB_NhanDAO();
        private KB_NhanDTO KB_NhanDTO = new KB_NhanDTO();

        public DataTable LayTatCaNhanBUS()
        {
            return NhanDAO.LayTatCaNhanDAO();
        }

        public DataTable LayNhanTheoIdBUS(int nhan_id)
        {
            KB_NhanDTO.Id = nhan_id;
            return NhanDAO.LayNhanTheoIdDAO(KB_NhanDTO.Id);
        }
    }
}