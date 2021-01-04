using NhacViecWinform.DAO;
using NhacViecWinform.DTO;
using System.Data;

namespace NhacViecWinform.BUS
{
    internal class TheoDoiBUS
    {
        private TheoDoiDAO TheoDoiDAO = new TheoDoiDAO();
        private TheoDoiDTO TheoDoiDTO = new TheoDoiDTO();

        public object LayDanhSachTheoDoiBUS(int tondong_id)
        {
            TheoDoiDTO.Tondong_id = tondong_id;

            return TheoDoiDAO.LayDanhSachTheoDoiDAO(TheoDoiDTO.Tondong_id);
        }

        public string LayNgayTheoDoiBUS(int tondong_id, string ngaytheodoi)
        {
            TheoDoiDTO.Tondong_id = tondong_id;

            return TheoDoiDAO.LayNgayTheoDoiDAO(TheoDoiDTO.Tondong_id, ngaytheodoi);
        }
        public TheoDoiDTO LayTinhTrangHuongXuLyMoiNhatTheoDoiBUS(int tondong_id)
        {
            DataTable dataTable = new DataTable();
            dataTable = TheoDoiDAO.LayTinhTrangHuongXuLyMoiNhatTheoDoiDAO(tondong_id);
            foreach (DataRow dr in dataTable.Rows)
            {
                TheoDoiDTO.Tinhtrang = dr["tinhtrang"].ToString();
                TheoDoiDTO.Huongxuly = dr["huongxuly"].ToString();
            }
            return TheoDoiDTO;
        }

        public object ThemHoacSuaTheoDoiBUS(int tondong_id, string ngaytheodoi, string tinhtrang, string huongxuly)
        {
            TheoDoiDTO TheoDoiDTO = new TheoDoiDTO();

            TheoDoiDTO.Tondong_id = tondong_id;
            TheoDoiDTO.Tinhtrang = tinhtrang;
            TheoDoiDTO.Huongxuly = huongxuly;

            if (string.IsNullOrEmpty(LayNgayTheoDoiBUS(TheoDoiDTO.Tondong_id, ngaytheodoi)))
            {
                return TheoDoiDAO.ThemTheoDoiDAO(TheoDoiDTO.Tondong_id, ngaytheodoi, TheoDoiDTO.Tinhtrang, TheoDoiDTO.Huongxuly);
            }
            else
            {
                return TheoDoiDAO.SuaTheoDoiDAO(TheoDoiDTO.Tondong_id, ngaytheodoi, TheoDoiDTO.Tinhtrang, TheoDoiDTO.Huongxuly);
            }
        }
    }
}