using DevExpress.XtraEditors;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;
using System.Windows.Forms;

namespace NhacViecWinform.GUI.Chuc_nang
{
    public partial class GV_DangThucHienCT : DevExpress.XtraEditors.XtraForm
    {
        private WorkflowBUS WorkflowBUS = new WorkflowBUS();
        private WorkflowDTO WorkflowDTO = new WorkflowDTO();
        private CategoryBUS CategoryBUS = new CategoryBUS();
        private CategoryDTO CategoryDTO = new CategoryDTO();
        private UserBUS UserBUS = new UserBUS();
        private UserDTO UserDTO = new UserDTO();

        public GV_DangThucHienCT()
        {
            InitializeComponent();
            WorkflowDTO = WorkflowBUS.HienThiGiaoViecDangThucHienCTBUS();
            CategoryDTO.Name = CategoryBUS.SelectNameCategoryBUS(WorkflowDTO.Category_id);
            UserDTO.FullName = UserBUS.HienThiTenNguoiNhanBUS(WorkflowDTO.User_recipent_id);
            lbTieuDe.Text = WorkflowDTO.Name;
            lbDanhMuc.Text = CategoryDTO.Name;
            lbNguoiNhan.Text = UserDTO.FullName;
            txtNgayTao.Text = WorkflowDTO.Date_create.ToString("dd-MM-yyyy HH:mm:ss");
            txtNgayTao.ReadOnly = true;
            txtNgayBatDau.Text = WorkflowDTO.Date_start.ToString("dd-MM-yyyy HH:mm:ss");
            txtNgayBatDau.ReadOnly = true;
            txtNgayHetHan.Text = WorkflowDTO.Date_reminder.ToString("dd-MM-yyyy HH:mm:ss");
            txtNgayHetHan.ReadOnly = true;
            reChiTiet.Text = WorkflowDTO.Details;
        }

        private void RefeshGridview()
        {
            //Get active = false va status = false hien thi cong viec dang thuc hien
            byte Getactive = 1;

            BienToanCuc.gc_GV_DangThucHien.DataSource = WorkflowBUS.HienThiGiaoViecDangThucHienBUS(BienToanCuc.UserID, Getactive);
            BienToanCuc.gv_GV_DangThucHien.Columns["id"].Visible = false;
        }

        private void btnXoaViec_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = XtraMessageBox.Show(BienToanCuc.ShowConfirm, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                WorkflowBUS.DeleteWorkflowBUS(BienToanCuc.workflow_id);
                RefeshGridview();
                this.Close();
            }
        }
    }
}