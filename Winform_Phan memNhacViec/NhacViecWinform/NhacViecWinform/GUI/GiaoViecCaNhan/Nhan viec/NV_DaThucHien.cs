using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;

namespace NhacViecWinform.GUI.Chuc_nang
{
    public partial class NV_DaThucHien : DevExpress.XtraEditors.XtraForm
    {
        private WorkflowBUS WorkflowBUS = new WorkflowBUS();

        public NV_DaThucHien()
        {
            InitializeComponent();
            //tao su kien click row
            gridView1.DoubleClick += new EventHandler(gridView1_DoubleClick);
            //Do du lieu gridview
            BienToanCuc.gc_NV_DaThucHien = gridControl1;
            BienToanCuc.gv_NV_DaThucHien = gridView1;
            BienToanCuc.gc_NV_DaThucHien.DataSource = WorkflowBUS.HienThiNhanViecDaThucHienBUS(BienToanCuc.UserID);
            BienToanCuc.gv_NV_DaThucHien.Columns["id"].Visible = false;
            BienToanCuc.gv_NV_DaThucHien.Columns["workflow_id"].Visible = false;
            BienToanCuc.gv_NV_DaThucHien.Columns["Ngày nhắc việc"].DisplayFormat.FormatType = FormatType.DateTime;
            BienToanCuc.gv_NV_DaThucHien.Columns["Ngày nhắc việc"].DisplayFormat.FormatString = "dd-MM-yyyy HH:mm";
            BienToanCuc.gv_NV_DaThucHien.Columns["Ngày nhắc lại"].DisplayFormat.FormatType = FormatType.DateTime;
            BienToanCuc.gv_NV_DaThucHien.Columns["Ngày nhắc lại"].DisplayFormat.FormatString = "dd-MM-yyyy HH:mm";
            BienToanCuc.gv_NV_DaThucHien.Columns["Ngày hoàn thành"].DisplayFormat.FormatType = FormatType.DateTime;
            BienToanCuc.gv_NV_DaThucHien.Columns["Ngày hoàn thành"].DisplayFormat.FormatString = "dd-MM-yyyy HH:mm";
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
                BienToanCuc.todolist_id = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "id").ToString());
                BienToanCuc.workflow_id = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "workflow_id").ToString());

                NV_DaThucHienCT NV_DaThucHienCT = new NV_DaThucHienCT();
                NV_DaThucHienCT.ShowDialog();
            }
        }
    }
}