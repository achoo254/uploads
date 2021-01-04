using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhanMemChuyenDoiBaoCaoWeb.Models.Entity
{
    public class AtrNode
    {
        private string name;
        private string value;

        public AtrNode(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get => name; set => name = value; }
        public string Value { get => value; set => this.value = value; }
    }
}
