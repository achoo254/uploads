using MySql.Data.MySqlClient;
using NhacViecWinform.DAL;
using System;
using System.Data;

namespace NhacViecWinform.DAO
{
    internal class TodolistDAO
    {
        private dbConnectionMySQL conn = new dbConnectionMySQL();

        public void CreateTodolistDAO(int workflow_id, string lydo, byte trangthai)
        {
            string query = string.Format("insert into todolist (workflow_id, ngay_batdau, ngay_hethan, ngay_hoanthanh, lydo, trangthai)" +
                "select id, ngay_batdau, ngay_hethan, now(), @lydo, @trangthai from workflow where id = @workflow_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[3];
            MySqlParameters[0] = new MySqlParameter("@workflow_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(workflow_id);
            MySqlParameters[1] = new MySqlParameter("@trangthai", MySqlDbType.Byte);
            MySqlParameters[1].Value = Convert.ToByte(trangthai);
            MySqlParameters[2] = new MySqlParameter("@lydo", MySqlDbType.Text);
            MySqlParameters[2].Value = Convert.ToString(lydo);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public void UpdateSuccessTodolistDAO(int workflow_id, byte trangthai)
        {
            string query = string.Format("update todolist set trangthai = @trangthai where workflow_id = @workflow_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@workflow_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(workflow_id);
            MySqlParameters[1] = new MySqlParameter("@trangthai", MySqlDbType.Byte);
            MySqlParameters[1].Value = Convert.ToByte(trangthai);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public void UpdateFailTodolistDAO(int todolist_id, int workflow_id, byte trangthai)
        {
            string query = string.Format("update todolist set trangthai = @trangthai where workflow_id = @workflow_id and id = @todolist_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[3];
            MySqlParameters[0] = new MySqlParameter("@workflow_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(workflow_id);
            MySqlParameters[1] = new MySqlParameter("@trangthai", MySqlDbType.Byte);
            MySqlParameters[1].Value = Convert.ToByte(trangthai);
            MySqlParameters[2] = new MySqlParameter("@todolist_id", MySqlDbType.Int32);
            MySqlParameters[2].Value = Convert.ToString(todolist_id);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        public DataTable GetTodolistDetailsDAO(int todolist_id)
        {
            string query = string.Format("select * from todolist where id = @todolist_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@todolist_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(todolist_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }
    }
}