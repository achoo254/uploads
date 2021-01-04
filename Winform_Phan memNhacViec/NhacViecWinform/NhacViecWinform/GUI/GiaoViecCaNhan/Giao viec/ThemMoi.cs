using DevExpress.XtraEditors.Calendar;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;

namespace NhacViecWinform.GUI.Quy_trinh
{
    public partial class ThemMoi : DevExpress.XtraEditors.XtraForm
    {
        private CategoryBUS CategoryBUS = new CategoryBUS();
        private UserBUS UserBUS = new UserBUS();
        private WorkflowBUS WorkflowBUS = new WorkflowBUS();

        public ThemMoi()
        {
            InitializeComponent();
            leChonChucNang.Properties.DataSource = CategoryBUS.GetCategoryBUS();
            leChonChucNang.Properties.DisplayMember = "ten";
            leChonChucNang.Properties.ValueMember = "id";

            leNguoiNhanViec.Properties.DataSource = UserBUS.GetUserBUS();
            leNguoiNhanViec.Properties.DisplayMember = "fullname";
            leNguoiNhanViec.Properties.ValueMember = "id";

            deNgayBatDau.EditValue = DateTime.Now;
            deNgayBatDau.DisableCalendarDate += new DevExpress.XtraEditors.Calendar.DisableCalendarDateEventHandler(deNgayBatDau_DisableCalendarDate);
        }

        private void deNgayBatDau_DisableCalendarDate(object sender, DisableCalendarDateEventArgs e)
        {
            if (e.View != DevExpress.XtraEditors.Controls.DateEditCalendarViewType.MonthInfo) return;

            if (e.Date.DayOfWeek == DayOfWeek.Sunday)
            {
                e.IsDisabled = true;
            }
        }

        private void btnDongYThemMoi_Click(object sender, EventArgs e)
        {
            if (leChonChucNang.Text != "" && txtTieuDe.Text != "" && txtNgayNhacViec.Text != ""
                && deNgayBatDau.Text != "" && leNguoiNhanViec.Text != "" && reChiTiet.Text != "")
            {
                DateTime dNgayTao = DateTime.Now;
                string NgayTao = dNgayTao.ToString("yyyy-MM-dd HH:mm:ss");

                DateTime dNgayBatDau = DateTime.Parse(deNgayBatDau.Text);
                string NgayBatDau = dNgayBatDau.ToString("yyyy-MM-dd HH:mm:ss");

                int NguoiNhanViec = int.Parse(leNguoiNhanViec.EditValue.ToString());
                int SoNgayNhac = int.Parse(txtNgayNhacViec.Text);
                byte active = 1;
                byte loop = 1;
                int positon = WorkflowBUS.LaySoThuTuCaoNhatBUS(BienToanCuc.UserID);
                int category_id = int.Parse(leChonChucNang.EditValue.ToString());

                DateTime dNgayNhacViec = dNgayTao;
                dNgayNhacViec = dNgayBatDau.AddDays(SoNgayNhac);

                string NgayNhacViec = dNgayNhacViec.ToString("yyyy-MM-dd HH:mm:ss");
                if (ceLapLai.IsOn == false)
                {
                    loop = 0;
                }
                else if (ceLapLai.IsOn == true)
                {
                    loop = 1;
                }
                //Cap nhat workflow
                WorkflowBUS.CreateWorkflowBUS(txtTieuDe.Text, reChiTiet.Text, NgayTao,
                    NgayBatDau, NgayNhacViec, BienToanCuc.UserID, NguoiNhanViec,
                    active, category_id, SoNgayNhac, loop, positon);
                lblMessage.Text = BienToanCuc.ShowSuccess;
            }
            else
            {
                lblMessage.Text = BienToanCuc.ShowEmpty;
            }
        }
    }
}