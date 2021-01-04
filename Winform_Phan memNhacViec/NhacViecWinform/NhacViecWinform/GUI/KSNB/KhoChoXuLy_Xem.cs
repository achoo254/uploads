using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HoTroNhacViecWinform.BUS;
using NhacViecWinform.DTO;

namespace HoTroNhacViecWinform.GUI.KSNB
{
    public partial class KhoChoXuLy_Xem : DevExpress.XtraEditors.XtraForm
    {
        KSNB_KhoChoXuLyBUS KSNB_KhoChoXuLyBUS = new KSNB_KhoChoXuLyBUS();
        public KhoChoXuLy_Xem(string thang, string nam)
        {
            InitializeComponent();
            gcXemTonKhoChoXuLy.DataSource = KSNB_KhoChoXuLyBUS.LayTonKhoChoXuLyBUS(thang, nam, BienToanCuc.UserID);
        }
    }
}