using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;
using System.Drawing;

namespace NhacViecWinform.GUI
{
    public partial class ViecKSNB : DevExpress.XtraEditors.XtraForm
    {
        private ViecKSNBBUS ViecKSNBBUS = new ViecKSNBBUS();
        private ViecKSNBDTO ViecKSNBDTO = new ViecKSNBDTO();
        private BienToanCuc BienToanCuc = new BienToanCuc();
        private DateTime ngayhientai = DateTime.Now;
        private string PhuTrach = "";
        private DateTime ngaytao = new DateTime();

        public ViecKSNB()
        {
            InitializeComponent();
            string ngaytao = Convert.ToString(ngayhientai.ToString("yyyy-MM-dd"));
            ViecKSNBDTO = ViecKSNBBUS.HienThiPhuTrach(ngaytao);
            gcCongViecKSNB.DataSource = ViecKSNBBUS.LayTrungTamBUS(ngaytao);
            //repositoryItemMemoEdit1.WordWrap = true;
            gvCongViecKSNB.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(gridView1_RowCellStyle);
            gvCongViecKSNB.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridView1_CellValueChanged);
        }

        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            ViecKSNBDTO.Phutrach_id = int.Parse(gvCongViecKSNB.GetRowCellValue(e.RowHandle, gvCongViecKSNB.Columns["phutrach_id"]).ToString());
            ViecKSNBDTO.Baocaonxt = gvCongViecKSNB.GetRowCellValue(e.RowHandle, gvCongViecKSNB.Columns["baocaonxt"]).ToString();
            ViecKSNBDTO.Hosocxlksnb = gvCongViecKSNB.GetRowCellValue(e.RowHandle, gvCongViecKSNB.Columns["hosocxlksnb"]).ToString();
            ViecKSNBDTO.Phieuchuyenkhoqas = gvCongViecKSNB.GetRowCellValue(e.RowHandle, gvCongViecKSNB.Columns["phieuchuyenkhoqas"]).ToString();
            ViecKSNBDTO.Phieuhuyqas = gvCongViecKSNB.GetRowCellValue(e.RowHandle, gvCongViecKSNB.Columns["phieuhuyqas"]).ToString();
            ViecKSNBDTO.Hosohuy = gvCongViecKSNB.GetRowCellValue(e.RowHandle, gvCongViecKSNB.Columns["hosohuy"]).ToString();
            ViecKSNBDTO.Baocaosailech = gvCongViecKSNB.GetRowCellValue(e.RowHandle, gvCongViecKSNB.Columns["baocaosailech"]).ToString();
            ViecKSNBDTO.Ngaytao = Convert.ToString(ngayhientai.ToString("yyyy-MM-dd"));
            ViecKSNBBUS.TaoCongViecHangNgayBUS(ViecKSNBDTO.Baocaonxt, ViecKSNBDTO.Hosocxlksnb, ViecKSNBDTO.Phieuchuyenkhoqas, ViecKSNBDTO.Phieuhuyqas, ViecKSNBDTO.Hosohuy, ViecKSNBDTO.Baocaosailech, ViecKSNBDTO.Ngaytao, ViecKSNBDTO.Phutrach_id);
        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            PhuTrach = gvCongViecKSNB.GetRowCellValue(e.RowHandle, "phutrach").ToString();
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

        private void deChonNgay_EditValueChanged(object sender, EventArgs e)
        {
            ngaytao = DateTime.Parse(deChonNgay.Text);
            ViecKSNBDTO.Ngaytao = Convert.ToString(ngaytao.ToString("yyyy-MM-dd"));
            gcCongViecKSNB.DataSource = ViecKSNBBUS.LayCongViecNgayCuBUS(ViecKSNBDTO.Ngaytao);
        }
    }
}