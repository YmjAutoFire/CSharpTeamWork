using LibraryManagerMent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerMent.DAL;

namespace LibraryManagerMent.BLL
{
    public class BookInfoBLL
    {

        /// <summary>
        /// get book's count
        /// </summary>
        /// <returns></returns>
        public int getBookCount()
        {
            BookInfoDAL dal = new BookInfoDAL();
            return dal.getBookCount();
        }

        public int getBookCount(string typeID)
        {
            BookInfoDAL dal = new BookInfoDAL();
            return dal.getBookCount(typeID);
        }

        public int getBookCountLike(string name)
        {
            BookInfoDAL dal = new BookInfoDAL();
            return dal.getBookCountLike(name);
        }

        /// <summary>
        /// 根据图书类型和当前页数返回查询的图书
        /// </summary>
        /// <param name="typeID"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        public List<BookInfoModel> getBookInfoByType(string typeID,int pageIndex)
        {
            
            BookInfoDAL dal = new BookInfoDAL();
            return dal.getBookInfoByPage(typeID, (pageIndex - 1) * 20 + 1, pageIndex * 20);
        }

        ///<summary>
        ///get all bookInfo by List
        ///</summary>
        public List<BookInfoModel> getAllBookInfoList(int pageIndex)
        {
            BookInfoDAL dal = new BookInfoDAL();
            return dal.getAllBookInfoList((pageIndex - 1)*20,pageIndex*20);
        }

        ///<summary>
        ///get bookInfo by List like book's name
        ///</summary>
        public List<BookInfoModel> getBookInfoLikeName(string name,int pageIndex)
        {
            BookInfoDAL dal = new BookInfoDAL();
            return dal.getBookInfoLikeName(name,(pageIndex - 1) * 20 + 1, pageIndex * 20);
        }

         ///<summary>
        ///insert one bookInfo by model
        ///</summary>
        public int insertBookInfo(BookInfoModel book)
        {
            BookInfoDAL dal = new BookInfoDAL();
            return dal.insertBookInfo(book);
        }

        ///<summary>
        ///insert bookInfos by excel about excel's path
        ///</summary>
        public int insertBookInfosByExcel(string excelPath)
        {
            BookInfoDAL dal = new BookInfoDAL();
            int success = 0;


            return success;
        }

        ///<summary>
        ///update bookInfo borrowing status
        ///</summary>
        public int updateBookInfoStatus(string bookID, bool status)
        {
            BookInfoDAL dal = new BookInfoDAL();
            return dal.updateBookInfoStatus(bookID, status);
        }
        ///<summary>
        ///update bookInfo infomation
        ///</summary>
        public int updateBookInfoModel(BookInfoModel model)
        {
            BookInfoDAL dal = new BookInfoDAL();
            return dal.updateBookInfoByModel(model);
        }


        ///<summary>
        ///delete bookInfo by model( many fields fuzzy query )
        ///</summary>
        public int deleteBookInfo(BookInfoModel book)
        {
            BookInfoDAL dal = new BookInfoDAL();
            return dal.deleteBookInfo(book);
        }

        ///<summary>
        ///delete bookInfo By bookID 
        ///</summary>
        public int deleteBookInfo(string bookID)
        {
            BookInfoDAL dal = new BookInfoDAL();
            return dal.deleteBookInfo(bookID);
        }



    }
}
