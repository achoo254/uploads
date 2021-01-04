using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;

namespace NhacViecWinform.GUI.KSNB
{
    public partial class TonDongKSNB : DevExpress.XtraEditors.XtraForm
    {
        private TonDongBUS TonDongBUS = new TonDongBUS();
        private HoSoBUS HoSoBUS = new HoSoBUS();
        private BienToanCuc BienToanCuc = new BienToanCuc();

        public TonDongKSNB()
        {
            InitializeComponent();
            BienToanCuc.gc_TonDong = gcTonDong;
            BienToanCuc.gv_TonDong = gvTonDong;
            leTrungTam.Properties.DataSource = TonDongBUS.LayDanhSachTrungTamBUS();
            leTrungTam.Properties.ValueMember = "id";
            leTrungTam.Properties.DisplayMember = "ten";
            leHoSo.Properties.DataSource = HoSoBUS.LayDanhSachHoSoBUS();
            leHoSo.Properties.ValueMember = "id";
            leHoSo.Properties.DisplayMember = "ten";
            gcTonDong.DataSource = TonDongBUS.LayDanhSachTonDongBUS();
            gvTonDong.DoubleClick += new EventHandler(gvTonDong_DoubleClick);
        }

        private void gvTonDong_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                BienToanCuc.tondong_id = int.Parse(gvTonDong.GetRowCellValue(gvTonDong.FocusedRowHandle, "tondong_id").ToString());

                TonDongKSNBCT TonDongKSNBCT = new TonDongKSNBCT();
                TonDongKSNBCT.ShowDialog();
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (leTrungTam.Text != "" && txtTenKho.Text != "" && deNgayHoSo.Text != "" && txtTenVacXin.Text != "" && meNguyenNhan.Text != "" && leHoSo.Text != "")
            {
                DateTime dNgayHoSo = DateTime.Parse(deNgayHoSo.Text);
                string NgayHoSo = dNgayHoSo.ToString("yyyy-MM-dd");
                int Trungtam_id = int.Parse(leTrungTam.EditValue.ToString());
                byte hoantat = 0;
                int Hoso_id = int.Parse(leHoSo.EditValue.ToString());

                TonDongBUS.ThemTonDongBUS(Trungtam_id, txtTenKho.Text, NgayHoSo, txtTenVacXin.Text, meNguyenNhan.Text, hoantat, Hoso_id, BienToanCuc.UserID);

                gcTonDong.DataSource = TonDongBUS.LayDanhSachTonDongBUS();
                BienToanCuc.gc_TonDong = gcTonDong;
                BienToanCuc.gv_TonDong = gvTonDong;

                lblMessage.Text = BienToanCuc.ShowSuccess;
            }
            else
            {
                lblMessage.Text = BienToanCuc.ShowEmpty;
            }
        }
    }
}