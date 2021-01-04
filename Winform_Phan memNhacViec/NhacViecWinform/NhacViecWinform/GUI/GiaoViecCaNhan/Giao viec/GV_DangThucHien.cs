using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;

namespace NhacViecWinform.GUI.Chuc_nang
{
    public partial class GV_DangThucHien : DevExpress.XtraEditors.XtraForm
    {
        private WorkflowBUS WorkflowBUS = new WorkflowBUS();

        public GV_DangThucHien()
        {
            InitializeComponent();
            //tao su kien click row
            gridView1.DoubleClick += new EventHandler(gridView1_DoubleClick);
            //active = true cong viec dang thuc hien
            byte active = 1;
            //Do du lieu gridview
            BienToanCuc.gc_GV_DangThucHien = gridControl1;
            BienToanCuc.gv_GV_DangThucHien = gridView1;
            BienToanCuc.gc_GV_DangThucHien.DataSource = WorkflowBUS.HienThiGiaoViecDangThucHienBUS(BienToanCuc.UserID, active);
            BienToanCuc.gv_GV_DangThucHien.Columns["id"].Visible = false;
            BienToanCuc.gv_GV_DangThucHien.Columns["Ngày nhắc việc"].DisplayFormat.FormatType = FormatType.DateTime;
            BienToanCuc.gv_GV_DangThucHien.Columns["Ngày nhắc việc"].DisplayFormat.FormatString = "dd-MM-yyyy HH:mm";
            BienToanCuc.gv_GV_DangThucHien.Columns["Ngày nhắc lại"].DisplayFormat.FormatType = FormatType.DateTime;
            BienToanCuc.gv_GV_DangThucHien.Columns["Ngày nhắc lại"].DisplayFormat.FormatString = "dd-MM-yyyy HH:mm";
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                BienToanCuc.workflow_id = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id").ToString());

                GV_DangThucHienCT GV_DangThucHienCT = new GV_DangThucHienCT();
                GV_DangThucHienCT.ShowDialog();
            }
        }
    }
}