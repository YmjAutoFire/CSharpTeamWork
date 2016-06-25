using LibraryManagerMent.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerMent.BLL
{
    public class BookHistoryBLL
    {
        /// <summary>
        ///获取当前图书被借阅的次数
        /// </summary>
        /// <param name="bookID"></param>
        /// <returns></returns>
        public int getBookBorrowedCount(string bookID)
        {
            BookHistoryDAL dal = new BookHistoryDAL();
            return dal.getBookBorrowedCount(bookID);
        }
    }
}
