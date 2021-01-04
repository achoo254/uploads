using DevExpress.XtraEditors;
using HoTroNhacViecWinform.BUS;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;
using System.Windows.Forms;

namespace NhacViecWinform.GUI
{
    public partial class UserInfoForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private UserBUS userBUS = new UserBUS();
        private UserDTO UserDTO = new UserDTO();
        private BoPhanBUS BoPhanBUS = new BoPhanBUS();
        private ChucDanhBUS ChucDanhBUS = new ChucDanhBUS();
        private TrungTamBUS TrungTamBUS = new TrungTamBUS();
        private BienToanCuc btc = new BienToanCuc();
        private string matkhau = "";
        private MainForm mainChinh;

        public UserInfoForm(MainForm main)
        {
            InitializeComponent();
            mainChinh = main;
            UserDTO = userBUS.LayTatCaThongTinTheoIdBUS();
            txtTaiKhoan.Text = UserDTO.UserName;
            txtEmail.Text = UserDTO.EMail;
            txtHoTen.Text = UserDTO.FullName;
            txtDienThoai.Text = UserDTO.Phone.ToString();
            //Hien thi bo phan
            leBoPhan.Properties.DataSource = BoPhanBUS.LayTatCaBoPhanBUS();
            leBoPhan.Properties.ValueMember = "id";
            leBoPhan.Properties.DisplayMember = "ten";
            leBoPhan.EditValue = UserDTO.Bophan_id;
            //Hien thi chuc danh
            leChucDanh.Properties.DataSource = ChucDanhBUS.LayTatCaChucDanhBUS();
            leChucDanh.Properties.ValueMember = "id";
            leChucDanh.Properties.DisplayMember = "ten";
            leChucDanh.EditValue = UserDTO.Chucdanh_id;
            //Hien thi trung tam
            leTrungTam.Properties.DataSource = TrungTamBUS.LayTatCaTrungTamBUS();
            leTrungTam.Properties.ValueMember = "id";
            leTrungTam.Properties.DisplayMember = "ten";
            leTrungTam.EditValue = UserDTO.Trungtam_id;

            txtDienThoai.TextChanged += new EventHandler(txtDienThoai_TextChanged);
            txtDienThoai.KeyPress += new KeyPressEventHandler(txtDienThoai_KeyPress);
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

        private void btnDoiThongTin_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != "" && txtEmail.Text != "" && txtHoTen.Text != "" & txtDienThoai.Text != "")
            {
                if (btc.CheckEmail(txtEmail.Text))
                {
                    if (txtMatKhau.Text != "")
                    {
                        matkhau = txtMatKhau.Text;
                    }
                    else
                    {
                        matkhau = BienToanCuc.MatKhauMaHoa;
                    }
                    double SoDienThoai = double.Parse(txtDienThoai.Text);
                    if (leBoPhan.EditValue != null && leChucDanh.EditValue != null && leTrungTam.EditValue != null)
                    {
                        int bophan_id = int.Parse(leBoPhan.EditValue.ToString());
                        int chucdanh_id = int.Parse(leChucDanh.EditValue.ToString());
                        int trungtam_id = int.Parse(leTrungTam.EditValue.ToString());

                        userBUS.UpdateUserBUS(matkhau, txtHoTen.Text, txtEmail.Text, SoDienThoai, bophan_id, chucdanh_id, trungtam_id);
                        DialogResult dialogResult = XtraMessageBox.Show(BienToanCuc.ShowConfirm, BienToanCuc.ShowAlert, MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            DisposeAllInActiveForms();
                            this.Hide();
                            LoginForm loginForm = new LoginForm();
                            loginForm.ShowDialog();
                            this.Close();
                        }
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainChinh.Show();
            this.Close();
        }

        public void DisposeAllInActiveForms()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
        }
    }
}