using PhanMemChuyenDoiBaoCaoWeb.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace PhanMemChuyenDoiBaoCaoWeb.Models
{
    public class Node
    {

        private string name;
        private string path;
        private string oldValue;
        private string newValue;
        private List<AtrNode> listAttr;

        public Node(string name, List<AtrNode> listAttr, string path, string oldValue, string newValue)
        {
            Name = name;
            ListAttr = listAttr;
            Path = path;
            OldValue = oldValue;
            NewValue = newValue;
        }

        public string Name { get => name; set => name = value; }
        public string Path { get => path; set => path = value; }
        public string OldValue { get => oldValue; set => oldValue = value; }
        public string NewValue { get => newValue; set => newValue = value; }
        public List<AtrNode> ListAttr { get => listAttr; set => listAttr = value; }
    }
}
