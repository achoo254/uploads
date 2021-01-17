using DevExpress.XtraEditors;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;
using System.Windows.Forms;

namespace NhacViecWinform.GUI.Chuc_nang
{
    public partial class NV_DangThucHienCT : DevExpress.XtraEditors.XtraForm
    {
        private WorkflowBUS WorkflowBUS = new WorkflowBUS();
        private WorkflowDTO WorkflowDTO = new WorkflowDTO();
        private CategoryBUS CategoryBUS = new CategoryBUS();
        private CategoryDTO CategoryDTO = new CategoryDTO();
        private UserBUS UserBUS = new UserBUS();
        private UserDTO UserDTO = new UserDTO();
        private TodolistBUS TodolistBUS = new TodolistBUS();
        private TodolistDTO TodolistDTO = new TodolistDTO();

        public NV_DangThucHienCT()
        {
            InitializeComponent();
            WorkflowDTO = WorkflowBUS.HienThiNhanViecDangThucHienCTBUS();
            CategoryDTO.Name = CategoryBUS.SelectNameCategoryBUS(WorkflowDTO.Category_id);
            UserDTO.FullName = UserBUS.HienThiTenNguoiGiaoBUS(WorkflowDTO.User_create_id);
            lbTieuDe.Text = WorkflowDTO.Name;
            lbDanhMuc.Text = CategoryDTO.Name;
            lbNguoiGiao.Text = UserDTO.FullName;
            txtNgayTao.Text = WorkflowDTO.Date_create.ToString("dd-MM-yyyy HH:mm:ss");
            txtNgayBatDau.Text = WorkflowDTO.Date_start.ToString("dd-MM-yyyy HH:mm:ss");
            txtNgayHetHan.Text = WorkflowDTO.Date_reminder.ToString("dd-MM-yyyy HH:mm:ss");
            reChiTiet.Text = WorkflowDTO.Details;
            reChiTiet.ReadOnly = true;
        }

        private void btnHoanThanhCongViec_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show(BienToanCuc.ShowConfirm, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                TodolistDTO.Reason = meLyDo.Text;
                //active = false cong viec da thuc hien va status = false cong viec chua hoan thanh
                byte active = 0;
                byte status = 0;
                WorkflowBUS.UpdateSuccessWorkflowBUS(WorkflowDTO.WorkflowID, WorkflowDTO.Details, active);
                TodolistBUS.CreateTodolistBUS(WorkflowDTO.WorkflowID, TodolistDTO.Reason, status);
                //Get active = true hien thi cong viec dang thuc hien
                byte Getactive = 1;
                BienToanCuc.gc_NV_DangThucHien.DataSource = WorkflowBUS.HienThiNhanViecDangThucHienBUS(BienToanCuc.UserID, Getactive);
                BienToanCuc.gv_NV_DangThucHien.Columns["id"].Visible = false;
                this.Close();
            }
        }
    }
}