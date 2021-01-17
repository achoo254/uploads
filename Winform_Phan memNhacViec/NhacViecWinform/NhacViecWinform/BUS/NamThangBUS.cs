using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoTroNhacViecWinform.BUS
{
    class NamThangBUS
    {
        public DataTable HienThiNam()
        {
            DataTable dt = new DataTable();
            // khởi tạo cột cho Datatable đã khai báo ở trên
            dt.Columns.Add(new DataColumn("nam", typeof(string)));
            // Add du lieu vao dt
            for(int i = 2020; i <= 2100; i++)
            {
                dt.Rows.Add(i);
            }
            return dt;
        }
        public DataTable HienThiThang()
        {
            DataTable dt = new DataTable();
            // khởi tạo cột cho Datatable đã khai báo ở trên
            dt.Columns.Add(new DataColumn("thang", typeof(string)));
            // Add du lieu vao dt
            for (int i = 1; i <= 12; i++)
            {
                dt.Rows.Add(i);
            }
            return dt;
        }
    }
}
