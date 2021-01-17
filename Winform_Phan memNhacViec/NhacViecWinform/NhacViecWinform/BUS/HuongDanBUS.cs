using NhacViecWinform.DAO;
using NhacViecWinform.DTO;
using System;
using System.Data;

namespace NhacViecWinform.BUS
{
    internal class HuongDanBUS
    {
        private HuongDanDAO HuongDanDAO = new HuongDanDAO();
        private HuongDanDTO HuongDanDTO = new HuongDanDTO();

        public DataTable LayHuongDanBaoCaoTheoPhanLoaiBUS(string phanloai_baocao, string phanloai_danhmuc)
        {
            HuongDanDTO.Phanloai_baocao = phanloai_baocao;
            HuongDanDTO.Phanloai_danhmuc = phanloai_danhmuc;
            return HuongDanDAO.LayHuongDanBaoCaoTheoPhanLoaiDAO(HuongDanDTO.Phanloai_baocao, HuongDanDTO.Phanloai_danhmuc);
        }

        public HuongDanDTO LayHuongDanBaoCaoTheoIdBUS(int huongdan_id)
        {
            DataTable dataTable = new DataTable();
            dataTable = HuongDanDAO.LayHuongDanBaoCaoTheoIdDAO(huongdan_id);
            foreach (DataRow dr in dataTable.Rows)
            {
                HuongDanDTO.Tieude = dr["tieude"].ToString();
                HuongDanDTO.Phanloai_baocao = dr["phanloai_baocao"].ToString();
                HuongDanDTO.Phanloai_danhmuc = dr["phanloai_danhmuc"].ToString();
                HuongDanDTO.Chitiet = dr["chitiet"].ToString();
                HuongDanDTO.Ngaytao = dr["ngaytao"].ToString();
                HuongDanDTO.Ngaycapnhat = dr["ngaycapnhat"].ToString();
                HuongDanDTO.Taikhoan_id = Int32.Parse(dr["taikhoan_id"].ToString());
            }
            return HuongDanDTO;
        }

        public DataTable HienThiPhanLoaiBaoCaoBUS()
        {
            DataTable dt = new DataTable();
            // khởi tạo cột cho Datatable đã khai báo ở trên
            dt.Columns.Add(new DataColumn("Báo cáo", typeof(string)));
            // Add du lieu vao dt

            dt.Rows.Add(BienToanCuc.huongdan_baocaoNXT);
            dt.Rows.Add(BienToanCuc.huongdan_bcsl);
            dt.Rows.Add(BienToanCuc.huongdan_baocaohuy);
            dt.Rows.Add(BienToanCuc.huongdan_baocaoSAT);
            dt.Rows.Add(BienToanCuc.huongdan_baocaohethan);
            return dt;
        }

        public DataTable HienThiPhanLoaiDanhMucBUS()
        {
            DataTable dt = new DataTable();
            // khởi tạo cột cho Datatable đã khai báo ở trên
            dt.Columns.Add(new DataColumn("Danh mục", typeof(string)));
            // Add du lieu vao dt

            dt.Rows.Add(BienToanCuc.huongdan_huongdan);
            dt.Rows.Add(BienToanCuc.huongdan_thamkhao);
            dt.Rows.Add(BienToanCuc.huongdan_quydinh);
            return dt;
        }

        public void TaoHuongDanMoiBUS(string tieude, string phanloai_baocao, string phanloai_danhmuc, string chitiet, string ngaytao, string ngaycapnhat, int taikhoan_id)
        {
            HuongDanDTO.Tieude = tieude;
            HuongDanDTO.Phanloai_baocao = phanloai_baocao;
            HuongDanDTO.Phanloai_danhmuc = phanloai_danhmuc;
            HuongDanDTO.Chitiet = chitiet;
            HuongDanDTO.Ngaytao = ngaytao;
            HuongDanDTO.Ngaycapnhat = ngaycapnhat;
            HuongDanDTO.Taikhoan_id = taikhoan_id;

            HuongDanDAO.TaoHuongDanMoiDAO(HuongDanDTO.Tieude, HuongDanDTO.Phanloai_baocao, HuongDanDTO.Phanloai_danhmuc, HuongDanDTO.Chitiet, HuongDanDTO.Ngaytao, HuongDanDTO.Ngaycapnhat, HuongDanDTO.Taikhoan_id);
        }

        public void SuaHuongDanBUS(int id, string tieude, string phanloai_baocao, string phanloai_danhmuc, string chitiet, string ngaycapnhat, int taikhoan_id)
        {
            HuongDanDTO.Id = id;
            HuongDanDTO.Tieude = tieude;
            HuongDanDTO.Phanloai_baocao = phanloai_baocao;
            HuongDanDTO.Phanloai_danhmuc = phanloai_danhmuc;
            HuongDanDTO.Chitiet = chitiet;
            HuongDanDTO.Ngaycapnhat = ngaycapnhat;
            HuongDanDTO.Taikhoan_id = taikhoan_id;

            HuongDanDAO.SuaHuongDanDAO(HuongDanDTO.Id, HuongDanDTO.Tieude, HuongDanDTO.Phanloai_baocao, HuongDanDTO.Phanloai_danhmuc, HuongDanDTO.Chitiet, HuongDanDTO.Ngaycapnhat, HuongDanDTO.Taikhoan_id);
        }
    }
}