using PhanMemChuyenDoiBaoCaoWeb.Models.DAO;
using PhanMemChuyenDoiBaoCaoWeb.Models.Entity;
using PhanMemChuyenDoiBaoCaoWeb.Models.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace PhanMemChuyenDoiBaoCaoWeb.Models.Service
{
    public class NodeServiceImp : NodeService
    {
        NodeDAO nodeDAO = new NodeDAOImp();

        public void DoiTenTruongCoDinh(string pathToFile, XmlDocument root)
        {
            XmlNodeList listNodeDatasource = root.SelectSingleNode(VariableStatic.keyValues["selectNodeDataSources"].Path).ChildNodes;

            foreach (XmlNode child in listNodeDatasource)
            {
                if (child.Name != listNodeDatasource[0].Name)
                {
                    nodeDAO.EditNode(child, VariableStatic.keyValues["SttToId"]);
                    nodeDAO.EditNode(child, VariableStatic.keyValues["Stt0ToId"]);

                    if (!nodeDAO.FindValue(child, VariableStatic.keyValues["findValueParentId"]))
                    {
                        nodeDAO.AddNode(root.SelectSingleNode("//" + child.Name + VariableStatic.keyValues["selectNodeColumns"].Path), VariableStatic.keyValues["SttToParentId"]);
                    }
                }
                else
                {
                    nodeDAO.EditNode(child, VariableStatic.keyValues["SttToId"]);
                }
            }
        }

        public void DoiThamSo(string pathToFile, XmlDocument root, XmlDocument rootMaster, Dictionary<string, string> variables, XmlNode variablesMaster)
        {
            //XmlNode variableMaster = rootMaster.SelectSingleNode(VariableStatic.keyValues["selectNodeVariables"].Path);
            XmlNodeList listVariableCurrent = root.SelectSingleNode(VariableStatic.keyValues["selectNodeVariables"].Path).ChildNodes;
            IList<string> list = new List<string>();

            //foreach (XmlNode nodeMaster in listVariableMaster)
            //{
            //    int indexM1 = nodeMaster.InnerText.IndexOf(',');
            //    string strMaster = nodeMaster.InnerText.Substring(indexM1 + 1, nodeMaster.InnerText.IndexOf(',', indexM1 + 1) - indexM1 - 1);

            //    bool existed = false;
            //    foreach (XmlNode nodeCurrent in listVariableCurrent)
            //    {
            //        int indexC1 = nodeCurrent.InnerText.IndexOf(',');
            //        string strCurrent = nodeCurrent.InnerText.Substring(indexC1 + 1, nodeCurrent.InnerText.IndexOf(',', indexC1 + 1) - indexC1 - 1);

            //        if (strMaster == strCurrent)
            //        {
            //            existed = true;
            //            //nodeCurrent.InnerText = nodeMaster.InnerText;
            //            VariableStatic.keyValues["selectNodeValueInVariables"].OldValue = nodeCurrent.InnerText;
            //            VariableStatic.keyValues["selectNodeValueInVariables"].NewValue = nodeMaster.InnerText;
            //            nodeDAO.EditNode(nodeCurrent, VariableStatic.keyValues["selectNodeValueInVariables"]);
            //        }
            //    }

            //    if (!existed)
            //    {
            //        list.Add(nodeMaster.InnerText);
            //    }
            //}

            //foreach (string item in list)
            //{
            //    VariableStatic.keyValues["selectNodeValueInVariables"].NewValue = item;
            //    nodeDAO.AddNode(root.SelectSingleNode(VariableStatic.keyValues["selectNodeVariables"].Path), VariableStatic.keyValues["selectNodeValueInVariables"]);
            //}

            //XmlNode nodeVariables = rootMaster.SelectSingleNode(VariableStatic.keyValues["selectNodeVariables"].Path).Clone(); //root.SelectSingleNode(VariableStatic.keyValues["selectNodeVariables"].Path);

            foreach (XmlNode nodeCurrent in listVariableCurrent)
            {
                int indexC1 = nodeCurrent.InnerText.IndexOf(',');
                string strCurrent = nodeCurrent.InnerText.Substring(indexC1 + 1, nodeCurrent.InnerText.IndexOf(',', indexC1 + 1) - indexC1 - 1);

                if (!variables.ContainsKey(strCurrent))
                {
                    list.Add(nodeCurrent.InnerText);
                }


                //bool existed = false;
                //foreach (XmlNode nodeMaster in listVariableMaster)
                //{
                //    int indexMaster = nodeMaster.InnerText.IndexOf(',', nodeMaster.InnerText.IndexOf(',') + 1);
                //    string strMaster = nodeMaster.InnerText.Substring(1, indexMaster);

                //    if (strCurrent == strMaster)
                //    {
                //        existed = true;
                //        nodeCurrent.InnerText = nodeMaster.InnerText;
                //        //break;
                //    }
                //}

                //    if (!existed)
                //    {
                //        list.Add(nodeCurrent.InnerText);
                //    }
            }
            //Remove tất cả variables trong file cần xử lý
            nodeDAO.RemoveNode(root.SelectSingleNode(VariableStatic.keyValues["selectNodeVariables"].Path));

            //Gán các tham số trong master vào file cần xử lý
            root.SelectSingleNode(VariableStatic.keyValues["selectNodeVariables"].Path).InnerXml = variablesMaster.InnerXml;

            //Gán tiếp các tham số còn thiếu vào file cần xử lý 
            foreach (string item in list)
            {
                nodeDAO.AddNode(root.SelectSingleNode(VariableStatic.keyValues["selectNodeVariables"].Path), new Node("value", null, null, null, item));
            }

        }

        public void DoiNhom(string pathToFile, XmlDocument root)
        {
            //Khai báo các thông tin
            XmlNodeList listNodeComponent = root.SelectSingleNode(VariableStatic.keyValues["selectNodeComponent"].Path).ChildNodes;

            List<AtrNode> listAttrHeader = new List<AtrNode>();
            listAttrHeader.Add(new AtrNode("type", "PageHeaderBand"));
            listAttrHeader.Add(new AtrNode("type", "HeaderBand"));

            List<AtrNode> listAttrFooter = new List<AtrNode>();
            listAttrFooter.Add(new AtrNode("type", "FooterBand"));
            listAttrFooter.Add(new AtrNode("type", "ReportSummaryBand"));

            VariableStatic.keyValues["changePageHeaderBand"].ListAttr = listAttrHeader;
            VariableStatic.keyValues["changePageFooterBand"].ListAttr = listAttrFooter;

            bool check = false;
            XmlNode clonePageFooter = null;

            foreach (XmlNode child in listNodeComponent)
            {
                //Thêm thẻ mới trong Page header
                if (nodeDAO.FindAttribute(child, VariableStatic.keyValues["findPageHeader"]))
                {
                    nodeDAO.AddNode(child, VariableStatic.keyValues["createNewPageBefore"]);
                }
                //Thêm thẻ mới trong Header
                if (nodeDAO.FindAttribute(child, VariableStatic.keyValues["findHeader"]))
                {
                    nodeDAO.AddNode(child, VariableStatic.keyValues["createPrintOnAllPages"]);
                }
                //Thay đổi giá trị trong footer
                if (nodeDAO.FindAttribute(child, VariableStatic.keyValues["findSummary"]) || nodeDAO.FindAttribute(child, VariableStatic.keyValues["findFooter"]))
                {
                    //Nếu không có thẻ PrintAtBottom thì thêm mới, ngược lại thì thay đổi giá trị từ false -> true
                    if (child.SelectSingleNode(VariableStatic.keyValues["changePrintAtBottom"].Name) != null)
                    {
                        nodeDAO.EditNode(child, VariableStatic.keyValues["changePrintAtBottom"]);
                    }
                    else
                    {
                        nodeDAO.AddNode(child, VariableStatic.keyValues["changePrintAtBottom"]);
                    }
                }
                //Đánh dấu tìm được thẻ Page Footer
                if (nodeDAO.FindAttribute(child, VariableStatic.keyValues["findPageFooter"]) && check == false)
                {
                    clonePageFooter = child;
                    check = true;
                }
                //Xóa thẻ PrintOn
                if (child.SelectSingleNode(VariableStatic.keyValues["changePrintOnFirst"].Path) != null)
                {
                    nodeDAO.RemoveNode(child.SelectSingleNode(VariableStatic.keyValues["changePrintOnFirst"].Path));
                }
                //Đổi kiểu header & footer cũ sang kiểu header & footer mới
                nodeDAO.EditAttribute(child, VariableStatic.keyValues["changePageHeaderBand"]);
                nodeDAO.EditAttribute(child, VariableStatic.keyValues["changePageFooterBand"]);
            }

            //Di chuyển thẻ Page Footer xuống dưới cùng
            if (check = true && clonePageFooter != null)
            {
                nodeDAO.MoveNode(root.SelectSingleNode(VariableStatic.keyValues["selectNodeComponent"].Path), clonePageFooter);
            }
        }

        public void SuaDatasource(string pathToFile, XmlDocument root)
        {
            //Khai báo biến
            XmlNodeList nameDatasource = root.SelectNodes(VariableStatic.keyValues["selectNameInSourceInDataSource"].Path);
            XmlNode database = root.SelectSingleNode(VariableStatic.keyValues["selectNodeDatabases"].Path);

            if (database != null)
            {
                //Kích hoạt thẻ Database
                nodeDAO.EditAttribute(database, VariableStatic.keyValues["selectNodeDatabases"]);
                if (!database.HasChildNodes)
                {
                    //Tạo mới thẻ JSON
                    nodeDAO.AddNode(database, VariableStatic.keyValues["createJSONDatabases"]);
                    //Tạo thẻ Alias con của JSON
                    nodeDAO.AddNode(database.SelectSingleNode(VariableStatic.keyValues["createJSONDatabases"].Path), VariableStatic.keyValues["createAliasDatabases"]);
                    //Tạo thẻ Key con của JSON
                    nodeDAO.AddNode(database.SelectSingleNode(VariableStatic.keyValues["createJSONDatabases"].Path), VariableStatic.keyValues["createKeyDatabases"]);
                    //Tạo thẻ Name con của JSON
                    nodeDAO.AddNode(database.SelectSingleNode(VariableStatic.keyValues["createJSONDatabases"].Path), VariableStatic.keyValues["createNameDatabases"]);
                    //Tạo thẻ PathData con của JSON
                    nodeDAO.AddNode(database.SelectSingleNode(VariableStatic.keyValues["createJSONDatabases"].Path), VariableStatic.keyValues["createPathDataDatabases"]);
                }
                //Thay đổi giá trị trong NameInSource
                foreach (XmlNode item in nameDatasource)
                {
                    if (item.Name == VariableStatic.keyValues["selectNameInSourceInDataSource"].Name)
                    {
                        VariableStatic.keyValues["selectNameInSourceInDataSource"].OldValue = item.InnerText;
                        VariableStatic.keyValues["selectNameInSourceInDataSource"].NewValue = "JSON." + item.InnerText;
                        nodeDAO.EditNode(item, VariableStatic.keyValues["selectNameInSourceInDataSource"]);
                    }
                }
            }
        }

        public void SuaWatermark(string pathToFile, XmlDocument root)
        {
            string strNew = "";
            XmlNodeList listPages = root.SelectNodes(VariableStatic.keyValues["selectListPage"].Path);
            XmlNodeList waterMark = root.SelectNodes(VariableStatic.keyValues["removeWatermark"].Path);
            foreach (XmlNode page in listPages)
            {
                string strOld = "this." + page.Name + "_Watermark.Text = DEMOString;";
                foreach (XmlNode item in waterMark)
                {
                    strNew = item.InnerText.Replace(strOld, "");
                    item.InnerText = strNew;
                }
            }
        }

        public void ThemLienKetBang(string pathToFile, XmlDocument root)
        {
            XmlNode datasource = root.SelectSingleNode(VariableStatic.keyValues["selectNodeDataSources"].Path);
            if (datasource.HasChildNodes && datasource.FirstChild.Name != datasource.LastChild.Name)
            {
                //Khai báo các thông tin
                string isRefDictionary = root.SelectSingleNode(VariableStatic.keyValues["selectNodeDictionary"].Path).Attributes["Ref"].Value;
                string isRefParentSource = datasource.FirstChild.Attributes["Ref"].Value;
                string isRefChildSource = datasource.LastChild.Attributes["Ref"].Value;
                string condition = "{" + datasource.LastChild.Name + ".Relation.Id}";


            }
        }

        public void ThemTheDuLieu(string pathToFile, XmlDocument root)
        {
            throw new NotImplementedException();
        }

        public XmlDocument OpenFile(string filepath)
        {
            return nodeDAO.OpenFile(filepath);
        }

        public bool SaveFile(XmlDocument root, string filepath)
        {
            return nodeDAO.SaveFile(root, filepath);
        }

        public void DocThamSoGoc(Dictionary<string, string> variables, XmlDocument rootMaster)
        {

            foreach (XmlNode node in rootMaster.SelectSingleNode(VariableStatic.keyValues["selectNodeVariables"].Path).ChildNodes)
            {
                variables.Add(node.InnerText.Substring(node.InnerText.IndexOf(',') + 1, node.InnerText.IndexOf(',', node.InnerText.IndexOf(',') + 1) - node.InnerText.IndexOf(',') - 1), node.InnerText);
            }
        }
    }
}
