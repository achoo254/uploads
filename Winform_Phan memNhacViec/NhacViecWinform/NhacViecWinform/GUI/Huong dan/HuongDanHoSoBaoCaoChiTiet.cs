using DevExpress.XtraEditors;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;
using System.Windows.Forms;

namespace NhacViecWinform.GUI.Huong_dan
{
    public partial class HuongDanHoSoBaoCaoChiTiet : DevExpress.XtraEditors.XtraForm
    {
        private HuongDanBUS HuongDanBUS = new HuongDanBUS();
        private HuongDanDTO HuongDanDTO = new HuongDanDTO();
        private int idHuongDan;

        public HuongDanHoSoBaoCaoChiTiet(int huongdan_id)
        {
            InitializeComponent();
            idHuongDan = huongdan_id;
            HuongDanDTO = HuongDanBUS.LayHuongDanBaoCaoTheoIdBUS(idHuongDan);

            txtTieuDe.Text = HuongDanDTO.Tieude;
            richChiTiet.RtfText = HuongDanDTO.Chitiet;
            dateNgayCapNhat.Text = HuongDanDTO.Ngaycapnhat;

            leChonBaoCao.Properties.DataSource = HuongDanBUS.HienThiPhanLoaiBaoCaoBUS();
            leChonBaoCao.Properties.ValueMember = "Báo cáo";
            leChonBaoCao.Properties.DisplayMember = "Báo cáo";
            leChonBaoCao.EditValue = HuongDanDTO.Phanloai_baocao;

            leChonDanhMuc.Properties.DataSource = HuongDanBUS.HienThiPhanLoaiDanhMucBUS();
            leChonDanhMuc.Properties.ValueMember = "Danh mục";
            leChonDanhMuc.Properties.DisplayMember = "Danh mục";
            leChonDanhMuc.EditValue = HuongDanDTO.Phanloai_danhmuc;

            if (BienToanCuc.UserID != HuongDanDTO.Taikhoan_id)
            {
                btnChinhSua.Enabled = false;
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            //Kiem tra khong duoc rong
            if (txtTieuDe.Text != "" && leChonBaoCao.Text != "" && leChonDanhMuc.Text != "" && richChiTiet.RtfText != "")
            {
                //Tao cac bien de them moi
                string tieude = txtTieuDe.Text;
                string baocao = leChonBaoCao.EditValue.ToString();
                string danhmuc = leChonDanhMuc.EditValue.ToString();
                string chitiet = richChiTiet.RtfText;
                DateTime dNgayTao = DateTime.Now;
                string ngaycapnhat = dNgayTao.ToString("yyyy-MM-dd");
                int nguoitao = BienToanCuc.UserID;

                //Xac nhan cap nhat
                if (XtraMessageBox.Show(BienToanCuc.ShowConfirm, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Them vao csdl
                    HuongDanBUS.SuaHuongDanBUS(idHuongDan, tieude, baocao, danhmuc, chitiet, ngaycapnhat, nguoitao);
                    XtraMessageBox.Show(BienToanCuc.ShowSuccess, BienToanCuc.ShowAlert);
                }
            }
            else
            {
                XtraMessageBox.Show(BienToanCuc.ShowEmpty, BienToanCuc.ShowAlert);
            }
        }
    }
}