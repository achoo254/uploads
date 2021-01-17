using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;

namespace NhacViecWinform.GUI.KSNB
{
    public partial class PhuTrachTrungTam : DevExpress.XtraEditors.XtraForm
    {
        private ViecKSNBBUS ViecKSNBBUS = new ViecKSNBBUS();
        private ViecKSNBDTO ViecKSNBDTO = new ViecKSNBDTO();

        public PhuTrachTrungTam()
        {
            InitializeComponent();

            leTrungTam.Properties.DataSource = ViecKSNBBUS.LayDanhSachTrungTamBUS();
            leTrungTam.Properties.ValueMember = "id";
            leTrungTam.Properties.DisplayMember = "ten";
            cbbPhuTrach.Properties.Items.Add(BienToanCuc.phutrach_khong);
            cbbPhuTrach.Properties.Items.Add(BienToanCuc.phutrach_baocaohuy);
            cbbPhuTrach.Properties.Items.Add(BienToanCuc.phutrach_baocaosailech);
            cbbPhuTrach.Properties.Items.Add(BienToanCuc.phutrach_tatca);
            gcPhuTrachTrungTam.DataSource = ViecKSNBBUS.LayDanhSachPhuTrachTrungTamBUS();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(leTrungTam.Text) || cbbPhuTrach.Text == "")
            {
                lblPhuTrach.Text = BienToanCuc.ShowEmpty;
            }
            else
            {
                string phutrach = cbbPhuTrach.SelectedItem.ToString();
                int trungtam_id = int.Parse(leTrungTam.EditValue.ToString());
                if (String.IsNullOrEmpty(ViecKSNBBUS.KiemTraDanhSachTrungTrungTamVaPhuTrachBUS(phutrach, trungtam_id)))
                {
                    if (String.IsNullOrEmpty(ViecKSNBBUS.KiemTraDanhSachTrungTrungTamBUS(trungtam_id, BienToanCuc.UserID)))
                    {
                        ViecKSNBBUS.ThemDanhSachTrungTamBUS(phutrach, trungtam_id, BienToanCuc.UserID);

                        gcPhuTrachTrungTam.DataSource = ViecKSNBBUS.LayDanhSachPhuTrachTrungTamBUS();
                        lblPhuTrach.Text = BienToanCuc.ShowSuccess;
                    }
                    else
                    {
                        if(phutrach == BienToanCuc.phutrach_khong)
                        {
                            ViecKSNBBUS.XoaPhuTrachTrungTamBUS(trungtam_id, BienToanCuc.UserID);
                        }
                        else
                        {
                            ViecKSNBBUS.CapNhatPhuTrachTrungTamBUS(phutrach, trungtam_id, BienToanCuc.UserID);
                        }

                        gcPhuTrachTrungTam.DataSource = ViecKSNBBUS.LayDanhSachPhuTrachTrungTamBUS();
                        lblPhuTrach.Text = BienToanCuc.ShowSuccess;
                    }
                }
                else
                {
                    lblPhuTrach.Text = BienToanCuc.ShowExist;
                }
            }
        }
    }
}