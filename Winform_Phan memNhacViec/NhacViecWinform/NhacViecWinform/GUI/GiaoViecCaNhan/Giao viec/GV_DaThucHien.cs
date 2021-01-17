using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;

namespace NhacViecWinform.GUI.Chuc_nang
{
    public partial class GV_DaThucHien : DevExpress.XtraEditors.XtraForm
    {
        private WorkflowBUS WorkflowBUS = new WorkflowBUS();

        public GV_DaThucHien()
        {
            InitializeComponent();
            //tao su kien click row
            gridView1.DoubleClick += new EventHandler(gridView1_DoubleClick);
            //active = false cong viec da thuc hien
            byte active = 0;
            //Do du lieu gridview
            BienToanCuc.gc_GV_DaThucHien = gridControl1;
            BienToanCuc.gv_GV_DaThucHien = gridView1;
            BienToanCuc.gc_GV_DaThucHien.DataSource = WorkflowBUS.HienThiGiaoViecDaThucHienBUS(BienToanCuc.UserID, active);
            BienToanCuc.gv_GV_DaThucHien.Columns["todolist_id"].Visible = false;
            BienToanCuc.gv_GV_DaThucHien.Columns["workflow_id"].Visible = false;
            BienToanCuc.gv_GV_DaThucHien.Columns["Ngày nhắc việc"].DisplayFormat.FormatType = FormatType.DateTime;
            BienToanCuc.gv_GV_DaThucHien.Columns["Ngày nhắc việc"].DisplayFormat.FormatString = "dd-MM-yyyy HH:mm";
            BienToanCuc.gv_GV_DaThucHien.Columns["Ngày nhắc lại"].DisplayFormat.FormatType = FormatType.DateTime;
            BienToanCuc.gv_GV_DaThucHien.Columns["Ngày nhắc lại"].DisplayFormat.FormatString = "dd-MM-yyyy HH:mm";
            BienToanCuc.gv_GV_DaThucHien.Columns["Ngày thực hiện"].DisplayFormat.FormatType = FormatType.DateTime;
            BienToanCuc.gv_GV_DaThucHien.Columns["Ngày thực hiện"].DisplayFormat.FormatString = "dd-MM-yyyy HH:mm";
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
                BienToanCuc.todolist_id = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "todolist_id").ToString());
                BienToanCuc.workflow_id = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "workflow_id").ToString());

                GV_DaThucHienCT GV_DaThucHienCT = new GV_DaThucHienCT();
                GV_DaThucHienCT.ShowDialog();
            }
        }
    }
}