using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerMent.Model
{
    public class BookInfoModel
    {
        //--图书：出版社，作者，图书类型编号，图书编号，图书名称，借阅状态（0/1）,图书封面

        public BookInfoModel()
        {
            publish = author = bookType = bookID = bookName = null;
        }

        string publish;

        public string Publish
        {
            get { return publish; }
            set { publish = value; }
        }
        string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        string bookType;

        public string BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }

        string typeName;

        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }
        string bookID;

        public string BookID
        {
            get { return bookID; }
            set { bookID = value; }
        }
        string bookName;

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        string bookStatus;

        public string BookStatus
        {
            get { return bookStatus; }
            set { bookStatus = value; }
        }
        string picPath;

        public string PicPath
        {
            get { return picPath; }
            set { picPath = value; }
        }

        public BookInfoModel Clone()
        {
            return (BookInfoModel)this.MemberwiseClone();
        }

    }
}
