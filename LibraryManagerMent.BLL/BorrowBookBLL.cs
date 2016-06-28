using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerMent.DAL;
using LibraryManagerMent.Model;

namespace LibraryManagerMent.BLL
{
    public class BorrowBookBLL
    {
        /// <summary>
        /// 判断向借阅表中插入记录是否成功
        /// </summary>
        /// <param name="stuID"></param>
        /// <param name="bookID"></param>
        /// <returns></returns>
        public bool borrowBook(string stuID, string bookID)
        {
            BorrowBookDAl dal = new BorrowBookDAl();
            return dal.borrowBook(stuID, bookID);
        }
        /// <summary>
        /// 判断图书是否可借
        /// </summary>
        /// <param name="bookState"></param>
        /// <returns></returns>
        public bool judgeBookState(bool bookState)
        {
            BorrowBookDAl dal = new BorrowBookDAl();
            return dal.judgeBookState(bookState);
        }
        /// <summary>
        /// 判断改变图书状态是否成功
        /// </summary>
        /// <param name="bookID"></param>
        /// <returns></returns>
        public bool changeBookState(string bookID)
        {
            BorrowBookDAl dal = new BorrowBookDAl();
            return dal.changeBookState(bookID);
        }
    }
}
