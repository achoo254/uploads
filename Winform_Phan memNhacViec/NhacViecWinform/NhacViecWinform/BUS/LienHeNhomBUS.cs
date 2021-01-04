using NhacViecWinform.DAO;
using NhacViecWinform.DTO;
using System.Data;

namespace NhacViecWinform.BUS
{
    internal class LienHeNhomBUS
    {
        private LienHeNhomDAO LienHeNhomDAO = new LienHeNhomDAO();
        private LienHeNhomDTO LienHeNhomDTO = new LienHeNhomDTO();

        public DataTable LayTatCaThanhVienNhanNhomBUS(int nguoitao_id)
        {
            LienHeNhomDTO.Nguoitao_id = nguoitao_id;
            return LienHeNhomDAO.LayTatCaThanhVienNhanNhomDAO(LienHeNhomDTO.Nguoitao_id);
        }

        public DataTable LayTatCaNhomNeuTrongNhomBUS(string nguoinhan_id, int nguoitao_id)
        {
            LienHeNhomDTO.Nguoinhan_id = nguoinhan_id;
            LienHeNhomDTO.Nguoitao_id = nguoitao_id;
            return LienHeNhomDAO.LayTatCaNhomNeuTrongNhomDAO(LienHeNhomDTO.Nguoinhan_id, LienHeNhomDTO.Nguoitao_id);
        }

        public void ThemNhomMoiBUS(string tieude, int nguoitao_id, string nguoinhan_id, byte thongbao)
        {
            LienHeNhomDTO.Tieude = tieude;
            LienHeNhomDTO.Nguoitao_id = nguoitao_id;
            LienHeNhomDTO.Nguoinhan_id = nguoinhan_id;
            LienHeNhomDTO.Thongbao = thongbao;

            LienHeNhomDAO.ThemNhomMoiDAO(LienHeNhomDTO.Tieude, LienHeNhomDTO.Nguoitao_id, LienHeNhomDTO.Nguoinhan_id, LienHeNhomDTO.Thongbao);
        }

        public void CapNhatThongBaoBUS(int lienhe_nhom_id, byte thongbao)
        {
            LienHeNhomDTO.Id = lienhe_nhom_id;
            LienHeNhomDTO.Thongbao = thongbao;

            LienHeNhomDAO.CapNhatThongBaoDAO(LienHeNhomDTO.Id, LienHeNhomDTO.Thongbao);
        }

        public DataTable LayHienThiThanhVienNhomTheoIdBUS(int lienhe_nhom_id)
        {
            LienHeNhomDTO.Id = lienhe_nhom_id;

            return LienHeNhomDAO.LayHienThiThanhVienNhomTheoIdDAO(LienHeNhomDTO.Id);
        }
    }
}