using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhanMemChuyenDoiBaoCaoWeb.Models.Entity
{
    public class Modules
    {
        private string inputFileEdit;
        private string inputFileMaster;
        private bool doiTenTruongCoDinh;
        private bool capNhatThamSo;
        private bool doiNhom;
        private bool themLienKetBang;
        private bool themTheDuLieu;
        private bool suaWatermark;
        private bool suaDatasource;
        public bool DoiTenTruongCoDinh { get => doiTenTruongCoDinh; set => doiTenTruongCoDinh = value; }
        public bool CapNhatThamSo { get => capNhatThamSo; set => capNhatThamSo = value; }
        public bool DoiNhom { get => doiNhom; set => doiNhom = value; }
        public bool ThemLienKetBang { get => themLienKetBang; set => themLienKetBang = value; }
        public bool ThemTheDuLieu { get => themTheDuLieu; set => themTheDuLieu = value; }
        public bool SuaWatermark { get => suaWatermark; set => suaWatermark = value; }
        public bool SuaDatasource { get => suaDatasource; set => suaDatasource = value; }
        public string InputFileMaster { get => inputFileMaster; set => inputFileMaster = value; }
        public string InputFileEdit { get => inputFileEdit; set => inputFileEdit = value; }
    }
}
