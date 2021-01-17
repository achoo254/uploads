using NhacViecWinform.DAO;
using NhacViecWinform.DTO;
using System.Data;

namespace NhacViecWinform.BUS
{
    internal class KB_CongViecBUS
    {
        private KB_CongViecDAO KB_CongViecDAO = new KB_CongViecDAO();
        private KB_CongViecDTO KB_CongViecDTO = new KB_CongViecDTO();

        public DataTable ThemThanhVienBUS()
        {
            DataTable dt = new DataTable();
            // khởi tạo cột cho Datatable đã khai báo ở trên
            dt.Columns.Add(new DataColumn("id"));
            dt.Columns.Add(new DataColumn("fullname"));
            dt.Columns.Add(new DataColumn("tenbophan"));
            dt.Columns.Add(new DataColumn("tenchucdanh"));
            // Add du lieu vao dt
            DataRow dr;
            dr = dt.NewRow();
            dt.Rows.Add(dr);
            return dt;
        }

        public DataTable ThemTheoBoPhanBUS(int bophan_id)
        {
            return KB_CongViecDAO.ThemTheoBoPhanDAO(bophan_id);
        }

        public DataTable ThemTheoThanhVienBUS()
        {
            return KB_CongViecDAO.ThemTheoThanhVienDAO();
        }

        public DataTable HienThiCongViecGuiBUS(int nguoigui_id)
        {
            KB_CongViecDTO.Kb_nguoigui_id = nguoigui_id;
            return KB_CongViecDAO.HienThiCongViecDaGuiDAO(KB_CongViecDTO.Kb_nguoigui_id);
        }

        public DataTable HienThiCongViecNhanBUS(int nguoinhan_id)
        {
            KB_CongViecDTO.Kb_nguoinhan_id = nguoinhan_id.ToString();
            return KB_CongViecDAO.HienThiCongViecDaNhanDAO(KB_CongViecDTO.Kb_nguoinhan_id);
        }

        public void ThemCongViecBUS(string tieude, string mota, string ngaytao, string congviecchitiet_id, int nguoigui_id, string nguoinhan_id, int nhan_id, int trangthai_id)
        {
            KB_CongViecDTO.Tieude = tieude;
            KB_CongViecDTO.Mota = mota;
            KB_CongViecDTO.Ngaytao = ngaytao;
            KB_CongViecDTO.Kb_congviec_chitiet_id = congviecchitiet_id;
            KB_CongViecDTO.Kb_nguoigui_id = nguoigui_id;
            KB_CongViecDTO.Kb_nguoinhan_id = nguoinhan_id;
            KB_CongViecDTO.Kb_nhan_id = nhan_id;
            KB_CongViecDTO.Kb_trangthai_id = trangthai_id;

            KB_CongViecDAO.ThemCongViecDAO(KB_CongViecDTO.Tieude, KB_CongViecDTO.Mota, KB_CongViecDTO.Ngaytao, KB_CongViecDTO.Kb_congviec_chitiet_id, KB_CongViecDTO.Kb_nguoigui_id, KB_CongViecDTO.Kb_nguoinhan_id, KB_CongViecDTO.Kb_nhan_id, KB_CongViecDTO.Kb_trangthai_id);
        }

        public void SuaCongViecBUS(string tieude, string mota, string ngaytao, string congviecchitiet_id, int nguoigui_id, string nguoinhan_id, int nhan_id)
        {
            KB_CongViecDTO.Tieude = tieude;
            KB_CongViecDTO.Mota = mota;
            KB_CongViecDTO.Ngaytao = ngaytao;
            KB_CongViecDTO.Kb_congviec_chitiet_id = congviecchitiet_id;
            KB_CongViecDTO.Kb_nguoigui_id = nguoigui_id;
            KB_CongViecDTO.Kb_nguoinhan_id = nguoinhan_id;
            KB_CongViecDTO.Kb_nhan_id = nhan_id;

            KB_CongViecDAO.SuaCongViecDAO(KB_CongViecDTO.Tieude, KB_CongViecDTO.Mota, KB_CongViecDTO.Ngaytao, KB_CongViecDTO.Kb_congviec_chitiet_id, KB_CongViecDTO.Kb_nguoigui_id, KB_CongViecDTO.Kb_nguoinhan_id, KB_CongViecDTO.Kb_nhan_id);
        }
    }
}