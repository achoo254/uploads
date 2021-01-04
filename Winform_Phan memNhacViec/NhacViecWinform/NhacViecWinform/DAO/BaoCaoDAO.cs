using MySql.Data.MySqlClient;
using NhacViecWinform.DAL;
using System.Data;

namespace NhacViecWinform.DAO
{
    internal class BaoCaoDAO
    {
        private dbConnectionMySQL conn = new dbConnectionMySQL();

        public DataTable LayBaoCaoSaiLechTonDongDAO()
        {
            string query = string.Format("select tt.ten, td.tenkho, ngayhoso, tenvacxin, nguyennhan, tdoi.ngaytheodoi, tinhtrang, huongxuly from test_theodoi as tdoi inner join test_tondong as td on tdoi.tondong_id = td.id inner join trungtam as tt on td.trungtam_id = tt.id order by ngaytheodoi DESC, td.trungtam_id ASC, ngayhoso ASC");
            MySqlParameter[] sqlParameters = new MySqlParameter[0];
            return conn.ExecuteSqlString(query, sqlParameters);
        }
    }
}