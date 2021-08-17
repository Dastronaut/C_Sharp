using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQSLV_UsingSQL
{
    class DBHelper
    {
        private static SqlConnection conn;
        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string connStr = @"Data Source=TKTD-MSI\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True";
                    _Instance = new DBHelper(connStr);
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private static DBHelper _Instance;
        private DBHelper(string s)
        {
            conn = new SqlConnection(s);
        }
        public DataTable getRecord(string s)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(s, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            conn.Open();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int ExcuteDB(string s)
        {
            SqlCommand cmd = new SqlCommand(s, conn);
            conn.Open();
            var rs = cmd.ExecuteNonQuery();
            conn.Close();
            return rs;
        }
    }
}
