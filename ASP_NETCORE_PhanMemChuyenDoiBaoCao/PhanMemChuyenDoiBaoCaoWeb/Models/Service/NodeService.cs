using PhanMemChuyenDoiBaoCaoWeb.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace PhanMemChuyenDoiBaoCaoWeb.Models.Service
{
    interface NodeService
    {
        public void DocThamSoGoc(Dictionary<string, string> variables, XmlDocument rootMaster);
        public void DoiTenTruongCoDinh(string pathToFile, XmlDocument root);
        public void DoiThamSo(string pathToFile, XmlDocument root, XmlDocument rootMaster, Dictionary<string, string> variables, XmlNode variablesMaster);
        public void DoiNhom(string pathToFile, XmlDocument root);
        public void ThemLienKetBang(string pathToFile, XmlDocument root);
        public void ThemTheDuLieu(string pathToFile, XmlDocument root);
        public void SuaWatermark(string pathToFile, XmlDocument root);
        public void SuaDatasource(string pathToFile, XmlDocument root);
        public XmlDocument OpenFile(string filepath);
        public bool SaveFile(XmlDocument root, string filepath);
    }
}
