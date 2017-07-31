using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsFileControl
{
    class DB_file
    {
            private static string connectString = @"server=MICHAEL-JORDAN\SQLSERVER;database=FileSystem;uid=sa;pwd=19690401" ;
            public static SqlConnection GetConnection()
            {
                return new SqlConnection(connectString);
            }
        public static int ExeuteNonQuery(string sql)
        {
            SqlConnection conn = GetConnection();
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return 0;
        }
    }
}
