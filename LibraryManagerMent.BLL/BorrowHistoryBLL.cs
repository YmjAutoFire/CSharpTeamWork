using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerMent.DAL;
using LibraryManagerMent.Model;

namespace LibraryManagerMent.BLL
{

    public class BorrowHistoryBLL
    {

        /// <summary>
        /// 当前借阅
        /// </summary>
        /// <returns></returns>
        public List<ShowBorrowHistory> getListBorrowHisoryNow(string stuID)
        {
            BorrowHistoryDAl dal = new BorrowHistoryDAl();
            return dal.getBookHistoryNow(stuID);
        }
        /// <summary>
        /// 历史借阅
        /// </summary>
        /// <returns></returns>
        public List<ShowBorrowHistory> getListBorrowHisoryAll(string stuID)
        {
            BorrowHistoryDAl dal = new BorrowHistoryDAl();
            return dal.getBookHistoryAll(stuID);
        }
        /// <summary>
        /// 判断当前借阅是否超期
        /// </summary>
        /// <param name="stuID"></param>
        /// <param name="bookID"></param>
        /// <returns></returns>
        public bool judgeOverDateNow(string stuID, string bookID)
        {
            BorrowHistoryDAl dal = new BorrowHistoryDAl();
            return dal.judgeOverDateNow(stuID, bookID);
        }
        /// <summary>
        /// 判断历史借阅是否超期
        /// </summary>
        /// <param name="stuID"></param>
        /// <param name="bookID"></param>
        /// <returns></returns>
        public bool judgeOverDateAll(string stuID, string bookID)
        {
            BorrowHistoryDAl dal = new BorrowHistoryDAl();
            return dal.judgeOverDateNow(stuID, bookID);
        }
        /// <summary>
        /// 获得当前借阅的数量
        /// </summary>
        /// <param name="stuID"></param>
        /// <returns></returns>
        public int getBorrowNowCount(string stuID)
        {
            BorrowHistoryDAl dal = new BorrowHistoryDAl();
            return dal.getBorrowNowCount(stuID);
    
        }
        /// <summary>
        /// 获得历史借阅的数量
        /// </summary>
        /// <param name="stuID"></param>
        /// <returns></returns>
        public int getBorrowAllCount(string stuID)
        {
            BorrowHistoryDAl dal = new BorrowHistoryDAl();
            return dal.getBorrowAllCount(stuID);
 
        }
    }
}
