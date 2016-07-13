using LibraryManagerMent.Common;
using LibraryManagerMent.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerMent.DAL
{
    public class BookInfoDAL
    {
        /// <summary>
        /// get book's count
        /// </summary>
        /// <returns></returns>
        public int getBookCount()
        {
            string comd = "select count(*) from BookInfo";
            SQLHelper h = new SQLHelper();
            return Convert.ToInt32( h.ExecuteScalar(comd));
        }
        /// <summary>
        /// 根据图书类型查询出来的图书的总数
        /// </summary>
        /// <param name="typeID"></param>
        /// <returns></returns>
        public int getBookCount(string typeID)
        {
            string comd = "select count(*) from BookInfo where bookType = @typeID";
            SqlParameter[] ps = { 
                                    new SqlParameter("@typeID",typeID)
                                };
            SQLHelper h = new SQLHelper();
            return Convert.ToInt32(h.ExecuteScalar(comd, ps));
        }
        /// <summary>
        /// 根据作者，书名模糊查询出来的书的总数
        /// </summary>
        public int getBookCountLike(string name)
        {
            string comd = "select count(*) from BookInfo where bookName like @name or author like @name";
            SqlParameter[] ps = { 
                                    new SqlParameter("@name",'%'+name+'%')
                                };
            SQLHelper h = new SQLHelper();
            return Convert.ToInt32(h.ExecuteScalar(comd, ps));
        }

        /// <summary>
        /// 根据类型返回图书集(bookType)
        /// </summary>
        /// <param name="typeID"></param>
        /// <param name="startNum"></param>
        /// <param name="endNum"></param>
        /// <returns></returns>
        public List<BookInfoModel> getBookInfoByPage(string typeID, int startNum, int endNum)
        {
            string comd = "select * from BookType,(select *,row_number() over(order by bookName) as number from BookInfo where bookType = @bookType) as tb where BookType.typeID = tb.BookType and number >= @startNum and number <= @endNum";
            SqlParameter[] ps = {
                                    new SqlParameter("@bookType",typeID),
                                    new SqlParameter("@startNum",startNum),
                                    new SqlParameter("@endNum",endNum)
                                };
            SQLHelper h = new SQLHelper();
            List<BookInfoModel> list = new List<BookInfoModel>();
            using(SqlDataReader read = h.getDataReader(comd,ps))
            {
                if(read.HasRows)
                {
                    while(read.Read())
                    {
                        BookInfoModel model = new BookInfoModel();
                        model.Author = read["author"].ToString();
                        model.BookID = read["bookID"].ToString();
                        model.BookName = read["bookName"].ToString();
                        model.BookStatus = Convert.ToBoolean(read["bookStatus"])? "可借" : "借出";
                        model.BookType = read["bookType"].ToString();
                        model.PicPath = read["picPath"].ToString();
                        model.Publish = read["publish"].ToString();
                        model.TypeName = read["typeName"].ToString();
                        list.Add(model);
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// 根据字段获取图书信息
        /// </summary>
        /// <param name="startNum"></param>
        /// <param name="endNum"></param>
        /// <param name="field"></param>
        /// <returns></returns>
        public DataTable getBookInfoByPage(int startNum, int endNum, string field)
        {
            string comd = "select * from (select publish,author,bookType,typeName,bookID,bookName,bookStatus,picPath,row_number() over(order by @field desc) as number from BookInfo ) as booknums where number >= @startNum and number <= endNum";
            SqlParameter[] ps = {
                                    new SqlParameter("@field",field),
                                    new SqlParameter("@startNum",startNum),
                                    new SqlParameter("@endNum",endNum)
                                };
            SQLHelper h = new SQLHelper();
            return h.getDataTable(comd);
        }

        ///<summary>
        ///获取根据图书类型排名的所有图书(分页)
        ///</summary>
        public List<BookInfoModel> getAllBookInfoList(int startNum, int endNum)
        {

            List<BookInfoModel> list = new List<BookInfoModel>();
            string comd = "select * from (select publish,author,bookType,typeName,bookID,bookName,bookStatus,picPath,row_number() over(order by bookName desc) as number from BookInfo,BookType where BookInfo.bookType = BookType.typeID) as tb where number >= @startNum and number <= @endNum";
            SqlParameter[] ps = { 
                                new SqlParameter("@startNum",startNum),
                                new SqlParameter("@endNum",endNum)
                                };
            FillModel(list, ps, comd);
            return list;

        }

        /// <summary>
        /// 填充对象
        /// </summary>
        /// <param name="list"></param>
        /// <param name="read"></param>
        private static void FillModel(List<BookInfoModel> list, SqlParameter[] ps,string comd)
        {
            SQLHelper h = new SQLHelper();
            using (SqlDataReader read = h.getDataReader(comd, ps))
            {
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        BookInfoModel book = new BookInfoModel();
                        book.BookID = read["bookID"].ToString();
                        book.BookName = read["bookName"].ToString();
                        book.BookStatus = Convert.ToBoolean(read["bookStatus"]) ? "可借" : "借出";
                        book.BookType = read["bookType"].ToString();
                        book.Publish = read["publish"].ToString();
                        book.Author = read["author"].ToString();
                        book.PicPath = read["picPath"].ToString();
                        book.TypeName = read["typeName"].ToString();
                        list.Add(book);
                    }
                }
            }
        }


        ///<summary>
        ///get bookInfo by List like book's name
        ///</summary>
        public List<BookInfoModel> getBookInfoLikeName(string name, int startNum, int endNum)
        {
            List<BookInfoModel> list = new List<BookInfoModel>();
            string comd = "select publish,author,bookType,typeName,bookID,bookName,bookStatus,picPath from BookType,(select *,row_number() over(order by bookName desc) as number from BookInfo where author like @name or bookName like @name ) as tb where bookType=BookType.typeID and number >= @startNum and number <= @endNum;";
            SqlParameter[] ps = {
                                    new SqlParameter("@name","%"+name+"%"),
                                new SqlParameter("@startNum",startNum),
                                new SqlParameter("@endNum",endNum)
                                };
            FillModel(list, ps, comd);
            
            return list;
        }
        /// <summary>
        /// get bookInfo's table like book's name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable getBookLikeNameTable(string name)
        {
            string comd = "select * from BookInfo where bookName like '%" + name + "%'";
            SQLHelper h = new SQLHelper();
            return h.getDataTable(comd);
        }

        ///<summary>
        ///insert one bookInfo by model
        ///</summary>
        public int insertBookInfo(BookInfoModel book)
        {
            List<BookInfoModel> list = new List<BookInfoModel>();
            string comd = "insert into BookInfo values( @publish, @author, @bookType, @bookID, @bookName, @bookStatus, @picPath ) ";
            SqlParameter[] ps = {
                                    new SqlParameter("@publish",book.Publish),
                                    new SqlParameter("@author",book.Author),
                                    new SqlParameter("@bookType",book.BookType),
                                    new SqlParameter("@bookID",book.BookID),
                                    new SqlParameter("@bookName",book.BookName),
                                    new SqlParameter("@bookStatus",1),
                                    new SqlParameter("@picPath",book.PicPath)
                                };
            SQLHelper h = new SQLHelper();
            return h.ExecuteNonQuery(comd,ps);

        }



        /// <summary>
        /// 根据图书类更新图书的大量信息
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public int updateBookInfoByModel(BookInfoModel book)
        {
            string comd = "update BookInfo set publish=@publish, author=@author, bookName=@bookName where bookID=@bookID ";
            SqlParameter[] ps = { 
                                new SqlParameter("@publish",book.Publish),
                                new SqlParameter("@author",book.Author),
                                new SqlParameter("@bookName",book.BookName),
                                new SqlParameter("@bookID",book.BookID)
                                };
            SQLHelper h = new SQLHelper();
            return h.ExecuteNonQuery(comd, ps);
        }

        ///<summary>
        ///update bookInfo borrowing status
        ///</summary>
        public int updateBookInfoStatus(string bookID, bool status)
        {
            List<BookInfoModel> list = new List<BookInfoModel>();
            string comd = "update BookInfo set bookStatus=@bookStatus  where  bookID=@bookID  ";
            SqlParameter[] ps = {
                                    new SqlParameter("@bookStatus",status),
                                    new SqlParameter("@bookID",bookID)
                                };
            SQLHelper h = new SQLHelper();
            return h.ExecuteNonQuery(comd, ps);
        }

        ///<summary>
        ///delete bookInfo by model( many fields fuzzy query )
        ///</summary>
        public int deleteBookInfo(BookInfoModel book)
        {
            List<BookInfoModel> list = new List<BookInfoModel>();
            string comd = "delete from BookInfo where bookName=@bookName or bookID =@bookID or publish=@publish or bookType=@bookType ot author=@author   ";
            SqlParameter[] ps = {
                                    new SqlParameter("@bookName",book.BookName),
                                    new SqlParameter("@bookID",book.BookID),
                                    new SqlParameter("@publish",book.Publish),
                                    new SqlParameter("@bookType",book.BookType),
                                    new SqlParameter("@author",book.Author)
                                };
            SQLHelper h = new SQLHelper();
            return h.ExecuteNonQuery(comd, ps);
        }

        ///<summary>
        ///delete bookInfo By bookID 
        ///</summary>
        public int deleteBookInfo(string bookID)
        {
            List<BookInfoModel> list = new List<BookInfoModel>();
            string comd = "delete from BookInfo where  bookID=@bookID  ";
            SqlParameter[] ps = {
                                    new SqlParameter("@bookID",bookID)
                                };
            SQLHelper h = new SQLHelper();
            return h.ExecuteNonQuery(comd, ps);
        }




    }
}
