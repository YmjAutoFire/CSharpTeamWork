using System;
using System.Collections.Generic;
using System.Data.SqlClient;//与SqlParameter有关
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerMent.Common;//!!与SQLHelper有关

namespace LibraryManagerMent.DAL
{
    public class BorrowBookDAl
    {

        /// <summary>
        /// 判断向借阅表中插入一条记录是否成功
        /// </summary>
        /// <param name="stuID"></param>
        /// <param name="bookID"></param>
        /// <returns></returns>
        public bool borrowBook(string stuID, string bookID)
        {

            string comd = "if((select bookStatus from BookInfo where bookID=@bookID)=1)insert into BorrowHistory(stuID,bookID,borrowTime) values(@stuID,@bookID,default)";
                SqlParameter[] ps = {
                                    new SqlParameter("@stuID",stuID),   
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
        /// <summary>
        /// 判断图书是否可借
        /// </summary>
        /// <param name="bookState"></param>
        /// <returns></returns>
        public bool judgeBookState(bool bookState)
        {
            if (bookState)
            {
                return true;
            }
            else
                return false;
 
        }
        /// <summary>
        /// 改变BookInfo表中被借阅的图书状态
        /// </summary>
        public bool  changeBookState(string bookID)
        {
            string comd = "update  BookInfo set bookStatus=0 where bookID=@bookID";
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
