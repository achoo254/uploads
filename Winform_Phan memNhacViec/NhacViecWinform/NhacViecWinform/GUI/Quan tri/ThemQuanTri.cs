using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;
using System.Windows.Forms;

namespace HoTroNhacViecWinform.GUI.Quan_tri
{
    public partial class ThemQuanTri : DevExpress.XtraEditors.XtraForm
    {
        private UserBUS UserBUS = new UserBUS();
        private UserDTO UserDTO = new UserDTO();

        public ThemQuanTri()
        {
            InitializeComponent();
            leTenThanhVien.Properties.DataSource = UserBUS.LayTatCaThanhVienBUS();
            leTenThanhVien.Properties.ValueMember = "id";
            leTenThanhVien.Properties.DisplayMember = "fullname";

            gcThemQuanTri.DataSource = UserBUS.LayTatCaThanhVienBUS();
            gvThemQuanTri.DoubleClick += GvThemQuanTri_DoubleClick;

            leTenThanhVien.TextChanged += LeTenThanhVien_TextChanged;
        }

        private void GvThemQuanTri_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                int thanhvien_id = int.Parse(gvThemQuanTri.GetRowCellValue(gvThemQuanTri.FocusedRowHandle, "id").ToString());
                string phanquyen = gvThemQuanTri.GetRowCellValue(gvThemQuanTri.FocusedRowHandle, "roles").ToString();

                leTenThanhVien.EditValue = thanhvien_id;
                if (phanquyen == BienToanCuc.RolesAdmin)
                {
                    ceQuanTriVien.IsOn = true;
                }
                else
                {
                    ceQuanTriVien.IsOn = false;
                }
            }
        }

        private void LeTenThanhVien_TextChanged(object sender, EventArgs e)
        {
            if (leTenThanhVien.EditValue != null)
            {
                int thanhvien_id = int.Parse(leTenThanhVien.EditValue.ToString());
                UserDTO = UserBUS.LayThanhVienTheoIdBUS(thanhvien_id);

                if (UserDTO.Roles == BienToanCuc.RolesAdmin)
                {
                    ceQuanTriVien.IsOn = true;
                }
                else
                {
                    ceQuanTriVien.IsOn = false;
                }

                leBoPhan.Properties.DataSource = UserBUS.LayThanhVienTheoIdChoDatasourceBUS(thanhvien_id);
                leBoPhan.Properties.ValueMember = "id";
                leBoPhan.Properties.DisplayMember = "tenbophan";
                leBoPhan.EditValue = thanhvien_id;

                leChucDanh.Properties.DataSource = UserBUS.LayThanhVienTheoIdChoDatasourceBUS(thanhvien_id);
                leChucDanh.Properties.ValueMember = "id";
                leChucDanh.Properties.DisplayMember = "tenchucdanh";
                leChucDanh.EditValue = thanhvien_id;
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (ceQuanTriVien.IsOn == true)
            {
                if (leTenThanhVien.EditValue != null)
                {
                    int thanhvien_id = int.Parse(leTenThanhVien.EditValue.ToString());
                    string phanquyen = BienToanCuc.RolesAdmin;

                    if (XtraMessageBox.Show(BienToanCuc.ShowConfirm, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        UserBUS.CapNhatPhanQuyenTaiKhoanBUS(thanhvien_id, phanquyen);
                        gcThemQuanTri.DataSource = UserBUS.LayTatCaThanhVienBUS();
                    }
                }
            }
            else if (ceQuanTriVien.IsOn == false)
            {
                if (leTenThanhVien.EditValue != null)
                {
                    int thanhvien_id = int.Parse(leTenThanhVien.EditValue.ToString());
                    string phanquyen = BienToanCuc.RolesUser;

                    if (XtraMessageBox.Show(BienToanCuc.ShowConfirm, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        UserBUS.CapNhatPhanQuyenTaiKhoanBUS(thanhvien_id, phanquyen);
                        gcThemQuanTri.DataSource = UserBUS.LayTatCaThanhVienBUS();
                    }
                }
            }
        }
    }
}