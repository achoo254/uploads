using DevExpress.XtraEditors;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;
using System.Windows.Forms;

namespace NhacViecWinform.GUI.Kanban
{
    public partial class DaGuiCongViec : DevExpress.XtraEditors.XtraForm
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private KB_CongViecChiTietBUS KB_CongViecChiTietBUS = new KB_CongViecChiTietBUS();
        private KB_CongViecBUS KB_CongViecBUS = new KB_CongViecBUS();
        private KB_CongViecDTO KB_CongViecDTO = new KB_CongViecDTO();
        private UserBUS UserBUS = new UserBUS();
        private UserDTO UserDTO = new UserDTO();
        private BoPhanBUS BoPhanBUS = new BoPhanBUS();
        private BoPhanDTO BoPhanDTO = new BoPhanDTO();
        private ChucDanhBUS ChucDanhBUS = new ChucDanhBUS();
        private ChucDanhDTO ChucDanhDTO = new ChucDanhDTO();
        private KB_NhanBUS NhanBUS = new KB_NhanBUS();
        private KB_NhanDTO NhanDTO = new KB_NhanDTO();
        private int idCongViec;

        public DaGuiCongViec(int id)
        {
            InitializeComponent();
            idCongViec = id;
            gvCongViecChiTiet.CustomDrawRowIndicator += GvCongViecChiTiet_CustomDrawRowIndicator;
            gvCongViecChiTiet.IndicatorWidth = 30;
        }

        private void GvCongViecChiTiet_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = e.RowHandle.ToString();
            }
        }

        private void CapNhatCongViec_Load(object sender, EventArgs e)
        {
            //Khoi tao bien hien thi thong itn
            KB_CongViecDTO = KB_CongViecChiTietBUS.HienThiThongTinCongViecTrongCapNhatCongViecBUS(idCongViec);
            txtTieuDe.Text = KB_CongViecDTO.Tieude;
            meMoTa.Text = KB_CongViecDTO.Mota;
            // Do du lieu vao 2 luoi cong viec va thanh vien nhan
            gcCongViecChiTiet.DataSource = KB_CongViecChiTietBUS.HienThiCongViecDaNhanTrongCapNhatCongViecBUS(KB_CongViecDTO.Kb_nguoinhan_id, idCongViec);
            gcThanhVien.DataSource = KB_CongViecChiTietBUS.HienThiThanhVienNhanTrongCapNhatCongViecBUS(KB_CongViecDTO.Kb_nguoinhan_id);
            //Hien thi nhan
            leNhan.Properties.DataSource = NhanBUS.LayNhanTheoIdBUS(KB_CongViecDTO.Kb_nhan_id);
            leNhan.Properties.ValueMember = "id";
            leNhan.Properties.DisplayMember = "tieude";
            leNhan.EditValue = KB_CongViecDTO.Kb_nhan_id;

            //Hien thi tien do
            //Tao bien thuc hien da hoan thanh
            byte thuchien = 1;
            int demsoHoanThanh = KB_CongViecChiTietBUS.DemSoCongViecChiTietDaThucHienBUS(idCongViec, thuchien);
            //Cap nhat tien do
            pbTienDo.EditValue = 0;
            pbTienDo.Properties.Step = 1;
            pbTienDo.Properties.PercentView = true;
            pbTienDo.Properties.Maximum = gvCongViecChiTiet.RowCount;
            pbTienDo.Properties.Minimum = 0;
            for (int i = 0; i < demsoHoanThanh; i++)
            {
                pbTienDo.PerformStep();
                pbTienDo.Update();
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            BienToanCuc.gc_CongViecDaGui.DataSource = KB_CongViecBUS.HienThiCongViecGuiBUS(BienToanCuc.UserID);
            this.Close();
        }

        private void btnHuyCongViec_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(BienToanCuc.ShowConfirm, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int huycongviec = 4;
                KB_CongViecChiTietBUS.CapNhatTrangThaiCongViecChiTietBUS(idCongViec, huycongviec, huycongviec);
                XtraMessageBox.Show(BienToanCuc.ShowSuccess, BienToanCuc.ShowAlert);
                BienToanCuc.gc_CongViecDaGui.DataSource = KB_CongViecBUS.HienThiCongViecGuiBUS(BienToanCuc.UserID);
                this.Close();
            }
        }
    }
}