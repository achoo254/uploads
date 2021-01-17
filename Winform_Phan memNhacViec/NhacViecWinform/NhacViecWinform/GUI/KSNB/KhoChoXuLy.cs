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
    public partial class KhoChoXuLy : DevExpress.XtraEditors.XtraForm
    {
        NamThangBUS NamThangBUS = new NamThangBUS();
        KSNB_KhoChoXuLyBUS KSNB_KhoChoXuLyBUS = new KSNB_KhoChoXuLyBUS();
        KSNB_KhoChoXuLyDTO KSNB_KhoChoXuLyDTO = new KSNB_KhoChoXuLyDTO();
        DateTime today = DateTime.Now;
        public KhoChoXuLy()
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
                gcTonKhoChoXuLy.DataSource = BienToanCuc.ExcelToDataTableByDevExpress(xtraOpenFileDialog1.FileName);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(gcTonKhoChoXuLy.DataSource != null)
            {
                //Doc tong so dong tren luoi
                int rowTonKhoChoXuLy = 0;
                while (gvTonKhoChoXuLy.IsValidRowHandle(rowTonKhoChoXuLy))
                {
                    rowTonKhoChoXuLy++;
                }
                //Xoa du lieu cu truoc khi cap nhat
                if (XtraMessageBox.Show(BienToanCuc.ShowDeleteBeforeInsert, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        //Thuc hien xoa va tao bien mac dinh
                        string thang = leChonThang.EditValue.ToString();
                        string nam = leChonNam.EditValue.ToString();
                        DateTime dNgaycapnhat = new DateTime(int.Parse(nam), int.Parse(thang), 1);
                        int nguoitao_id = BienToanCuc.UserID;
                        string ngaycapnhat = dNgaycapnhat.ToString("yyyy-MM-dd");

                        KSNB_KhoChoXuLyBUS.XoaKhoChoXuLyTheoIdThanhVienBUS(thang, nam, nguoitao_id);
                        //Doc tung dong tren luoi cua ton kho cho xu ly
                        for (int i = 0; i < rowTonKhoChoXuLy; i++)
                        {
                            if (!string.IsNullOrEmpty(gvTonKhoChoXuLy.GetRowCellValue(i, colMaSP).ToString()))
                            {
                                string masp = gvTonKhoChoXuLy.GetRowCellValue(i, colMaSP).ToString();
                                string tensp = gvTonKhoChoXuLy.GetRowCellValue(i, colTenSP).ToString();
                                string dvt = gvTonKhoChoXuLy.GetRowCellValue(i, colDVT).ToString();
                                string hamluong = gvTonKhoChoXuLy.GetRowCellValue(i, colHamLuong).ToString();
                                string lo = gvTonKhoChoXuLy.GetRowCellValue(i, colLo).ToString();
                                DateTime dHandung = DateTime.Parse(gvTonKhoChoXuLy.GetRowCellValue(i, colHanDung).ToString());
                                string handung = dHandung.ToString("yyyy-MM-dd");
                                double soluong = double.Parse(gvTonKhoChoXuLy.GetRowCellValue(i, colSoTon).ToString());
                                string khochoxuly = gvTonKhoChoXuLy.GetRowCellValue(i, colKhoChoXuLy).ToString();
                                DateTime dNgaybcsl = DateTime.Parse(gvTonKhoChoXuLy.GetRowCellValue(i, colNgayBCSL).ToString());
                                string ngaybcsl = dNgaybcsl.ToString("yyyy-MM-dd");
                                DateTime dNgaychuyenkho = DateTime.Parse(gvTonKhoChoXuLy.GetRowCellValue(i, colNgayChuyenKho).ToString());
                                string ngaychuyenkho = dNgaychuyenkho.ToString("yyyy-MM-dd");
                                string sobcsl = gvTonKhoChoXuLy.GetRowCellValue(i, colSoBCSL).ToString();
                                string trungtamchuyen = gvTonKhoChoXuLy.GetRowCellValue(i, colTrungTamChuyen).ToString();
                                string lydo = gvTonKhoChoXuLy.GetRowCellValue(i, colLyDo).ToString();
                                string huongxuly = gvTonKhoChoXuLy.GetRowCellValue(i, colHuongXuLy).ToString();

                                KSNB_KhoChoXuLyBUS.ThemKhoChoXuLyBUS(masp, tensp, dvt, hamluong, lo, handung, soluong, khochoxuly, ngaybcsl, ngaychuyenkho, sobcsl, trungtamchuyen, lydo, huongxuly, ngaycapnhat, nguoitao_id);
                            }
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show(BienToanCuc.ShowError, BienToanCuc.ShowAlert);
                    }
                    finally
                    {
                        gcTonKhoChoXuLy.DataSource = null;
                        XtraMessageBox.Show(BienToanCuc.ShowSuccess, BienToanCuc.ShowAlert);
                    }
                }   
            }
            else
            {
                XtraMessageBox.Show(BienToanCuc.ShowEmpty, BienToanCuc.ShowAlert);
            }
        }

        private void btnXemTonKhoChoXuLy_Click(object sender, EventArgs e)
        {
            KhoChoXuLy_Xem KhoChoXuLy_Xem = new KhoChoXuLy_Xem(leChonThang.EditValue.ToString(), leChonNam.EditValue.ToString());
            KhoChoXuLy_Xem.ShowDialog();
        }
    }
}