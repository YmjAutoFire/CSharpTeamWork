using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerMent.Common;

namespace LibraryManagerMent.DAL
{
   public  class ReturnBookDAL
    {
       /// <summary>
       /// 判断该条借阅记录是否从借阅表中删除
       /// </summary>
       /// <param name="bookID"></param>
       /// <returns></returns>
       public bool retrunBook(string bookID)
       {
           string comd = "update BorrowHistory set timeLiness = 0, returnTime=getdate() where bookID=@bookID";
           SqlParameter[] ps = {
                                    new  SqlParameter("@bookID",bookID),
                                    
                                };
                SQLHelper h = new SQLHelper();
                int count = Convert.ToInt32(h.ExecuteNonQuery(comd, ps));
                if (count>0)
                {
                    return true;
                }
                else
                    return false;
        }
       /// <summary>
       /// 改变BookInfo表中被借阅的图书状态
       /// </summary>
       public bool changeBookState(string bookID)
       {
           string comd = "update  BookInfo set bookStatus=1 where bookID=@bookID";
           SqlParameter[] ps = {
                                    new  SqlParameter("@bookID",bookID)
                                };
           SQLHelper h = new SQLHelper();
           int count = Convert.ToInt32(h.ExecuteNonQuery(comd, ps));
           if (count > 0)
           {
               return true;
           }
           else
               return false;
       }
    }
}
