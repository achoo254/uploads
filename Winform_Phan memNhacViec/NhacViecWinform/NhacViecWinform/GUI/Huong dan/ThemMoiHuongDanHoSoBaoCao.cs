using DevExpress.XtraEditors;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;
using System.Windows.Forms;

namespace NhacViecWinform.GUI.Huong_dan
{
    public partial class ThemMoiHuongDanHoSoBaoCao : DevExpress.XtraEditors.XtraForm
    {
        private HuongDanBUS HuongDanBUS = new HuongDanBUS();
        private HuongDanDTO HuongDanDTO = new HuongDanDTO();

        public ThemMoiHuongDanHoSoBaoCao()
        {
            InitializeComponent();
            leChonBaoCao.Properties.DataSource = HuongDanBUS.HienThiPhanLoaiBaoCaoBUS();
            leChonBaoCao.Properties.ValueMember = "Báo cáo";
            leChonBaoCao.Properties.DisplayMember = "Báo cáo";

            leChonDanhMuc.Properties.DataSource = HuongDanBUS.HienThiPhanLoaiDanhMucBUS();
            leChonDanhMuc.Properties.ValueMember = "Danh mục";
            leChonDanhMuc.Properties.DisplayMember = "Danh mục";
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
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
                string ngaytao = dNgayTao.ToString("yyyy-MM-dd");
                string ngaycapnhat = dNgayTao.ToString("yyyy-MM-dd");
                int nguoitao = BienToanCuc.UserID;

                //Xac nhan cap nhat
                if (XtraMessageBox.Show(BienToanCuc.ShowConfirm, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Them vao csdl
                    HuongDanBUS.TaoHuongDanMoiBUS(tieude, baocao, danhmuc, chitiet, ngaytao, ngaycapnhat, nguoitao);
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