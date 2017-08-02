using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace WindowsFormsFileControl
{
    class DB_file
    {

            private static string connectionString = @"server=MICHAEL-JORDAN\SQLSERVER;database=FileSystem;uid=sa;pwd=19690401" ;
      

        public static SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
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
        public static void Close()
        {
            SqlConnection conn = GetConnection();
             conn.Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionString">目标连接字符</param>
        /// <param name="TableName">目标表</param>
        /// <param name="dt">源数据</param>
        static public void SqlBulkCopyByDatatable( DataTable dt)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlBulkCopy sqlbulkcopy = new SqlBulkCopy(connectionString, SqlBulkCopyOptions.UseInternalTransaction))
                {
                    try
                    {
                        sqlbulkcopy.DestinationTableName = dt.TableName;
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            sqlbulkcopy.ColumnMappings.Add(dt.Columns[i].ColumnName, dt.Columns[i].ColumnName);
                        }
                        sqlbulkcopy.WriteToServer(dt);
                    }
                    catch (System.Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
    }
}
