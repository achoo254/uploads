using NhacViecWinform.DAO;
using NhacViecWinform.DTO;
using System;
using System.Data;

namespace NhacViecWinform.BUS
{
    internal class TodolistBUS
    {
        public void CreateTodolistBUS(int workflow_id, string reason, byte status)
        {
            TodolistDAO TodolistDAO = new TodolistDAO();
            TodolistDTO TodolistDTO = new TodolistDTO();

            TodolistDTO.Workflow_id = workflow_id;

            TodolistDTO.Reason = reason;

            TodolistDAO.CreateTodolistDAO(TodolistDTO.Workflow_id, TodolistDTO.Reason, status);
        }

        public void UpdateSuccessTodolistBUS(int workflow_id, byte status)
        {
            TodolistDAO TodolistDAO = new TodolistDAO();
            TodolistDTO TodolistDTO = new TodolistDTO();

            TodolistDTO.Workflow_id = workflow_id;

            TodolistDAO.UpdateSuccessTodolistDAO(TodolistDTO.Workflow_id, status);
        }

        public void UpdateFailTodolistBUS(int todolist_id, int workflow_id, byte status)
        {
            TodolistDAO TodolistDAO = new TodolistDAO();
            TodolistDTO TodolistDTO = new TodolistDTO();

            TodolistDTO.Workflow_id = workflow_id;

            TodolistDTO.Id = todolist_id;
            TodolistDAO.UpdateFailTodolistDAO(TodolistDTO.Id, TodolistDTO.Workflow_id, status);
        }

        public TodolistDTO GetTodolistDetailsBUS()
        {
            TodolistDAO TodolistDAO = new TodolistDAO();
            TodolistDTO TodolistDTO = new TodolistDTO();

            DataTable dataTable = new DataTable();
            dataTable = TodolistDAO.GetTodolistDetailsDAO(BienToanCuc.todolist_id);
            foreach (DataRow dr in dataTable.Rows)
            {
                TodolistDTO.Id = Int32.Parse(dr["id"].ToString());
                TodolistDTO.Reason = dr["lydo"].ToString();

                TodolistDTO.Status = bool.Parse(dr["trangthai"].ToString());
                TodolistDTO.Date_start = DateTime.Parse(dr["ngay_batdau"].ToString());
                TodolistDTO.Date_reminder = DateTime.Parse(dr["ngay_hethan"].ToString());
                TodolistDTO.Date_success = DateTime.Parse(dr["ngay_hoanthanh"].ToString());
            }
            return TodolistDTO;
        }
    }
}