using NhacViecWinform.BUS;
using NhacViecWinform.DTO;

namespace NhacViecWinform.GUI.Chuc_nang
{
    public partial class NV_DaThucHienCT : DevExpress.XtraEditors.XtraForm
    {
        private WorkflowBUS WorkflowBUS = new WorkflowBUS();
        private WorkflowDTO WorkflowDTO = new WorkflowDTO();
        private CategoryBUS CategoryBUS = new CategoryBUS();
        private CategoryDTO CategoryDTO = new CategoryDTO();
        private UserBUS UserBUS = new UserBUS();
        private UserDTO UserDTO = new UserDTO();
        private TodolistBUS TodolistBUS = new TodolistBUS();
        private TodolistDTO TodolistDTO = new TodolistDTO();

        public NV_DaThucHienCT()
        {
            InitializeComponent();
            WorkflowDTO = WorkflowBUS.HienThiNhanViecDaThucHienCTBUS();
            TodolistDTO = TodolistBUS.GetTodolistDetailsBUS();
            CategoryDTO.Name = CategoryBUS.SelectNameCategoryBUS(WorkflowDTO.Category_id);
            UserDTO.FullName = UserBUS.HienThiTenNguoiGiaoBUS(WorkflowDTO.User_create_id);
            lbTieuDe.Text = WorkflowDTO.Name;
            lbDanhMuc.Text = CategoryDTO.Name;
            lbNguoiGiao.Text = UserDTO.FullName;
            txtNgayTao.Text = WorkflowDTO.Date_create.ToString("dd-MM-yyyy HH:mm:ss");
            txtNgayBatDau.Text = TodolistDTO.Date_start.ToString("dd-MM-yyyy HH:mm:ss");
            txtNgayHetHan.Text = TodolistDTO.Date_reminder.ToString("dd-MM-yyyy HH:mm:ss");
            txtNgayHoanThanh.Text = TodolistDTO.Date_success.ToString("dd-MM-yyyy HH:mm:ss");
            ceHoanThanhCongViec.Checked = TodolistDTO.Status;
            meLyDo.Text = TodolistDTO.Reason;
            meLyDo.ReadOnly = true;
            reChiTiet.Text = WorkflowDTO.Details;
            reChiTiet.ReadOnly = true;
        }
    }
}