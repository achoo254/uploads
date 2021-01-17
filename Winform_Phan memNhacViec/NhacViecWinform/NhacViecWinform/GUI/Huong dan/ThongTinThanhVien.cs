using NhacViecWinform.BUS;

namespace HoTroNhacViecWinform.GUI.Huong_dan
{
    public partial class ThongTinThanhVien : DevExpress.XtraEditors.XtraForm
    {
        private UserBUS UserBUS = new UserBUS();

        public ThongTinThanhVien()
        {
            InitializeComponent();
            gcThongTinThanhVien.DataSource = UserBUS.LayThongTinCacThanhVienBUS();
        }
    }
}