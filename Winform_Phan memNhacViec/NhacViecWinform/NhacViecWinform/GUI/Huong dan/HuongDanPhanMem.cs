using System.IO;
using System.Net;

namespace NhacViecWinform.GUI.Huong_dan
{
    public partial class HuongDanPhanMem : DevExpress.XtraEditors.XtraForm
    {
        public HuongDanPhanMem()
        {
            InitializeComponent();
            string pdfURL = @"https://achoobucket.s3-ap-southeast-1.amazonaws.com/HuongDanSuDungPhanMem.pdf";
            MemoryStream ms;
            using (WebClient client = new WebClient())
            {
                byte[] fileBytes = client.DownloadData(pdfURL);
                ms = new MemoryStream(fileBytes);
                pdfHuongDanPhanMem.LoadDocument(ms);
            }
            //string executableLocation = Path.GetDirectoryName(
            //Assembly.GetExecutingAssembly().Location);
            //string pdfFile = Path.Combine(executableLocation, "HuongDanPhanMem.pdf");
            //pdfHuongDanPhanMem.LoadDocument(pdfFile);
        }
    }
}