using NhacViecWinform.DAO;
using NhacViecWinform.DTO;
using System;
using System.Data;

namespace NhacViecWinform.BUS
{
    internal class KB_CongViecChiTietBUS
    {
        private KB_CongViecChiTietDAO KB_CongViecChiTietDAO = new KB_CongViecChiTietDAO();
        private KB_CongViecChiTietDTO KB_CongViecChiTietDTO = new KB_CongViecChiTietDTO();
        private KB_CongViecDTO KB_CongViecDTO = new KB_CongViecDTO();

        public DataTable ThemCongViecChiTietBUS()
        {
            DataTable dt = new DataTable();
            // khởi tạo cột cho Datatable đã khai báo ở trên
            dt.Columns.Add(new DataColumn("id"));
            dt.Columns.Add(new DataColumn("congviecchitiet"));
            // Add du lieu vao dt
            DataRow dr;
            dr = dt.NewRow();
            dt.Rows.Add(dr);
            return dt;
        }

        public DataTable HienThiCongViecDaNhanTrongCapNhatCongViecBUS(string nguoinhan_id, int congviec_id)
        {
            return KB_CongViecChiTietDAO.HienThiCongViecDaNhanTrongCapNhatCongViecDAO(nguoinhan_id, congviec_id);
        }

        public DataTable HienThiThanhVienNhanTrongCapNhatCongViecBUS(string nguoinhan_id)
        {
            return KB_CongViecChiTietDAO.HienThiThanhVienNhanTrongCapNhatCongViecDAO(nguoinhan_id);
        }

        public KB_CongViecDTO HienThiThongTinCongViecTrongCapNhatCongViecBUS(int congviec_id)
        {
            DataTable dataTable = new DataTable();
            dataTable = KB_CongViecChiTietDAO.HienThiThongTinCongViecTrongCapNhatCongViecDAO(congviec_id);
            foreach (DataRow dr in dataTable.Rows)
            {
                KB_CongViecDTO.Tieude = dr["tieude"].ToString();
                KB_CongViecDTO.Mota = dr["mota"].ToString();
                KB_CongViecDTO.Kb_nhan_id = Int32.Parse(dr["kb_nhan_id"].ToString());
                KB_CongViecDTO.Kb_nguoinhan_id = dr["kb_nguoinhan_id"].ToString();
            }
            return KB_CongViecDTO;
        }

        public void ThucHienCongViecChiTietBUS(int congviecchitiet_id, byte thuchien, int nguoithuchien_id)
        {
            KB_CongViecChiTietDTO.Id = congviecchitiet_id;
            KB_CongViecChiTietDTO.Hoanthanh = thuchien;
            KB_CongViecChiTietDTO.Nguoihoanthanh_id = nguoithuchien_id;
            KB_CongViecChiTietDAO.ThucHienCongViecChiTietDAO(KB_CongViecChiTietDTO.Id, KB_CongViecChiTietDTO.Hoanthanh, KB_CongViecChiTietDTO.Nguoihoanthanh_id);
        }

        public void TaoCongViecChiTietBUS(string congviecchitiet, string ngay_tao, int nguoigui_id, byte hoanthanh)
        {
            KB_CongViecChiTietDTO.Tieude = congviecchitiet;
            KB_CongViecChiTietDTO.Ngay_tao = ngay_tao;
            KB_CongViecChiTietDTO.Nguoigui_id = nguoigui_id;
            KB_CongViecChiTietDTO.Hoanthanh = hoanthanh;
            KB_CongViecChiTietDAO.TaoCongViecChiTietDAO(KB_CongViecChiTietDTO.Tieude, KB_CongViecChiTietDTO.Ngay_tao, KB_CongViecChiTietDTO.Nguoigui_id, KB_CongViecChiTietDTO.Hoanthanh);
        }

        public void CapNhatTrangThaiCongViecChiTietBUS(int congviec_id, int trangthai_id, int huycongviec)
        {
            KB_CongViecDTO.Id = congviec_id;
            KB_CongViecDTO.Kb_trangthai_id = trangthai_id;

            KB_CongViecChiTietDAO.CapNhatTrangThaiCongViecChiTietDAO(KB_CongViecDTO.Id, KB_CongViecDTO.Kb_trangthai_id, huycongviec);
        }

        public string LayCongViecChiTietChoCongViecMoiBUS(string ngay_tao)
        {
            string congviecchitiet_id = "";
            DataTable dataTable = new DataTable();
            dataTable = KB_CongViecChiTietDAO.LayCongViecChiTietTheoNguoiGuiDAO(BienToanCuc.UserID, ngay_tao);
            foreach (DataRow dr in dataTable.Rows)
            {
                congviecchitiet_id = dr["id"].ToString();
            }
            return congviecchitiet_id;
        }

        public int DemSoCongViecChiTietDaThucHienBUS(int congviec_id, byte thuchien)
        {
            return KB_CongViecChiTietDAO.DemSoCongViecChiTietDaThucHienDAO(congviec_id, thuchien);
        }
    }
}