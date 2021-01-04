using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhanMemChuyenDoiBaoCaoWeb.Models;
using PhanMemChuyenDoiBaoCaoWeb.Models.DAO;
using PhanMemChuyenDoiBaoCaoWeb.Models.Entity;
using PhanMemChuyenDoiBaoCaoWeb.Models.Service;
using PhanMemChuyenDoiBaoCaoWeb.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace PhanMemChuyenDoiBaoCaoWeb.Controllers
{
    public class NodeController : Controller
    {
        // GET: NodeController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DoiGiaTriTrongThe()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CapNhatDuLieuThe(string inputFileEdit, string InputFileMaster)
        {
            Modules modules = new Modules();
            modules.InputFileEdit = inputFileEdit;
            modules.InputFileMaster = InputFileMaster;
            return View(modules);
        }

        // POST: NodeController/CapNhatDuLieuTheSubmit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CapNhatDuLieuTheSubmit(Modules modules)
        {
            try
            {
                NodeService nodeService = new NodeServiceImp();
                bool checkSaveFile = false;

                //Gọi service load file master
                XmlDocument rootMaster = nodeService.OpenFile(modules.InputFileMaster);

                //Goij service đọc tham số trong master
                Dictionary<string, string> variables = new Dictionary<string, string>();
                XmlNode variablesMaster = rootMaster.SelectSingleNode(VariableStatic.keyValues["selectNodeVariables"].Path);
                if(rootMaster.HasChildNodes)
                {
                    nodeService.DocThamSoGoc(variables, rootMaster);
                }

                foreach (var file in System.IO.Directory.GetFiles(modules.InputFileEdit))
                {
                    //Gọi service load file cần xử lý
                    XmlDocument root = nodeService.OpenFile(file);
                    //Thực hiện các chức năng
                    if(modules.DoiTenTruongCoDinh)
                    {
                        nodeService.DoiTenTruongCoDinh(file, root);
                    }
                    if(modules.CapNhatThamSo)
                    {
                        nodeService.DoiThamSo(file, root, rootMaster, variables, variablesMaster);
                    }
                    if(modules.DoiNhom)
                    {
                        nodeService.DoiNhom(file, root);
                    }
                    if(modules.ThemLienKetBang)
                    {
                        nodeService.ThemLienKetBang(file, root);
                    }
                    if(modules.ThemTheDuLieu)
                    {
                        nodeService.ThemTheDuLieu(file, root);
                    }
                    if(modules.SuaWatermark)
                    {
                        nodeService.SuaWatermark(file, root);
                    }
                    if(modules.SuaDatasource)
                    {
                        nodeService.SuaDatasource(file, root);
                    }
                    //Gọi service lưu file sau khi thực hiện các chức năng
                    checkSaveFile = nodeService.SaveFile(root, file);
                }
                if (checkSaveFile)
                {
                    return View("Index");
                }
                else
                {
                    return Content("Chưa xử lý");
                }
            }
            catch (Exception e)
            {
                return Content("Có lỗi xảy ra:\n"+ e);
            }
        }
        
    }
}
