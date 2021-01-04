using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraNavBar;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;

namespace NhacViecWinform.GUI.Huong_dan
{
    public partial class HuongDanHoSoBaoCao : DevExpress.XtraEditors.XtraForm
    {
        private HuongDanBUS HuongDanBUS = new HuongDanBUS();
        private HuongDanDTO HuongDanDTO = new HuongDanDTO();
        private string phanloai_baocao = "";
        private string phanloai_danhmuc = "";
        private string huongdan = BienToanCuc.huongdan_huongdan;
        private string thamkhao = BienToanCuc.huongdan_thamkhao;
        private string quydinh = BienToanCuc.huongdan_quydinh;
        private string baocaoNXT = BienToanCuc.huongdan_baocaoNXT;
        private string bcsl = BienToanCuc.huongdan_bcsl;
        private string baocaohuy = BienToanCuc.huongdan_baocaohuy;
        private string baocaoSAT = BienToanCuc.huongdan_baocaoSAT;
        private string baocaohethan = BienToanCuc.huongdan_baocaohethan;

        public HuongDanHoSoBaoCao()
        {
            InitializeComponent();
            for (int i = 0; i < navBarControl1.Groups.Count; i++)
            {
                NavBarGroup currGroup = navBarControl1.Groups[i];
                currGroup.Expanded = true;
            }
            //Trang huong dan bao cao NXT
            gvHuongDanBaoCaoNXT.CustomDrawRowIndicator += GvHuongDanBaoCaoNXT_CustomDrawRowIndicator;
            gvHuongDanBaoCaoNXT.IndicatorWidth = 30;
            gvHuongDanBaoCaoNXT.DoubleClick += GvHuongDanBaoCaoNXT_DoubleClick;
            //Trang tham khao bao cao NXT
            gvThamKhaoBaoCaoNXT.CustomDrawRowIndicator += GvThamKhaoBaoCaoNXT_CustomDrawRowIndicator;
            gvThamKhaoBaoCaoNXT.IndicatorWidth = 30;
            gvThamKhaoBaoCaoNXT.DoubleClick += GvThamKhaoBaoCaoNXT_DoubleClick;
            //Trang quy dinh bao cao NXT
            gvQuyDinhBaoCaoNXT.CustomDrawRowIndicator += GvQuyDinhBaoCaoNXT_CustomDrawRowIndicator;
            gvQuyDinhBaoCaoNXT.IndicatorWidth = 30;
            gvQuyDinhBaoCaoNXT.DoubleClick += GvQuyDinhBaoCaoNXT_DoubleClick;

            //Trang huong dan BCSL
            gvHuongDanBCSL.CustomDrawRowIndicator += GvHuongDanBCSL_CustomDrawRowIndicator;
            gvHuongDanBCSL.IndicatorWidth = 30;
            gvHuongDanBCSL.DoubleClick += GvHuongDanBCSL_DoubleClick;
            //Trang tham khao BCSL
            gvThamKhaoBCSL.CustomDrawRowIndicator += GvThamKhaoBCSL_CustomDrawRowIndicator;
            gvThamKhaoBCSL.IndicatorWidth = 30;
            gvThamKhaoBCSL.DoubleClick += GvThamKhaoBCSL_DoubleClick;
            //Trang quy dinh BCSL
            gvQuyDinhBCSL.CustomDrawRowIndicator += GvQuyDinhBCSL_CustomDrawRowIndicator;
            gvQuyDinhBCSL.IndicatorWidth = 30;
            gvQuyDinhBCSL.DoubleClick += GvQuyDinhBCSL_DoubleClick;

            //Trang huong dan bao cao huy
            gvHuongDanBaoCaoHuy.CustomDrawRowIndicator += GvHuongDanBaoCaoHuy_CustomDrawRowIndicator;
            gvHuongDanBaoCaoHuy.IndicatorWidth = 30;
            gvHuongDanBaoCaoHuy.DoubleClick += GvHuongDanBaoCaoHuy_DoubleClick;
            //Trang tham khao bao cao huy
            gvThamKhaoBaoCaoHuy.CustomDrawRowIndicator += GvThamKhaoBaoCaoHuy_CustomDrawRowIndicator;
            gvThamKhaoBaoCaoHuy.IndicatorWidth = 30;
            gvThamKhaoBaoCaoHuy.DoubleClick += GvThamKhaoBaoCaoHuy_DoubleClick;
            //Trang quy dinh bao cao huy
            gvQuyDinhBaoCaoHuy.CustomDrawRowIndicator += GvQuyDinhBaoCaoHuy_CustomDrawRowIndicator;
            gvQuyDinhBaoCaoHuy.IndicatorWidth = 30;
            gvQuyDinhBaoCaoHuy.DoubleClick += GvQuyDinhBaoCaoHuy_DoubleClick;

            //Trang huong dan bao cao SAT
            gvHuongDanBaoCaoSAT.CustomDrawRowIndicator += GvHuongDanBaoCaoSAT_CustomDrawRowIndicator;
            gvHuongDanBaoCaoSAT.IndicatorWidth = 30;
            gvHuongDanBaoCaoSAT.DoubleClick += GvHuongDanBaoCaoSAT_DoubleClick;
            //Trang tham khao bao cao SAT
            gvThamKhaoBaoCaoSAT.CustomDrawRowIndicator += GvThamKhaoBaoCaoSAT_CustomDrawRowIndicator;
            gvThamKhaoBaoCaoSAT.IndicatorWidth = 30;
            gvThamKhaoBaoCaoSAT.DoubleClick += GvThamKhaoBaoCaoSAT_DoubleClick;
            //Trang quy dinh bao cao SAT
            gvQuyDinhBaoCaoSAT.CustomDrawRowIndicator += GvQuyDinhBaoCaoSAT_CustomDrawRowIndicator;
            gvQuyDinhBaoCaoSAT.IndicatorWidth = 30;
            gvQuyDinhBaoCaoSAT.DoubleClick += GvQuyDinhBaoCaoSAT_DoubleClick;

            //Trang huong dan bao cao het han
            gvHuongDanBaoCaoHetHan.CustomDrawRowIndicator += GvHuongDanBaoCaoHetHan_CustomDrawRowIndicator;
            gvHuongDanBaoCaoHetHan.IndicatorWidth = 30;
            gvHuongDanBaoCaoHetHan.DoubleClick += GvHuongDanBaoCaoHetHan_DoubleClick;
            //Trang tham khao bao cao het han
            gvThamKhaoBaoCaoHetHan.CustomDrawRowIndicator += GvThamKhaoBaoCaoHetHan_CustomDrawRowIndicator;
            gvThamKhaoBaoCaoHetHan.IndicatorWidth = 30;
            gvThamKhaoBaoCaoHetHan.DoubleClick += GvThamKhaoBaoCaoHetHan_DoubleClick;
            //Trang quy dinh bao cao het han
            gvQuyDinhBaoCaoHetHan.CustomDrawRowIndicator += GvQuyDinhBaoCaoHetHan_CustomDrawRowIndicator;
            gvQuyDinhBaoCaoHetHan.IndicatorWidth = 30;
            gvQuyDinhBaoCaoHetHan.DoubleClick += GvQuyDinhBaoCaoHetHan_DoubleClick;
        }

        private void GvQuyDinhBCSL_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                HuongDanDTO.Id = int.Parse(gvQuyDinhBCSL.GetRowCellValue(gvQuyDinhBCSL.FocusedRowHandle, "id").ToString());

                HuongDanHoSoBaoCaoChiTiet HuongDanHoSoBaoCaoChiTiet = new HuongDanHoSoBaoCaoChiTiet(HuongDanDTO.Id);
                HuongDanHoSoBaoCaoChiTiet.ShowDialog();
            }
        }

        private void GvQuyDinhBCSL_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = e.RowHandle.ToString();
            }
        }

        private void GvQuyDinhBaoCaoHetHan_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                HuongDanDTO.Id = int.Parse(gvQuyDinhBaoCaoHetHan.GetRowCellValue(gvQuyDinhBaoCaoHetHan.FocusedRowHandle, "id").ToString());

                HuongDanHoSoBaoCaoChiTiet HuongDanHoSoBaoCaoChiTiet = new HuongDanHoSoBaoCaoChiTiet(HuongDanDTO.Id);
                HuongDanHoSoBaoCaoChiTiet.ShowDialog();
            }
        }

        private void GvQuyDinhBaoCaoHetHan_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = e.RowHandle.ToString();
            }
        }

        private void GvThamKhaoBaoCaoHetHan_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                HuongDanDTO.Id = int.Parse(gvThamKhaoBaoCaoHetHan.GetRowCellValue(gvThamKhaoBaoCaoHetHan.FocusedRowHandle, "id").ToString());

                HuongDanHoSoBaoCaoChiTiet HuongDanHoSoBaoCaoChiTiet = new HuongDanHoSoBaoCaoChiTiet(HuongDanDTO.Id);
                HuongDanHoSoBaoCaoChiTiet.ShowDialog();
            }
        }

        private void GvThamKhaoBaoCaoHetHan_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = e.RowHandle.ToString();
            }
        }

        private void GvHuongDanBaoCaoHetHan_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                HuongDanDTO.Id = int.Parse(gvHuongDanBaoCaoHetHan.GetRowCellValue(gvHuongDanBaoCaoHetHan.FocusedRowHandle, "id").ToString());

                HuongDanHoSoBaoCaoChiTiet HuongDanHoSoBaoCaoChiTiet = new HuongDanHoSoBaoCaoChiTiet(HuongDanDTO.Id);
                HuongDanHoSoBaoCaoChiTiet.ShowDialog();
            }
        }

        private void GvHuongDanBaoCaoHetHan_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = e.RowHandle.ToString();
            }
        }

        private void GvQuyDinhBaoCaoSAT_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                HuongDanDTO.Id = int.Parse(gvQuyDinhBaoCaoSAT.GetRowCellValue(gvQuyDinhBaoCaoSAT.FocusedRowHandle, "id").ToString());

                HuongDanHoSoBaoCaoChiTiet HuongDanHoSoBaoCaoChiTiet = new HuongDanHoSoBaoCaoChiTiet(HuongDanDTO.Id);
                HuongDanHoSoBaoCaoChiTiet.ShowDialog();
            }
        }

        private void GvQuyDinhBaoCaoSAT_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = e.RowHandle.ToString();
            }
        }

        private void GvThamKhaoBaoCaoSAT_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                HuongDanDTO.Id = int.Parse(gvThamKhaoBaoCaoSAT.GetRowCellValue(gvThamKhaoBaoCaoSAT.FocusedRowHandle, "id").ToString());

                HuongDanHoSoBaoCaoChiTiet HuongDanHoSoBaoCaoChiTiet = new HuongDanHoSoBaoCaoChiTiet(HuongDanDTO.Id);
                HuongDanHoSoBaoCaoChiTiet.ShowDialog();
            }
        }

        private void GvThamKhaoBaoCaoSAT_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = e.RowHandle.ToString();
            }
        }

        private void GvHuongDanBaoCaoSAT_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                HuongDanDTO.Id = int.Parse(gvHuongDanBaoCaoSAT.GetRowCellValue(gvHuongDanBaoCaoSAT.FocusedRowHandle, "id").ToString());

                HuongDanHoSoBaoCaoChiTiet HuongDanHoSoBaoCaoChiTiet = new HuongDanHoSoBaoCaoChiTiet(HuongDanDTO.Id);
                HuongDanHoSoBaoCaoChiTiet.ShowDialog();
            }
        }

        private void GvHuongDanBaoCaoSAT_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = e.RowHandle.ToString();
            }
        }

        private void GvQuyDinhBaoCaoHuy_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                HuongDanDTO.Id = int.Parse(gvQuyDinhBaoCaoHuy.GetRowCellValue(gvQuyDinhBaoCaoHuy.FocusedRowHandle, "id").ToString());

                HuongDanHoSoBaoCaoChiTiet HuongDanHoSoBaoCaoChiTiet = new HuongDanHoSoBaoCaoChiTiet(HuongDanDTO.Id);
                HuongDanHoSoBaoCaoChiTiet.ShowDialog();
            }
        }

        private void GvQuyDinhBaoCaoHuy_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = e.RowHandle.ToString();
            }
        }

        private void GvThamKhaoBaoCaoHuy_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                HuongDanDTO.Id = int.Parse(gvThamKhaoBaoCaoHuy.GetRowCellValue(gvThamKhaoBaoCaoHuy.FocusedRowHandle, "id").ToString());

                HuongDanHoSoBaoCaoChiTiet HuongDanHoSoBaoCaoChiTiet = new HuongDanHoSoBaoCaoChiTiet(HuongDanDTO.Id);
                HuongDanHoSoBaoCaoChiTiet.ShowDialog();
            }
        }

        private void GvThamKhaoBaoCaoHuy_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = e.RowHandle.ToString();
            }
        }

        private void GvHuongDanBaoCaoHuy_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                HuongDanDTO.Id = int.Parse(gvHuongDanBaoCaoHuy.GetRowCellValue(gvHuongDanBaoCaoHuy.FocusedRowHandle, "id").ToString());

                HuongDanHoSoBaoCaoChiTiet HuongDanHoSoBaoCaoChiTiet = new HuongDanHoSoBaoCaoChiTiet(HuongDanDTO.Id);
                HuongDanHoSoBaoCaoChiTiet.ShowDialog();
            }
        }

        private void GvHuongDanBaoCaoHuy_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = e.RowHandle.ToString();
            }
        }

        private void GvThamKhaoBCSL_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                HuongDanDTO.Id = int.Parse(gvThamKhaoBCSL.GetRowCellValue(gvThamKhaoBCSL.FocusedRowHandle, "id").ToString());

                HuongDanHoSoBaoCaoChiTiet HuongDanHoSoBaoCaoChiTiet = new HuongDanHoSoBaoCaoChiTiet(HuongDanDTO.Id);
                HuongDanHoSoBaoCaoChiTiet.ShowDialog();
            }
        }

        private void GvThamKhaoBCSL_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = e.RowHandle.ToString();
            }
        }

        private void GvHuongDanBCSL_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                HuongDanDTO.Id = int.Parse(gvHuongDanBCSL.GetRowCellValue(gvHuongDanBCSL.FocusedRowHandle, "id").ToString());

                HuongDanHoSoBaoCaoChiTiet HuongDanHoSoBaoCaoChiTiet = new HuongDanHoSoBaoCaoChiTiet(HuongDanDTO.Id);
                HuongDanHoSoBaoCaoChiTiet.ShowDialog();
            }
        }

        private void GvHuongDanBCSL_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = e.RowHandle.ToString();
            }
        }

        private void GvQuyDinhBaoCaoNXT_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                HuongDanDTO.Id = int.Parse(gvQuyDinhBaoCaoNXT.GetRowCellValue(gvQuyDinhBaoCaoNXT.FocusedRowHandle, "id").ToString());

                HuongDanHoSoBaoCaoChiTiet HuongDanHoSoBaoCaoChiTiet = new HuongDanHoSoBaoCaoChiTiet(HuongDanDTO.Id);
                HuongDanHoSoBaoCaoChiTiet.ShowDialog();
            }
        }

        private void GvQuyDinhBaoCaoNXT_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = e.RowHandle.ToString();
            }
        }

        private void GvThamKhaoBaoCaoNXT_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                HuongDanDTO.Id = int.Parse(gvThamKhaoBaoCaoNXT.GetRowCellValue(gvThamKhaoBaoCaoNXT.FocusedRowHandle, "id").ToString());

                HuongDanHoSoBaoCaoChiTiet HuongDanHoSoBaoCaoChiTiet = new HuongDanHoSoBaoCaoChiTiet(HuongDanDTO.Id);
                HuongDanHoSoBaoCaoChiTiet.ShowDialog();
            }
        }

        private void GvThamKhaoBaoCaoNXT_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = e.RowHandle.ToString();
            }
        }

        private void GvHuongDanBaoCaoNXT_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                HuongDanDTO.Id = int.Parse(gvHuongDanBaoCaoNXT.GetRowCellValue(gvHuongDanBaoCaoNXT.FocusedRowHandle, "id").ToString());

                HuongDanHoSoBaoCaoChiTiet HuongDanHoSoBaoCaoChiTiet = new HuongDanHoSoBaoCaoChiTiet(HuongDanDTO.Id);
                HuongDanHoSoBaoCaoChiTiet.ShowDialog();
            }
        }

        private void GvHuongDanBaoCaoNXT_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = e.RowHandle.ToString();
            }
        }

        private void itemHuongDanBaoCaoNXT_LinkClicked_1(object sender, NavBarLinkEventArgs e)
        {
            phanloai_baocao = baocaoNXT;
            phanloai_danhmuc = huongdan;
            gcHuongDanBaoCaoNXT.DataSource = HuongDanBUS.LayHuongDanBaoCaoTheoPhanLoaiBUS(phanloai_baocao, phanloai_danhmuc);

            navigationFrame1.SelectedPage = pageHuongDanBaoCaoNXT;
        }

        private void itemThamKhaoBaoCaoNXT_LinkClicked_1(object sender, NavBarLinkEventArgs e)
        {
            phanloai_baocao = baocaoNXT;
            phanloai_danhmuc = thamkhao;
            gcThamKhaoBaoCaoNXT.DataSource = HuongDanBUS.LayHuongDanBaoCaoTheoPhanLoaiBUS(phanloai_baocao, phanloai_danhmuc);

            navigationFrame1.SelectedPage = pageThamKhaoBaoCaoNXT;
        }

        private void itemQuyDinhBaoCaoNXT_LinkClicked_1(object sender, NavBarLinkEventArgs e)
        {
            phanloai_baocao = baocaoNXT;
            phanloai_danhmuc = quydinh;
            gcQuyDinhBaoCaoNXT.DataSource = HuongDanBUS.LayHuongDanBaoCaoTheoPhanLoaiBUS(phanloai_baocao, phanloai_danhmuc);

            navigationFrame1.SelectedPage = pageQuyDinhBaoCaoNXT;
        }

        private void itemHuongDanBCSL_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            phanloai_baocao = bcsl;
            phanloai_danhmuc = huongdan;
            gcHuongDanBCSL.DataSource = HuongDanBUS.LayHuongDanBaoCaoTheoPhanLoaiBUS(phanloai_baocao, phanloai_danhmuc);

            navigationFrame1.SelectedPage = pageHuongDanBCSL;
        }

        private void itemThamKhaoBCSL_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            phanloai_baocao = bcsl;
            phanloai_danhmuc = thamkhao;
            gcThamKhaoBCSL.DataSource = HuongDanBUS.LayHuongDanBaoCaoTheoPhanLoaiBUS(phanloai_baocao, phanloai_danhmuc);

            navigationFrame1.SelectedPage = pageThamKhaoBCSL;
        }

        private void itemQuyDinhBCSL_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            phanloai_baocao = bcsl;
            phanloai_danhmuc = quydinh;
            gcQuyDinhBCSL.DataSource = HuongDanBUS.LayHuongDanBaoCaoTheoPhanLoaiBUS(phanloai_baocao, phanloai_danhmuc);

            navigationFrame1.SelectedPage = pageQuyDinhBCSL;
        }

        private void itemHuongDanBaoCaoHuy_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            phanloai_baocao = baocaohuy;
            phanloai_danhmuc = huongdan;
            gcHuongDanBaoCaoHuy.DataSource = HuongDanBUS.LayHuongDanBaoCaoTheoPhanLoaiBUS(phanloai_baocao, phanloai_danhmuc);

            navigationFrame1.SelectedPage = pageHuongDanBaoCaoHuy;
        }

        private void itemThamKhaoBaoCaoHuy_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            phanloai_baocao = baocaohuy;
            phanloai_danhmuc = thamkhao;
            gcThamKhaoBaoCaoHuy.DataSource = HuongDanBUS.LayHuongDanBaoCaoTheoPhanLoaiBUS(phanloai_baocao, phanloai_danhmuc);

            navigationFrame1.SelectedPage = pageThamKhaoBaoCaoHuy;
        }

        private void itemQuyDinhBaoCaoHuy_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            phanloai_baocao = baocaohuy;
            phanloai_danhmuc = quydinh;
            gcQuyDinhBaoCaoHuy.DataSource = HuongDanBUS.LayHuongDanBaoCaoTheoPhanLoaiBUS(phanloai_baocao, phanloai_danhmuc);

            navigationFrame1.SelectedPage = pageQuyDinhBaoCaoHuy;
        }

        private void itemHuongDanBaoCaoSAT_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            phanloai_baocao = baocaoSAT;
            phanloai_danhmuc = huongdan;
            gcHuongDanBaoCaoSAT.DataSource = HuongDanBUS.LayHuongDanBaoCaoTheoPhanLoaiBUS(phanloai_baocao, phanloai_danhmuc);

            navigationFrame1.SelectedPage = pageHuongDanBaoCaoSAT;
        }

        private void itemThamKhaoBaoCaoSAT_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            phanloai_baocao = baocaoSAT;
            phanloai_danhmuc = thamkhao;
            gcThamKhaoBaoCaoSAT.DataSource = HuongDanBUS.LayHuongDanBaoCaoTheoPhanLoaiBUS(phanloai_baocao, phanloai_danhmuc);

            navigationFrame1.SelectedPage = pageThamKhaoBaoCaoSAT;
        }

        private void itemQuyDinhBaoCaoSAT_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            phanloai_baocao = baocaoSAT;
            phanloai_danhmuc = quydinh;
            gcQuyDinhBaoCaoSAT.DataSource = HuongDanBUS.LayHuongDanBaoCaoTheoPhanLoaiBUS(phanloai_baocao, phanloai_danhmuc);

            navigationFrame1.SelectedPage = pageQuyDinhBaoCaoSAT;
        }

        private void itemHuongDanBaoCaoHetHan_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            phanloai_baocao = baocaohethan;
            phanloai_danhmuc = huongdan;
            gcHuongDanBaoCaoHetHan.DataSource = HuongDanBUS.LayHuongDanBaoCaoTheoPhanLoaiBUS(phanloai_baocao, phanloai_danhmuc);

            navigationFrame1.SelectedPage = pageHuongDanBaoCaoHetHan;
        }

        private void itemThamKhaoBaoCaoHetHan_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            phanloai_baocao = baocaohethan;
            phanloai_danhmuc = thamkhao;
            gcThamKhaoBaoCaoHetHan.DataSource = HuongDanBUS.LayHuongDanBaoCaoTheoPhanLoaiBUS(phanloai_baocao, phanloai_danhmuc);

            navigationFrame1.SelectedPage = pageThamKhaoBaoCaoHetHan;
        }

        private void itemQuyDinhBaoCaoHetHan_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            phanloai_baocao = baocaohethan;
            phanloai_danhmuc = quydinh;
            gcQuyDinhBaoCaoHetHan.DataSource = HuongDanBUS.LayHuongDanBaoCaoTheoPhanLoaiBUS(phanloai_baocao, phanloai_danhmuc);

            navigationFrame1.SelectedPage = pageQuyDinhBaoCaoHetHan;
        }
    }
}