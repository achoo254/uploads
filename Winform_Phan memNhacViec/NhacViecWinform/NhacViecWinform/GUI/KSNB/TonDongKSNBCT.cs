using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;

namespace NhacViecWinform.GUI.KSNB
{
    public partial class TonDongKSNBCT : DevExpress.XtraEditors.XtraForm
    {
        private TonDongBUS TonDongBUS = new TonDongBUS();
        private TonDongDTO TonDongDTO = new TonDongDTO();
        private HoSoBUS HoSoBUS = new HoSoBUS();
        private TheoDoiBUS TheoDoiBUS = new TheoDoiBUS();
        TheoDoiDTO TheoDoiDTO = new TheoDoiDTO();
        private BienToanCuc BienToanCuc = new BienToanCuc();

        public TonDongKSNBCT()
        {
            InitializeComponent();

            leTrungTam.Properties.DataSource = TonDongBUS.LayDanhSachTrungTamBUS();
            leTrungTam.Properties.ValueMember = "id";
            leTrungTam.Properties.DisplayMember = "ten";

            leHoSo.Properties.DataSource = HoSoBUS.LayDanhSachHoSoBUS();
            leHoSo.Properties.ValueMember = "id";
            leHoSo.Properties.DisplayMember = "ten";

            TonDongDTO = TonDongBUS.LayDanhSachTonDongChiTietBUS();
            TheoDoiDTO = TheoDoiBUS.LayTinhTrangHuongXuLyMoiNhatTheoDoiBUS(TonDongDTO.Id);

            leTrungTam.EditValue = TonDongDTO.Trungtam_id;
            leHoSo.EditValue = TonDongDTO.Hoso_id;
            deNgayHoSo.EditValue = TonDongDTO.Ngayhoso;
            txtTenKho.Text = TonDongDTO.Tenkho;
            txtTenVacXin.Text = TonDongDTO.Tenvacxin;
            meNguyenNhan.Text = TonDongDTO.Nguyennhan;
            ceHoanTat.IsOn = Convert.ToBoolean(TonDongDTO.Hoantat);
            meTinhTrang.Text = TheoDoiDTO.Tinhtrang;
            meHuongXuLy.Text = TheoDoiDTO.Huongxuly;

            gcTonDongCT.DataSource = TheoDoiBUS.LayDanhSachTheoDoiBUS(TonDongDTO.Id);
            repositoryItemMemoEdit1.WordWrap = true;

            if (TonDongDTO.Hoantat == 1)
            {
                leTrungTam.ReadOnly = true;
                leHoSo.ReadOnly = true;
                deNgayHoSo.ReadOnly = true;
                txtTenKho.ReadOnly = true;
                txtTenVacXin.ReadOnly = true;
                meNguyenNhan.ReadOnly = true;
                meTinhTrang.ReadOnly = true;
                meHuongXuLy.ReadOnly = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (leTrungTam.Text != "" && txtTenKho.Text != "" && deNgayHoSo.Text != "" && txtTenVacXin.Text != "" && meNguyenNhan.Text != "" && leHoSo.Text != "")
            {
                DateTime dNgayHoSo = DateTime.Parse(deNgayHoSo.Text);
                string NgayHoSo = dNgayHoSo.ToString("yyyy-MM-dd");

                int Trungtam_id = int.Parse(leTrungTam.EditValue.ToString());
                int Hoso_id = int.Parse(leHoSo.EditValue.ToString());
                DateTime dNgayTheoDoi = DateTime.Now;
                string NgayTheoDoi = dNgayTheoDoi.ToString("yyyy-MM-dd");
                byte hoantat = 0;
                if (ceHoanTat.IsOn == false)
                {
                    hoantat = 0;
                }
                else if (ceHoanTat.IsOn == true)
                {
                    hoantat = 1;
                }
                TonDongBUS.SuaTonDongBUS(TonDongDTO.Id, Trungtam_id, txtTenKho.Text, NgayHoSo, txtTenVacXin.Text, meNguyenNhan.Text, hoantat, Hoso_id, BienToanCuc.UserID);
                
                TheoDoiBUS.ThemHoacSuaTheoDoiBUS(TonDongDTO.Id, NgayTheoDoi, meTinhTrang.Text, meHuongXuLy.Text);

                gcTonDongCT.DataSource = TheoDoiBUS.LayDanhSachTheoDoiBUS(TonDongDTO.Id);
                BienToanCuc.gc_TonDong.DataSource = TonDongBUS.LayDanhSachTonDongBUS();

                lblMessage.Text = BienToanCuc.ShowSuccess;
            }
            else
            {
                lblMessage.Text = BienToanCuc.ShowEmpty;
            }
        }
    }
}