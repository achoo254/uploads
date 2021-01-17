using PhanMemChuyenDoiBaoCaoWeb.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemChuyenDoiBaoCaoWeb.Models.Utils
{
    class VariableStatic
    {
        internal static string msgLoiKetNoiFolder = "Đường dẫn đến folder không hợp lệ";
        internal static string msgLoiKetNoiFile = "Đường dẫn đến file không hợp lệ";
        internal static string nodeDictionary = "Dictionary";
        internal static string nodeDatabases = "Databases";
        internal static string nodeDataSources = "DataSources";
        internal static string nodeColumns = "Columns";
        internal static string nodeValue = "value";
        internal static string nodeVariables = "Variables";
        internal static string atrNodeIsList = "isList";
        internal static string atrNodeCount = "count";
        internal static string atrNodeType = "type";
        internal static string atrNodeRef = "Ref";
        internal static string bienTruongStt = "Stt,System.String";
        internal static string bienTruongStt0 = "Stt0,System.String";
        internal static string bienTruongId = "Id,System.String";
        internal static string bienTruongParentId = "ParentId,System.String";

        internal static Dictionary<string, Node> keyValues = new Dictionary<string, Node>() {
            { "selectNodeDictionary", new Node("Dictionary", null, "//Dictionary", null, null) },
            { "selectNodeDataSources", new Node("DataSources", null, "//DataSources", null, null) },
            { "selectNodeColumns", new Node("Columns", null, "//Columns", null, null) },
            { "selectNodeValue", new Node("value", null, "//Columns/value", null, null)},
            { "selectNodeVariables", new Node("Variables", null, "//Variables", null, null)},
            { "selectNodeValueInVariables", new Node("value", null, "//Variables/value", null, null)},
            { "selectNodeComponent", new Node("Components", null, "//Pages/*/Components", null, null)},
            { "selectRelations", new Node("Relations", new List<AtrNode>(){ 
                new AtrNode("count","0")
            }, "//Relations", null, "1") },
            { "changePageHeaderBand", new Node(null, null, "//Pages/*/Components/*", null, "GroupHeaderBand") },
            { "changePageFooterBand", new Node(null, null, "//Pages/*/Components/*", null, "GroupFooterBand") },
            { "findPageHeader", new Node(null, null, null, "PageHeaderBand", null) },
            { "findHeader", new Node(null, null, null, "HeaderBand", null) },
            { "findSummary", new Node(null, null, null, "ReportSummaryBand", null) },
            { "findFooter", new Node(null, null, null, "FooterBand", null) },
            { "findPageFooter", new Node(null, null, null, "PageFooterBand", null) },
            { "createNewPageBefore", new Node("NewPageBefore", null, "//Pages/*/Components/*/*", null, "true") },
            { "createPrintOnAllPages", new Node("PrintOnAllPages", null, "//Pages/*/Components/*/*", null, "true") },
            { "changePrintOnFirst", new Node(null, null, "//Pages/*/Components/*/PrintOn", "OnlyFirstPage", "") },
            { "changePrintOnLast", new Node(null, null, "//Pages/*/Components/*/PrintOn", "OnlyLastPage", "") },
            { "changePrintAtBottom", new Node("PrintAtBottom", null, "//Pages/*/Components/*/*", null, "true") },
            { "findValueParentId", new Node("value", null, "//Columns/value", "ParentId,System.String", null)},
            { "SttToId", new Node("value", null, "//Columns/value", "Stt,System.String", "Id,System.String")},
            { "Stt0ToId", new Node("value", null, "//Columns/value", "Stt0,System.String", "Id,System.String")},
            { "SttToParentId", new Node("value", null, "//Columns/value", "Stt,System.String", "ParentId,System.String")},
            { "selectNodeDatabases", new Node("Databases", new List<AtrNode>(){
                new AtrNode("count","0")
            }, "//Databases", null, "1") },
          { "createJSONDatabases", new Node("JSON", new List<AtrNode>(){
              new AtrNode("Ref","1010"),
              new AtrNode("type","Stimulsoft.Report.Dictionary.StiJsonDatabase"),
              new AtrNode("isKey","true")
          }, "//JSON", null, null) },
          { "createAliasDatabases", new Node("Alias", null, null, null, "JSON") },
          { "createKeyDatabases", new Node("Key", null, null, null, null) },
          { "createNameDatabases", new Node("Name", null, null, null, "JSON") },
          { "createPathDataDatabases", new Node("PathData", null, null, null, "resource://Demo") },
          { "selectNameInSourceInDataSource", new Node("NameInSource", null, "//DataSources/*/NameInSource", null, "JSON.") },
             { "selectListPage", new Node("Page", null, "//Pages/*", null, "") },
             { "removeWatermark", new Node("Watermark", null, "//Pages/*/*", null, null) },
     { "createRelation", new Node("Relation", new List<AtrNode>(){ 
        new AtrNode("Ref","1989"),
        new AtrNode("type","DataRelation"),
        new AtrNode("isKey","true")
     }, null, null, null) },
     { "createAliasInRelation", new Node("Alias", null, null, null, "Relation") },
     { "createChildColumnsInRelation", new Node("ChildColumns", new List<AtrNode>(){ 
        new AtrNode("isList","true"),
        new AtrNode("count","1")
     }, null, null, null) },
     { "createValueInRelation", new Node("value", null, null, null, "ParentId") },
     { "createChildSourceInRelation", new Node("ChildSource", null, null, null, null) },
     { "createDictionaryInRelation", new Node("Dictionary", null, null, null, null) },
     { "createNameInRelation", new Node("Name", null, null, null, "Relation") },
     { "createNameInSourceInRelation", new Node("NameInSource", null, null, null, "Relation") },
     { "createParentColumnsInRelation", new Node("ParentColumns", new List<AtrNode>(){ 
        new AtrNode("isList","true"),
        new AtrNode("count","1")
     }, null, null, null) },
     { "createValueInParentColumnsRelation", new Node("value", null, null, null, "Id") },
     { "createParentSourceInRelation", new Node("ParentSource", null, null, null, null) },
     { "removeWatermark", new Node("Watermark", null, null, null, null) }
        };
    }
}
