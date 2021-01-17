using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;
using System.Windows.Forms;

namespace NhacViecWinform.GUI.Chat
{
    public partial class LienHeThanhVien : DevExpress.XtraEditors.XtraForm
    {
        private LienHeBUS LienHeBUS = new LienHeBUS();
        private LienHeDTO LienHeDTO = new LienHeDTO();
        private LienHeNhomBUS LienHeNhomBUS = new LienHeNhomBUS();
        private LienHeNhomDTO LienHeNhomDTO = new LienHeNhomDTO();
        private UserBUS UserBUS = new UserBUS();
        private UserDTO UserDTO = new UserDTO();
        private Timer timer = new Timer();
        private int lienhe_nhom_id = 0;

        public LienHeThanhVien()
        {
            InitializeComponent();
            ceChonThanhVien.Properties.DataSource = LienHeNhomBUS.LayTatCaThanhVienNhanNhomBUS(BienToanCuc.UserID);
            ceChonThanhVien.Properties.ValueMember = "id";
            ceChonThanhVien.Properties.DisplayMember = "fullname";
            ceChonThanhVien.EditValueChanged += CeChonThanhVien_EditValueChanged;

            //Lay danh sach nhom lien he
            gcNhom.DataSource = LienHeNhomBUS.LayTatCaNhomNeuTrongNhomBUS(BienToanCuc.UserID.ToString(), BienToanCuc.UserID);

            //Lay thong tin nguoi gui
            UserDTO = UserBUS.LayTatCaThongTinTheoIdBUS();

            meGuiTinNhan.KeyDown += MeGuiTinNhan_KeyDown;
            gvNhom.MouseEnter += GvNhom_MouseEnter;
            gvChat.MouseEnter += GvChat_MouseEnter;
            gvChat.CustomDrawCell += GvChat_CustomDrawCell;
        }

        private void GvChat_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "noidung")
            {
                if (e.CellValue != null)
                {
                    int nguoigui_id = Convert.ToInt32(gvChat.GetRowCellValue(e.RowHandle, "nguoigui_id"));
                    if (nguoigui_id == BienToanCuc.UserID)
                    {
                        e.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
                    }
                }
            }
        }

        private void CeChonThanhVien_EditValueChanged(object sender, EventArgs e)
        {
            txtTieuDe.Text = ceChonThanhVien.Text;
        }

        private void GvChat_MouseEnter(object sender, EventArgs e)
        {
            TaiLaiBangNhomVaLienHe();
        }

        private void GvNhom_MouseEnter(object sender, EventArgs e)
        {
            TaiLaiBangNhomVaLienHe();
        }

        private void MeGuiTinNhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GuiTinNhan();
            }
        }

        private void btnThemLienHe_Click(object sender, EventArgs e)
        {
            if (ceChonThanhVien.Text != "" && txtTieuDe.Text != "")
            {
                string tieude = txtTieuDe.Text;
                int nguoitao_id = BienToanCuc.UserID;
                string nguoinhan_id = ceChonThanhVien.EditValue.ToString();
                byte thongbao = 1;

                LienHeNhomBUS.ThemNhomMoiBUS(tieude, nguoitao_id, nguoinhan_id, thongbao);
                txtTieuDe.Text = "";
                gcNhom.DataSource = LienHeNhomBUS.LayTatCaNhomNeuTrongNhomBUS(BienToanCuc.UserID.ToString(), nguoitao_id);
            }
            else
            {
                XtraMessageBox.Show(BienToanCuc.ShowEmpty, BienToanCuc.ShowAlert);
            }
        }

        private void btnGuiTinNhan_Click(object sender, EventArgs e)
        {
            GuiTinNhan();
        }

        private void TaiLaiBangNhomVaLienHe()
        {
            gcNhom.DataSource = LienHeNhomBUS.LayTatCaNhomNeuTrongNhomBUS(BienToanCuc.UserID.ToString(), BienToanCuc.UserID);

            if (lienhe_nhom_id > 0)
            {
                string khoa = BienToanCuc.UserID.ToString();
                gcChat.DataSource = LienHeBUS.LayNoiDungLienheTheoNhomBUS(lienhe_nhom_id, khoa);
                gvChat.MoveLastVisible();
            }
        }

        private void GuiTinNhan()
        {
            if (lienhe_nhom_id <= 0)
            {
                XtraMessageBox.Show(BienToanCuc.ShowChatEmpty, BienToanCuc.ShowAlert);
            }
            else
            {
                if (meGuiTinNhan.Text != "" && lienhe_nhom_id > 0)
                {
                    string noidung = meGuiTinNhan.Text;
                    int nguoigui_id = BienToanCuc.UserID;
                    int nhom_id = lienhe_nhom_id;
                    DateTime dNgayTao = DateTime.Now;
                    string NgayTao = dNgayTao.ToString("yyyy-MM-dd HH:mm:ss");
                    string khoa = BienToanCuc.UserID.ToString();
                    byte thongbao = 1;
                    string tennguoigui = "\b" + UserDTO.FullName + "\b";
                    string khong_khoa = "0";

                    LienHeBUS.GuiTinNhanBUS(noidung, nguoigui_id, nhom_id, NgayTao, tennguoigui, khong_khoa);
                    meGuiTinNhan.Text = "";
                    gcChat.DataSource = LienHeBUS.LayNoiDungLienheTheoNhomBUS(lienhe_nhom_id, khoa);
                    LienHeNhomBUS.CapNhatThongBaoBUS(lienhe_nhom_id, thongbao);
                    gvChat.MoveLastVisible();
                }
                else
                {
                    XtraMessageBox.Show(BienToanCuc.ShowEmpty, BienToanCuc.ShowAlert);
                }
            }
        }

        private void gvNhom_Click(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                //MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.RowHandle, colCaption));
                //Lay nhom id
                lienhe_nhom_id = int.Parse(gvNhom.GetRowCellValue(gvNhom.FocusedRowHandle, "id").ToString());
                string tieude = gvNhom.GetRowCellValue(gvNhom.FocusedRowHandle, "tieude").ToString();
                //Lay thong bao, neu bang 0 tuc la da doc
                byte thongbao = 0;
                string khoa = BienToanCuc.UserID.ToString();

                gcChat.DataSource = LienHeBUS.LayNoiDungLienheTheoNhomBUS(lienhe_nhom_id, khoa);
                LienHeNhomBUS.CapNhatThongBaoBUS(lienhe_nhom_id, thongbao);
                layoutBangLienHe.Text = tieude;

                listThanhVien.DataSource = LienHeNhomBUS.LayHienThiThanhVienNhomTheoIdBUS(lienhe_nhom_id);
                listThanhVien.ValueMember = "id";
                listThanhVien.DisplayMember = "fullname";
            }
        }

        private void btnXoaNoiDung_Click(object sender, EventArgs e)
        {
            if (lienhe_nhom_id > 0)
            {
                if (XtraMessageBox.Show(BienToanCuc.ShowConfirm, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Tao bien de khoa
                    string khoa = BienToanCuc.UserID.ToString();
                    //Them vao csdl
                    LienHeBUS.KhoaTinNhanBUS(lienhe_nhom_id, khoa, BienToanCuc.UserID);
                }
            }
        }
    }
}