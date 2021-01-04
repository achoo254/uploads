using MySql.Data.MySqlClient;
using NhacViecWinform.DAL;
using System;
using System.Data;

namespace NhacViecWinform.DAO
{
    internal class CategoryDAO
    {
        private dbConnectionMySQL conn = new dbConnectionMySQL();

        public DataTable GetCategoryDAO()
        {
            string query = string.Format("select * from category");
            MySqlParameter[] sqlParameters = new MySqlParameter[0];
            return conn.ExecuteSqlString(query, sqlParameters);
        }

        public string SelectNameCategoryDAO(int category_id)
        {
            string name = "";
            string query = string.Format("select cate.ten  from category as cate where id = @category_id");
            MySqlParameter[] MySqlParameter = new MySqlParameter[1];
            MySqlParameter[0] = new MySqlParameter("@category_id", MySqlDbType.Int32);
            MySqlParameter[0].Value = Convert.ToString(category_id);
            name = conn.ExecuteScalarString(query, MySqlParameter);
            return name;
        }
    }
}