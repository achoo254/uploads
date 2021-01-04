using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.Spreadsheet;
using NhacViecWinform.DTO;
using HoTroNhacViecWinform.BUS;
using HoTroNhacViecWinform.DTO;

namespace HoTroNhacViecWinform.GUI.KSNB
{
    public partial class LichKiemKe : DevExpress.XtraEditors.XtraForm
    {
        NamThangBUS NamThangBUS = new NamThangBUS();
        KSNB_LichKiemKeBUS KSNB_LichKiemKeBUS = new KSNB_LichKiemKeBUS();
        KSNB_LichKiemKeDTO KSNB_LichKiemKeDTO = new KSNB_LichKiemKeDTO();
        DateTime today = DateTime.Now;
        public LichKiemKe()
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

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                gcLichKiemKe.DataSource = BienToanCuc.ExcelToDataTableByDevExpress(xtraOpenFileDialog1.FileName);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(gcLichKiemKe.DataSource != null)
            {
                //Doc tong so dong tren luoi
                int rowLichKiemKe = 0;
                while (gvLichKiemKe.IsValidRowHandle(rowLichKiemKe))
                {
                    rowLichKiemKe++;
                }
                //Xoa du lieu cu truoc khi cap nhat
                if (XtraMessageBox.Show(BienToanCuc.ShowDeleteBeforeInsert, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //Thuc hien xoa va tao bien mac dinh
                        string thang = leChonThang.EditValue.ToString();
                        string nam = leChonNam.EditValue.ToString();
                        DateTime dNgaycapnhat = new DateTime(int.Parse(nam), int.Parse(thang), today.Day);
                        int nguoitao_id = BienToanCuc.UserID;
                        string ngaycapnhat = dNgaycapnhat.ToString("yyyy-MM-dd");

                        KSNB_LichKiemKeBUS.XoaLichKiemKeTheoIdThanhVienBUS(thang, nam, nguoitao_id);
                        //Doc tung dong tren luoi cua ton kho cho xu ly
                        for (int i = 0; i < rowLichKiemKe; i++)
                        {
                            if (!string.IsNullOrEmpty(gvLichKiemKe.GetRowCellValue(i, colTrungTam).ToString()))
                            {
                                string trungtam = gvLichKiemKe.GetRowCellValue(i, colTrungTam).ToString();
                                string tenkho = gvLichKiemKe.GetRowCellValue(i, colTenKho).ToString();
                                string thoigiankiemke = gvLichKiemKe.GetRowCellValue(i, colThoiGianKiemKe).ToString();
                                DateTime dngaykiemke = DateTime.Parse(gvLichKiemKe.GetRowCellValue(i, colNgayKiemKe).ToString());
                                string ngaykiemke = dngaykiemke.ToString("yyyy-MM-dd");
                                int phongtiem_tong = int.Parse(gvLichKiemKe.GetRowCellValue(i, colTongPhongTiem).ToString());
                                int phongtiem_nghi = int.Parse(gvLichKiemKe.GetRowCellValue(i, colSoPhongTiemOff).ToString());
                                int phongtiem_kiemsang = int.Parse(gvLichKiemKe.GetRowCellValue(i, colTongSoPhongTiemKiemBuoiSang).ToString());
                                string nhanvien_chinh = gvLichKiemKe.GetRowCellValue(i, colNhanVienChinh).ToString();
                                string nhanvien_phu = gvLichKiemKe.GetRowCellValue(i, colNhanVienPhu).ToString();
                                string khoangcach = gvLichKiemKe.GetRowCellValue(i, colKhoangCach).ToString();
                               
                                KSNB_LichKiemKeBUS.ThemLichKiemKeBUS(trungtam, tenkho, thoigiankiemke, ngaykiemke, phongtiem_tong, phongtiem_nghi, phongtiem_kiemsang, nhanvien_chinh, nhanvien_phu, khoangcach, ngaycapnhat, nguoitao_id);
                            }
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show(BienToanCuc.ShowError, BienToanCuc.ShowAlert);
                    }
                    finally
                    {
                        gcLichKiemKe.DataSource = null;
                        XtraMessageBox.Show(BienToanCuc.ShowSuccess, BienToanCuc.ShowAlert);
                    }
                }   
            }
            else
            {
                XtraMessageBox.Show(BienToanCuc.ShowEmpty, BienToanCuc.ShowAlert);
            }
        }

        private void btnXemLichKiemKe_Click(object sender, EventArgs e)
        {
            LichKiemKe_Xem LichKiemKe_Xem = new LichKiemKe_Xem(leChonThang.EditValue.ToString(), leChonNam.EditValue.ToString());
            LichKiemKe_Xem.ShowDialog();
        }
    }
}