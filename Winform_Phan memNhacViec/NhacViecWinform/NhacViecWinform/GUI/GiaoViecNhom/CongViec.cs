using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;
using System.Drawing;

namespace NhacViecWinform.GUI.Kanban
{
    public partial class CongViec : DevExpress.XtraEditors.XtraForm
    {
        private KB_CongViecBUS KB_CongViecBUS = new KB_CongViecBUS();
        private KB_CongViecDTO KB_CongViecDTO = new KB_CongViecDTO();

        public CongViec()
        {
            InitializeComponent();
            BienToanCuc.gc_CongViecDaNhan = gcCongViecNhan;
            BienToanCuc.gv_CongViecDaNhan = gvCongViecNhan;
            BienToanCuc.gc_CongViecDaGui = gcCongViecGui;
            BienToanCuc.gv_CongViecDaGui = gvCongViecGui;

            BienToanCuc.gc_CongViecDaGui.DataSource = KB_CongViecBUS.HienThiCongViecGuiBUS(BienToanCuc.UserID);
            BienToanCuc.gc_CongViecDaNhan.DataSource = KB_CongViecBUS.HienThiCongViecNhanBUS(BienToanCuc.UserID);

            BienToanCuc.gv_CongViecDaGui.RowCellStyle += GridView1_RowCellStyle;
            BienToanCuc.gv_CongViecDaNhan.RowCellStyle += GvCongViecNhan_RowCellStyle;

            BienToanCuc.gv_CongViecDaGui.DoubleClick += Gv_CongViecDaGui_DoubleClick;
            BienToanCuc.gv_CongViecDaNhan.DoubleClick += new System.EventHandler(gvCongViecNhan_DoubleClick);
        }

        private void Gv_CongViecDaGui_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                //string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                if (gvCongViecGui.GetRowCellValue(gvCongViecGui.FocusedRowHandle, colNGId) != null)
                {
                    KB_CongViecDTO.Id = int.Parse(gvCongViecGui.GetRowCellValue(gvCongViecGui.FocusedRowHandle, colNGId).ToString());
                }

                DaGuiCongViec DaGuiCongViec = new DaGuiCongViec(KB_CongViecDTO.Id);
                DaGuiCongViec.ShowDialog();
            }
        }

        private void gvCongViecNhan_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                //string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                if (gvCongViecNhan.GetRowCellValue(gvCongViecNhan.FocusedRowHandle, colNGId) != null)
                {
                    KB_CongViecDTO.Id = int.Parse(gvCongViecNhan.GetRowCellValue(gvCongViecNhan.FocusedRowHandle, colNGId).ToString());
                }

                CapNhatCongViec CapNhatCongViec = new CapNhatCongViec(KB_CongViecDTO.Id);
                CapNhatCongViec.ShowDialog();
            }
        }

        private void GvCongViecNhan_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (gvCongViecNhan.GetRowCellValue(e.RowHandle, "ma_mau") != null)
            {
                var ma_mau = gvCongViecNhan.GetRowCellValue(e.RowHandle, "ma_mau").ToString();
                Color mau = Color.FromName(ma_mau);
                if (e.Column.FieldName == "n_tieude")
                {
                    e.Appearance.BackColor = mau;
                }
            }
        }

        private void GridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (gvCongViecGui.GetRowCellValue(e.RowHandle, "ma_mau") != null)
            {
                var ma_mau = gvCongViecGui.GetRowCellValue(e.RowHandle, "ma_mau").ToString();
                Color mau = Color.FromName(ma_mau);
                if (e.Column.FieldName == "n_tieude")
                {
                    e.Appearance.BackColor = mau;
                }
            }
        }
    }
}