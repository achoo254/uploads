using AutoUpdaterDotNET;
using NhacViecWinform.BUS;
using NhacViecWinform.DTO;
using System;
using System.Windows.Forms;

namespace NhacViecWinform.GUI
{
    public partial class LoginForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private UserBUS userBUS = new UserBUS();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (userBUS.LoginUserBUS(txtTaiKhoan.Text, txtMatKhau.Text) == true)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                lblMessage.Text = BienToanCuc.ShowError;
            }
        }

        private void linkDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm frmRegister = new RegisterForm();
            frmRegister.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblPhienBan.Text = Application.ProductVersion;
            //Autoupdate online
            AutoUpdater.Start(@"https://achoobucket.s3-ap-southeast-1.amazonaws.com/AutoUpdater.xml");

            //Autoupdate offline
            //AutoUpdater.Start("C:\\Users\\HoanDat\\OneDrive\\GitHub\\VNVC\\NhacViecWinform\\NhacViecWinform\\AutoUpdater - offline.xml");

            AutoUpdater.Mandatory = true;
            AutoUpdater.UpdateMode = Mode.Forced;
        }
    }
}