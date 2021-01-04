using NhacViecWinform.DAO;
using NhacViecWinform.DTO;
using System;
using System.Data;

namespace NhacViecWinform.BUS
{
    internal class BoPhanBUS
    {
        private BoPhanDAO BoPhanDAO = new BoPhanDAO();

        public DataTable LayTatCaBoPhanBUS()
        {
            return BoPhanDAO.LayTatCaBoPhanDAO();
        }

        public DataTable LayBoPhanTheoIdTaiKhoanBUS(int taikhoan_id)
        {
            return BoPhanDAO.LayBoPhanTheoIdTaiKhoanDAO(taikhoan_id);
        }

        public BoPhanDTO LayBoPhanTheoIdBUS(int id)
        {
            BoPhanDTO BoPhanDTO = new BoPhanDTO();

            DataTable dataTable = new DataTable();
            dataTable = BoPhanDAO.LayBoPhanTheoIdDAO(id);
            foreach (DataRow dr in dataTable.Rows)
            {
                BoPhanDTO.Id = Int32.Parse(dr["id"].ToString());
                BoPhanDTO.Ten = dr["ten"].ToString();
            }
            return BoPhanDTO;
        }
    }
}