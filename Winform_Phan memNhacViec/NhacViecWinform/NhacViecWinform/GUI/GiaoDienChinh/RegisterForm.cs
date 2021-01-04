using HoTroNhacViecWinform.BUS;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;
using System.Windows.Forms;

namespace NhacViecWinform.GUI
{
    public partial class RegisterForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private UserBUS userBUS = new UserBUS();
        private BoPhanBUS BoPhanBUS = new BoPhanBUS();
        private ChucDanhBUS ChucDanhBUS = new ChucDanhBUS();
        private TrungTamBUS TrungTamBUS = new TrungTamBUS();
        private BienToanCuc btc = new BienToanCuc();

        public RegisterForm()
        {
            InitializeComponent();
            txtDienThoai.TextChanged += new EventHandler(txtDienThoai_TextChanged);
            txtDienThoai.KeyPress += new KeyPressEventHandler(txtDienThoai_KeyPress);
            //Hien thi bo phan
            leBoPhan.Properties.DataSource = BoPhanBUS.LayTatCaBoPhanBUS();
            leBoPhan.Properties.ValueMember = "id";
            leBoPhan.Properties.DisplayMember = "ten";
            //Hien thi chuc danh
            leChucDanh.Properties.DataSource = ChucDanhBUS.LayTatCaChucDanhBUS();
            leChucDanh.Properties.ValueMember = "id";
            leChucDanh.Properties.DisplayMember = "ten";
            //Hien thi trung tam
            leTrungTam.Properties.DataSource = TrungTamBUS.LayTatCaTrungTamBUS();
            leTrungTam.Properties.ValueMember = "id";
            leTrungTam.Properties.DisplayMember = "ten";
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDienThoai.Text, "  ^ [0-9]"))
            {
                txtDienThoai.Text = "";
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != "" && txtMatKhau.Text != "" && txtEmail.Text != "" && txtHoTen.Text != "" & txtDienThoai.Text != "" && leBoPhan.Text != "" && leChucDanh.Text != "")
            {
                if (btc.CheckEmail(txtEmail.Text))
                {
                    if (userBUS.CheckExistUserBUS(txtTaiKhoan.Text))
                    {
                        if (userBUS.CheckExistEmailBUS(txtEmail.Text))
                        {
                            double SoDienThoai = double.Parse(txtDienThoai.Text);
                            if (leBoPhan.EditValue != null && leChucDanh.EditValue != null && leTrungTam.EditValue != null)
                            {
                                int bophan_id = int.Parse(leBoPhan.EditValue.ToString());
                                int chucdanh_id = int.Parse(leChucDanh.EditValue.ToString());
                                int trungtam_id = int.Parse(leTrungTam.EditValue.ToString());
                                userBUS.CreateUserBUS(txtTaiKhoan.Text, txtMatKhau.Text, txtHoTen.Text, txtEmail.Text, SoDienThoai, bophan_id, chucdanh_id, trungtam_id);
                                lblMessage.Text = BienToanCuc.ShowSuccess;
                            }
                        }
                        else
                        {
                            lblMessage.Text = BienToanCuc.ShowEmailExist;
                        }
                    }
                    else
                    {
                        lblMessage.Text = BienToanCuc.ShowExist;
                    }
                }
                else
                {
                    lblMessage.Text = BienToanCuc.ShowRegex;
                }
            }
            else
            {
                lblMessage.Text = BienToanCuc.ShowEmpty;
            }
        }

        private void linkDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frmLogin = new LoginForm();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}