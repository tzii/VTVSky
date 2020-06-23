using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Data_Transfer_Objects
{
    public class DataProvider
    {
        private static SqlConnection Connection()
        {
            string connectionString = String.Format("Server={0},1433;Initial Catalog={1};Persist Security Info=False;User ID={2};Password={3};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;", Server.ServerName, Server.DBName, Server.Login, Server.Password);
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }

        public static DataTable ExecuteReader(string cmdText)
        {
            SqlConnection conn = Connection();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dataReader);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                Notification.Show(ex.Message);
                return null;
            }
        }

        public static string ExecuteScalar(string cmdText)
        {
            SqlConnection conn = Connection();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                
                string res = cmd.ExecuteScalar().ToString();
                conn.Close();
                return res;
            }
            catch (NullReferenceException ex)
            {
                conn.Close();
                Notification.Show(ex.Message);
                return null;
            }
        }
        public static bool ExecuteNonQuery(string cmdText)
        {
            SqlConnection conn = Connection();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                int res = cmd.ExecuteNonQuery();
                conn.Close();
                if (res > 0) return true;
                else return false;
            }
            catch (Exception ex)
            {
                conn.Close();
                Notification.Show(ex.Message);
                return false;
            }
        }
        public static string ConvertToInt(string s)
        {
            try
            {
                string temp = Regex.Replace(s, "[a-zA-z]{1}", "");
                return Convert.ToInt32(temp).ToString();
            }
            catch (Exception ex)
            {
                Notification.Show(ex.Message);
                return "";
            }
        }
    }
}
