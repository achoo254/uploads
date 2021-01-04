using DevExpress.Spreadsheet;
using SaveRestoreSkinSettings;
using System;
using System.Data;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;

namespace NhacViecWinform.DTO
{
    public class BienToanCuc
    {
        public static int UserID = 0;
        public static string MatKhauMaHoa = "";

        //Workflow
        public static int workflow_id = 0;

        public static int user_create_id = 0;
        public static int user_recipent_id = 0;
        public static int category_workflow_id = 0;

        //end
        //todolist
        public static int todolist_id = 0;

        //end
        //tondong
        public static int tondong_id = 0;

        //end
        public static string RolesAdmin = "Quản trị viên";

        public static string RolesUser = "Thành viên";
        public static string RolesUserKSNB = "Thành viên KSNB";
        public static string RolesUserQA = "Thành viên QA";
        public static string RolesUserCU = "Thành viên Cung Ứng";
        public static string RolesUserDD = "Thành viên Điều Dưỡng";
        public static string ShowSuccess = "Thành công!";
        public static string ShowError = "Xảy ra lỗi!";
        public static string ShowEmpty = "Thiếu thông tin!";
        public static string ShowRegex = "Nhập sai!";
        public static string ShowExist = "Dữ liệu đã có!";
        public static string ShowEmailExist = "Email đã có!";
        public static string ShowConfirm = "Xác nhận?";
        public static string ShowAlert = "Thông báo";
        public static string ShowChatEmpty = "Chọn liên hệ!";
        public static string ShowDeleteBeforeInsert = "Xóa thông tin đã có trước khi cập nhật?";

        //Tao bien cho huong dan
        public static string huongdan_huongdan = "Hướng dẫn";

        public static string huongdan_thamkhao = "Tham khảo";
        public static string huongdan_quydinh = "Quy định";
        public static string huongdan_baocaoNXT = "Báo cáo NXT";
        public static string huongdan_bcsl = "Báo cáo sai lệch";
        public static string huongdan_baocaohuy = "Báo cáo hủy";
        public static string huongdan_baocaoSAT = "Báo cáo SAT";
        public static string huongdan_baocaohethan = "Báo cáo hết hạn dùng";

        //Ket thuc
        //Tao bien cho phu trach
        public static string phutrach_khong = "Không phụ trách";

        public static string phutrach_baocaohuy = "Phụ trách hồ sơ hủy";
        public static string phutrach_baocaosailech = "Phụ trách báo cáo sai lệch";
        public static string phutrach_tatca = "Phụ trách tất cả";
        //Ket thuc

        //Bien them thông tin
        public static string ThemThongTin = "";

        //Ket thuc

        //GridControl kiem tra moi ngay
        public static DevExpress.XtraGrid.GridControl gc_NV_DangThucHien;

        public static DevExpress.XtraGrid.Views.Grid.GridView gv_NV_DangThucHien;
        public static DevExpress.XtraGrid.GridControl gc_GV_DangThucHien;
        public static DevExpress.XtraGrid.Views.Grid.GridView gv_GV_DangThucHien;
        public static DevExpress.XtraGrid.GridControl gc_NV_DaThucHien;
        public static DevExpress.XtraGrid.Views.Grid.GridView gv_NV_DaThucHien;
        public static DevExpress.XtraGrid.GridControl gc_GV_DaThucHien;
        public static DevExpress.XtraGrid.Views.Grid.GridView gv_GV_DaThucHien;
        public static DevExpress.XtraGrid.GridControl gc_TonDong;
        public static DevExpress.XtraGrid.Views.Grid.GridView gv_TonDong;
        public static DevExpress.XtraGrid.GridControl gc_CongViecDaNhan;
        public static DevExpress.XtraGrid.Views.Grid.GridView gv_CongViecDaNhan;
        public static DevExpress.XtraGrid.GridControl gc_CongViecDaGui;
        public static DevExpress.XtraGrid.Views.Grid.GridView gv_CongViecDaGui;

        public bool CheckEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void SaveLookAndFeelSettings()
        {
            LookAndFeelSettings.Save("LookAndFeelSettings.dat");
        }

        public static void LoadLookAndFeelSettings()
        {
            LookAndFeelSettings.Load("LookAndFeelSettings.dat");
        }
        public static DataTable ExcelToDataTableByDevExpress(string fullFilePath)
        {
            Workbook workbook = new Workbook();
            workbook.LoadDocument(fullFilePath);
            Worksheet workSheet = workbook.Worksheets[0];
            
            DataTable dataTable = workSheet.CreateDataTable(workSheet.GetUsedRange().CurrentRegion, true, true);
            for (int i = 1; i <= workSheet.GetUsedRange().RowCount - 1; i++)
            {
                DataRow newRow = dataTable.NewRow();
                for (int j = 0; j <= workSheet.GetUsedRange().CurrentRegion.ColumnCount - 1; j++)
                {
                    newRow[j] = workSheet.Cells[i, j].DisplayText;
                }
                dataTable.Rows.Add(newRow);
            }
            return dataTable;
        }
    }
}