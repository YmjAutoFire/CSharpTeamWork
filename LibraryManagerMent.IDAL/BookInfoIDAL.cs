using LibraryManagerMent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerMent.IDAL
{
    public interface BookInfoIDAL
    {
        ///<summary>
        ///get all bookInfo by List
        ///</summary>
         List<BookInfoModel> getAllBookInfoList();

        ///<summary>
        ///get bookInfo by List like book's name
        ///</summary>
         List<BookInfoModel> getBookInfoLikeName(string name);

        ///<summary>
        ///insert one bookInfo by model
        ///</summary>
         int insertBookInfo(BookInfoModel book);


        ///<summary>
        ///update bookInfo by model
        ///</summary>
         int updateBookInfo(BookInfoModel book);


        ///<summary>
        ///update bookInfo borrowing status
        ///</summary>
         int updateBookInfoStatus(string bookID,bool status);

        ///<summary>
        ///delete bookInfo by model( many fields fuzzy query )
        ///</summary>
         int deleteBookInfo(BookInfoModel book);

        ///<summary>
        ///delete bookInfo By bookID 
        ///</summary>
         int deleteBookInfo(string bookID);



    }
}
