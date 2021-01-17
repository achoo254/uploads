using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using HoTroNhacViecWinform.BUS;
using HoTroNhacViecWinform.GUI.Huong_dan;
using HoTroNhacViecWinform.GUI.KSNB;
using HoTroNhacViecWinform.GUI.Quan_tri;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using NhacViecWinform.GUI;
using NhacViecWinform.GUI.Bao_cao;
using NhacViecWinform.GUI.Chat;
using NhacViecWinform.GUI.Chuc_nang;
using NhacViecWinform.GUI.Huong_dan;
using NhacViecWinform.GUI.Kanban;
using NhacViecWinform.GUI.KSNB;
using NhacViecWinform.GUI.Quy_trinh;
using System;
using System.Windows.Forms;

namespace NhacViecWinform
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //Tao bien
        private UserBUS UserBUS = new UserBUS();

        private UserDTO UserDTO = new UserDTO();
        private WorkflowBUS WorkflowBUS = new WorkflowBUS();

        public MainForm()
        {
            InitializeComponent();
            this.Text = "Phần mềm hỗ trợ nhắc việc phiên bản " + Application.ProductVersion;
            UserDTO = UserBUS.LayTatCaThongTinTheoIdBUS();
            //Thiet lap quyen xem va chinh sua
            if (UserDTO.Roles == BienToanCuc.RolesAdmin)
            {
                pageQuanTri.Visible = true;
                pgCongViecQA.Visible = true;
                pgCongViecKSNB.Visible = true;
                pgCongViecCU.Visible = true;
                pgCongViecDD.Visible = true;
                btnTaoMoiHuongDan.Enabled = true;
            }
            if (UserDTO.Roles == BienToanCuc.RolesUserKSNB)
            {
                pgCongViecKSNB.Visible = true;
                btnTaoMoiHuongDan.Enabled = true;
            }
            else if (UserDTO.Roles == BienToanCuc.RolesUserQA)
            {
                pgCongViecQA.Visible = true;
                btnTaoMoiHuongDan.Enabled = true;
            }
            else if (UserDTO.Roles == BienToanCuc.RolesUserCU)
            {
                pgCongViecCU.Visible = true;
                btnTaoMoiHuongDan.Enabled = true;
            }
            else if (UserDTO.Roles == BienToanCuc.RolesUserDD)
            {
                pgCongViecDD.Visible = true;
                btnTaoMoiHuongDan.Enabled = true;
            }

            timer1.Tick += new EventHandler(timer1_Tick);
            
            gridView1.DoubleClick += new EventHandler(gridView1_DoubleClick);
            gridView1.Click += new EventHandler(gridView1_Click);
            subHoTen.Caption = UserBUS.SelectFullnameUserBUS();
        }
        private void gcReminder_Enter(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void gcReminder_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                flyoutPanel1.ShowBeakForm();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                OpenFormNhacViecHangNgay();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WorkflowBUS.UpdateLoopWorkflowBUS();
            gcReminder.DataSource = WorkflowBUS.SelectTimeReminderBUS();
            if (gridView1.RowCount > 0)
            {
                FlashWindow.Flash(this);
            }
        }

        private void btnThemMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ThemMoi))
                {
                    form.Activate();
                    return;
                }
            }

            ThemMoi newForm = new ThemMoi();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void btnNhacViecHangNgay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFormNhacViecHangNgay();
        }

        private void btnKiemTraHoanThanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(GV_DaThucHien))
                {
                    form.Activate();
                    return;
                }
            }

            GV_DaThucHien newForm = new GV_DaThucHien();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void btnKiemTraDangThucHien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(GV_DangThucHien))
                {
                    form.Activate();
                    return;
                }
            }

            GV_DangThucHien newForm = new GV_DangThucHien();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void btnKiemTraDaHoanThanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(NV_DaThucHien))
                {
                    form.Activate();
                    return;
                }
            }

            NV_DaThucHien newForm = new NV_DaThucHien();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void OpenFormNhacViecHangNgay()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(NV_DangThucHien))
                {
                    form.Activate();
                    return;
                }
            }

            NV_DangThucHien newForm = new NV_DangThucHien();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void btnDangXuat_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show(BienToanCuc.ShowConfirm, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DisposeAllInActiveForms();
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void btnDoiThongTin_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            UserInfoForm UserInfoForm = new UserInfoForm(this);
            UserInfoForm.ShowDialog();
        }

        private void btnCongViec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ViecKSNB))
                {
                    form.Activate();
                    return;
                }
            }

            ViecKSNB newForm = new ViecKSNB();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void btnLichSu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(LichSuKSNB))
                {
                    form.Activate();
                    return;
                }
            }

            LichSuKSNB newForm = new LichSuKSNB();
            newForm.MdiParent = this;
            newForm.Show();
        }

        public void DisposeAllInActiveForms()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
        }

        private void btnPhuTrachTrungTam_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhuTrachTrungTam PhuTrachTrungTam = new PhuTrachTrungTam();
            PhuTrachTrungTam.ShowDialog();
        }

        private void btnTonDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(TonDongKSNB))
                {
                    form.Activate();
                    return;
                }
            }

            TonDongKSNB newForm = new TonDongKSNB();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void btnBaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(BaoCao))
                {
                    form.Activate();
                    return;
                }
            }

            BaoCao newForm = new BaoCao();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void btnThemCongViecKanban_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ThemCongViec))
                {
                    form.Activate();
                    return;
                }
            }

            ThemCongViec newForm = new ThemCongViec();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void btnCongViecKanban_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(CongViec))
                {
                    form.Activate();
                    return;
                }
            }

            CongViec newForm = new CongViec();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BienToanCuc.LoadLookAndFeelSettings();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BienToanCuc.SaveLookAndFeelSettings();
        }

        private void btnXemHuongDan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(HuongDanHoSoBaoCao))
                {
                    form.Activate();
                    return;
                }
            }

            HuongDanHoSoBaoCao newForm = new HuongDanHoSoBaoCao();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void btnTaoMoiHuongDan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThemMoiHuongDanHoSoBaoCao newForm = new ThemMoiHuongDanHoSoBaoCao();
            newForm.ShowDialog();
        }

        private void btnThongTinThanhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ThongTinThanhVien))
                {
                    form.Activate();
                    return;
                }
            }

            ThongTinThanhVien newForm = new ThongTinThanhVien();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void btnHuongDanPhanMem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HuongDanPhanMem newForm = new HuongDanPhanMem();
            newForm.ShowDialog();
        }

        private void btnLienHe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LienHeThanhVien chat = new LienHeThanhVien();
            chat.Show();
        }

        private void btnThemQuanTri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ThemQuanTri))
                {
                    form.Activate();
                    return;
                }
            }

            ThemQuanTri newForm = new ThemQuanTri();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void btnThemCSDL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ThemCSDL))
                {
                    form.Activate();
                    return;
                }
            }

            ThemCSDL newForm = new ThemCSDL();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void btnThemThanhVienPhuTrach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ThemThanhVienPhuTrach))
                {
                    form.Activate();
                    return;
                }
            }

            ThemThanhVienPhuTrach newForm = new ThemThanhVienPhuTrach();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void btnKhoChoXuLy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(KhoChoXuLy))
                {
                    form.Activate();
                    return;
                }
            }

            KhoChoXuLy newForm = new KhoChoXuLy();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void btnLichKiemKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(LichKiemKe))
                {
                    form.Activate();
                    return;
                }
            }

            LichKiemKe newForm = new LichKiemKe();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void btnDD_CongViec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}