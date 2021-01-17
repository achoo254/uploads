using DevExpress.XtraEditors;
using HoTroNhacViecWinform.BUS;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;
using System.Windows.Forms;

namespace HoTroNhacViecWinform.GUI.Quan_tri
{
    public partial class ThemCSDL : DevExpress.XtraEditors.XtraForm
    {
        private BoPhanBUS BoPhanBUS = new BoPhanBUS();
        private ChucDanhBUS ChucDanhBUS = new ChucDanhBUS();
        private TrungTamBUS TrungTamBUS = new TrungTamBUS();
        private CategoryBUS CategoryBUS = new CategoryBUS();
        private HoSoBUS HoSoBUS = new HoSoBUS();
        private CSDL_BUS CSDL_BUS = new CSDL_BUS();
        private string ten = "";
        private string bang = "";
        private string tencu = "";
        private string tenmoi = "";

        public ThemCSDL()
        {
            InitializeComponent();
            listThongTin.DoubleClick += ListThongTin_DoubleClick;
        }

        private void ListThongTin_DoubleClick(object sender, EventArgs e)
        {
            tencu = listThongTin.GetItemText(listThongTin.SelectedIndex);

            ThemCSDL_ChinhSua myControl = new ThemCSDL_ChinhSua();

            if (DevExpress.XtraEditors.XtraDialog.Show(myControl, BienToanCuc.ShowConfirm, MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (BienToanCuc.ThemThongTin != "")
                {
                    tenmoi = BienToanCuc.ThemThongTin;

                    if (bang == "bophan")
                    {
                        //Kiem tra neu chua ton tai ten moi thi cap nhat
                        if (CSDL_BUS.XemThongTinBoPhanTonTaiBUS(tenmoi))
                        {
                            CSDL_BUS.SuaThongTinBoPhanCSDLBUS(tencu, tenmoi);
                            BienToanCuc.ThemThongTin = "";

                            listThongTin.DataSource = BoPhanBUS.LayTatCaBoPhanBUS();
                            listThongTin.ValueMember = "id";
                            listThongTin.DisplayMember = "ten";
                        }
                        //Nguoc lai da co ten moi thi thong bao
                        else
                        {
                            XtraMessageBox.Show(BienToanCuc.ShowExist, BienToanCuc.ShowAlert);
                        }
                    }
                    else if (bang == "trungtam")
                    {
                        //Kiem tra neu chua ton tai ten moi thi cap nhat
                        if (CSDL_BUS.XemThongTintrungtamTonTaiBUS(tenmoi))
                        {
                            CSDL_BUS.SuaThongTintrungtamCSDLBUS(tencu, tenmoi);
                            BienToanCuc.ThemThongTin = "";

                            listThongTin.DataSource = TrungTamBUS.LayTatCaTrungTamBUS();
                            listThongTin.ValueMember = "id";
                            listThongTin.DisplayMember = "ten";
                        }
                        //Nguoc lai da co ten moi thi thong bao
                        else
                        {
                            XtraMessageBox.Show(BienToanCuc.ShowExist, BienToanCuc.ShowAlert);
                        }
                    }
                    else if (bang == "chucdanh")
                    {
                        //Kiem tra neu chua ton tai ten moi thi cap nhat
                        if (CSDL_BUS.XemThongTinchucdanhTonTaiBUS(tenmoi))
                        {
                            CSDL_BUS.SuaThongTinchucdanhCSDLBUS(tencu, tenmoi);
                            BienToanCuc.ThemThongTin = "";

                            listThongTin.DataSource = ChucDanhBUS.LayTatCaChucDanhBUS();
                            listThongTin.ValueMember = "id";
                            listThongTin.DisplayMember = "ten";
                        }
                        //Nguoc lai da co ten moi thi thong bao
                        else
                        {
                            XtraMessageBox.Show(BienToanCuc.ShowExist, BienToanCuc.ShowAlert);
                        }
                    }
                    else if (bang == "danhmuc")
                    {
                        //Kiem tra neu chua ton tai ten moi thi cap nhat
                        if (CSDL_BUS.XemThongTindanhmucTonTaiBUS(tenmoi))
                        {
                            CSDL_BUS.SuaThongTindanhmucCSDLBUS(tencu, tenmoi);
                            BienToanCuc.ThemThongTin = "";

                            listThongTin.DataSource = CategoryBUS.GetCategoryBUS();
                            listThongTin.ValueMember = "id";
                            listThongTin.DisplayMember = "ten";
                        }
                        //Nguoc lai da co ten moi thi thong bao
                        else
                        {
                            XtraMessageBox.Show(BienToanCuc.ShowExist, BienToanCuc.ShowAlert);
                        }
                    }
                    else if (bang == "hoso")
                    {
                        //Kiem tra neu chua ton tai ten moi thi cap nhat
                        if (CSDL_BUS.XemThongTinhosoTonTaiBUS(tenmoi))
                        {
                            CSDL_BUS.SuaThongTinhosoCSDLBUS(tencu, tenmoi);
                            BienToanCuc.ThemThongTin = "";

                            listThongTin.DataSource = HoSoBUS.LayDanhSachHoSoBUS();
                            listThongTin.ValueMember = "id";
                            listThongTin.DisplayMember = "ten";
                        }
                        //Nguoc lai da co ten moi thi thong bao
                        else
                        {
                            XtraMessageBox.Show(BienToanCuc.ShowExist, BienToanCuc.ShowAlert);
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show(BienToanCuc.ShowEmpty, BienToanCuc.ShowAlert);
                }
            }
        }

        private void txtThemBoPhan_Enter(object sender, EventArgs e)
        {
            listThongTin.DataSource = BoPhanBUS.LayTatCaBoPhanBUS();
            listThongTin.ValueMember = "id";
            listThongTin.DisplayMember = "ten";

            bang = "bophan";
            lblDanhSachThongTin.Text = "Danh sách bộ phận";
            txtThemTrungTam.Text = "";
            txtThemChucDanh.Text = "";
            txtThemDanhMuc.Text = "";
            txtThemHoSo.Text = "";
        }

        private void txtThemTrungTam_Enter(object sender, EventArgs e)
        {
            listThongTin.DataSource = TrungTamBUS.LayTatCaTrungTamBUS();
            listThongTin.ValueMember = "id";
            listThongTin.DisplayMember = "ten";

            bang = "trungtam";
            lblDanhSachThongTin.Text = "Danh sách trung tâm";
            txtThemBoPhan.Text = "";
            txtThemChucDanh.Text = "";
            txtThemDanhMuc.Text = "";
            txtThemHoSo.Text = "";
        }

        private void txtThemChucDanh_Enter(object sender, EventArgs e)
        {
            listThongTin.DataSource = ChucDanhBUS.LayTatCaChucDanhBUS();
            listThongTin.ValueMember = "id";
            listThongTin.DisplayMember = "ten";

            bang = "chucdanh";
            lblDanhSachThongTin.Text = "Danh sách chức danh";
            txtThemBoPhan.Text = "";
            txtThemTrungTam.Text = "";
            txtThemDanhMuc.Text = "";
            txtThemHoSo.Text = "";
        }

        private void txtThemDanhMuc_Enter(object sender, EventArgs e)
        {
            listThongTin.DataSource = CategoryBUS.GetCategoryBUS();
            listThongTin.ValueMember = "id";
            listThongTin.DisplayMember = "ten";

            bang = "danhmuc";
            lblDanhSachThongTin.Text = "Danh sách danh mục";
            txtThemBoPhan.Text = "";
            txtThemTrungTam.Text = "";
            txtThemChucDanh.Text = "";
            txtThemHoSo.Text = "";
        }

        private void txtThemHoSo_Enter(object sender, EventArgs e)
        {
            listThongTin.DataSource = HoSoBUS.LayDanhSachHoSoBUS();
            listThongTin.ValueMember = "id";
            listThongTin.DisplayMember = "ten";

            bang = "hoso";
            lblDanhSachThongTin.Text = "Danh sách hồ sơ";
            txtThemBoPhan.Text = "";
            txtThemTrungTam.Text = "";
            txtThemDanhMuc.Text = "";
            txtThemChucDanh.Text = "";
        }

        private void btnThemBoPhan_Click(object sender, EventArgs e)
        {
            if (txtThemBoPhan.Text != "")
            {
                ten = txtThemBoPhan.Text;
                if (XtraMessageBox.Show(BienToanCuc.ShowConfirm, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CSDL_BUS.ThemThongTinBoPhanCSDLBUS(ten);

                    listThongTin.DataSource = BoPhanBUS.LayTatCaBoPhanBUS();
                    listThongTin.ValueMember = "id";
                    listThongTin.DisplayMember = "ten";

                    XtraMessageBox.Show(BienToanCuc.ShowSuccess, BienToanCuc.ShowAlert);
                }
            }
            else
            {
                XtraMessageBox.Show(BienToanCuc.ShowEmpty, BienToanCuc.ShowAlert);
            }
        }

        private void btnThemTrungTam_Click(object sender, EventArgs e)
        {
            if (txtThemTrungTam.Text != "")
            {
                ten = txtThemTrungTam.Text;
                if (XtraMessageBox.Show(BienToanCuc.ShowConfirm, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CSDL_BUS.ThemThongTintrungtamCSDLBUS(ten);

                    listThongTin.DataSource = TrungTamBUS.LayTatCaTrungTamBUS();
                    listThongTin.ValueMember = "id";
                    listThongTin.DisplayMember = "ten";

                    XtraMessageBox.Show(BienToanCuc.ShowSuccess, BienToanCuc.ShowAlert);
                }
            }
            else
            {
                XtraMessageBox.Show(BienToanCuc.ShowEmpty, BienToanCuc.ShowAlert);
            }
        }

        private void btnThemChucDanh_Click(object sender, EventArgs e)
        {
            if (txtThemChucDanh.Text != "")
            {
                ten = txtThemChucDanh.Text;
                if (XtraMessageBox.Show(BienToanCuc.ShowConfirm, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CSDL_BUS.ThemThongTinchucdanhCSDLBUS(ten);

                    listThongTin.DataSource = ChucDanhBUS.LayTatCaChucDanhBUS();
                    listThongTin.ValueMember = "id";
                    listThongTin.DisplayMember = "ten";

                    XtraMessageBox.Show(BienToanCuc.ShowSuccess, BienToanCuc.ShowAlert);
                }
            }
            else
            {
                XtraMessageBox.Show(BienToanCuc.ShowEmpty, BienToanCuc.ShowAlert);
            }
        }

        private void btnThemDanhMuc_Click(object sender, EventArgs e)
        {
            if (txtThemDanhMuc.Text != "")
            {
                ten = txtThemDanhMuc.Text;
                if (XtraMessageBox.Show(BienToanCuc.ShowConfirm, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CSDL_BUS.ThemThongTindanhmucCSDLBUS(ten);

                    listThongTin.DataSource = CategoryBUS.GetCategoryBUS();
                    listThongTin.ValueMember = "id";
                    listThongTin.DisplayMember = "ten";

                    XtraMessageBox.Show(BienToanCuc.ShowSuccess, BienToanCuc.ShowAlert);
                }
            }
            else
            {
                XtraMessageBox.Show(BienToanCuc.ShowEmpty, BienToanCuc.ShowAlert);
            }
        }

        private void btnThemHoSo_Click(object sender, EventArgs e)
        {
            if (txtThemHoSo.Text != "")
            {
                ten = txtThemHoSo.Text;
                if (XtraMessageBox.Show(BienToanCuc.ShowConfirm, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CSDL_BUS.ThemThongTinhosoCSDLBUS(ten);

                    listThongTin.DataSource = HoSoBUS.LayDanhSachHoSoBUS();
                    listThongTin.ValueMember = "id";
                    listThongTin.DisplayMember = "ten";

                    XtraMessageBox.Show(BienToanCuc.ShowSuccess, BienToanCuc.ShowAlert);
                }
            }
            else
            {
                XtraMessageBox.Show(BienToanCuc.ShowEmpty, BienToanCuc.ShowAlert);
            }
        }
    }
}