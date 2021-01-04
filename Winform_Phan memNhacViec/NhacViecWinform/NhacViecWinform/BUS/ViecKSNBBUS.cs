using NhacViecWinform.DAO;
using NhacViecWinform.DTO;
using System;
using System.Data;

namespace NhacViecWinform.BUS
{
    internal class ViecKSNBBUS
    {
        private ViecKSNBDAO ViecKSNBDAO = new ViecKSNBDAO();
        private ViecKSNBDTO ViecKSNBDTO = new ViecKSNBDTO();
        DataTable dataTable = new DataTable();

        public object LayDanhSachTrungTamBUS()
        {
            return ViecKSNBDAO.LayDanhSachTrungTamDAO();
        }

        public object ThemDanhSachTrungTamBUS(string phutrach, int trungtam_id, int taikhoan_phutrach_id)
        {
            ViecKSNBDTO.Phutrach = phutrach;
            ViecKSNBDTO.Trungtam_id = trungtam_id;
            ViecKSNBDTO.Taikhoan_phutrach_id = taikhoan_phutrach_id;

            return ViecKSNBDAO.ThemDanhSachTrungTamDAO(ViecKSNBDTO.Phutrach, ViecKSNBDTO.Trungtam_id, ViecKSNBDTO.Taikhoan_phutrach_id);
        }

        public DataTable LayDanhSachPhuTrachTrungTamBUS()
        {
            return ViecKSNBDAO.LayDanhSachPhuTrachTrungTamDAO();
        }

        public object CapNhatPhuTrachTrungTamBUS(string phutrach, int trungtam_id, int taikhoan_phutrach_id)
        {
            
            ViecKSNBDTO.Phutrach = phutrach;
            ViecKSNBDTO.Trungtam_id = trungtam_id;
            ViecKSNBDTO.Taikhoan_phutrach_id = taikhoan_phutrach_id;

            return ViecKSNBDAO.CapNhatPhuTrachTrungTamDAO(ViecKSNBDTO.Phutrach, ViecKSNBDTO.Trungtam_id, ViecKSNBDTO.Taikhoan_phutrach_id);
        }
        public void XoaPhuTrachTrungTamBUS(int trungtam_id, int taikhoan_phutrach_id)
        {
            ViecKSNBDTO.Trungtam_id = trungtam_id;
            ViecKSNBDTO.Taikhoan_phutrach_id = taikhoan_phutrach_id;
            ViecKSNBDAO.XoaPhuTrachTrungTamDAO(ViecKSNBDTO.Trungtam_id, ViecKSNBDTO.Taikhoan_phutrach_id);
        }

        public string KiemTraDanhSachTrungTrungTamBUS(int trungtam_id, int taikhoan_phutrach_id)
        {
            ViecKSNBDTO.Trungtam_id = trungtam_id;
            ViecKSNBDTO.Taikhoan_phutrach_id = taikhoan_phutrach_id;

            return ViecKSNBDAO.KiemTraDanhSachTrungTrungTamDAO(ViecKSNBDTO.Trungtam_id, ViecKSNBDTO.Taikhoan_phutrach_id);
        }

        public string KiemTraDanhSachTrungTrungTamVaPhuTrachBUS(string phutrach, int trungtam_id)
        {
            ViecKSNBDTO.Phutrach = phutrach;
            ViecKSNBDTO.Trungtam_id = trungtam_id;

            return ViecKSNBDAO.KiemTraDanhSachTrungTrungTamVaPhuTrachDAO(ViecKSNBDTO.Phutrach, ViecKSNBDTO.Trungtam_id);
        }

        public object LayTrungTamBUS(string ngaytao)
        {
            ViecKSNBDTO.Ngaytao = ngaytao;

            return ViecKSNBDAO.LayTrungTamDAO(ViecKSNBDTO.Ngaytao, BienToanCuc.UserID);
        }

        public object LayLichSuTrungTamPhuTrachBUS(string ngaytao)
        {
            ViecKSNBDTO.Ngaytao = ngaytao;

            return ViecKSNBDAO.LayLichSuTrungTamPhuTrachDAO(ViecKSNBDTO.Ngaytao, BienToanCuc.UserID);
        }

        public object LayCongViecNgayCuBUS(string ngaytao)
        {
            ViecKSNBDTO.Ngaytao = ngaytao;

            return ViecKSNBDAO.LayCongViecNgayCuDAO(ViecKSNBDTO.Ngaytao, BienToanCuc.UserID);
        }

        public ViecKSNBDTO HienThiPhuTrach(string ngaytao)
        {
            dataTable = ViecKSNBDAO.LayTrungTamDAO(ngaytao, BienToanCuc.UserID);
            foreach (DataRow dr in dataTable.Rows)
            {
                ViecKSNBDTO.Id = Int32.Parse(dr["id"].ToString());
                ViecKSNBDTO.Trungtam = dr["ten"].ToString();
                ViecKSNBDTO.Phutrach = dr["phutrach"].ToString();
                ViecKSNBDTO.Phutrach_id = Int32.Parse(dr["phutrach_id"].ToString());
            }
            return ViecKSNBDTO;
        }

        public void TaoCongViecHangNgayBUS(string baocaonxt, string hosocxlksnb, string phieuchuyenkhoqas, string phieuhuyqas, string hosohuy, string baocaosailech, string ngaytao, int phutrach_id)
        {
            ViecKSNBDTO.Baocaonxt = baocaonxt;
            ViecKSNBDTO.Hosocxlksnb = hosocxlksnb;
            ViecKSNBDTO.Phieuchuyenkhoqas = phieuchuyenkhoqas;
            ViecKSNBDTO.Phieuhuyqas = phieuhuyqas;
            ViecKSNBDTO.Hosohuy = hosohuy;
            ViecKSNBDTO.Baocaosailech = baocaosailech;
            ViecKSNBDTO.Ngaytao = ngaytao;
            ViecKSNBDTO.Phutrach_id = phutrach_id;
            if (string.IsNullOrEmpty(ViecKSNBDAO.KiemTraPhuTrach(ViecKSNBDTO.Phutrach_id, BienToanCuc.UserID)))
            {
                return;
            }
            else
            {
                string phutrach = ViecKSNBDAO.KiemTraPhuTrach(ViecKSNBDTO.Phutrach_id, BienToanCuc.UserID);
                if (phutrach == BienToanCuc.phutrach_khong)
                {
                    return;
                }
                else if (phutrach == BienToanCuc.phutrach_baocaohuy)
                {
                    if (ViecKSNBDTO.Hosocxlksnb == "" && ViecKSNBDTO.Phieuchuyenkhoqas == "" && ViecKSNBDTO.Baocaosailech == "")
                    {
                        if (string.IsNullOrEmpty(ViecKSNBDAO.KiemTraTonTaiNgayTao(ViecKSNBDTO.Ngaytao, ViecKSNBDTO.Phutrach_id)))
                        {
                            ViecKSNBDAO.TaoCongViecHangNgayDAO(ViecKSNBDTO.Baocaonxt, ViecKSNBDTO.Hosocxlksnb, ViecKSNBDTO.Phieuchuyenkhoqas, ViecKSNBDTO.Phieuhuyqas, ViecKSNBDTO.Hosohuy, ViecKSNBDTO.Baocaosailech, ViecKSNBDTO.Ngaytao, ViecKSNBDTO.Phutrach_id);
                        }
                        else
                        {
                            ViecKSNBDAO.CapNhatCongViecHangNgayDAO(ViecKSNBDTO.Baocaonxt, ViecKSNBDTO.Hosocxlksnb, ViecKSNBDTO.Phieuchuyenkhoqas, ViecKSNBDTO.Phieuhuyqas, ViecKSNBDTO.Hosohuy, ViecKSNBDTO.Baocaosailech, ViecKSNBDTO.Ngaytao, ViecKSNBDTO.Phutrach_id);
                        }
                    }
                }
                else if (phutrach == BienToanCuc.phutrach_baocaosailech)
                {
                    if (ViecKSNBDTO.Hosohuy == "" && ViecKSNBDTO.Phieuhuyqas == "")
                    {
                        if (string.IsNullOrEmpty(ViecKSNBDAO.KiemTraTonTaiNgayTao(ViecKSNBDTO.Ngaytao, ViecKSNBDTO.Phutrach_id)))
                        {
                            ViecKSNBDAO.TaoCongViecHangNgayDAO(ViecKSNBDTO.Baocaonxt, ViecKSNBDTO.Hosocxlksnb, ViecKSNBDTO.Phieuchuyenkhoqas, ViecKSNBDTO.Phieuhuyqas, ViecKSNBDTO.Hosohuy, ViecKSNBDTO.Baocaosailech, ViecKSNBDTO.Ngaytao, ViecKSNBDTO.Phutrach_id);
                        }
                        else
                        {
                            ViecKSNBDAO.CapNhatCongViecHangNgayDAO(ViecKSNBDTO.Baocaonxt, ViecKSNBDTO.Hosocxlksnb, ViecKSNBDTO.Phieuchuyenkhoqas, ViecKSNBDTO.Phieuhuyqas, ViecKSNBDTO.Hosohuy, ViecKSNBDTO.Baocaosailech, ViecKSNBDTO.Ngaytao, ViecKSNBDTO.Phutrach_id);
                        }
                    }
                }
                else if (phutrach == BienToanCuc.phutrach_tatca)
                {
                    if (string.IsNullOrEmpty(ViecKSNBDAO.KiemTraTonTaiNgayTao(ViecKSNBDTO.Ngaytao, ViecKSNBDTO.Phutrach_id)))
                    {
                        ViecKSNBDAO.TaoCongViecHangNgayDAO(ViecKSNBDTO.Baocaonxt, ViecKSNBDTO.Hosocxlksnb, ViecKSNBDTO.Phieuchuyenkhoqas, ViecKSNBDTO.Phieuhuyqas, ViecKSNBDTO.Hosohuy, ViecKSNBDTO.Baocaosailech, ViecKSNBDTO.Ngaytao, ViecKSNBDTO.Phutrach_id);
                    }
                    else
                    {
                        ViecKSNBDAO.CapNhatCongViecHangNgayDAO(ViecKSNBDTO.Baocaonxt, ViecKSNBDTO.Hosocxlksnb, ViecKSNBDTO.Phieuchuyenkhoqas, ViecKSNBDTO.Phieuhuyqas, ViecKSNBDTO.Hosohuy, ViecKSNBDTO.Baocaosailech, ViecKSNBDTO.Ngaytao, ViecKSNBDTO.Phutrach_id);
                    }
                }
            }
        }
    }
}