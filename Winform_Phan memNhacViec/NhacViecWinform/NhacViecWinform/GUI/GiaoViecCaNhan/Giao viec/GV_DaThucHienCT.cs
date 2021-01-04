using DevExpress.XtraEditors;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;
using System.Windows.Forms;

namespace NhacViecWinform.GUI.Chuc_nang
{
    public partial class GV_DaThucHienCT : DevExpress.XtraEditors.XtraForm
    {
        private WorkflowBUS WorkflowBUS = new WorkflowBUS();
        private WorkflowDTO WorkflowDTO = new WorkflowDTO();
        private CategoryBUS CategoryBUS = new CategoryBUS();
        private CategoryDTO CategoryDTO = new CategoryDTO();
        private UserBUS UserBUS = new UserBUS();
        private UserDTO UserDTO = new UserDTO();
        private TodolistBUS TodolistBUS = new TodolistBUS();
        private TodolistDTO TodolistDTO = new TodolistDTO();

        public GV_DaThucHienCT()
        {
            InitializeComponent();
            WorkflowDTO = WorkflowBUS.HienThiGiaoViecDaThucHienCTBUS();
            TodolistDTO = TodolistBUS.GetTodolistDetailsBUS();
            CategoryDTO.Name = CategoryBUS.SelectNameCategoryBUS(WorkflowDTO.Category_id);
            UserDTO.FullName = UserBUS.HienThiTenNguoiNhanBUS(WorkflowDTO.User_recipent_id);
            lbTieuDe.Text = WorkflowDTO.Name;
            lbDanhMuc.Text = CategoryDTO.Name;
            lbNguoiNhan.Text = UserDTO.FullName;
            txtNgayBatDau.Text = WorkflowDTO.Date_start.ToString("dd-MM-yyyy HH:mm:ss");
            txtNgayBatDau.ReadOnly = true;
            txtNgayHetHan.Text = WorkflowDTO.Date_reminder.ToString("dd-MM-yyyy HH:mm:ss");
            txtNgayHetHan.ReadOnly = true;
            txtNgayThucHien.Text = TodolistDTO.Date_success.ToString("dd-MM-yyyy HH:mm:ss");
            txtNgayThucHien.ReadOnly = true;
            meLyDo.Text = TodolistDTO.Reason;
            meLyDo.ReadOnly = true;
            reChiTiet.Text = WorkflowDTO.Details;
            if (TodolistDTO.Status == true)
            {
                btnChuaHoanThanhCongViec.Enabled = false;
            }
        }

        private void btnChuaHoanThanhCongViec_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show(BienToanCuc.ShowConfirm, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //active = true cong viec chua thuc hien
                byte active = 1;
                WorkflowDTO.Details = reChiTiet.Text;
                //Done = false cong viec chua hoan thanh
                byte done = 0;
                TodolistBUS.UpdateFailTodolistBUS(TodolistDTO.Id, WorkflowDTO.WorkflowID, done);
                WorkflowBUS.UpdateSuccessWorkflowBUS(WorkflowDTO.WorkflowID, WorkflowDTO.Details, active);
                RefeshGridview();
                this.Close();
            }
        }

        private void btnHoanThanhCongViec_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show(BienToanCuc.ShowConfirm, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Done = true cong viec da hoan thanh
                byte done = 1;
                TodolistBUS.UpdateSuccessTodolistBUS(WorkflowDTO.WorkflowID, done);
                RefeshGridview();
                this.Close();
            }
        }

        private void RefeshGridview()
        {
            //Get active = false va status = false hien thi cong viec dang thuc hien
            byte Getactive = 0;

            BienToanCuc.gc_GV_DaThucHien.DataSource = WorkflowBUS.HienThiGiaoViecDaThucHienBUS(BienToanCuc.UserID, Getactive);
            BienToanCuc.gv_GV_DaThucHien.Columns["todolist_id"].Visible = false;
            BienToanCuc.gv_GV_DaThucHien.Columns["workflow_id"].Visible = false;
        }
    }
}