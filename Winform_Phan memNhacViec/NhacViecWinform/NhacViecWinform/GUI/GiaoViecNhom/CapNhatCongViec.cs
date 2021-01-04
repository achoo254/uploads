using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;
using System.Windows.Forms;

namespace NhacViecWinform.GUI.Kanban
{
    public partial class CapNhatCongViec : DevExpress.XtraEditors.XtraForm
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

        public CapNhatCongViec(int id)
        {
            InitializeComponent();
            idCongViec = id;
            gvCongViecChiTiet.CustomDrawRowIndicator += GvCongViecChiTiet_CustomDrawRowIndicator;
            gvCongViecChiTiet.IndicatorWidth = 30;
            gvCongViecChiTiet.CellValueChanged += GvCongViecChiTiet_CellValueChanged;
            gvCongViecChiTiet.CellValueChanging += GvCongViecChiTiet_CellValueChanging;
        }

        private void GvCongViecChiTiet_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            BeginInvoke(new Action(delegate
            {
                var gridView = sender as GridView;
                gridView.PostEditor();
                gridView.UpdateCurrentRow();
            }));
        }

        private void GvCongViecChiTiet_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                bool thuchienCongViec = bool.Parse(gvCongViecChiTiet.GetRowCellValue(e.RowHandle, colHoanThanh).ToString());
                byte hoanthanh = 0;
                int congviecChiTiet = int.Parse(gvCongViecChiTiet.GetRowCellValue(e.RowHandle, colIdCongViecChiTiet).ToString());
                if (thuchienCongViec == true)
                {
                    hoanthanh = 1;
                }
                else
                {
                    hoanthanh = 0;
                }
                //Cap nhat thuc hien cong viec chi tiet
                KB_CongViecChiTietBUS.ThucHienCongViecChiTietBUS(congviecChiTiet, hoanthanh, BienToanCuc.UserID);
                //Hien thi lai luoi
                gcCongViecChiTiet.DataSource = KB_CongViecChiTietBUS.HienThiCongViecDaNhanTrongCapNhatCongViecBUS(BienToanCuc.UserID.ToString(), idCongViec);
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
                //Cap nhat trang thai cong viec chi tiet
                int trangthai = 0;
                //Tao bien huy cong viec thi khong thay doi trang thai - trong database la 4
                int huycongviec = 4;
                //Cap nhat dang lam
                if (demsoHoanThanh > 0 && demsoHoanThanh < gvCongViecChiTiet.RowCount)
                {
                    trangthai = 2;
                    KB_CongViecChiTietBUS.CapNhatTrangThaiCongViecChiTietBUS(idCongViec, trangthai, huycongviec);
                }
                else if (demsoHoanThanh == gvCongViecChiTiet.RowCount)
                {
                    trangthai = 3;
                    KB_CongViecChiTietBUS.CapNhatTrangThaiCongViecChiTietBUS(idCongViec, trangthai, huycongviec);
                }
            }
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
            gcCongViecChiTiet.DataSource = KB_CongViecChiTietBUS.HienThiCongViecDaNhanTrongCapNhatCongViecBUS(BienToanCuc.UserID.ToString(), idCongViec);
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
            BienToanCuc.gc_CongViecDaNhan.DataSource = KB_CongViecBUS.HienThiCongViecNhanBUS(BienToanCuc.UserID);
            this.Close();
        }

        private void btnHuyCongViec_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(BienToanCuc.ShowConfirm, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int huycongviec = 4;
                KB_CongViecChiTietBUS.CapNhatTrangThaiCongViecChiTietBUS(idCongViec, huycongviec, huycongviec);
                XtraMessageBox.Show(BienToanCuc.ShowSuccess, BienToanCuc.ShowAlert);
                BienToanCuc.gc_CongViecDaNhan.DataSource = KB_CongViecBUS.HienThiCongViecNhanBUS(BienToanCuc.UserID);
                this.Close();
            }
        }
    }
}