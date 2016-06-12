using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerMent.Model
{
    public class ShowBorrowHistory:BookInfoModel
    {
        //图书编号，图书出版社，图书作者，借出日期，归还日期
        
        DateTime borrowTime;

        public DateTime BorrowTime
        {
            get { return borrowTime; }
            set { borrowTime = value; }
        }
        DateTime returnTime;

        public DateTime ReturnTime
        {
            get { return returnTime; }
            set { returnTime = value; }
        }


    }
}
