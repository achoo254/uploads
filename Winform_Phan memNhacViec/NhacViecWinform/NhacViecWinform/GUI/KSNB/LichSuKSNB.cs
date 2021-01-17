using DevExpress.XtraGrid.Views.Grid;
using HoTroNhacViecWinform.BUS;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;
using System.Drawing;

namespace NhacViecWinform.GUI
{
    public partial class LichSuKSNB : DevExpress.XtraEditors.XtraForm
    {
        private ViecKSNBBUS ViecKSNBBUS = new ViecKSNBBUS();
        private ViecKSNBDTO ViecKSNBDTO = new ViecKSNBDTO();
        private TrungTamBUS TrungTamBUS = new TrungTamBUS();
        private DateTime ngaytao = new DateTime();
        private string PhuTrach = "";

        public LichSuKSNB()
        {
            InitializeComponent();
            repositoryItemMemoEdit1.WordWrap = true;

            deLichSu.EditValueChanged += new EventHandler(deLichSu_EditValueChanged);
            gvLichSuKSNB.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(gvLichSuKSNB_RowCellStyle);
        }

        private void gvLichSuKSNB_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            PhuTrach = gvLichSuKSNB.GetRowCellValue(e.RowHandle, "phutrach").ToString();
            if (PhuTrach == BienToanCuc.phutrach_khong)
            {
                if (e.Column.FieldName == "baocaonxt" || e.Column.FieldName == "hosocxlksnb" || e.Column.FieldName == "phieuchuyenkhoqas" || e.Column.FieldName == "baocaosailech" || e.Column.FieldName == "phieuhuyqas" || e.Column.FieldName == "hosohuy")
                {
                    e.Appearance.BackColor = Color.Black;
                }
            }
            else if (PhuTrach == BienToanCuc.phutrach_baocaohuy)
            {
                if (e.Column.FieldName == "hosocxlksnb" || e.Column.FieldName == "phieuchuyenkhoqas" || e.Column.FieldName == "baocaosailech")
                {
                    e.Appearance.BackColor = Color.Black;
                }
            }
            else if (PhuTrach == BienToanCuc.phutrach_baocaosailech)
            {
                if (e.Column.FieldName == "phieuhuyqas" || e.Column.FieldName == "hosohuy")
                {
                    e.Appearance.BackColor = Color.Black;
                }
            }
        }

        private void deLichSu_EditValueChanged(object sender, EventArgs e)
        {
            ngaytao = DateTime.Parse(deLichSu.Text);
            ViecKSNBDTO.Ngaytao = Convert.ToString(ngaytao.ToString("yyyy-MM-dd"));

            gcLichSuKSNB.DataSource = ViecKSNBBUS.LayLichSuTrungTamPhuTrachBUS(ViecKSNBDTO.Ngaytao);
        }
    }
}