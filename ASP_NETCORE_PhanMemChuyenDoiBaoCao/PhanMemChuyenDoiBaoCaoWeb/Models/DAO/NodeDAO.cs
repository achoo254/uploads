using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace PhanMemChuyenDoiBaoCaoWeb.Models.DAO
{
    interface NodeDAO
    {
        public XmlDocument OpenFile(string filepath);
        public bool SaveFile(XmlDocument root, string filepath);
        public void EditNode(XmlNode current, Node obj);
        public void EditAttribute(XmlNode current, Node obj);
        public bool FindValue(XmlNode current, Node obj);
        public bool FindAttribute(XmlNode current, Node obj);
        public void AddNode(XmlNode current, Node obj);
        public void RemoveNode(XmlNode current);

        public void MoveNode(XmlNode current, XmlNode move);
    }
}
