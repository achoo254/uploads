using NhacViecWinform.DAO;
using NhacViecWinform.DTO;
using System;
using System.Data;

namespace NhacViecWinform.BUS
{
    internal class ChucDanhBUS
    {
        private ChucDanhDAO ChucDanhDAO = new ChucDanhDAO();

        public ChucDanhDTO LayChucDanhTheoIdBUS(int id)
        {
            ChucDanhDTO ChucDanhDTO = new ChucDanhDTO();

            DataTable dataTable = new DataTable();
            dataTable = ChucDanhDAO.LayChucDanhTheoIdDAO(id);
            foreach (DataRow dr in dataTable.Rows)
            {
                ChucDanhDTO.Id = Int32.Parse(dr["id"].ToString());
                ChucDanhDTO.Ten = dr["ten"].ToString();
            }
            return ChucDanhDTO;
        }

        public DataTable LayTatCaChucDanhBUS()
        {
            return ChucDanhDAO.LayTatCaChucDanhDAO();
        }

        public DataTable LayChucDanhTheoIdTaiKhoanBUS(int taikhoan_id)
        {
            return ChucDanhDAO.LayChucDanhTheoIdTaiKhoanDAO(taikhoan_id);
        }
    }
}