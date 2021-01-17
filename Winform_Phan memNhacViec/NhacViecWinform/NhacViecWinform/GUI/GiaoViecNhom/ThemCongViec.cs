using DevExpress.XtraEditors;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NhacViecWinform.GUI.Kanban
{
    public partial class ThemCongViec : DevExpress.XtraEditors.XtraForm
    {
        private KB_CongViecChiTietBUS KB_CongViecChiTietBUS = new KB_CongViecChiTietBUS();
        private KB_CongViecBUS KB_CongViecBUS = new KB_CongViecBUS();
        private UserBUS UserBUS = new UserBUS();
        private UserDTO UserDTO = new UserDTO();
        private BoPhanBUS BoPhanBUS = new BoPhanBUS();
        private BoPhanDTO BoPhanDTO = new BoPhanDTO();
        private ChucDanhBUS ChucDanhBUS = new ChucDanhBUS();
        private ChucDanhDTO ChucDanhDTO = new ChucDanhDTO();
        private KB_NhanBUS NhanBUS = new KB_NhanBUS();
        private KB_NhanDTO NhanDTO = new KB_NhanDTO();
        private Dictionary<String, Bitmap> iconsCache = new Dictionary<string, Bitmap>();

        public ThemCongViec()
        {
            InitializeComponent();
            gcCongViecChiTiet.ProcessGridKey += GcCongViecChiTiet_ProcessGridKey;
            gcThanhVien.ProcessGridKey += GcThanhVien_ProcessGridKey;
            btnXoa.ButtonClick += BtnXoa_ButtonClick;
            gvCongViecChiTiet.ValidateRow += GvCongViecChiTiet_ValidateRow;
            gvCongViecChiTiet.InvalidRowException += GvCongViecChiTiet_InvalidRowException;
        }

        private void GvCongViecChiTiet_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            // Sự kiện này để người ta không chuyển qua dòng khác được khi có lỗi xảy ra nè
            // Nó nhận giá trị e.Valid của gridView1_ValidateRow để ứng xử
            // neu e,Valid =True thì nó cho chuyển qua dòng khác hoặc làm tác vụ khác
            // và ngược lại
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void GvCongViecChiTiet_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
        }

        private void GcThanhVien_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && gvThanhVien.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
            {
                gvThanhVien.DeleteSelectedRows();
            }
        }

        private void GcCongViecChiTiet_ProcessGridKey(object sender, KeyEventArgs e)

        {
            // kiểm tra xem có phải người dùng bấm nút xóa trên bàn phím
            // Và trạng thái của Gridcontrol có không phải là đang edit không (tránh
            // tình trạng người dùng đang focus để sửa 1 cell nào trong Grid view )
            if (e.KeyCode == Keys.Delete && gvCongViecChiTiet.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
            {
                gvCongViecChiTiet.DeleteSelectedRows();
            }
            if (e.KeyCode == Keys.Enter)
            {
                BeginInvoke(new MethodInvoker(() => gvCongViecChiTiet.AddNewRow()));
            }
        }

        private void BtnXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            BeginInvoke(new MethodInvoker(() => gvCongViecChiTiet.DeleteSelectedRows()));
        }

        private void ThemCongViec_Load(object sender, EventArgs e)
        {
            // Gan dt va Gridcontrol
            gcCongViecChiTiet.DataSource = KB_CongViecChiTietBUS.ThemCongViecChiTietBUS();
            //Them nhan
            leNhan.Properties.DataSource = NhanBUS.LayTatCaNhanBUS();
            leNhan.Properties.ValueMember = "id";
            leNhan.Properties.DisplayMember = "tieude";
            // Them theo bo phan
            leChonBoPhan.Properties.DataSource = BoPhanBUS.LayTatCaBoPhanBUS();
            leChonBoPhan.Properties.ValueMember = "id";
            leChonBoPhan.Properties.DisplayMember = "ten";
            //Them theo thanh vien
            leChonThanhVien.Properties.DataSource = KB_CongViecBUS.ThemTheoThanhVienBUS();
            leChonThanhVien.Properties.ValueMember = "id";
            leChonThanhVien.Properties.DisplayMember = "fullname";
        }

        private void btnChonBoPhan_Click(object sender, EventArgs e)
        {
            if (leChonBoPhan.EditValue.ToString() != "")
            {
                gcThanhVien.DataSource = KB_CongViecBUS.ThemTheoBoPhanBUS(int.Parse(leChonBoPhan.EditValue.ToString()));
            }
        }

        private void btnChonThanhVien_Click(object sender, EventArgs e)
        {
            if (leChonThanhVien.EditValue.ToString() != "")
            {
                UserDTO = UserBUS.LayThanhVienTheoIdBUS(int.Parse(leChonThanhVien.EditValue.ToString()));
                BoPhanDTO = BoPhanBUS.LayBoPhanTheoIdBUS(UserDTO.Bophan_id);
                ChucDanhDTO = ChucDanhBUS.LayChucDanhTheoIdBUS(UserDTO.Chucdanh_id);
                int rowHandle = gvThanhVien.GetRowHandle(gvThanhVien.DataRowCount);
                if (rowHandle == 0)
                {
                    gcThanhVien.DataSource = UserBUS.LayThanhVienTheoIdChoDatasourceBUS(int.Parse(leChonThanhVien.EditValue.ToString()));
                }
                else
                {
                    //Kiem tra da co thanh vien tren luoi chua
                    int rowThanhVien = 0;
                    while (gvThanhVien.IsValidRowHandle(rowThanhVien))
                    {
                        rowThanhVien++;
                    }
                    //Doc tung dong tren luoi cua thanh vien
                    ArrayList myList = new ArrayList(rowThanhVien);
                    for (int y = 0; y < rowThanhVien; y++)
                    {
                        myList.Add(gvThanhVien.GetRowCellValue(y, colIdThanhVien).ToString());
                    }
                    //Tao bien kiem tra, neu true tuc la da co, false la khong co
                    bool DaCoThanhVien = false;
                    //Tao bien gan gia tri id thanh vien dong duoi cung
                    int IdThanhVienDuoiCung = DevExpress.XtraGrid.GridControl.NewItemRowHandle;
                    int IdThanhVienDaLay = 0;
                    if (gvThanhVien.GetRowCellValue(IdThanhVienDuoiCung, colIdThanhVien) != null)
                    {
                        IdThanhVienDaLay = int.Parse(gvThanhVien.GetRowCellValue(IdThanhVienDuoiCung, colIdThanhVien).ToString());
                    }

                    //Chay vong lap trong luoi, so sanh da co thanh vien hay chua
                    foreach (var id in myList)
                    {
                        if (UserDTO.UserID == int.Parse(id.ToString()))
                        {
                            DaCoThanhVien = true;
                            break;
                        }
                    }
                    //Neu có thanh vien thi thong bao
                    if (DaCoThanhVien == true || UserDTO.UserID == IdThanhVienDaLay)
                    {
                        XtraMessageBox.Show(BienToanCuc.ShowExist, BienToanCuc.ShowAlert);
                    }
                    //Neu chua co thanh vien thi them vao luoi
                    else
                    {
                        gvThanhVien.AddNewRow();
                        gvThanhVien.FocusedRowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle;
                        gvThanhVien.SetRowCellValue(gvThanhVien.FocusedRowHandle, "id", UserDTO.UserID);
                        gvThanhVien.SetRowCellValue(gvThanhVien.FocusedRowHandle, "fullname", UserDTO.FullName);

                        gvThanhVien.SetRowCellValue(gvThanhVien.FocusedRowHandle, "tenbophan", BoPhanDTO.Ten);
                        gvThanhVien.SetRowCellValue(gvThanhVien.FocusedRowHandle, "tenchucdanh", ChucDanhDTO.Ten);
                    }
                }
            }
        }

        private void btnThemCongViecMoi_Click(object sender, EventArgs e)
        {
            //Ket thuc trang thai edit cua 2 luoi
            gvCongViecChiTiet.CloseEditor();
            gvThanhVien.CloseEditor();
            //Xoa dung duoi cung view thanh vien
            gvThanhVien.AddNewRow();
            int rowThanhVien = 0;
            while (gvThanhVien.IsValidRowHandle(rowThanhVien))
            {
                var data = gvThanhVien.GetRow(rowThanhVien);
                bool isSelected = gvThanhVien.IsRowSelected(rowThanhVien);
                rowThanhVien++;
            }
            gvThanhVien.DeleteSelectedRows();
            //ket thuc
            //xoa dong duoi cung view cong viec chi tiet
            gvCongViecChiTiet.AddNewRow();
            int rowCongViecChiTiet = 0;
            while (gvCongViecChiTiet.IsValidRowHandle(rowCongViecChiTiet))
            {
                var data = gvCongViecChiTiet.GetRow(rowCongViecChiTiet);
                bool isSelected = gvCongViecChiTiet.IsRowSelected(rowCongViecChiTiet);
                rowCongViecChiTiet++;
            }
            gvCongViecChiTiet.DeleteSelectedRows();
            //ket thuc
            //Kiem tra thong tin rong hay khong, neu khong rong thi bat dau cap nhat csdl
            if (txtTieuDe.Text != "" && leNhan.Text != "" && meMoTa.Text != "" && rowThanhVien >= 1 && rowCongViecChiTiet >= 1)
            {
                //Xac nhan cap nhat
                if (XtraMessageBox.Show(BienToanCuc.ShowConfirm, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Khai bao bien de tao cong viec chi tiet sau do chon cong viec chi tiet moi nhat theo ngay va nguoi gui
                    DateTime dNgayTao = DateTime.Now;
                    string NgayTao = dNgayTao.ToString("yyyy-MM-dd HH:mm:ss");
                    int nguoigui_id = BienToanCuc.UserID;
                    byte hoanthanh = 0;
                    //Doc tung dong tren luoi cua cong viec chi tiet
                    for (int i = 0; i < rowCongViecChiTiet; i++)
                    {
                        if (gvCongViecChiTiet.GetRowCellValue(i, colCongViecChiTiet) != null)
                        {
                            string congviecchitiet = gvCongViecChiTiet.GetRowCellValue(i, colCongViecChiTiet).ToString();
                            if (congviecchitiet != "")
                            {
                                //Them du lieu vao csdl
                                KB_CongViecChiTietBUS.TaoCongViecChiTietBUS(congviecchitiet, NgayTao, nguoigui_id, hoanthanh);
                            }
                        }
                    }
                    //Doc tung dong tren luoi cua thanh vien
                    ArrayList myList = new ArrayList(rowThanhVien);
                    for (int y = 0; y < rowThanhVien; y++)
                    {
                        myList.Add(gvThanhVien.GetRowCellValue(y, colIdThanhVien).ToString());
                    }
                    //Co du lieu cong viec chi tiet bat dau tao bien cho cong viec
                    string tieude = txtTieuDe.Text;
                    string mota = meMoTa.Text;
                    //Bien ngay tao da co phia tren
                    string congviecchitiet_id = KB_CongViecChiTietBUS.LayCongViecChiTietChoCongViecMoiBUS(NgayTao);
                    //Bien nguoi gui da co phia tren
                    string nguoinhan_id = String.Join(",", myList.ToArray());
                    int nhan_id = int.Parse(leNhan.EditValue.ToString());
                    //Bien trang thai mac dinh bang 1 - Chua Lam
                    int trangthai_id = 1;
                    try
                    {
                        KB_CongViecBUS.ThemCongViecBUS(tieude, mota, NgayTao, congviecchitiet_id, nguoigui_id, nguoinhan_id, nhan_id, trangthai_id);
                        XtraMessageBox.Show(BienToanCuc.ShowSuccess, BienToanCuc.ShowAlert);
                    }
                    catch
                    {
                        XtraMessageBox.Show(BienToanCuc.ShowError, BienToanCuc.ShowAlert);
                    }
                }
            }
            //kiem tra neu rong thi thong bao
            else
            {
                XtraMessageBox.Show(BienToanCuc.ShowEmpty, BienToanCuc.ShowAlert);
            }
        }

        private void btnSuaCongViec_Click(object sender, EventArgs e)
        {
            //Ket thuc trang thai edit cua 2 luoi
            gvCongViecChiTiet.CloseEditor();
            gvThanhVien.CloseEditor();
            //Xoa dung duoi cung view thanh vien
            gvThanhVien.AddNewRow();
            int rowThanhVien = 0;
            while (gvThanhVien.IsValidRowHandle(rowThanhVien))
            {
                var data = gvThanhVien.GetRow(rowThanhVien);
                bool isSelected = gvThanhVien.IsRowSelected(rowThanhVien);
                rowThanhVien++;
            }
            gvThanhVien.DeleteSelectedRows();
            //ket thuc
            //xoa dong duoi cung view cong viec chi tiet
            gvCongViecChiTiet.AddNewRow();
            int rowCongViecChiTiet = 0;
            while (gvThanhVien.IsValidRowHandle(rowCongViecChiTiet))
            {
                var data = gvThanhVien.GetRow(rowCongViecChiTiet);
                bool isSelected = gvThanhVien.IsRowSelected(rowCongViecChiTiet);
                rowCongViecChiTiet++;
            }
            gvCongViecChiTiet.DeleteSelectedRows();
            //ket thuc
            //Kiem tra thong tin rong hay khong, neu khong rong thi bat dau cap nhat csdl
            if (txtTieuDe.Text != "" && leNhan.Text != "" && meMoTa.Text != "" && rowThanhVien >= 1 && rowCongViecChiTiet >= 1)
            {
                //Xac nhan cap nhat
                if (XtraMessageBox.Show(BienToanCuc.ShowConfirm, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Khai bao bien de tao cong viec chi tiet sau do chon cong viec chi tiet moi nhat theo ngay va nguoi gui
                    DateTime dNgayTao = DateTime.Now;
                    string NgayTao = dNgayTao.ToString("yyyy-MM-dd HH:mm:ss");
                    int nguoigui_id = BienToanCuc.UserID;
                    byte hoanthanh = 0;
                    //Doc tung dong tren luoi cua cong viec chi tiet
                    for (int i = 0; i < rowCongViecChiTiet; i++)
                    {
                        if (gvCongViecChiTiet.GetRowCellValue(i, colCongViecChiTiet) != null)
                        {
                            string congviecchitiet = gvCongViecChiTiet.GetRowCellValue(i, colCongViecChiTiet).ToString();
                            if (congviecchitiet != "")
                            {
                                //Them du lieu vao csdl
                                KB_CongViecChiTietBUS.TaoCongViecChiTietBUS(congviecchitiet, NgayTao, nguoigui_id, hoanthanh);
                            }
                        }
                    }
                    //Doc tung dong tren luoi cua thanh vien
                    ArrayList myList = new ArrayList(rowThanhVien);
                    for (int y = 0; y < rowThanhVien; y++)
                    {
                        myList.Add(gvThanhVien.GetRowCellValue(y, colIdThanhVien).ToString());
                    }
                    //Co du lieu cong viec chi tiet bat dau tao bien cho cong viec
                    string tieude = txtTieuDe.Text;
                    string mota = meMoTa.Text;
                    //Bien ngay tao da co phia tren
                    string congviecchitiet_id = KB_CongViecChiTietBUS.LayCongViecChiTietChoCongViecMoiBUS(NgayTao);
                    //Bien nguoi gui da co phia tren
                    string nguoinhan_id = String.Join(",", myList.ToArray());
                    int nhan_id = int.Parse(leNhan.EditValue.ToString());
                    try
                    {
                        //KB_CongViecBUS.ThemCongViecBUS(tieude, mota, NgayTao, congviecchitiet_id, nguoigui_id, nguoinhan_id, nhan_id, trangthai_id);
                        KB_CongViecBUS.SuaCongViecBUS(tieude, mota, NgayTao, congviecchitiet_id, nguoigui_id, nguoinhan_id, nhan_id);
                        XtraMessageBox.Show(BienToanCuc.ShowSuccess, BienToanCuc.ShowAlert);
                    }
                    catch
                    {
                        XtraMessageBox.Show(BienToanCuc.ShowError, BienToanCuc.ShowAlert);
                    }
                }
            }
            //kiem tra neu rong thi thong bao
            else
            {
                XtraMessageBox.Show(BienToanCuc.ShowEmpty, BienToanCuc.ShowAlert);
            }
        }
    }
}