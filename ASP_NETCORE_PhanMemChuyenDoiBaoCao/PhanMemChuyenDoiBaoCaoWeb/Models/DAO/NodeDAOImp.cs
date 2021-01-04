using PhanMemChuyenDoiBaoCaoWeb.Models.Entity;
using PhanMemChuyenDoiBaoCaoWeb.Models.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace PhanMemChuyenDoiBaoCaoWeb.Models.DAO
{
    public class NodeDAOImp : NodeDAO
    {
        public XmlDocument OpenFile(string filepath)
        {
            XmlDocument root = new XmlDocument();
            if (File.Exists(filepath))
            {
                root.Load(filepath);
            }
            return root;
        }

        public bool SaveFile(XmlDocument root, string filepath)
        {
            bool check = false;
            if (File.Exists(filepath))
            {
                root.Save(filepath);
                check = true;
            }
            return check;
        }

        public void EditNode(XmlNode current, Node obj)
        {
            XmlNodeList listNode = current.SelectNodes(obj.Path);
            foreach(XmlNode node in listNode)
            {
                if(node.InnerText == obj.OldValue)
                {
                    node.InnerText = obj.NewValue;
                }
            }
        }
        public void EditAttribute(XmlNode current, Node obj)
        {
            if (obj.ListAttr != null && current.Attributes != null)
            {
                foreach (XmlAttribute attr in current.Attributes)
                {
                    foreach (var item in obj.ListAttr)
                    {
                        if (attr.Name == item.Name && attr.Value == item.Value)
                        {
                            attr.Value = obj.NewValue;
                        }
                    }
                }
            }
        }
        public bool FindValue(XmlNode current, Node obj)
        {
            bool check = false;
            XmlNodeList listNode = current.SelectNodes(obj.Path);
            foreach (XmlNode node in listNode)
            {
                if (node.InnerText == obj.OldValue)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        public bool FindAttribute(XmlNode current, Node obj)
        {
            bool check = false;
            if(current.Attributes != null)
            {
                foreach(XmlAttribute item in current.Attributes)
                {
                    if(item.Value.Equals(obj.OldValue))
                    {
                        check = true;
                        break;
                    }
                }
            }
            return check;
        }

        public void AddNode(XmlNode current, Node obj)
        {
            XmlElement element = current.OwnerDocument.CreateElement(obj.Name);
            element.InnerText = obj.NewValue;
            if (obj.ListAttr != null)
            {
                foreach(var item in obj.ListAttr)
                {
                    element.SetAttribute(item.Name, item.Value);
                }
            }
            current.AppendChild(element);
        }

        public void RemoveNode(XmlNode current)
        {
            if (current.HasChildNodes)
            {
                foreach(XmlNode item in current.ChildNodes)
                {
                    current.RemoveChild(item);
                }
            }
            else
            {
                current.ParentNode.RemoveChild(current);
            }
        }

        public void MoveNode(XmlNode current, XmlNode move)
        {
            current.AppendChild(move);
        }
    }
}
