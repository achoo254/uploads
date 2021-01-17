using Ookii.Dialogs.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace PhanMemChuyenDoiBaoCao
{
    public partial class Form1 : Form
    {
        XmlDocument docConfig = null;
        XmlNode nodeProfile = null;
        XmlNode nodeConfigFolder = null;
        XmlNode nodeConfigTruongCoDinh = null;
        XmlNode nodeConfigTruongThamSo = null;
        XmlNode nodeConfigTruongNhom = null;
        XmlNode nodeConfigTruongLienKet = null;
        XmlNode nodeConfigThemTheData = null;
        XmlNode nodeConfigSuaWatermark = null;
        XmlNode nodeConfigSuaDatasource = null;
        XmlNode nodeConfigChuyenThamSo = null;
        XmlNode nodeConfigThemTienTo = null;
        XmlNode nodeConfigFile = null;
        DataGridViewRow row = null;

        string logThem = "Thêm";
        string logXoa = "Xóa";
        string logSua = "Sửa";
        string bienTruongStt = "Stt,System.String";
        string bienTruongStt0 = "Stt0,System.String";
        string bienTruongId = "Id,System.String";
        string bienTruongParentId = "ParentId,System.String";
        string theNewPageBeforeTrongPageHeader = "NewPageBefore";
        string thePrintOnAllPagesTrongHeader = "PrintOnAllPages";
        string thePrintAtBottomTrongFooter = "PrintAtBottom";
        string thePrintOnTrongFooter = "PrintOn";
        bool giatriNewPageBeforeTrongPageHeader = true;
        bool giatrithePrintOnAllPagesTrongHeader = true;
        bool giatrithePrintAtBottomTrongFooter = true;
        string kieuHeaderCu = "HeaderBand";
        string kieuPageHeaderCu = "PageHeaderBand";
        string kieuSummaryCu = "ReportSummaryBand";
        string kieuFooterCu = "FooterBand";
        string kieuPageFooterCu = "PageFooterBand";
        string kieuHeaderMoi = "GroupHeaderBand";
        string kieuFooterMoi = "GroupFooterBand";
        string kieuDataBand = "DataBand";
        string msgThongBao = "Thông báo";
        string msgThamSoGocTrong = "Tham số gốc đang trống";
        string msgFolderTrong = "Thư mục đang trống";
        string msgTenProfileDaTonTai = "Tên cấu hình đã tồn tại, hãy đặt tên khác";
        string msgCauHinhTrong = "Không có cấu hình nào được lưu";
        string msgTenCauHinhTrong = "Tên cấu hình đang trống";
        string msgComboboxTenCauHinhTrong = "Chưa chọn cấu hình";
        string msgLuuCauHinhThanhCong = "Lưu cấu hình thành công";
        string msgSuaCauHinhThanhCong = "Sửa cấu hình thành công";
        string pathConfig = "config.xml";
        string econfig = "config";
        string eprofile = "profile";
        string efolderpath = "folderpath";
        string elist_checked_truongcodinh = "list_checked_truongcodinh";
        string elist_checked_thamso = "list_checked_thamso";
        string elist_checked_nhom = "list_checked_nhom";
        string elist_checked_lienket = "list_checked_lienket";
        string elist_checked_themthedata = "list_checked_themthedata";
        string elist_checked_suawatermark = "list_checked_suawatermark";
        string elist_checked_suadatasource = "list_checked_suadatasource";
        string elist_checked_chuyenthamsothanhtruongdulieu = "list_checked_chuyenthamsothanhtruongdulieu";
        string elist_checked_themtiento = "list_checked_themtiento";
        string efilepath = "filepath";
        string edatagridview = "datagridview";
        string etenthe = "tenthe";
        string egiatricu = "giatricu";
        string egiatrimoi = "giatrimoi";
        string findDemoString = "DEMOString";
        string findNumToWordVN = "NumToWordsVN";
        string findNumToWordEN = "NumToWordsEN";
        string findSubCompanyAddress = "SubCompanyAddress";
        string findStt = "SubCompanyAddress";
        string findComputerInformation = "ComputerInformation";
        string findCounter = "counter";
        string findPrintDiscountChecked0 = "Print_Discount_Checked0";
        string findPrintDiscountChecked1 = "Print_Discount_Checked1";
        string findPrintDiscountChecked2 = "Print_Discount_Checked2";
        VistaFolderBrowserDialog vistaFolderBrowserDialog;
        VistaOpenFileDialog vistaOpenFileDialog;

        public Form1()
        {
            InitializeComponent();
            //Load profile cấu hình vào combobox
            if (File.Exists(pathConfig))
            {
                docConfig = new XmlDocument();
                docConfig.Load(pathConfig);
                XmlNodeList nodelistProfile = docConfig.SelectNodes("//profile");
                foreach (XmlNode data in nodelistProfile)
                {
                    cbbDocCauHinh.Items.Add(data.Attributes["name"].Value);
                }
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            //Nếu đường dẫn đến thư mục không trống thì tiếp tục
            if (txtDuongDan_Folder.Text != "")
            {
                //Khai báo biến max min để load
                pbLoading.Visible = true;
                lvNhieuPage.Clear();
                lvNhieuDatasource.Clear();


                int loadMax = System.IO.Directory.GetFiles(txtDuongDan_Folder.Text).Length;
                int loadMin = 1;
                pbLoading.Minimum = loadMin;
                pbLoading.Maximum = loadMax;
                //Xóa toàn bộ tiến trình xử lý đang có
                dgvLogXuLy.Rows.Clear();
                //Khai báo list để chứa tham số
                List<string> listThamSoGoc = new List<string>();
                List<string> listThamSoFileCanThem = new List<string>();
                List<string> listKhongTrung = new List<string>();
                //Nếu đường dẫn đến file chứa tham số không trống thì tiếp tục
                if (txtDuongDan_File.Text != "")
                {
                    XmlDocument docFile = new XmlDocument();
                    docFile.Load(txtDuongDan_File.Text);

                    //Lấy giá trị node gốc
                    XmlNode rootFile = docFile.SelectSingleNode("/StiSerializer");
                    XmlNodeList nodelistValueFile = rootFile.SelectNodes("//Variables/value");
                    foreach (XmlNode nodevalue in nodelistValueFile)
                    {
                        listThamSoGoc.Add(nodevalue.InnerText);
                    }
                }
                //Duyệt từng file
                foreach (var file in System.IO.Directory.GetFiles(txtDuongDan_Folder.Text))
                {
                    
                    //Bắt đầu thực hiện các chức năng trong đây.....
                    XmlDocument docFolder = new XmlDocument();
                    docFolder.Load(file);
                    //Lấy giá trị node gốc
                    XmlNode rootFolder = docFolder.SelectSingleNode("/StiSerializer");
                    //Lấy giá trị node Dictionary
                    XmlNode nodeDictionary = rootFolder.SelectSingleNode("Dictionary");
                    //Lấy giá trị node datasource
                    XmlNode nodeDatabase = rootFolder.SelectSingleNode("Dictionary/Databases");
                    //Lấy giá trị node datasource
                    XmlNode nodeDataSource = rootFolder.SelectSingleNode("Dictionary/DataSources");
                    int demDataSource = int.Parse(nodeDataSource.Attributes["count"].Value);
                    //Lấy giá trị list Variables
                    XmlNodeList listVariables = rootFolder.SelectNodes("//Variables/*");
                    //Lấy giá trị node Variable
                    XmlNode nodeVariable = rootFolder.SelectSingleNode("//Variables");
                    //Lấy giá trị node Pages
                    XmlNode nodePages = docFolder.SelectSingleNode("/StiSerializer/Pages");
                    //XmlNode nodechildPage = nodePages.FirstChild;
                    XmlNodeList nodechildPages = nodePages.SelectNodes("//Pages/*");
                    //Đổi tên trường cố định
                    if (clCapNhatGiaTriThe.GetItemChecked(0))
                    {
                        XmlNodeList nodelistColumns = null;
                        //Nếu datasource chỉ có 1 và tên thẻ con đầu tiên và cuối cùng bằng nhau thì:
                        if (demDataSource == 1 && nodeDataSource.FirstChild.Name == nodeDataSource.LastChild.Name)
                        {
                            //Truy cập vào thẻ columns để lấy giá trị trong value
                            nodelistColumns = nodeDataSource.SelectNodes("//Columns/value");
                            foreach (XmlNode nodeValue in nodelistColumns)
                            {
                                //Tìm giá trị có chứa trường Stt đổi thành Id
                                if (nodeValue.InnerText.Equals(bienTruongStt))
                                {
                                    nodeValue.InnerText = bienTruongId;
                                    //Ghi tiến trình xử lý
                                    GhiLogFileXuLy(file, nodeValue.Name, bienTruongStt, bienTruongId);
                                    //Kết thúc ghi tiến trình xử lý
                                    break;
                                }
                            }
                        }
                        //Ngược lại nếu lớn hơn 1 thì:
                        else
                        {
                            //Nếu không có trường Stt thì thêm mới trong Datasource thứ 2 trở đi
                            foreach (XmlNode nodeDatasource in nodeDataSource.ChildNodes)
                            {
                                //Truy cập vào thẻ value của columns
                                nodelistColumns = nodeDatasource.SelectNodes("Columns/value");
                                //Loại trừ datasource đầu tiên không thêm trường ParentId
                                if (nodeDatasource.Name != nodeDataSource.FirstChild.Name)
                                {
                                    bool check = false;
                                    foreach (XmlNode nodeValue in nodelistColumns)
                                    {
                                        //Nếu trường Stt0 đang có thì đổi thành Id
                                        if (nodeValue.InnerText.Equals(bienTruongStt0))
                                        {
                                            nodeValue.InnerText = bienTruongId;
                                            //Ghi tiến trình xử lý
                                            GhiLogFileXuLy(file, nodeValue.Name, bienTruongStt0, bienTruongId);
                                            //Kết thúc ghi tiến trình xử lý
                                        }
                                        //Nếu trường Stt đang có thì đổi thành ParentId
                                        if (nodeValue.InnerText.Equals(bienTruongStt))
                                        {
                                            nodeValue.InnerText = bienTruongParentId;
                                            //Ghi tiến trình xử lý
                                            GhiLogFileXuLy(file, nodeValue.Name, bienTruongStt, bienTruongParentId);
                                            //Kết thúc ghi tiến trình xử lý
                                        }
                                        //Nếu trường ParentId đang có thì đánh dấu đã tồn tại
                                        if (nodeValue.InnerText.Equals(bienTruongParentId))
                                        {
                                            check = true;
                                        }
                                    }
                                    //Nếu trường ParentId chưa tồn tại thì thêm mới
                                    if (check == false)
                                    {
                                        XmlElement xmlElement = docFolder.CreateElement("value");
                                        xmlElement.InnerText = bienTruongParentId;
                                        XmlNode nodeColumns = nodeDatasource.SelectSingleNode("Columns");
                                        nodeColumns.AppendChild(xmlElement);
                                        //Ghi tiến trình xử lý
                                        GhiLogFileXuLy(file, xmlElement.Name, bienTruongParentId, logThem);
                                        //Kết thúc ghi tiến trình xử lý
                                    }
                                }
                                //Nếu tên datasource bằng tên thẻ datasource đầu tiên thì:
                                else
                                {
                                    //Duyệt từng thẻ value trong columns
                                    foreach (XmlNode nodeValue in nodelistColumns)
                                    {
                                        //Tìm giá trị có chứa trường Stt đổi thành Id
                                        if (nodeValue.InnerText.Equals(bienTruongStt))
                                        {
                                            nodeValue.InnerText = bienTruongId;
                                            //Ghi tiến trình xử lý
                                            GhiLogFileXuLy(file, nodeValue.Name, bienTruongStt, bienTruongId);
                                            //Kết thúc ghi tiến trình xử lý
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    //Cập nhật thêm tham số mẫu
                    if (clCapNhatGiaTriThe.GetItemChecked(1))
                    {
                        if (listThamSoGoc != null)
                        {
                            //Xóa tham số trong list tham số cần thêm
                            listThamSoFileCanThem.Clear();
                            listKhongTrung.Clear();
                            //Truy cập vào thẻ value trong file muốn thêm tham số
                            XmlNodeList nodelistValue = rootFolder.SelectNodes("//Variables/value");
                            //Thêm tham số vào list của file muốn thêm tham số
                            foreach (XmlNode nodeValue in nodelistValue)
                            {
                                listThamSoFileCanThem.Add(nodeValue.InnerText);
                                listKhongTrung.Add(nodeValue.InnerText);
                            }
                            //Lấy tên tham số để kiểm tra trùng dữ liệu hay không
                            foreach (var itemGoc in listThamSoGoc)
                            {
                                int indexGoc = itemGoc.IndexOf(',');
                                string strGoc = itemGoc.Substring(indexGoc + 1, itemGoc.IndexOf(',', indexGoc + 1) - indexGoc - 1);

                                foreach (var itemTrongFile in listThamSoFileCanThem)
                                {
                                    int index = itemTrongFile.IndexOf(',');
                                    string strItem = itemTrongFile.Substring(index + 1, itemTrongFile.IndexOf(',', index + 1) - index - 1);

                                    if (strGoc == strItem)
                                    {
                                        listKhongTrung.Remove(itemTrongFile);
                                    }
                                }
                            }

                            //Thêm tham số gốc vào list của file muốn thêm tham số
                            listKhongTrung.AddRange(listThamSoGoc);
                            //Truy cập vào thẻ variable trong file muốn thêm tham số
                            XmlNode nodeVariables = rootFolder.SelectSingleNode("//Variables");
                            //Ghi tiến trình xử lý
                            GhiLogFileXuLy(file, nodeVariables.Name, nodeVariables.InnerXml, logXoa);
                            //Kết thúc ghi tiến trình xử lý
                            //Xóa tham số đang có trong file
                            nodeVariables.InnerXml = "";
                            //Duyệt từng tham số trong list để thêm vào file muốn thêm tham số
                            foreach (var items in listKhongTrung)
                            {
                                XmlElement xmlElement = docFolder.CreateElement("value");
                                xmlElement.InnerText = items.ToString();
                                nodeVariables.AppendChild(xmlElement);
                                //Ghi tiến trình xử lý
                                GhiLogFileXuLy(file, xmlElement.Name, xmlElement.InnerText, logThem);
                                //Kết thúc ghi tiến trình xử lý
                            }
                        }
                        else
                        {
                            MessageBox.Show(msgThamSoGocTrong,msgThongBao);
                        }
                    }
                    //Đổi nhóm
                    if (clCapNhatGiaTriThe.GetItemChecked(2))
                    {
                        //Duyệt từng page
                        foreach(XmlNode nodechildPage in nodechildPages)
                        {
                            //Khai báo biến cho chức năng Đổi nhóm
                            bool timTheComponent = false;
                            bool timThePageFooter = false;
                            XmlNode nodeComponent = null;
                            XmlNode nodeClonePageFooter = null;

                            //Truy cập vào thẻ con của Pages
                            foreach (XmlNode nodelistComponent in nodechildPage.ChildNodes)
                            {
                                if (timTheComponent == false && nodelistComponent.Name == "Components")
                                {
                                    nodeComponent = nodelistComponent;
                                    timTheComponent = true;
                                }
                                //Truy cập vào các thẻ component
                                foreach (XmlNode component in nodelistComponent.ChildNodes)
                                {
                                    if (component.Attributes != null && component.Attributes.Count > 0)
                                    {
                                        //Đổi kiểu dữ liệu thẻ cũ sang kiểu dữ liệu mới
                                        if (component.Attributes["type"].Value == kieuPageHeaderCu)
                                        {
                                            component.Attributes["type"].Value = kieuHeaderMoi;
                                            //Ghi tiến trình xử lý
                                            GhiLogFileXuLy(file, component.Name, kieuPageHeaderCu, kieuHeaderMoi);
                                            //Kết thúc ghi tiến trình xử lý
                                            //Thêm thẻ mới
                                            XmlElement xmlElement = docFolder.CreateElement(theNewPageBeforeTrongPageHeader);
                                            xmlElement.InnerText = giatriNewPageBeforeTrongPageHeader.ToString();
                                            component.AppendChild(xmlElement);
                                            //Ghi tiến trình xử lý
                                            GhiLogFileXuLy(file, xmlElement.Name, xmlElement.InnerText, logThem);
                                            //Kết thúc ghi tiến trình xử lý
                                        }
                                        if (component.Attributes["type"].Value == kieuHeaderCu)
                                        {
                                            component.Attributes["type"].Value = kieuHeaderMoi;
                                            //Ghi tiến trình xử lý
                                            GhiLogFileXuLy(file, component.Name, kieuHeaderCu, kieuHeaderMoi);
                                            //Kết thúc ghi tiến trình xử lý
                                            //Thêm thẻ mới
                                            XmlElement xmlElement = docFolder.CreateElement(thePrintOnAllPagesTrongHeader);
                                            xmlElement.InnerText = giatrithePrintOnAllPagesTrongHeader.ToString();
                                            component.AppendChild(xmlElement);
                                            //Ghi tiến trình xử lý
                                            GhiLogFileXuLy(file, xmlElement.Name, xmlElement.InnerText, logThem);
                                            //Kết thúc ghi tiến trình xử lý
                                        }
                                        if (component.Attributes["type"].Value == kieuFooterCu)
                                        {
                                            component.Attributes["type"].Value = kieuFooterMoi;
                                            //Ghi tiến trình xử lý
                                            GhiLogFileXuLy(file, component.Name, kieuFooterCu, kieuFooterMoi);
                                            //Kết thúc ghi tiến trình xử lý

                                            //Tìm thẻ PrintOn để xóa
                                            XmlNode nodePrintOn = component.SelectSingleNode(thePrintOnTrongFooter);
                                            if (nodePrintOn != null)
                                            {
                                                component.RemoveChild(nodePrintOn);
                                                //Ghi tiến trình xử lý
                                                GhiLogFileXuLy(file, component.Name, nodePrintOn.Name, logXoa);
                                                //Kết thúc ghi tiến trình xử lý
                                            }

                                            //Tìm thẻ PrintAtBottom để đổi giá trị từ false -> true
                                            XmlNode nodePrintAtBottom = component.SelectSingleNode(thePrintAtBottomTrongFooter);
                                            if (nodePrintAtBottom != null)
                                            {
                                                //Ghi tiến trình xử lý
                                                GhiLogFileXuLy(file, nodePrintAtBottom.Name, nodePrintAtBottom.InnerText, logSua);
                                                //Kết thúc ghi tiến trình xử lý
                                                nodePrintAtBottom.InnerText = giatrithePrintAtBottomTrongFooter.ToString();
                                            }
                                            else
                                            {
                                                //Thêm thẻ mới
                                                XmlElement xmlElement = docFolder.CreateElement(thePrintAtBottomTrongFooter);
                                                xmlElement.InnerText = giatrithePrintAtBottomTrongFooter.ToString();
                                                component.AppendChild(xmlElement);
                                                //Ghi tiến trình xử lý
                                                GhiLogFileXuLy(file, xmlElement.Name, xmlElement.InnerText, logThem);
                                                //Kết thúc ghi tiến trình xử lý
                                            }
                                        }
                                        if (component.Attributes["type"].Value == kieuSummaryCu)
                                        {
                                            component.Attributes["type"].Value = kieuFooterMoi;
                                            //Ghi tiến trình xử lý
                                            GhiLogFileXuLy(file, component.Name, kieuSummaryCu, kieuFooterMoi);
                                            //Kết thúc ghi tiến trình xử lý

                                            //Tìm thẻ PrintOn để xóa
                                            XmlNode nodePrintOn = component.SelectSingleNode(thePrintOnTrongFooter);
                                            if (nodePrintOn != null)
                                            {
                                                component.RemoveChild(nodePrintOn);
                                                //Ghi tiến trình xử lý
                                                GhiLogFileXuLy(file, nodePrintOn.Name, nodePrintOn.InnerText, logXoa);
                                                //Kết thúc ghi tiến trình xử lý
                                            }

                                            //Tìm thẻ PrintAtBottom để đổi giá trị từ false -> true
                                            XmlNode nodePrintAtBottom = component.SelectSingleNode(thePrintAtBottomTrongFooter);
                                            if (nodePrintAtBottom != null)
                                            {
                                                nodePrintAtBottom.InnerText = giatrithePrintAtBottomTrongFooter.ToString();
                                                //Ghi tiến trình xử lý
                                                GhiLogFileXuLy(file, nodePrintAtBottom.Name, nodePrintAtBottom.InnerText, logSua);
                                                //Kết thúc ghi tiến trình xử lý
                                            }
                                            else
                                            {
                                                //Thêm thẻ mới
                                                XmlElement xmlElement = docFolder.CreateElement(thePrintAtBottomTrongFooter);
                                                xmlElement.InnerText = giatrithePrintAtBottomTrongFooter.ToString();
                                                component.AppendChild(xmlElement);
                                                //Ghi tiến trình xử lý
                                                GhiLogFileXuLy(file, xmlElement.Name, xmlElement.InnerText, logThem);
                                                //Kết thúc ghi tiến trình xử lý
                                            }
                                        }
                                        //Gán thẻ ảo cho PageFooter
                                        if (component.Attributes["type"].Value == kieuPageFooterCu && timThePageFooter == false)
                                        {
                                            nodeClonePageFooter = component;
                                            timThePageFooter = true;
                                        }
                                    }
                                }
                            }
                            //Nếu trong file có thẻ PageFooter thì chuyển xuống dưới cùng để không bị lỗi hiển thị kiểu group header
                            if (nodeClonePageFooter != null && nodeComponent != null)
                            {
                                nodeComponent.AppendChild(nodeClonePageFooter);
                                //Ghi tiến trình xử lý
                                GhiLogFileXuLy(file, nodeClonePageFooter.Name, nodeClonePageFooter.InnerText, logThem);
                                //Kết thúc ghi tiến trình xử lý
                            }
                        }
                    }
                    //Đổi giá trị trong thẻ
                    if (dgvLuoiDoiGiaTri.Rows.Count > 0)
                    {
                        //Khai báo các biến
                        string tenThe = "";
                        string giatriCu = "";
                        string giatriMoi = "";

                        for (int i = 0; i < dgvLuoiDoiGiaTri.Rows.Count; i++)
                        {
                            if (dgvLuoiDoiGiaTri.Rows[i].Cells[0].Value != null)
                            {
                                tenThe = dgvLuoiDoiGiaTri.Rows[i].Cells[0].Value.ToString();
                            }
                            if (dgvLuoiDoiGiaTri.Rows[i].Cells[1].Value != null)
                            {
                                giatriCu = dgvLuoiDoiGiaTri.Rows[i].Cells[1].Value.ToString();
                            }
                            if (dgvLuoiDoiGiaTri.Rows[i].Cells[2].Value != null)
                            {
                                giatriMoi = dgvLuoiDoiGiaTri.Rows[i].Cells[2].Value.ToString();
                            }
                            if (tenThe != "" && giatriCu != "" && giatriMoi != "")
                            {
                                //Lấy tên thẻ cần thay đổi giá trị
                                XmlNodeList nodelistDoiGiaTri = rootFolder.SelectNodes(String.Format(".//{0}", tenThe));
                                foreach (XmlNode nodeDoiGiaTri in nodelistDoiGiaTri)
                                {
                                    if (nodeDoiGiaTri.InnerText == giatriCu)
                                    {
                                        nodeDoiGiaTri.InnerText = giatriMoi;
                                        //Ghi tiến trình xử lý
                                        GhiLogFileXuLy(file, nodeDoiGiaTri.Name, giatriCu, giatriMoi);
                                        //Kết thúc ghi tiến trình xử lý
                                    }
                                }
                            }
                        }
                    }
                    //Thêm liên kết bảng (Relations)
                    if (clCapNhatGiaTriThe.GetItemChecked(3))
                    {
                        if (demDataSource > 1 && nodeDataSource.FirstChild.Name != nodeDataSource.LastChild.Name)
                        {
                            string isRefDictionary = nodeDictionary.Attributes["Ref"].Value;
                            string isRefParentSource = nodeDataSource.FirstChild.Attributes["Ref"].Value;
                            string isRefChildSource = nodeDataSource.LastChild.Attributes["Ref"].Value;
                            string condition = "{" + nodeDataSource.LastChild.Name + ".Relation.Id}";
                            //Khai báo biến dành cho thêm liên kết bảng
                            //Truy cập vào thẻ Relations và kích hoạt sử dụng nếu chưa tồn tại
                            XmlNode nodeRelations = docFolder.SelectSingleNode("//Relations");
                            nodeRelations.Attributes["count"].Value = "1";
                            if (!nodeRelations.HasChildNodes)
                            {
                                /* Khai báo các thẻ con của Relations */
                                XmlElement eRelation = docFolder.CreateElement("Relation");
                                eRelation.SetAttribute("Ref", "9999");
                                eRelation.SetAttribute("type", "DataRelation");
                                eRelation.SetAttribute("isKey", "true");
                                nodeRelations.AppendChild(eRelation);
                                //Ghi tiến trình xử lý
                                GhiLogFileXuLy(file, eRelation.Name, eRelation.InnerText, logThem);
                                //Kết thúc ghi tiến trình xử lý

                                //Truy cập vào thẻ Relation
                                XmlNode nodeRelation = docFolder.SelectSingleNode("//Relations/Relation");
                                XmlElement eAlias = docFolder.CreateElement("Alias");
                                eAlias.InnerText = "Relation";
                                nodeRelation.AppendChild(eAlias);
                                //Ghi tiến trình xử lý
                                GhiLogFileXuLy(file, eAlias.Name, eAlias.InnerText, logThem);
                                //Kết thúc ghi tiến trình xử lý

                                XmlElement eChildColumns = docFolder.CreateElement("ChildColumns");
                                eChildColumns.SetAttribute("isList", "true");
                                eChildColumns.SetAttribute("count", "1");
                                nodeRelation.AppendChild(eChildColumns);
                                //Ghi tiến trình xử lý
                                GhiLogFileXuLy(file, eChildColumns.Name, eChildColumns.InnerText, logThem);
                                //Kết thúc ghi tiến trình xử lý

                                //Truy cập vào thẻ ChildColumns
                                XmlNode nodeChildColumns = nodeRelation.SelectSingleNode("//ChildColumns");
                                XmlElement evalueChild = docFolder.CreateElement("value");
                                evalueChild.InnerText = "ParentId";
                                nodeChildColumns.AppendChild(evalueChild);
                                //Ghi tiến trình xử lý
                                GhiLogFileXuLy(file, evalueChild.Name, evalueChild.InnerText, logThem);
                                //Kết thúc ghi tiến trình xử lý

                                XmlElement eChildSource = docFolder.CreateElement("ChildSource");
                                eChildSource.SetAttribute("isRef", isRefChildSource);
                                nodeRelation.AppendChild(eChildSource);
                                //Ghi tiến trình xử lý
                                GhiLogFileXuLy(file, eChildSource.Name, eChildSource.InnerText, logThem);
                                //Kết thúc ghi tiến trình xử lý

                                XmlElement eDictionary = docFolder.CreateElement("Dictionary");
                                eDictionary.SetAttribute("isRef", isRefDictionary);
                                nodeRelation.AppendChild(eDictionary);
                                //Ghi tiến trình xử lý
                                GhiLogFileXuLy(file, eDictionary.Name, eDictionary.InnerText, logThem);
                                //Kết thúc ghi tiến trình xử lý

                                XmlElement eName = docFolder.CreateElement("Name");
                                eName.InnerText = "Relation";
                                nodeRelation.AppendChild(eName);
                                //Ghi tiến trình xử lý
                                GhiLogFileXuLy(file, eName.Name, eName.InnerText, logThem);
                                //Kết thúc ghi tiến trình xử lý

                                XmlElement eNameInSource = docFolder.CreateElement("NameInSource");
                                eNameInSource.InnerText = "Relation";
                                nodeRelation.AppendChild(eNameInSource);
                                //Ghi tiến trình xử lý
                                GhiLogFileXuLy(file, eNameInSource.Name, eNameInSource.InnerText, logThem);
                                //Kết thúc ghi tiến trình xử lý

                                XmlElement eParentColumns = docFolder.CreateElement("ParentColumns");
                                eParentColumns.SetAttribute("isList", "true");
                                eParentColumns.SetAttribute("count", "1");
                                nodeRelation.AppendChild(eParentColumns);
                                //Ghi tiến trình xử lý
                                GhiLogFileXuLy(file, eParentColumns.Name, eParentColumns.InnerText, logThem);
                                //Kết thúc ghi tiến trình xử lý

                                //Truy cập vào thẻ ParentColumns
                                nodeChildColumns = nodeRelation.SelectSingleNode("//ParentColumns");
                                XmlElement evalueParent = docFolder.CreateElement("value");
                                evalueParent.InnerText = "Id";
                                nodeChildColumns.AppendChild(evalueParent);
                                //Ghi tiến trình xử lý
                                GhiLogFileXuLy(file, evalueParent.Name, evalueParent.InnerText, logThem);
                                //Kết thúc ghi tiến trình xử lý

                                XmlElement eParentSource = docFolder.CreateElement("ParentSource");
                                eParentSource.SetAttribute("isRef", isRefParentSource);
                                nodeRelation.AppendChild(eParentSource);
                                //Ghi tiến trình xử lý
                                GhiLogFileXuLy(file, eParentSource.Name, eParentSource.InnerText, logThem);
                                //Kết thúc ghi tiến trình xử lý
                                /* Kết thúc khai báo các thẻ con của Relations */

                                //Duyệt từng page
                                foreach(XmlNode nodechildPage in nodechildPages)
                                {
                                    //Truy cập vào GroupHeader để thêm điều kiện đã liên kết
                                    bool kiemtraTonTaiCondition = false;
                                    bool kiemtraTonTaiNewPageBefore = false;
                                    foreach (XmlNode nodelistComponent in nodechildPage.ChildNodes)
                                    {
                                        //Truy cập vào các thẻ component
                                        foreach (XmlNode component in nodelistComponent.ChildNodes)
                                        {
                                            if (component.Attributes != null && component.Attributes.Count > 0)
                                            {
                                                if (component.Attributes["type"].Value == kieuHeaderMoi)
                                                {
                                                    foreach (XmlNode childnode in component.ChildNodes)
                                                    {
                                                        if (childnode.Name == "Condition")
                                                        {
                                                            kiemtraTonTaiCondition = true;
                                                        }
                                                        if (childnode.Name == theNewPageBeforeTrongPageHeader && childnode.InnerText == String.Format(giatriNewPageBeforeTrongPageHeader.ToString()))
                                                        {
                                                            kiemtraTonTaiNewPageBefore = true;
                                                        }                                                     
                                                    }
                                                    if (kiemtraTonTaiCondition == false && kiemtraTonTaiNewPageBefore == true)
                                                    {
                                                        XmlElement eCondition = docFolder.CreateElement("Condition");
                                                        eCondition.InnerText = condition;
                                                        component.AppendChild(eCondition);
                                                        //Ghi tiến trình xử lý
                                                        GhiLogFileXuLy(file, eCondition.Name, eCondition.InnerText, logThem);
                                                        //Kết thúc ghi tiến trình xử lý
                                       
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    //Thêm thẻ dữ liệu DataBand nếu trong file không có Band bất kỳ nào
                    if (clCapNhatGiaTriThe.GetItemChecked(4))
                    {
                        //Khai báo biến cho thêm thẻ dữ liệu
                        string tentheComponentChinh = "Components";
                        string tentheDataBand = "DataBand1";
                        string tentheBorderDataBand = "Border";
                        string tentheBrushDataBand = "Brush";
                        string tentheClientRectangleDataBand = "ClientRectangle";
                        string tentheDataSourceNameDataBand = "DataSourceName";
                        string tentheLockedDataBand = "Locked";
                        string tentheNameDataBand = "Name";
                        string tenthePageDataBand = "Page";
                        string tentheParentDataBand = "Parent";
                        string tentheSortParentDataBand = "Sort";
                        int dem = 1;

                        //Duyệt từng Page
                        foreach(XmlNode nodechildPage in nodechildPages)
                        {
                            bool kiemtraTonTaiTheBand = false;
                            XmlNode cloneTheComponent = null;
                            dem++;

                            foreach (XmlNode nodelistcomponent in nodechildPage.ChildNodes)
                            {
                                if (nodelistcomponent.Name == "Components")
                                {
                                    cloneTheComponent = nodelistcomponent;
                                }
                                foreach (XmlNode component in nodelistcomponent.ChildNodes)
                                {
                                    if (component.Attributes != null && component.Attributes.Count > 0)
                                    {
                                        if (kiemtraTonTaiTheBand == false && component.Attributes["type"].Value == kieuHeaderCu || component.Attributes["type"].Value == kieuHeaderMoi || component.Attributes["type"].Value == kieuFooterCu || component.Attributes["type"].Value == kieuFooterMoi || component.Attributes["type"].Value == kieuSummaryCu || component.Attributes["type"].Value == kieuPageFooterCu || component.Attributes["type"].Value == kieuPageHeaderCu || component.Attributes["type"].Value == kieuDataBand)
                                        {
                                            kiemtraTonTaiTheBand = true;
                                        }
                                    }
                                }
                            }
                            if (kiemtraTonTaiTheBand == false && cloneTheComponent != null)
                            {
                                //Xóa thẻ Components chính
                                nodechildPage.RemoveChild(cloneTheComponent);
                                //Tạo lại thẻ Component chính
                                XmlElement eComponentChinh = docFolder.CreateElement(tentheComponentChinh);
                                eComponentChinh.SetAttribute("isList", "true");
                                eComponentChinh.SetAttribute("count", "1");

                                //Thêm thẻ mới DataBand
                                XmlElement eDataBand = docFolder.CreateElement(tentheDataBand + dem);
                                eDataBand.SetAttribute("Ref", "123456" + dem);
                                eDataBand.SetAttribute("type", kieuDataBand);
                                eDataBand.SetAttribute("isKey", "true");

                                //Thêm thẻ Border trong DataBand
                                XmlElement eBorder = docFolder.CreateElement(tentheBorderDataBand);
                                eBorder.InnerText = "All;DarkGray;1;Solid;False;4;Black";
                                eDataBand.AppendChild(eBorder);

                                //Thêm thẻ Brush trong DataBand
                                XmlElement eBrush = docFolder.CreateElement(tentheBrushDataBand);
                                eBrush.InnerText = "Transparent";
                                eDataBand.AppendChild(eBrush);

                                //Thêm thẻ Brush trong DataBand
                                XmlElement eClientRectangle = docFolder.CreateElement(tentheClientRectangleDataBand);
                                eClientRectangle.InnerText = "0,0.4,19,28.2";
                                eDataBand.AppendChild(eClientRectangle);

                                //Thêm thẻ con component trong DataBand
                                XmlElement eComponentCuaDataBand = docFolder.CreateElement(tentheComponentChinh);
                                eComponentCuaDataBand.SetAttribute("isList", "true");
                                eComponentCuaDataBand.SetAttribute("count", cloneTheComponent.Attributes["count"].Value);

                                //Thêm nội dung của Component chính vào trong Component con
                                eComponentCuaDataBand.InnerXml = cloneTheComponent.InnerXml;
                                eDataBand.AppendChild(eComponentCuaDataBand);

                                //Thêm thẻ mới DataSourceName
                                if (nodeDataSource.FirstChild != null)
                                {
                                    XmlElement eDataSourceName = docFolder.CreateElement(tentheDataSourceNameDataBand);
                                    eDataSourceName.InnerText = nodeDataSource.FirstChild.Name;
                                    eDataBand.AppendChild(eDataSourceName);
                                }
                                //Thêm thẻ mới Locked
                                XmlElement eLocked = docFolder.CreateElement(tentheLockedDataBand);
                                eLocked.InnerText = "True";
                                eDataBand.AppendChild(eLocked);
                                //Thêm thẻ mới Name
                                XmlElement eName = docFolder.CreateElement(tentheNameDataBand);
                                eName.InnerText = tentheDataBand;
                                eDataBand.AppendChild(eName);
                                //Thêm thẻ mới Page
                                XmlElement ePage = docFolder.CreateElement(tenthePageDataBand);
                                ePage.SetAttribute("isRef", nodechildPage.Attributes["Ref"].Value);
                                eDataBand.AppendChild(ePage);
                                //Thêm thẻ mới Parent
                                XmlElement eParent = docFolder.CreateElement(tentheParentDataBand);
                                eParent.SetAttribute("isRef", nodechildPage.Attributes["Ref"].Value);
                                eDataBand.AppendChild(eParent);
                                //Thêm thẻ mới Sort
                                XmlElement eSort = docFolder.CreateElement(tentheSortParentDataBand);
                                eSort.SetAttribute("isList", "true");
                                eSort.SetAttribute("count", "0");
                                eDataBand.AppendChild(eSort);
                                //Đổ dữ liệu vào thẻ component chính
                                eComponentChinh.AppendChild(eDataBand);

                                nodechildPage.InsertAfter(eComponentChinh, nodechildPage.FirstChild);
                                //Ghi tiến trình xử lý
                                GhiLogFileXuLy(file, eDataBand.Name, eDataBand.Name, logThem);
                                //Kết thúc ghi tiến trình xử lý
                            }
                        }
                    }
                    //Sửa watermark
                    if (clCapNhatGiaTriThe.GetItemChecked(5))
                    {
                        //Truy cập vào thẻ con của page
                        foreach(XmlNode listPages in nodePages.ChildNodes)
                        {
                            //Khai báo biến cho chức năng
                            string noidungTrongThe = "";
                            string watermarkCu = "this." + listPages.Name + "_Watermark.Text = DEMOString;";
                            foreach (XmlNode item in listPages.ChildNodes)
                            {
                                string findDemoString = item.InnerText.Substring(0, item.InnerText.IndexOf(';') + 1);
                                if (findDemoString.Equals(watermarkCu))
                                {
                                    noidungTrongThe = item.InnerText;
                                    noidungTrongThe = noidungTrongThe.Replace(watermarkCu, "");
                                    //Ghi tiến trình xử lý
                                    GhiLogFileXuLy(file, item.Name, item.InnerText, noidungTrongThe);
                                    //Kết thúc ghi tiến trình xử lý
                                    item.InnerText = noidungTrongThe;
                                    break;
                                }
                            }
                        }
                    }
                    //Sửa Datasource
                    if (clCapNhatGiaTriThe.GetItemChecked(6))
                    {
                        //Khai báo biến
                        string nameDatasource = "";
                        //Kích hoạt database
                        if(nodeDatabase.Attributes["count"] != null)
                        {
                            nodeDatabase.Attributes["count"].Value = "1";

                            if (!nodeDatabase.HasChildNodes)
                            {
                                //Tạo mới thẻ JSON
                                XmlElement nodeJson = docFolder.CreateElement("JSON");
                                nodeJson.SetAttribute("Ref", "654321");
                                nodeJson.SetAttribute("type", "Stimulsoft.Report.Dictionary.StiJsonDatabase");
                                nodeJson.SetAttribute("isKey", "true");

                                //Tạo thẻ Alias con của JSON
                                XmlElement nodeJsonAlias = docFolder.CreateElement("Alias");
                                nodeJsonAlias.InnerText = "JSON";
                                nodeJson.AppendChild(nodeJsonAlias);

                                //Tạo thẻ Key con của JSON
                                XmlElement nodeJsonKey = docFolder.CreateElement("Key");
                                nodeJson.AppendChild(nodeJsonKey);

                                //Tạo thẻ Name con của JSON
                                XmlElement nodeJsonName = docFolder.CreateElement("Name");
                                nodeJsonName.InnerText = "JSON";
                                nodeJson.AppendChild(nodeJsonName);

                                //Tạo thẻ PathData con của JSON
                                XmlElement nodeJsonPathData = docFolder.CreateElement("PathData");
                                nodeJsonPathData.InnerText = "resource://Demo";
                                nodeJson.AppendChild(nodeJsonPathData);

                                nodeDatabase.AppendChild(nodeJson);

                                //Truy cập vào trong thẻ Datasource để sửa NameInSource
                                foreach (XmlNode childDatasource in nodeDataSource.ChildNodes)
                                {
                                    foreach(XmlNode valueDatasource in childDatasource.ChildNodes)
                                    {
                                        if(valueDatasource.Name == "Name")
                                        {
                                            nameDatasource = valueDatasource.InnerText;
                                        }
                                        if(valueDatasource.Name == "NameInSource")
                                        {
                                            valueDatasource.InnerText = "JSON." + nameDatasource;
                                        }
                                    }
                                }
                            }
                        }


                    }
                    //Chuyển tham số thành trường dữ liệu
                    if (clCapNhatGiaTriThe.GetItemChecked(7))
                    {
                        if(listThamSoGoc != null && demDataSource > 0)
                        {
                            //Khai báo thông tin
                            List<XmlNode> list = new List<XmlNode>();
                            Dictionary<string, string> keyValues = new Dictionary<string, string>();
                            //Gán giá trị mặc định cho Dictionary
                            keyValues.Add("AmountInWord", "System.String");
                            keyValues.Add("AmountInWord_E", "System.String");
                            keyValues.Add("CompanyBranchName", "System.String");
                            //Duyệt tới node column thứ 1
                            XmlNode columns = rootFolder.SelectSingleNode("//DataSources/" + nodeDataSource.FirstChild.Name + "/Columns");
                            //Duyệt từng tham số trong file
                            foreach (XmlNode value in listVariables)
                            {
                                int indexContent = value.InnerText.IndexOf(',');
                                string strContent = value.InnerText.Substring(indexContent + 1, value.InnerText.IndexOf(',', indexContent + 1) - indexContent - 1);

                                int indexType = value.InnerText.IndexOf("System.");
                                string strType = value.InnerText.Substring(indexType, value.InnerText.IndexOf(',', indexType + 1) - indexType);

                                //Đổ hết tham số vào list node để lát remove sau
                                list.Add(value);
                                //Loại bỏ những tham số không chuyển thành master
                                if (!strContent.Equals(findDemoString) && !strContent.Equals(findNumToWordEN) && !strContent.Equals(findNumToWordVN) && !strContent.Equals(findComputerInformation) && !strContent.Equals(findStt) && !strContent.Equals(findSubCompanyAddress) && !strContent.Equals(findCounter) && !strContent.Equals(findPrintDiscountChecked0) && !strContent.Equals(findPrintDiscountChecked1) && !strContent.Equals(findPrintDiscountChecked2))
                                {
                                    keyValues.Add(strContent, strType);
                                }
                            }
                            //Loại bỏ những tham số không còn sử dụng
                            if (list.Count > 0)
                            {
                                foreach (XmlNode value in list)
                                {
                                    int indexContent = value.InnerText.IndexOf(',');
                                    string strContent = value.InnerText.Substring(indexContent + 1, value.InnerText.IndexOf(',', indexContent + 1) - indexContent - 1);
                                    //Bỏ qua những biến không được remove
                                    if (!strContent.Equals(findCounter) && !strContent.Equals(findPrintDiscountChecked0) && !strContent.Equals(findPrintDiscountChecked1) && !strContent.Equals(findPrintDiscountChecked2))
                                    {
                                        nodeVariable.RemoveChild(value);
                                        //Ghi tiến trình xử lý
                                        GhiLogFileXuLy(file, value.Name, value.InnerText, logXoa);
                                        //Kết thúc ghi tiến trình xử lý
                                    }

                                }
                            }
                            //Chuyển tham số sang kiểu dữ liệu
                            if (keyValues.Count > 0)
                            {
                                foreach (var item in keyValues)
                                {
                                    bool check = false;
                                    XmlElement element = docFolder.CreateElement("value");
                                    element.InnerText = item.Key + "," + item.Value;

                                    foreach (XmlNode value in columns.ChildNodes)
                                    {
                                        if (value.InnerText.Equals(element.InnerText))
                                        {
                                            check = true;
                                            break;
                                        }
                                    }

                                    if (!check)
                                    {
                                        columns.AppendChild(element);
                                        //Ghi tiến trình xử lý
                                        GhiLogFileXuLy(file, element.Name, element.InnerText, logThem);
                                        //Kết thúc ghi tiến trình xử lý
                                    }

                                    //Xóa columns nếu có trong tham số mẫu
                                    foreach (var itemRemove in listThamSoGoc)
                                    {
                                        int indexContent = itemRemove.IndexOf(',');
                                        string strContent = itemRemove.Substring(indexContent + 1, itemRemove.IndexOf(',', indexContent + 1) - indexContent - 1);
                                        if (strContent.ToUpper().Equals(item.Key.ToUpper()))
                                        {
                                            columns.RemoveChild(element);
                                        }
                                    }
                                }
                            }

                            //Đưa tham số mẫu vào file cần xử lý
                            foreach (var item in listThamSoGoc)
                            {
                                bool check = false;
                                XmlElement element = docFolder.CreateElement("value");
                                element.InnerText = item;

                                foreach (XmlNode value in nodeVariable.ChildNodes)
                                {
                                    if (value.InnerText.Equals(element.InnerText))
                                    {
                                        check = true;
                                        break;
                                    }
                                }

                                if (!check)
                                {
                                    nodeVariable.AppendChild(element);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show(msgThamSoGocTrong, msgThongBao);
                        }
                    }
                    //Thêm tiền tố trường dữ liệu vào tham số cũ
                    if (clCapNhatGiaTriThe.GetItemChecked(8))
                    {
                        if(demDataSource > 0)
                        {
                            //Khai báo thông tin
                            string strReplace = "";
                            Dictionary<string, string> keyValues = new Dictionary<string, string>();
                            if (demDataSource > 1)
                            {
                                //keyValues.Add(findCounter, nodeDataSource.LastChild.Name + ".Relation." + "counter");
                                keyValues.Add(findNumToWordVN, nodeDataSource.LastChild.Name + ".Relation." + "AmountInWord");
                                keyValues.Add(findNumToWordEN, nodeDataSource.LastChild.Name + ".Relation." + "AmountInWord_E");
                                //keyValues.Add(findSubCompanyAddress, nodeDataSource.LastChild.Name + ".Relation." + "CompanyBranchName");
                                keyValues.Add(findSubCompanyAddress, "CompanyBranchName");
                            }
                            else
                            {
                                //keyValues.Add(findCounter, nodeDataSource.LastChild.Name + ".counter");
                                keyValues.Add(findNumToWordVN, nodeDataSource.LastChild.Name + ".AmountInWord");
                                keyValues.Add(findNumToWordEN, nodeDataSource.LastChild.Name + ".AmountInWord_E");
                                //keyValues.Add(findSubCompanyAddress, nodeDataSource.LastChild.Name + ".CompanyBranchName");
                                keyValues.Add(findSubCompanyAddress, "CompanyBranchName");
                            }
                            //Duyệt từng page
                            foreach (XmlNode nodechildPage in nodechildPages)
                            {
                                foreach (XmlNode nodelistComponent in nodechildPage.ChildNodes)
                                {
                                    foreach (XmlNode component in nodelistComponent.ChildNodes)
                                    {
                                        if (component.Attributes != null && component.Attributes.Count > 0)
                                        {
                                            //Sửa các biến không có tiền tố Relations trong GroupHeader và GroupFooter và DataBand
                                            if (component.Attributes["type"].Value == kieuHeaderMoi || component.Attributes["type"].Value == kieuFooterMoi || component.Attributes["type"].Value == kieuDataBand)
                                            {
                                                XmlNodeList listFind = component.SelectNodes("//Components/" + component.Name + "/Components/*/Text");
                                                foreach (XmlNode find in listFind)
                                                {
                                                    if (find.InnerText.IndexOf('.') > 0 && find.InnerText.IndexOf('{') >= 0 && component.Attributes["type"].Value != kieuDataBand)
                                                    {
                                                        string strText = find.InnerText.Substring(find.InnerText.IndexOf('{') + 1, find.InnerText.IndexOf('.') - find.InnerText.IndexOf('{') - 1);
                                                        if (strText.Equals(nodeDataSource.FirstChild.Name))
                                                        {
                                                            strReplace = find.InnerText;
                                                            if (demDataSource > 1)
                                                            {
                                                                strReplace = strReplace.Replace(strText, nodeDataSource.LastChild.Name + ".Relation");
                                                            }
                                                            else
                                                            {
                                                                strReplace = strReplace.Replace(strText, nodeDataSource.LastChild.Name);
                                                            }
                                                            find.InnerText = strReplace;
                                                            //Ghi tiến trình xử lý
                                                            GhiLogFileXuLy(file, find.Name, strReplace, logSua);
                                                            //Kết thúc ghi tiến trình xử lý
                                                        }
                                                    }

                                                    if (find.InnerText.Contains("{") && find.InnerText.Contains("}"))
                                                    {
                                                        bool check = false;
                                                        int indexStart = find.InnerText.IndexOf('{');
                                                        int indexEnd = find.InnerText.IndexOf('}');
                                                        string strCanSua = find.InnerText.Substring(indexStart + 1, indexEnd - indexStart - 1);

                                                        //Duyệt tới node columns
                                                        XmlNode columns = rootFolder.SelectSingleNode("//DataSources/" + nodeDataSource.FirstChild.Name + "/Columns");
                                                        foreach (XmlNode item in columns.ChildNodes)
                                                        {
                                                            int indexValue = item.InnerText.IndexOf(',');
                                                            string strValue = item.InnerText.Substring(0, indexValue);
                                                            //So sánh
                                                            if (strCanSua == strValue)
                                                            {
                                                                check = true;
                                                                break;
                                                            }
                                                        }
                                                        if (check)
                                                        {
                                                            strReplace = find.InnerText;
                                                            if (demDataSource > 1)
                                                            {
                                                                strReplace = strReplace.Replace(strCanSua, nodeDataSource.LastChild.Name + ".Relation." + strCanSua);
                                                            }
                                                            else
                                                            {
                                                                strReplace = strReplace.Replace(strCanSua, nodeDataSource.LastChild.Name + "." + strCanSua);
                                                            }
                                                            find.InnerText = strReplace;
                                                            //Ghi tiến trình xử lý
                                                            GhiLogFileXuLy(file, find.Name, strReplace, logSua);
                                                            //Kết thúc ghi tiến trình xử lý
                                                        }

                                                        if (keyValues.ContainsKey(strCanSua))
                                                        {
                                                            foreach (var item in keyValues)
                                                            {
                                                                strReplace = find.InnerText;
                                                                strReplace = strReplace.Replace(item.Key, item.Value);
                                                                find.InnerText = strReplace;
                                                                //Ghi tiến trình xử lý
                                                                GhiLogFileXuLy(file, find.Name, strReplace, logSua);
                                                                //Kết thúc ghi tiến trình xử lý
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                            //Xử lý những giá trị còn lại kiểu tham số trên báo cáo
                                            //XmlNodeList listChild = component.SelectNodes("//Components/" + component.Name + "/*");
                                            //Dictionary<string, string> keyValues2 = new Dictionary<string, string>();
                                            //if (demDataSource > 1)
                                            //{
                                            //    keyValues2.Add("counter", "" + nodeDataSource.LastChild.Name + ".Relation." + "counter");
                                            //}
                                            //else
                                            //{
                                            //    keyValues2.Add("counter", "" + nodeDataSource.LastChild.Name + ".counter");
                                            //}
                                            //foreach (var item in keyValues2)
                                            //{
                                            //    foreach (XmlNode child in listChild)
                                            //    {
                                            //        if (child.InnerText.Contains(item.Key))
                                            //        {
                                            //            strReplace = child.InnerText;
                                            //            strReplace = strReplace.Replace(item.Key, item.Value);
                                            //            child.InnerText = strReplace;
                                            //            //Ghi tiến trình xử lý
                                            //            GhiLogFileXuLy(file, child.Name, strReplace, logSua);
                                            //            //Kết thúc ghi tiến trình xử lý
                                            //        }
                                            //    }
                                            //}
                                        }
                                    }
                                }
                            }
                        }
                    }
         
                    //Lưu file
                    docFolder.Save(file);
                    //Lấy tổng số Page trong file
                    int demPage = nodePages.ChildNodes.Count;
                    //Lấy tổng số Datasource trong file
                    int demData = nodeDataSource.ChildNodes.Count;
                    //Hiển thị trong listview nếu Page nhiều hơn 1
                    if (demPage > 1)
                    {
                        lvNhieuPage.Items.Add(Path.GetFileName(file));
                    }
                    //Hiển thị trong listview nếu Page nhiều hơn 1
                    if (demData > 2)
                    {
                        lvNhieuDatasource.Items.Add(Path.GetFileName(file));
                    }
                    //Tăng giá trị loading
                    loadMin++;
                    if(loadMin <= loadMax)
                    {
                        pbLoading.Value = loadMin;
                    }
                }
                //Hiển thị tổng số file thực hiện
                lbTongSoFile.Text = loadMax.ToString();


                //Ghi ra file log
                if (dgvLogXuLy.Rows.Count > 0)
                {
                    //kiểm tra đã tồn tại folder chứa file log chưa
                    string strFolder = "./logs";
                    if (!Directory.Exists(strFolder))
                    {
                        Directory.CreateDirectory(strFolder);
                    }
                    //Khai báo các biến
                    DateTime dateTime = DateTime.Now;
                    string convertDt = dateTime.ToString("dd-MM-yyyy-HH-mm-ss");
                    XmlWriterSettings writerSettings = new XmlWriterSettings { Indent = true };
                    XmlWriter logFile = XmlWriter.Create("./logs/log-file-" + convertDt + ".xml", writerSettings);
                    logFile.WriteStartElement("logfile");
                    for (int i = 0; i < dgvLogXuLy.Rows.Count; i++)
                    {
                        logFile.WriteStartElement(dgvLogXuLy.Rows[i].Cells[0].Value.ToString());
                        logFile.WriteElementString("tenthe", dgvLogXuLy.Rows[i].Cells[1].Value.ToString());
                        logFile.WriteElementString("noidungcu", dgvLogXuLy.Rows[i].Cells[2].Value.ToString());
                        logFile.WriteElementString("noidungmoi", dgvLogXuLy.Rows[i].Cells[3].Value.ToString());
                        logFile.WriteEndElement();
                    }
                    logFile.Flush();
                    logFile.Close();
                }
            }
            else
            {
                MessageBox.Show(msgFolderTrong, msgThongBao);
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            vistaFolderBrowserDialog = new VistaFolderBrowserDialog();
            vistaFolderBrowserDialog.ShowDialog();
            txtDuongDan_Folder.Text = vistaFolderBrowserDialog.SelectedPath;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            vistaOpenFileDialog = new VistaOpenFileDialog();
            vistaOpenFileDialog.ShowDialog();
            txtDuongDan_File.Text = vistaOpenFileDialog.FileName;
        }

        private void btnLuuCauHinh_Click(object sender, EventArgs e)
        {
            //Lưu cấu hình đã thiết lập điều kiện file chưa tồn tại
            if (txtTenCauHinh.Text != "" && !File.Exists(pathConfig))
            {
                //Tạo mới file cấu hình và gán giá trị
                XmlWriterSettings writerSettings = new XmlWriterSettings { Indent = true };
                XmlWriter writer = XmlWriter.Create("./config.xml", writerSettings);
                writer.WriteStartElement(econfig);
                writer.WriteStartElement(eprofile);
                writer.WriteAttributeString("name", txtTenCauHinh.Text);
                writer.WriteElementString(efolderpath, txtDuongDan_Folder.Text);
                writer.WriteElementString(elist_checked_truongcodinh, clCapNhatGiaTriThe.GetItemChecked(0).ToString());
                writer.WriteElementString(elist_checked_thamso, clCapNhatGiaTriThe.GetItemChecked(1).ToString());
                writer.WriteElementString(elist_checked_nhom, clCapNhatGiaTriThe.GetItemChecked(2).ToString());
                writer.WriteElementString(elist_checked_lienket, clCapNhatGiaTriThe.GetItemChecked(3).ToString());
                writer.WriteElementString(elist_checked_themthedata, clCapNhatGiaTriThe.GetItemChecked(4).ToString());
                writer.WriteElementString(elist_checked_suawatermark, clCapNhatGiaTriThe.GetItemChecked(5).ToString());
                writer.WriteElementString(elist_checked_suadatasource, clCapNhatGiaTriThe.GetItemChecked(6).ToString());
                writer.WriteElementString(elist_checked_chuyenthamsothanhtruongdulieu, clCapNhatGiaTriThe.GetItemChecked(7).ToString());
                writer.WriteElementString(elist_checked_themtiento, clCapNhatGiaTriThe.GetItemChecked(8).ToString());
                writer.WriteElementString(efilepath, txtDuongDan_File.Text);
                writer.WriteEndElement();
                writer.Flush();
                writer.Close();
                //Nếu có giá trị trên lưới thì thêm vào file cấu hình
                LuuDataGridViewTheoTen(false);
                //Thêm cấu hình vừa tạo vào combobox
                cbbDocCauHinh.Items.Add(txtTenCauHinh.Text);

                MessageBox.Show(msgLuuCauHinhThanhCong, msgThongBao);
            }
            //Lưu cấu hình đã thiết lập điều kiện file đã tồn tại
            else if (txtTenCauHinh.Text != "" && File.Exists(pathConfig))
            {
                docConfig = new XmlDocument();
                docConfig.Load(pathConfig);

                XmlNode nodeKiemTraTonTaiProfile = docConfig.SelectSingleNode("//" + eprofile + "[@name='" + txtTenCauHinh.Text + "']");
                if(nodeKiemTraTonTaiProfile != null)
                {
                    MessageBox.Show(msgTenProfileDaTonTai, msgThongBao);
                }
                else
                {
                    XmlNode nodeRootConfig = docConfig.SelectSingleNode(econfig);

                    XmlElement nodeProfile = docConfig.CreateElement(eprofile);
                    nodeProfile.SetAttribute("name", txtTenCauHinh.Text);
                    nodeRootConfig.AppendChild(nodeProfile);

                    XmlElement nodeFolderpath = docConfig.CreateElement(efolderpath);
                    nodeFolderpath.InnerText = txtDuongDan_Folder.Text;
                    nodeProfile.AppendChild(nodeFolderpath);

                    XmlElement nodeTruongCoDinh = docConfig.CreateElement(elist_checked_truongcodinh);
                    nodeTruongCoDinh.InnerText = clCapNhatGiaTriThe.GetItemChecked(0).ToString();
                    nodeProfile.AppendChild(nodeTruongCoDinh);

                    XmlElement nodeThamSo = docConfig.CreateElement(elist_checked_thamso);
                    nodeThamSo.InnerText = clCapNhatGiaTriThe.GetItemChecked(1).ToString();
                    nodeProfile.AppendChild(nodeThamSo);

                    XmlElement nodeNhom = docConfig.CreateElement(elist_checked_nhom);
                    nodeNhom.InnerText = clCapNhatGiaTriThe.GetItemChecked(2).ToString();
                    nodeProfile.AppendChild(nodeNhom);

                    XmlElement nodeLienKet = docConfig.CreateElement(elist_checked_lienket);
                    nodeLienKet.InnerText = clCapNhatGiaTriThe.GetItemChecked(3).ToString();
                    nodeProfile.AppendChild(nodeLienKet);

                    XmlElement nodeThemTheData = docConfig.CreateElement(elist_checked_themthedata);
                    nodeThemTheData.InnerText = clCapNhatGiaTriThe.GetItemChecked(4).ToString();
                    nodeProfile.AppendChild(nodeThemTheData);

                    XmlElement nodeSuaWatermark = docConfig.CreateElement(elist_checked_suawatermark);
                    nodeSuaWatermark.InnerText = clCapNhatGiaTriThe.GetItemChecked(5).ToString();
                    nodeProfile.AppendChild(nodeSuaWatermark);

                    XmlElement nodeSuaDatasource = docConfig.CreateElement(elist_checked_suadatasource);
                    nodeSuaDatasource.InnerText = clCapNhatGiaTriThe.GetItemChecked(6).ToString();
                    nodeProfile.AppendChild(nodeSuaDatasource);

                    XmlElement nodeChuyenThamSo = docConfig.CreateElement(elist_checked_chuyenthamsothanhtruongdulieu);
                    nodeChuyenThamSo.InnerText = clCapNhatGiaTriThe.GetItemChecked(7).ToString();
                    nodeProfile.AppendChild(nodeChuyenThamSo);

                    XmlElement nodeThemTienTo = docConfig.CreateElement(elist_checked_themtiento);
                    nodeThemTienTo.InnerText = clCapNhatGiaTriThe.GetItemChecked(8).ToString();
                    nodeProfile.AppendChild(nodeThemTienTo);

                    XmlElement nodeFilepath = docConfig.CreateElement(efilepath);
                    nodeFilepath.InnerText = txtDuongDan_File.Text;
                    nodeProfile.AppendChild(nodeFilepath);
                    //Nếu có giá trị trên lưới thì thêm vào file cấu hình
                    LuuDataGridViewTheoTen(true);
                    docConfig.Save(pathConfig);
                    //Thêm cấu hình vừa tạo vào combobox
                    cbbDocCauHinh.Items.Add(txtTenCauHinh.Text);

                    MessageBox.Show(msgLuuCauHinhThanhCong, msgThongBao);
                }
            }
            else
            {
                MessageBox.Show(msgTenCauHinhTrong, msgThongBao);
            }
        }

        public void LoadCauHinhTheoTen(string profileName)
        {
            DocCauHinhTrongFile(profileName);

            //Reset thông tin trên form trước khi gán giá trị mới
            txtDuongDan_Folder.Text = "";
            clCapNhatGiaTriThe.ClearSelected();
            txtDuongDan_File.Text = "";
            dgvLuoiDoiGiaTri.Rows.Clear();

            //Đọc giá trị trong file cấu hình
            txtDuongDan_Folder.Text = nodeConfigFolder.InnerText;

            clCapNhatGiaTriThe.SetItemChecked(0, Convert.ToBoolean(nodeConfigTruongCoDinh.InnerText));
            clCapNhatGiaTriThe.SetItemChecked(1, Convert.ToBoolean(nodeConfigTruongThamSo.InnerText));
            clCapNhatGiaTriThe.SetItemChecked(2, Convert.ToBoolean(nodeConfigTruongNhom.InnerText));
            clCapNhatGiaTriThe.SetItemChecked(3, Convert.ToBoolean(nodeConfigTruongLienKet.InnerText));
            clCapNhatGiaTriThe.SetItemChecked(4, Convert.ToBoolean(nodeConfigThemTheData.InnerText));
            clCapNhatGiaTriThe.SetItemChecked(5, Convert.ToBoolean(nodeConfigSuaWatermark.InnerText));
            clCapNhatGiaTriThe.SetItemChecked(6, Convert.ToBoolean(nodeConfigSuaDatasource.InnerText));
            clCapNhatGiaTriThe.SetItemChecked(7, Convert.ToBoolean(nodeConfigChuyenThamSo.InnerText));
            clCapNhatGiaTriThe.SetItemChecked(8, Convert.ToBoolean(nodeConfigThemTienTo.InnerText));

            txtDuongDan_File.Text = nodeConfigFile.InnerText;


            foreach (XmlNode data in nodeProfile.ChildNodes)
            {
                if (data.Name == edatagridview)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvLuoiDoiGiaTri);
                    foreach (XmlNode value in data.ChildNodes)
                    {
                        if (value.Name == etenthe)
                        {
                            row.Cells[0].Value = value.InnerText;
                        }
                        if (value.Name == egiatricu)
                        {
                            row.Cells[1].Value = value.InnerText;
                        }
                        if (value.Name == egiatrimoi)
                        {
                            row.Cells[2].Value = value.InnerText;
                        }
                    }
                    dgvLuoiDoiGiaTri.Rows.Add(row);
                }
            }
        }

        public void LuuDataGridViewTheoTen(bool kiemtraTonTaiFile)
        {
            if (dgvLuoiDoiGiaTri.Rows.Count > 0)
            {
                //Add thêm các giá trị trong Datagridview vào file cấu hình
                if(!kiemtraTonTaiFile)
                {
                    docConfig = new XmlDocument();
                    docConfig.Load(pathConfig);
                }
                XmlNode nodeProfile = docConfig.SelectSingleNode("//"+eprofile+"[@name='" + txtTenCauHinh.Text + "']");
                //Reset data nếu có trong profile cấu hình
                XmlNodeList nodeKiemTraTonTaiData = docConfig.SelectNodes("//" + eprofile + "[@name='" + txtTenCauHinh.Text + "']/"+ edatagridview + "");
                if(nodeKiemTraTonTaiData != null)
                {
                    foreach(XmlNode data in nodeKiemTraTonTaiData)
                    {
                        nodeProfile.RemoveChild(data);
                    }
                }
                for (int i = 0; i < dgvLuoiDoiGiaTri.Rows.Count; i++)
                {
                    if (dgvLuoiDoiGiaTri.Rows[i].Cells[0].Value != null || dgvLuoiDoiGiaTri.Rows[i].Cells[1].Value != null || dgvLuoiDoiGiaTri.Rows[i].Cells[2].Value != null)
                    {
                        XmlElement nodeData = docConfig.CreateElement(edatagridview);
                        nodeProfile.AppendChild(nodeData);
                        XmlElement nodeTenThe = docConfig.CreateElement(etenthe);
                        XmlElement nodeGiaTriCu = docConfig.CreateElement(egiatricu);
                        XmlElement nodeGiaTriMoi = docConfig.CreateElement(egiatrimoi);
                        XmlNodeList nodelistData = nodeProfile.SelectNodes("//"+edatagridview+"");

                        foreach (XmlNode nodedata in nodelistData)
                        {
                            if (!nodedata.HasChildNodes)
                            {
                                nodedata.AppendChild(nodeTenThe);
                                nodedata.AppendChild(nodeGiaTriCu);
                                nodedata.AppendChild(nodeGiaTriMoi);
                                //Gán giá trị vào các node
                                if (dgvLuoiDoiGiaTri.Rows[i].Cells[0].Value != null && dgvLuoiDoiGiaTri.Rows[i].Cells[1].Value != null && dgvLuoiDoiGiaTri.Rows[i].Cells[2].Value != null)
                                {
                                    nodeTenThe.InnerText = dgvLuoiDoiGiaTri.Rows[i].Cells[0].Value.ToString();
                                    nodeGiaTriCu.InnerText = dgvLuoiDoiGiaTri.Rows[i].Cells[1].Value.ToString();
                                    nodeGiaTriMoi.InnerText = dgvLuoiDoiGiaTri.Rows[i].Cells[2].Value.ToString();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnXoaCauHinh_Click(object sender, EventArgs e)
        {
            if (File.Exists(pathConfig))
            {
                if (cbbDocCauHinh.Text != "")
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa cấu hình " + cbbDocCauHinh.Text + "?", msgThongBao, MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //Xóa cấu hình trong file xml
                        XmlNode nodeRootConfig = docConfig.SelectSingleNode(econfig);
                        nodeRootConfig.RemoveChild(docConfig.SelectSingleNode("//" + eprofile + "[@name='" + cbbDocCauHinh.Text + "']"));
                        docConfig.Save(pathConfig);
                        //Xóa cấu hình trên combobox
                        cbbDocCauHinh.Items.Remove(cbbDocCauHinh.SelectedItem);
                    }
                }
                else
                {
                    MessageBox.Show(msgComboboxTenCauHinhTrong, msgThongBao);
                }
            }
            else
            {
                MessageBox.Show(msgCauHinhTrong, msgThongBao);
            }
        }

        private void btnSuaCauHinh_Click(object sender, EventArgs e)
        {
            if (File.Exists(pathConfig))
            {
                if(cbbDocCauHinh.Text != "")
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa cấu hình " + cbbDocCauHinh.Text + "?", msgThongBao, MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //Sửa cấu hình trong file xml
                        DocCauHinhTrongFile(cbbDocCauHinh.Text);

                        nodeConfigFolder.InnerText = txtDuongDan_Folder.Text;
                        nodeConfigTruongCoDinh.InnerText = clCapNhatGiaTriThe.GetItemChecked(0).ToString();
                        nodeConfigTruongThamSo.InnerText = clCapNhatGiaTriThe.GetItemChecked(1).ToString();
                        nodeConfigTruongNhom.InnerText = clCapNhatGiaTriThe.GetItemChecked(2).ToString();
                        nodeConfigTruongLienKet.InnerText = clCapNhatGiaTriThe.GetItemChecked(3).ToString();
                        nodeConfigThemTheData.InnerText = clCapNhatGiaTriThe.GetItemChecked(4).ToString();
                        nodeConfigSuaWatermark.InnerText = clCapNhatGiaTriThe.GetItemChecked(5).ToString();
                        nodeConfigSuaDatasource.InnerText = clCapNhatGiaTriThe.GetItemChecked(6).ToString();
                        nodeConfigChuyenThamSo.InnerText = clCapNhatGiaTriThe.GetItemChecked(7).ToString();
                        nodeConfigThemTienTo.InnerText = clCapNhatGiaTriThe.GetItemChecked(8).ToString();
                        nodeConfigFile.InnerText = txtDuongDan_File.Text;

                        LuuDataGridViewTheoTen(true);

                        docConfig.Save(pathConfig);

                        MessageBox.Show(msgSuaCauHinhThanhCong, msgThongBao);
                    }
                }
                else
                {
                    MessageBox.Show(msgComboboxTenCauHinhTrong, msgThongBao);
                }
            }
            else
            {
                MessageBox.Show(msgCauHinhTrong, msgThongBao);
            }
        }
        public void DocCauHinhTrongFile(string profileName)
        {
            //Truy cập vào các thẻ
            nodeProfile = docConfig.SelectSingleNode("//" + eprofile + "[@name='" + profileName + "']");
            //Khai báo biến
            nodeConfigFolder = nodeProfile.SelectSingleNode("folderpath");
            nodeConfigTruongCoDinh = nodeProfile.SelectSingleNode("list_checked_truongcodinh");
            nodeConfigTruongThamSo = nodeProfile.SelectSingleNode("list_checked_thamso");
            nodeConfigTruongNhom = nodeProfile.SelectSingleNode("list_checked_nhom");
            nodeConfigTruongLienKet = nodeProfile.SelectSingleNode("list_checked_lienket");
            nodeConfigThemTheData = nodeProfile.SelectSingleNode("list_checked_themthedata");
            nodeConfigSuaWatermark = nodeProfile.SelectSingleNode("list_checked_suawatermark");
            nodeConfigSuaDatasource = nodeProfile.SelectSingleNode("list_checked_suadatasource");
            nodeConfigChuyenThamSo = nodeProfile.SelectSingleNode("list_checked_chuyenthamsothanhtruongdulieu");
            nodeConfigThemTienTo = nodeProfile.SelectSingleNode("list_checked_themtiento");
            nodeConfigFile = nodeProfile.SelectSingleNode("filepath");
        }

        private void txtTenCauHinh_TextChanged(object sender, EventArgs e)
        {
            if(txtTenCauHinh.Text != cbbDocCauHinh.Text)
            {
                btnSuaCauHinh.Enabled = false;
            }
            else
            {
                btnSuaCauHinh.Enabled = true;
            }
        }

        private void cbbDocCauHinh_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadCauHinhTheoTen(cbbDocCauHinh.Text);
            txtTenCauHinh.Text = cbbDocCauHinh.Text;
        }

        public void GhiLogFileXuLy(string filename, string tenthe, string noidungcu, string noidungmoi)
        {
            row = new DataGridViewRow();
            row.CreateCells(dgvLogXuLy);
            row.Cells[0].Value = Path.GetFileName(filename);
            row.Cells[1].Value = tenthe;
            row.Cells[2].Value = noidungcu;
            row.Cells[3].Value = noidungmoi;
            dgvLogXuLy.Rows.Add(row);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.F1))
            {
                btnOpenFolder.PerformClick();
            }
            if (keyData == ( Keys.F2))
            {
                btnOpenFile.PerformClick();
            }
            if (keyData == ( Keys.F3))
            {
                btnXoaCauHinh.PerformClick();
            }
            if (keyData == (Keys.F4))
            {
                btnSuaCauHinh.PerformClick();
            }
            if (keyData == (Keys.F5))
            {
                btnThemCauHinh.PerformClick();
            }
            if (keyData == (Keys.F6))
            {
                btnThucHien.PerformClick();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
