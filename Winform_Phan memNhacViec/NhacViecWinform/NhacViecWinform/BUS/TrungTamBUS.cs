using HoTroNhacViecWinform.DAO;
using HoTroNhacViecWinform.DTO;
using System;
using System.Data;

namespace HoTroNhacViecWinform.BUS
{
    internal class TrungTamBUS
    {
        private TrungTamDAO TrungTamDAO = new TrungTamDAO();

        public DataTable LayTatCaTrungTamBUS()
        {
            return TrungTamDAO.LayTatCaTrungTamDAO();
        }

        public DataTable LayTrungTamTheoIdTaiKhoanBUS(int taikhoan_id)
        {
            return TrungTamDAO.LayTrungTamTheoIdTaiKhoanDAO(taikhoan_id);
        }

        public TrungTamDTO LayTrungTamTheoIdBUS(int id)
        {
            TrungTamDTO TrungTamDTO = new TrungTamDTO();

            DataTable dataTable = new DataTable();
            dataTable = TrungTamDAO.LayTrungTamTheoIdDAO(id);
            foreach (DataRow dr in dataTable.Rows)
            {
                TrungTamDTO.Id = Int32.Parse(dr["id"].ToString());
                TrungTamDTO.Trungtam = dr["ten"].ToString();
                TrungTamDTO.Diachi = dr["diachi"].ToString();
                TrungTamDTO.Kho_phongtiem = dr["kho_phongtiem"].ToString();
            }
            return TrungTamDTO;
        }
    }
}