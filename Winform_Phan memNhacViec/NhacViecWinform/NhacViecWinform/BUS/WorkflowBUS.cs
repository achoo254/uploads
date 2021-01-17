using NhacViecWinform.DAO;
using NhacViecWinform.DTO;
using System;
using System.Data;

namespace NhacViecWinform.BUS
{
    internal class WorkflowBUS
    {
        public void CreateWorkflowBUS(string name, string details, string date_create,
            string date_start, string date_reminder, int user_create_id, int user_recipent_id, byte active, int category_id, int date_count, byte loop, int positon)
        {
            WorkflowDAO WorkflowDAO = new WorkflowDAO();
            WorkflowDTO WorkflowDTO = new WorkflowDTO();

            WorkflowDTO.Name = name;
            WorkflowDTO.Details = details;

            WorkflowDTO.User_create_id = user_create_id;
            WorkflowDTO.User_recipent_id = user_recipent_id;

            WorkflowDTO.Category_id = category_id;
            WorkflowDTO.Date_count = date_count;

            WorkflowDTO.Positon = positon;
            WorkflowDAO.CreateWorkflowDAO(WorkflowDTO.Name, WorkflowDTO.Details, date_create,
                date_start, date_reminder,
                WorkflowDTO.User_create_id, WorkflowDTO.User_recipent_id, active, WorkflowDTO.Category_id, WorkflowDTO.Date_count, loop, WorkflowDTO.Positon);
        }

        public object HienThiGiaoViecDangThucHienBUS(int user_create_id, byte active)
        {
            WorkflowDAO WorkflowDAO = new WorkflowDAO();
            WorkflowDTO WorkflowDTO = new WorkflowDTO();

            WorkflowDTO.User_create_id = user_create_id;

            return WorkflowDAO.HienThiGiaoViecDangThucHienDAO(WorkflowDTO.User_create_id, active);
        }

        public object HienThiGiaoViecDaThucHienBUS(int user_create_id, byte active)
        {
            WorkflowDAO WorkflowDAO = new WorkflowDAO();
            WorkflowDTO WorkflowDTO = new WorkflowDTO();

            WorkflowDTO.User_create_id = user_create_id;

            return WorkflowDAO.HienThiGiaoViecDaThucHienDAO(WorkflowDTO.User_create_id, active);
        }

        public object HienThiNhanViecDaThucHienBUS(int user_recipent_id)
        {
            WorkflowDAO WorkflowDAO = new WorkflowDAO();
            WorkflowDTO WorkflowDTO = new WorkflowDTO();

            WorkflowDTO.User_recipent_id = user_recipent_id;
            return WorkflowDAO.HienThiNhanViecDaThucHienDAO(WorkflowDTO.User_recipent_id);
        }

        public object HienThiNhanViecDangThucHienBUS(int user_recipent_id, byte active)
        {
            WorkflowDAO WorkflowDAO = new WorkflowDAO();
            WorkflowDTO WorkflowDTO = new WorkflowDTO();

            WorkflowDTO.User_recipent_id = user_recipent_id;

            return WorkflowDAO.HienThiNhanViecDangThucHienDAO(WorkflowDTO.User_recipent_id, active);
        }

        public WorkflowDTO HienThiGiaoViecDangThucHienCTBUS()
        {
            WorkflowDAO WorkflowDAO = new WorkflowDAO();
            WorkflowDTO WorkflowDTO = new WorkflowDTO();
            Console.WriteLine(BienToanCuc.workflow_id);
            DataTable dataTable = new DataTable();
            dataTable = WorkflowDAO.HienThiGiaoViecDangThucHienCTDAO(BienToanCuc.workflow_id);
            foreach (DataRow dr in dataTable.Rows)
            {
                WorkflowDTO.WorkflowID = Int32.Parse(dr["id"].ToString());
                WorkflowDTO.Name = dr["ten"].ToString();
                WorkflowDTO.Details = dr["chitiet"].ToString();
                WorkflowDTO.User_recipent_id = Int32.Parse(dr["user_nhan_id"].ToString());
                WorkflowDTO.Category_id = Int32.Parse(dr["category_id"].ToString());
                WorkflowDTO.Date_create = DateTime.Parse(dr["ngay_tao"].ToString());
                WorkflowDTO.Date_start = DateTime.Parse(dr["ngay_batdau"].ToString());
                WorkflowDTO.Date_reminder = DateTime.Parse(dr["ngay_hethan"].ToString());
            }
            return WorkflowDTO;
        }

        public WorkflowDTO HienThiGiaoViecDaThucHienCTBUS()
        {
            WorkflowDAO WorkflowDAO = new WorkflowDAO();
            WorkflowDTO WorkflowDTO = new WorkflowDTO();

            DataTable dataTable = new DataTable();
            dataTable = WorkflowDAO.HienThiGiaoViecDaThucHienCTDAO(BienToanCuc.workflow_id);
            foreach (DataRow dr in dataTable.Rows)
            {
                WorkflowDTO.WorkflowID = Int32.Parse(dr["id"].ToString());
                WorkflowDTO.Name = dr["ten"].ToString();
                WorkflowDTO.Details = dr["chitiet"].ToString();
                WorkflowDTO.User_recipent_id = Int32.Parse(dr["user_nhan_id"].ToString());
                WorkflowDTO.Category_id = Int32.Parse(dr["category_id"].ToString());
                WorkflowDTO.Date_create = DateTime.Parse(dr["ngay_tao"].ToString());
                WorkflowDTO.Date_start = DateTime.Parse(dr["ngay_batdau"].ToString());
                WorkflowDTO.Date_reminder = DateTime.Parse(dr["ngay_hethan"].ToString());
            }
            return WorkflowDTO;
        }

        public WorkflowDTO HienThiNhanViecDangThucHienCTBUS()
        {
            WorkflowDAO WorkflowDAO = new WorkflowDAO();
            WorkflowDTO WorkflowDTO = new WorkflowDTO();

            DataTable dataTable = new DataTable();
            dataTable = WorkflowDAO.HienThiNhanViecDangThucHienCTDAO(BienToanCuc.workflow_id);
            foreach (DataRow dr in dataTable.Rows)
            {
                WorkflowDTO.WorkflowID = Int32.Parse(dr["id"].ToString());
                WorkflowDTO.Name = dr["ten"].ToString();
                WorkflowDTO.Details = dr["chitiet"].ToString();
                WorkflowDTO.User_create_id = Int32.Parse(dr["user_gui_id"].ToString());
                WorkflowDTO.Category_id = Int32.Parse(dr["category_id"].ToString());
                WorkflowDTO.Date_create = DateTime.Parse(dr["ngay_tao"].ToString());
                WorkflowDTO.Date_start = DateTime.Parse(dr["ngay_batdau"].ToString());
                WorkflowDTO.Date_reminder = DateTime.Parse(dr["ngay_hethan"].ToString());
            }
            return WorkflowDTO;
        }

        public WorkflowDTO HienThiNhanViecDaThucHienCTBUS()
        {
            WorkflowDAO WorkflowDAO = new WorkflowDAO();
            WorkflowDTO WorkflowDTO = new WorkflowDTO();

            DataTable dataTable = new DataTable();
            dataTable = WorkflowDAO.HienThiNhanViecDaThucHienCTDAO(BienToanCuc.todolist_id);
            foreach (DataRow dr in dataTable.Rows)
            {
                WorkflowDTO.Name = dr["ten"].ToString();
                WorkflowDTO.Details = dr["chitiet"].ToString();
                WorkflowDTO.User_create_id = Int32.Parse(dr["user_gui_id"].ToString());
                WorkflowDTO.Category_id = Int32.Parse(dr["category_id"].ToString());
                WorkflowDTO.Date_create = DateTime.Parse(dr["ngay_tao"].ToString());
            }
            return WorkflowDTO;
        }

        public void UpdateSuccessWorkflowBUS(int workflow_id, string details, byte active)
        {
            WorkflowDAO WorkflowDAO = new WorkflowDAO();
            WorkflowDTO WorkflowDTO = new WorkflowDTO();

            WorkflowDTO.WorkflowID = workflow_id;

            WorkflowDTO.Details = details;
            WorkflowDAO.UpdateSuccessWorkflowDAO(WorkflowDTO.WorkflowID, WorkflowDTO.Details, active);
        }

        public DataTable SelectTimeReminderBUS()
        {
            WorkflowDAO WorkflowDAO = new WorkflowDAO();
            WorkflowDTO WorkflowDTO = new WorkflowDTO();
            byte active = 1;

            DataTable dataTable = new DataTable();
            dataTable = WorkflowDAO.SelectTimeReminderDAO(BienToanCuc.UserID, active);
            foreach (DataRow dr in dataTable.Rows)
            {
                WorkflowDTO.WorkflowID = Int32.Parse(dr["id"].ToString());
                WorkflowDTO.Name = dr["ten"].ToString();
                WorkflowDTO.Date_reminder = DateTime.Parse(dr["ngay_hethan"].ToString());
                WorkflowDTO.Loop = bool.Parse(dr["vonglap"].ToString());
            }
            return dataTable;
        }

        public void UpdateLoopWorkflowBUS()
        {
            WorkflowDAO WorkflowDAO = new WorkflowDAO();

            byte active = 1;
            byte loop = 1;
            WorkflowDAO.UpdateLoopWorkflowDAO(active, loop);
        }

        public void DeleteWorkflowBUS(int workflow_id)
        {
            WorkflowDAO WorkflowDAO = new WorkflowDAO();
            WorkflowDTO WorkflowDTO = new WorkflowDTO();

            WorkflowDTO.WorkflowID = workflow_id;
            WorkflowDAO.DeleteWorkflowDAO(WorkflowDTO.WorkflowID);
        }

        public int LaySoThuTuCaoNhatBUS(int user_create_id)
        {
            WorkflowDAO WorkflowDAO = new WorkflowDAO();
            return WorkflowDAO.LaySoThuTuCaoNhatDAO(user_create_id);
        }
    }
}