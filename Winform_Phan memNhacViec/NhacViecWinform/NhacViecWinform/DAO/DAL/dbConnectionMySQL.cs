//using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace NhacViecWinform.DAL
{
    public class dbConnectionMySQL
    {
        //Ket noi online
        private string conn = ConfigurationManager.ConnectionStrings["MySQLLocalhost"].ToString();

        //Ket noi offline
        //private string conn = ConfigurationManager.ConnectionStrings["MySQLLocalhost"].ToString();
        private MySqlConnection objsqlconn;

        private MySqlCommand objcmd;

        public void InsertUpdateDeleteSQLString(string sqlstring, MySqlParameter[] sqlParameter)
        {
            try
            {
                objsqlconn = new MySqlConnection(conn);
                objsqlconn.Open();
                objcmd = new MySqlCommand(sqlstring, objsqlconn);
                objcmd.Parameters.AddRange(sqlParameter);
                objcmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (objsqlconn != null)
                {
                    objsqlconn.Dispose();
                }
                if (objcmd != null)
                {
                    objcmd.Dispose();
                }
            }
        }

        public DataTable ExecuteSqlString(string sqlstring, MySqlParameter[] sqlParameter)
        {
            objsqlconn = new MySqlConnection(conn);
            objsqlconn.Open();
            DataTable dt = new DataTable();
            try
            {
                objcmd = new MySqlCommand(sqlstring, objsqlconn);
                objcmd.Parameters.AddRange(sqlParameter);
                MySqlDataAdapter objAdp = new MySqlDataAdapter(objcmd);
                objAdp.Fill(dt);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (objsqlconn != null)
                {
                    objsqlconn.Dispose();
                }
                if (objcmd != null)
                {
                    objcmd.Dispose();
                }
            }
            return dt;
        }

        public string ExecuteScalarString(string sqlstring, MySqlParameter[] sqlParameter)
        {
            String NameCheck = "";
            objsqlconn = new MySqlConnection(conn);
            objsqlconn.Open();
            try
            {
                objcmd = new MySqlCommand(sqlstring, objsqlconn);
                objcmd.Parameters.AddRange(sqlParameter);
                NameCheck = Convert.ToString(objcmd.ExecuteScalar());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (objsqlconn != null)
                {
                    objsqlconn.Dispose();
                }
                if (objcmd != null)
                {
                    objcmd.Dispose();
                }
            }
            return NameCheck;
        }
    }
}