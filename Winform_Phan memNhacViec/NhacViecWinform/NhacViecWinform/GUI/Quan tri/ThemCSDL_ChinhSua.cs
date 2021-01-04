using NhacViecWinform.DTO;
using System;

namespace HoTroNhacViecWinform.GUI.Quan_tri
{
    public partial class ThemCSDL_ChinhSua : DevExpress.XtraEditors.XtraUserControl
    {
        public ThemCSDL_ChinhSua()
        {
            InitializeComponent();
        }

        private void txtThongTin_EditValueChanged(object sender, EventArgs e)
        {
            BienToanCuc.ThemThongTin = txtThongTin.Text;
        }
    }
}