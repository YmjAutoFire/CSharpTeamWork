using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerMent.DAL;
using LibraryManagerMent.Model;


namespace LibraryManagerMent.BLL
{
   public class ReturnBookBLL
    {
       /// <summary>
        /// 判断是否该条借阅记录是否从借阅表中删除
       /// </summary>
       /// <param name="bookID"></param>
       /// <param name="stuID"></param>
       /// <returns></returns>
       public bool retrunBook(string bookID)
       {
           ReturnBookDAL dal = new ReturnBookDAL();
            return  dal.retrunBook(bookID);
       
       }
       /// <summary>
       /// 改变BookInfo表中被借阅的图书状态
       /// </summary>
       public bool changeBookState(string bookID)
       {
           ReturnBookDAL dal = new ReturnBookDAL();
           return dal.changeBookState(bookID);
 
       }
    }
}
