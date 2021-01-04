using NhacViecWinform.DAO;
using NhacViecWinform.DTO;
using System;
using System.Data;

namespace NhacViecWinform.BUS
{
    internal class TonDongBUS
    {
        private TonDongDAO TonDongDAO = new TonDongDAO();

        public object LayDanhSachTrungTamBUS()
        {
            return TonDongDAO.LayDanhSachTrungTamDAO();
        }

        public object LayDanhSachTonDongBUS()
        {
            return TonDongDAO.LayDanhSachTonDongDAO();
        }

        public TonDongDTO LayDanhSachTonDongChiTietBUS()
        {
            TonDongDTO TonDongDTO = new TonDongDTO();

            DataTable dataTable = new DataTable();
            dataTable = TonDongDAO.LayDanhSachTonDongChiTietDAO(BienToanCuc.tondong_id);
            foreach (DataRow dr in dataTable.Rows)
            {
                TonDongDTO.Id = Int32.Parse(dr["tondong_id"].ToString());
                TonDongDTO.Trungtam_id = int.Parse(dr["trungtam_id"].ToString());
                TonDongDTO.Tenkho = dr["tenkho"].ToString();
                TonDongDTO.Ngayhoso = DateTime.Parse(dr["ngayhoso"].ToString());
                TonDongDTO.Tenvacxin = dr["tenvacxin"].ToString();
                TonDongDTO.Nguyennhan = dr["nguyennhan"].ToString();
                TonDongDTO.Nguoitao_id = int.Parse(dr["nguoitao_id"].ToString());
                byte hoantat = 0;
                string dhoantat = dr["hoantat"].ToString();
                if (bool.Parse(dhoantat) == true)
                {
                    hoantat = 1;
                }
                TonDongDTO.Hoantat = hoantat;
                TonDongDTO.Hoso_id = int.Parse(dr["hoso_id"].ToString());
            }
            return TonDongDTO;
        }

        public object ThemTonDongBUS(int trungtam_id, string tenkho, string ngayhoso, string tenvacxin, string nguyennhan, byte hoantat, int hoso_id, int nguoitao_id)
        {
            TonDongDTO TonDongDTO = new TonDongDTO();

            TonDongDTO.Trungtam_id = trungtam_id;
            TonDongDTO.Tenkho = tenkho;
            TonDongDTO.Tenvacxin = tenvacxin;
            TonDongDTO.Nguyennhan = nguyennhan;
            TonDongDTO.Hoantat = hoantat;
            TonDongDTO.Hoso_id = hoso_id;
            TonDongDTO.Nguoitao_id = nguoitao_id;

            return TonDongDAO.ThemTonDongDAO(TonDongDTO.Trungtam_id, TonDongDTO.Tenkho, ngayhoso, TonDongDTO.Tenvacxin, TonDongDTO.Nguyennhan, TonDongDTO.Hoantat, TonDongDTO.Hoso_id, TonDongDTO.Nguoitao_id);
        }

        public object SuaTonDongBUS(int tondong_id, int trungtam_id, string tenkho, string ngayhoso, string tenvacxin, string nguyennhan, byte hoantat, int hoso_id, int nguoisua_id)
        {
            TonDongDTO TonDongDTO = new TonDongDTO();

            TonDongDTO.Id = tondong_id;
            TonDongDTO.Trungtam_id = trungtam_id;
            TonDongDTO.Tenkho = tenkho;
            TonDongDTO.Tenvacxin = tenvacxin;
            TonDongDTO.Nguyennhan = nguyennhan;
            TonDongDTO.Hoantat = hoantat;
            TonDongDTO.Hoso_id = hoso_id;
            TonDongDTO.Nguoitao_id = nguoisua_id;

            return TonDongDAO.SuaTonDongDAO(TonDongDTO.Id, TonDongDTO.Trungtam_id, TonDongDTO.Tenkho, ngayhoso, TonDongDTO.Tenvacxin, TonDongDTO.Nguyennhan, TonDongDTO.Hoantat, TonDongDTO.Hoso_id, TonDongDTO.Nguoitao_id);
        }
    }
}