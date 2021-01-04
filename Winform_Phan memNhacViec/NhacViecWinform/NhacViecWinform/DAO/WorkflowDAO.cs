using MySql.Data.MySqlClient;
using NhacViecWinform.DAL;
using System;
using System.Data;

namespace NhacViecWinform.DAO
{
    internal class WorkflowDAO
    {
        private dbConnectionMySQL conn = new dbConnectionMySQL();

        public void CreateWorkflowDAO(string ten, string chitiet, string ngay_tao,
            string ngay_batdau, string ngay_hethan, int user_gui_id, int user_nhan_id, byte kichhoat, int category_id, int ngay_dem, byte vonglap, int vitri)
        {
            string query = string.Format("insert into workflow (ten, chitiet, ngay_tao, ngay_batdau, ngay_hethan, user_gui_id, user_nhan_id, kichhoat, category_id, ngay_dem, vonglap, vitri) values (@ten, @chitiet, @ngay_tao, @ngay_batdau, @ngay_hethan, @user_gui_id, @user_nhan_id, @kichhoat, @category_id, @ngay_dem, @vonglap, @vitri)");
            MySqlParameter[] MySqlParameters = new MySqlParameter[12];
            MySqlParameters[0] = new MySqlParameter("@ten", MySqlDbType.VarChar);
            MySqlParameters[0].Value = Convert.ToString(ten);
            MySqlParameters[1] = new MySqlParameter("@chitiet", MySqlDbType.LongText);
            MySqlParameters[1].Value = Convert.ToString(chitiet);
            MySqlParameters[2] = new MySqlParameter("@ngay_tao", MySqlDbType.DateTime);
            MySqlParameters[2].Value = Convert.ToString(ngay_tao);
            MySqlParameters[3] = new MySqlParameter("@ngay_batdau", MySqlDbType.DateTime);
            MySqlParameters[3].Value = Convert.ToString(ngay_batdau);
            MySqlParameters[4] = new MySqlParameter("@ngay_hethan", MySqlDbType.DateTime);
            MySqlParameters[4].Value = Convert.ToString(ngay_hethan);
            MySqlParameters[5] = new MySqlParameter("@user_gui_id", MySqlDbType.Int32);
            MySqlParameters[5].Value = Convert.ToString(user_gui_id);
            MySqlParameters[6] = new MySqlParameter("@user_nhan_id", MySqlDbType.Int32);
            MySqlParameters[6].Value = Convert.ToString(user_nhan_id);
            MySqlParameters[7] = new MySqlParameter("@kichhoat", MySqlDbType.Byte);
            MySqlParameters[7].Value = Convert.ToByte(kichhoat);
            MySqlParameters[8] = new MySqlParameter("@category_id", MySqlDbType.Int32);
            MySqlParameters[8].Value = Convert.ToString(category_id);
            MySqlParameters[9] = new MySqlParameter("@ngay_dem", MySqlDbType.Int32);
            MySqlParameters[9].Value = Convert.ToString(ngay_dem);
            MySqlParameters[10] = new MySqlParameter("@vonglap", MySqlDbType.Byte);
            MySqlParameters[10].Value = Convert.ToByte(vonglap);
            MySqlParameters[11] = new MySqlParameter("@vitri", MySqlDbType.Int32);
            MySqlParameters[11].Value = Convert.ToString(vitri);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        //Lay danh sach hien thi cong viec dang thuc hien - Giao viec
        public DataTable HienThiGiaoViecDangThucHienDAO(int user_gui_id, byte kichhoat)
        {
            string query = string.Format("select wo.id as 'id', wo.vitri as 'Số thứ tự', " +
                "wo.ten as 'Tiêu đề', " +
                "ngay_batdau as 'Ngày nhắc việc', ngay_hethan as 'Ngày nhắc lại', " +
                "u.fullname as 'Người nhận', cate.ten as 'Danh mục' from workflow as wo, category as cate, " +
                "users as u where user_gui_id = @user_gui_id " +
                "and wo.category_id = cate.id " +
                "and wo.user_gui_id = u.id and wo.kichhoat = @kichhoat order by wo.vitri asc");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@user_gui_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(user_gui_id);
            MySqlParameters[1] = new MySqlParameter("@kichhoat", MySqlDbType.Byte);
            MySqlParameters[1].Value = Convert.ToByte(kichhoat);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        //Lay danh sach hien thi cong viec chi tiet dang thuc hien - Giao viec
        public DataTable HienThiGiaoViecDangThucHienCTDAO(int workflow_id)
        {
            string query = string.Format("select wo.id AS 'id', wo.ten, wo.chitiet, wo.ngay_tao, wo.ngay_batdau, wo.ngay_hethan, " +
               "user_nhan_id, category_id from workflow as wo where wo.id = @workflow_id ");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@workflow_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(workflow_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        //Lay danh sach hien thi cong viec da thuc hien - Giao viec
        public DataTable HienThiGiaoViecDaThucHienDAO(int user_gui_id, byte kichhoat)
        {
            string query = string.Format("select todo.id as 'todolist_id', wo.id as 'workflow_id', wo.vitri as 'Số thứ tự', wo.ten as 'Tiêu đề', todo.ngay_batdau as 'Ngày nhắc việc', todo.ngay_hethan as 'Ngày nhắc lại', todo.ngay_hoanthanh as 'Ngày thực hiện', " +
                "cate.ten as 'Danh mục', todo.trangthai as 'Hoàn thành' from todolist as todo inner join workflow as wo on todo.workflow_id = wo.id and wo.user_gui_id = @user_gui_id " +
                "inner join category as cate on cate.id = wo.category_id where wo.kichhoat = @kichhoat order by wo.vitri asc");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@user_gui_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(user_gui_id);
            MySqlParameters[1] = new MySqlParameter("@kichhoat", MySqlDbType.Byte);
            MySqlParameters[1].Value = Convert.ToByte(kichhoat);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        //Lay danh sach hien thi cong viec chi tiet da thuc hien chi tiet - Giao viec
        public DataTable HienThiGiaoViecDaThucHienCTDAO(int workflow_id)
        {
            string query = string.Format("select wo.id AS 'id', wo.ten, wo.chitiet, wo.ngay_tao, wo.ngay_batdau, wo.ngay_hethan, " +
                "user_nhan_id, category_id from workflow as wo where wo.id = @workflow_id ");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@workflow_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(workflow_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        //Lay danh sach hien thi cong viec dang thuc hien - Nhan viec
        public DataTable HienThiNhanViecDangThucHienDAO(int user_nhan_id, byte kichhoat)
        {
            string query = string.Format("select wo.id as 'id', wo.vitri as 'Số thứ tự', " +
                "wo.ten as 'Tiêu đề', " +
                "ngay_batdau as 'Ngày nhắc việc', ngay_hethan as 'Ngày nhắc lại', " +
                "u.fullname as 'Người giao', cate.ten as 'Danh mục' from workflow as wo, category as cate, " +
                "users as u where user_nhan_id = @user_nhan_id " +
                "and wo.category_id = cate.id " +
                "and wo.user_gui_id = u.id and wo.kichhoat = @kichhoat order by wo.vitri asc");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@user_nhan_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(user_nhan_id);
            MySqlParameters[1] = new MySqlParameter("@kichhoat", MySqlDbType.Byte);
            MySqlParameters[1].Value = Convert.ToByte(kichhoat);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        //Lay danh sach hien thi chi tiet cong viec dang thuc hien - Nhan viec
        public DataTable HienThiNhanViecDangThucHienCTDAO(int workflow_id)
        {
            string query = string.Format("select wo.id AS 'id', wo.ten, wo.chitiet, wo.ngay_tao, wo.ngay_batdau, wo.ngay_hethan, " +
                "user_gui_id, category_id from workflow as wo where wo.id = @workflow_id ");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@workflow_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(workflow_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        //Lay danh sach hien thi cong viec da thuc hien - Nhan viec
        public DataTable HienThiNhanViecDaThucHienDAO(int user_nhan_id)
        {
            string query = string.Format("select todo.id as 'id', wo.id as 'workflow_id', wo.vitri as 'Số thứ tự', wo.ten as 'Tiêu đề', todo.ngay_batdau as 'Ngày nhắc việc', todo.ngay_hethan as 'Ngày nhắc lại', todo.ngay_hoanthanh as 'Ngày hoàn thành', " +
                "u.fullname as 'Người giao', cate.ten as 'Danh mục', todo.trangthai as 'Hoàn thành' from todolist as todo inner join workflow as wo on todo.workflow_id = wo.id and wo.user_nhan_id = @user_nhan_id " +
                "inner join users as u on u.id = wo.user_gui_id " +
                "inner join category as cate on cate.id = wo.category_id order by wo.vitri asc");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@user_nhan_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(user_nhan_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        //Lay danh sach hien thi cong viec chi tiet da thuc hien chi tiet - Nhan viec
        public DataTable HienThiNhanViecDaThucHienCTDAO(int todolist_id)
        {
            string query = string.Format("select todo.id as 'id', wo.ten, wo.ngay_tao, todo.ngay_batdau, todo.ngay_hethan, todo.ngay_hoanthanh, " +
                "wo.user_gui_id, category_id, todo.trangthai, todo.lydo, wo.chitiet from todolist as todo inner join workflow as wo on todo.workflow_id = wo.id " +
                "where todo.id = @todolist_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@todolist_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(todolist_id);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        //Cap nhat cong viec da thuc hien
        public void UpdateSuccessWorkflowDAO(int workflow_id, string chitiet, byte kichhoat)
        {
            string query = string.Format("update workflow set kichhoat = @kichhoat, chitiet = @chitiet where id = @workflow_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[3];
            MySqlParameters[0] = new MySqlParameter("@workflow_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(workflow_id);
            MySqlParameters[1] = new MySqlParameter("@kichhoat", MySqlDbType.Byte);
            MySqlParameters[1].Value = Convert.ToByte(kichhoat);
            MySqlParameters[2] = new MySqlParameter("@chitiet", MySqlDbType.Text);
            MySqlParameters[2].Value = Convert.ToString(chitiet);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        //Lay danh sach hien thi ngay thuc hien - tu dong
        public DataTable SelectTimeReminderDAO(int user_nhan_id, byte kichhoat)
        {
            string query = string.Format("select wo.id AS 'id', ROW_NUMBER() OVER (ORDER BY wo.id) as 'STT', wo.ten, ngay_hethan, wo.vonglap, user_gui_id, category_id from workflow as wo, category as cate where wo.category_id = cate.id and ngay_batdau <= now() and kichhoat = @kichhoat and user_nhan_id = @user_nhan_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@user_nhan_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(user_nhan_id);
            MySqlParameters[1] = new MySqlParameter("@kichhoat", MySqlDbType.Byte);
            MySqlParameters[1].Value = Convert.ToByte(kichhoat);
            return conn.ExecuteSqlString(query, MySqlParameters);
        }

        //Cap nhat thoi han neu lap lai - tu dong
        public void UpdateLoopWorkflowDAO(byte kichhoat, byte vonglap)
        {
            string query = string.Format("update workflow set ngay_batdau = DATE_ADD(ngay_batdau, INTERVAL ngay_dem day), ngay_hethan  = DATE_ADD(ngay_hethan, INTERVAL ngay_dem day), kichhoat = @kichhoat where workflow.vonglap = @vonglap and ngay_hethan <= CONVERT_TZ(NOW(), 'UTC','Asia/Ho_Chi_Minh') and EXISTS(select * from todolist where todolist.workflow_id = workflow_id and trangthai = 1)");
            MySqlParameter[] MySqlParameters = new MySqlParameter[2];
            MySqlParameters[0] = new MySqlParameter("@kichhoat", MySqlDbType.Byte);
            MySqlParameters[0].Value = Convert.ToByte(kichhoat);
            MySqlParameters[1] = new MySqlParameter("@vonglap", MySqlDbType.Bit);
            MySqlParameters[1].Value = Convert.ToByte(vonglap);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        //Xoa cong viec
        public void DeleteWorkflowDAO(int workflow_id)
        {
            string query = string.Format("delete from todolist where todolist.workflow_id = @workflow_id ; " +
                "delete from workflow where workflow.id = @workflow_id;");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@workflow_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(workflow_id);
            conn.InsertUpdateDeleteSQLString(query, MySqlParameters);
        }

        //Lay so thu tu cao nhat de cap nhat cong viec moi
        public int LaySoThuTuCaoNhatDAO(int user_gui_id)
        {
            int vitri = 0;
            string query = string.Format("select MAX(vitri)+1 as stt from workflow where user_gui_id = @user_gui_id");
            MySqlParameter[] MySqlParameters = new MySqlParameter[1];
            MySqlParameters[0] = new MySqlParameter("@user_gui_id", MySqlDbType.Int32);
            MySqlParameters[0].Value = Convert.ToString(user_gui_id);
            var check_vitri = conn.ExecuteScalarString(query, MySqlParameters);
            if (string.IsNullOrEmpty(check_vitri))
            {
                vitri = 1;
            }
            else
            {
                vitri = int.Parse(check_vitri);
            }
            return vitri;
        }
    }
}