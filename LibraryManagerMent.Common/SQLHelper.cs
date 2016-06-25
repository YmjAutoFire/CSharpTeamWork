using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LibraryManagerMent.Common
{
    public class SQLHelper
    {
        private readonly string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        /// <summary>
        /// Scalar(insert,delete,update)
        /// </summary>
        /// <param name="comd">Sqlcommand</param>
        /// <param name="ps">Sqlcommand parameter</param>
        /// <returns>the result of the first row and the first column</returns>
        public  object ExecuteScalar(string comd, params SqlParameter[] ps)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand com = new SqlCommand(comd, conn))
                {
                    conn.Open();
                    com.Parameters.AddRange(ps);
                    object res = com.ExecuteScalar();
                    com.Parameters.Clear();
                    return res;
                }
            }
        }

        /// <summary>
        /// NonQuery(insert,delete,update)
        /// </summary>
        /// <param name="comd"></param>
        /// <param name="ps"></param>
        /// <returns>the number of rows affected</returns>
        public int ExecuteNonQuery(string comd,params SqlParameter[] ps)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand com = new SqlCommand(comd, conn))
                {
                    conn.Open();
                    com.Parameters.AddRange(ps);
                    int res = com.ExecuteNonQuery();
                    com.Parameters.Clear();
                    return res;
                }
            }
        }
        /// <summary>
        /// getDataReader(conn is not close;after using must be closed)
        /// </summary>
        /// <param name="comd"></param>
        /// <param name="ps"></param>
        /// <returns>the result of the reader</returns>
        public SqlDataReader getDataReader(string comd,params SqlParameter[] ps)
        {
            SqlConnection conn = new SqlConnection(connStr);
            using(SqlCommand com = new SqlCommand(comd,conn))
            {
                conn.Open();
                com.Parameters.AddRange(ps);
                SqlDataReader read = com.ExecuteReader();
                com.Parameters.Clear();
                return read;
            }
        }

        /// <summary>
        /// getDataTable
        /// </summary>
        /// <param name="comd"></param>
        /// <param name="ps"></param>
        /// <returns>the result of the table</returns>
        public DataTable getDataTable(string comd,params SqlParameter[] ps)
        {
            using(SqlConnection conn = new SqlConnection(connStr))
            {
                using(SqlDataAdapter ad = new SqlDataAdapter(comd,conn))
                {
                    conn.Open();
                    ad.SelectCommand.CommandType = CommandType.Text;
                    ad.SelectCommand.Parameters.AddRange(ps);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    ad.SelectCommand.Parameters.Clear();
                    return dt;
                }
            }
        }


    }
}
