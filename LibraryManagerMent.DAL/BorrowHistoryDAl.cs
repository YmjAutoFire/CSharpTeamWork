using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerMent.Common;
using LibraryManagerMent.Model;
using System.Data.SqlClient;//!

namespace LibraryManagerMent.DAL
{
    public class BorrowHistoryDAl//访问权限为public！！
    {
        /// <summary>
        /// 返回历史借阅查询结果
        /// </summary>
        /// <param name="stuID"></param>
        /// <returns></returns>
        public List<ShowBorrowHistory> getBookHistoryAll(string stuID)
        {
            string comd = "select [dbo].[BookInfo].bookID,[dbo].[BookInfo].bookName,[dbo].[BookInfo].author,[dbo].[BookInfo].publish,BorrowHistory.borrowTime,BorrowHistory.returnTime from [dbo].[BookInfo],[dbo].[BorrowHistory] where [dbo].[BorrowHistory].stuID=@stuID and BorrowHistory.bookID=BookInfo.bookID and BorrowHistory.returnTime is not null  order by BorrowHistory.returnTime";
            SqlParameter[] ps = {
                                    new SqlParameter("@stuID",stuID),   
                                };
            SQLHelper h = new SQLHelper();
            List<ShowBorrowHistory> list = new List<ShowBorrowHistory>();
             using(SqlDataReader read = h.getDataReader(comd,ps))
            {
                if(read.HasRows)
                {
                    while(read.Read())
                    {
                        //BookInfoModel为ShowBorrowHistory的父类
                        ShowBorrowHistory model = new ShowBorrowHistory(); 
                        model.BookID = read["bookID"].ToString();
                        model.BookName = read["bookName"].ToString();
                        model.Author = read["author"].ToString();
                        model.Publish = read["publish"].ToString();
                        model.BorrowTime =(DateTime) read["borrowTime"];
                       if(read["returnTime"].ToString()!="") model.ReturnTime = (DateTime)read["returnTime"];

                        list.Add(model);
                      

                    }
                }
            }
            return list;
        }
        /// <summary>
        /// 返回当前借阅查询结果
        /// </summary>
        /// <param name="stuID"></param>
        /// <returns></returns>
        public List<ShowBorrowHistory> getBookHistoryNow(string stuID)
        {
            string comd = "select [dbo].[BookInfo].bookID,[dbo].[BookInfo].bookName,[dbo].[BookInfo].author,[dbo].[BookInfo].publish,BorrowHistory.borrowTime,( dateadd(day,60,borrowTime)) as returnTime from [dbo].[BookInfo],[dbo].[BorrowHistory] where [dbo].[BorrowHistory].stuID=@stuID and BorrowHistory.bookID=BookInfo.bookID and BorrowHistory.returnTime is null order by returnTime";
            SqlParameter[] ps = {
                                    new SqlParameter("@stuID",stuID),   
                                };
            SQLHelper h = new SQLHelper();
            List<ShowBorrowHistory> list = new List<ShowBorrowHistory>();
            using (SqlDataReader read = h.getDataReader(comd, ps))
            {
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        ShowBorrowHistory model = new ShowBorrowHistory();
                        model.BookID = read["bookID"].ToString();
                        model.BookName = read["bookName"].ToString();
                        model.Author = read["author"].ToString();
                        model.Publish = read["publish"].ToString();
                        model.BorrowTime = (DateTime)read["borrowTime"];
                        model.ReturnTime = (DateTime)read["returnTime"];

                        list.Add(model);

                    }
                }
            }
            return list;
        }
        /// <summary>
        /// 判断当前借阅的图书是否超期
        /// </summary>
        /// <returns></returns>
        public bool judgeOverDateNow(string stuID,string bookID)
        {
           
            string comd="select BorrowHistory.borrowTime from BorrowHistory where BorrowHistory.stuID =@stuID and BorrowHistory.bookID=@bookID";
            SqlParameter[] ps = {
                                    new SqlParameter("@stuID",stuID) ,
                                    new SqlParameter("@bookID",bookID)
                                };
            SQLHelper h = new SQLHelper();
            DateTime borrowTime=(DateTime)h.ExecuteScalar(comd,ps);
            
            if (DateTime.Now >= borrowTime.AddDays(60))
            {
                return true;
                //DateTime.Now获取当前电脑的时间；
            }
            else
            {
                return false;
            }
 
        }
        /// <summary>
        /// 判断历史借阅的图书是否超期
        /// </summary>
        /// <param name="stuID"></param>
        /// <param name="bookID"></param>
        /// <returns></returns>
        public bool judgeOverDateAll(string stuID, string bookID)
        {
            string comd1 = "select BorrowHistory.returnTime from BorrowHistory where BorrowHistory.stuID =@stuID and BorrowHistory.bookID=@bookID";
            string comd2 = "select BorrowHistory.borrowTime from BorrowHistory where BorrowHistory.stuID =@stuID and BorrowHistory.bookID=@bookID";
            SQLHelper h = new SQLHelper();
            DateTime returnTime =(DateTime)h.ExecuteScalar(comd1);
            DateTime borrowTime = (DateTime)h.ExecuteScalar(comd2);

            if (returnTime >= borrowTime.AddDays(60))
            {
                return true;
            }
            else
            {
                return false;
            }
 
        }
        /// <summary>
        /// 获得当前借阅的图书数量
        /// </summary>
        /// <param name="stuID"></param>
        /// <returns></returns>
        public int getBorrowNowCount(string stuID)
        {
            string comd = "select count(*) from BorrowHistory where stuID=@stuID and returnTime is  NULL";
            SqlParameter[] ps = { 
                                    new SqlParameter("@stuID",stuID)
                                };
            SQLHelper h = new SQLHelper();
            return Convert.ToInt32(h.ExecuteScalar(comd,ps));

        }
        /// <summary>
        /// 获得历史借阅的总数量
        /// </summary>
        /// <param name="stuID"></param>
        /// <returns></returns>
         public int getBorrowAllCount(string stuID)
        {
            string comd = "select count(*) from [dbo].[BookInfo],[dbo].[BorrowHistory] where [dbo].[BorrowHistory].stuID=@stuID and BorrowHistory.bookID=BookInfo.bookID and [dbo].[BookInfo].bookStatus=1 ";
            SqlParameter[] ps = { 
                                    new SqlParameter("@stuID",stuID)
                                };
            SQLHelper h = new SQLHelper();
            return Convert.ToInt32(h.ExecuteScalar(comd, ps));

        }
        

        }
    }
    

