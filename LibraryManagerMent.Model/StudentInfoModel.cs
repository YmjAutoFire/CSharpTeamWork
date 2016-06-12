using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerMent.Model
{
    public class StudentInfoModel
    {
        
//--学号，姓名，学校，学院，专业，班级，密码（默认是学号），当前借书量（满编10本），当前信誉值（满值为10，超出借阅期限一次减1），头像，入学时间
        string stuID;
        //学号
        public string StuID
        {
            get { return stuID; }
            set { stuID = value; }
        }
        string stuName;
        //姓名
        public string StuName
        {
            get { return stuName; }
            set { stuName = value; }
        }
        string schoolID;
        //学校
        public string SchoolID
        {
            get { return schoolID; }
            set { schoolID = value; }
        }
        string collegeID;
        //学院
        public string CollegeID
        {
            get { return collegeID; }
            set { collegeID = value; }
        }
        string professionID;
        //专业
        public string ProfessionID
        {
            get { return professionID; }
            set { professionID = value; }
        }
        string stuClass;
        //班级
        public string StuClass
        {
            get { return stuClass; }
            set { stuClass = value; }
        }
        string stuPwd;
        //密码
        public string StuPwd
        {
            get { return stuPwd; }
            set { stuPwd = value; }
        }
        int nowBorrows;
        //当前借阅量
        public int NowBorrows
        {
            get { return nowBorrows; }
            set { nowBorrows = value; }
        }
        int nowsCredit;
        //当前信誉值
        public int NowsCredit
        {
            get { return nowsCredit; }
            set { nowsCredit = value; }
        }
        string headPath;
        //头像
        public string HeadPath
        {
            get { return headPath; }
            set { headPath = value; }
        }
        DateTime entrance;
        //入学时间
        public DateTime Entrance
        {
            get { return entrance; }
            set { entrance = value; }
        }
    }
}
