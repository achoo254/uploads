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
    public partial class ThemThanhVienPhuTrach : DevExpress.XtraEditors.XtraForm
    {
        private UserBUS UserBUS = new UserBUS();
        private UserDTO UserDTO = new UserDTO();

        public ThemThanhVienPhuTrach()
        {
            InitializeComponent();
            leTenThanhVien.Properties.DataSource = UserBUS.LayThongTinCacThanhVienPhuTrachBUS(BienToanCuc.RolesAdmin);
            leTenThanhVien.Properties.ValueMember = "id";
            leTenThanhVien.Properties.DisplayMember = "fullname";

            gcThemPhuTrach.DataSource = UserBUS.LayThongTinCacThanhVienPhuTrachBUS(BienToanCuc.RolesAdmin);
            gvThemPhuTrach.DoubleClick += GvThemQuanTri_DoubleClick;

            leTenThanhVien.TextChanged += LeTenThanhVien_TextChanged;
        }

        private void GvThemQuanTri_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                int thanhvien_id = int.Parse(gvThemPhuTrach.GetRowCellValue(gvThemPhuTrach.FocusedRowHandle, "id").ToString());
                string phanquyen = gvThemPhuTrach.GetRowCellValue(gvThemPhuTrach.FocusedRowHandle, "roles").ToString();

                leTenThanhVien.EditValue = thanhvien_id;
                if (phanquyen == BienToanCuc.RolesUserKSNB)
                {
                    listThanhVienPhuTrach.SetItemChecked(0, true);
                }
                else if (phanquyen == BienToanCuc.RolesUserQA)
                {
                    listThanhVienPhuTrach.SetItemChecked(1, true);
                }
                else if (phanquyen == BienToanCuc.RolesUserCU)
                {
                    listThanhVienPhuTrach.SetItemChecked(2, true);
                }
                else if (phanquyen == BienToanCuc.RolesUserDD)
                {
                    listThanhVienPhuTrach.SetItemChecked(3, true);
                }
                else if (phanquyen == BienToanCuc.RolesUser)
                {
                    listThanhVienPhuTrach.SetItemChecked(4, true);
                }
            }
        }

        private void LeTenThanhVien_TextChanged(object sender, EventArgs e)
        {
            if (leTenThanhVien.EditValue != null)
            {
                int thanhvien_id = int.Parse(leTenThanhVien.EditValue.ToString());
                UserDTO = UserBUS.LayThanhVienTheoIdBUS(thanhvien_id);

                if (UserDTO.Roles == BienToanCuc.RolesUserKSNB)
                {
                    listThanhVienPhuTrach.SetItemChecked(0, true);
                }
                else if (UserDTO.Roles == BienToanCuc.RolesUserQA)
                {
                    listThanhVienPhuTrach.SetItemChecked(1, true);
                }
                else if (UserDTO.Roles == BienToanCuc.RolesUserCU)
                {
                    listThanhVienPhuTrach.SetItemChecked(2, true);
                }
                else if (UserDTO.Roles == BienToanCuc.RolesUserDD)
                {
                    listThanhVienPhuTrach.SetItemChecked(3, true);
                }
                else if (UserDTO.Roles == BienToanCuc.RolesUser)
                {
                    listThanhVienPhuTrach.SetItemChecked(4, true);
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
            if (leTenThanhVien.EditValue != null)
            {
                int thanhvien_id = int.Parse(leTenThanhVien.EditValue.ToString());
                string phanquyen = listThanhVienPhuTrach.GetItemText(listThanhVienPhuTrach.SelectedIndex);

                if (XtraMessageBox.Show(BienToanCuc.ShowConfirm, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    UserBUS.CapNhatPhanQuyenTaiKhoanBUS(thanhvien_id, phanquyen);

                    gcThemPhuTrach.DataSource = UserBUS.LayThongTinCacThanhVienPhuTrachBUS(BienToanCuc.RolesAdmin);

                    leTenThanhVien.Properties.DataSource = UserBUS.LayThongTinCacThanhVienPhuTrachBUS(BienToanCuc.RolesAdmin);
                    leTenThanhVien.Properties.ValueMember = "id";
                    leTenThanhVien.Properties.DisplayMember = "fullname";
                }
            }
        }
    }
}