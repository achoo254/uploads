using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using HoTroNhacViecWinform.BUS;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace NhacViecWinform.GUI.Bao_cao
{
    public partial class BaoCao : DevExpress.XtraEditors.XtraForm
    {
        private TonDongBUS TonDongBUS = new TonDongBUS();
        NamThangBUS NamThangBUS = new NamThangBUS();
        DateTime today = DateTime.Now;
        public BaoCao()
        {
            InitializeComponent();
            string thang = today.Month.ToString();
            string nam = today.Year.ToString();
            leChonNam.Properties.DataSource = NamThangBUS.HienThiNam();
            leChonNam.Properties.ValueMember = "nam";
            leChonNam.Properties.DisplayMember = "nam";
            leChonNam.EditValue = nam;

            leChonThang.Properties.DataSource = NamThangBUS.HienThiThang();
            leChonThang.Properties.ValueMember = "thang";
            leChonThang.Properties.DisplayMember = "thang";
            leChonThang.EditValue = thang;
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            string tag = ((WindowsUIButton)e.Button).Tag.ToString();
            switch (tag)
            {
                case "tondong":
                    BaoCaoBCSLTonDong BaoCaoBCSLTonDong = new BaoCaoBCSLTonDong();
                    ReportPrintTool toolBCSLTonDong = new ReportPrintTool(BaoCaoBCSLTonDong);
                    BaoCaoBCSLTonDong.Parameters["pmNam"].Value = leChonNam.EditValue.ToString();
                    BaoCaoBCSLTonDong.Parameters["pmThang"].Value = leChonThang.EditValue.ToString();
                    toolBCSLTonDong.ShowPreview();
                    break;
                case "choxuly":
                    BaoCaoTonKhoChoXuLy BaoCaoTonKhoChoXuLy = new BaoCaoTonKhoChoXuLy();
                    ReportPrintTool toolTonKhoCXL = new ReportPrintTool(BaoCaoTonKhoChoXuLy);
                    BaoCaoTonKhoChoXuLy.Parameters["pmNam"].Value = leChonNam.EditValue.ToString();
                    BaoCaoTonKhoChoXuLy.Parameters["pmThang"].Value = leChonThang.EditValue.ToString();
                    toolTonKhoCXL.ShowPreview();
                    break;
                case "lichkiemke":
                    BaoCaoLichKiemKe BaoCaoLichKiemKe = new BaoCaoLichKiemKe();
                    ReportPrintTool toolBaoCaoLichKiemKe = new ReportPrintTool(BaoCaoLichKiemKe);
                    BaoCaoLichKiemKe.Parameters["pmNam"].Value = leChonNam.EditValue.ToString();
                    BaoCaoLichKiemKe.Parameters["pmThang"].Value = leChonThang.EditValue.ToString();
                    toolBaoCaoLichKiemKe.ShowPreview();
                    break;
                case "lienhe":
                    XtraMessageBox.Show("Liên hệ Hoàn Đạt để thiết kế báo cáo theo nhu cầu công việc của bạn!");
                    break;
            }
        }
    }
}