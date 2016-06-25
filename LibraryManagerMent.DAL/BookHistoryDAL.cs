using LibraryManagerMent.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerMent.DAL
{
    public class BookHistoryDAL
    {

        /// <summary>
        ///获取当前图书被借阅的次数
        /// </summary>
        /// <param name="bookID"></param>
        /// <returns></returns>
        public int getBookBorrowedCount(string bookID)
        {
            string sql = "select count(*) from BorrowHistory where bookID = @bookID";
            SqlParameter[] ps = { new SqlParameter("@bookID",bookID) };
            SQLHelper h = new SQLHelper();
            return Convert.ToInt32(h.ExecuteScalar(sql,ps));
        }
    }
}
