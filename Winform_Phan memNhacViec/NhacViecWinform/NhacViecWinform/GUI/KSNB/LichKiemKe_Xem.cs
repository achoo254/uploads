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
    public partial class LichKiemKe_Xem : DevExpress.XtraEditors.XtraForm
    {
        KSNB_LichKiemKeBUS KSNB_LichKiemKeBUS = new KSNB_LichKiemKeBUS();
        public LichKiemKe_Xem(string thang, string nam)
        {
            InitializeComponent();
            gcXemLichKiemKe.DataSource = KSNB_LichKiemKeBUS.LayLichKiemKeBUS(thang, nam, BienToanCuc.UserID);
        }
    }
}