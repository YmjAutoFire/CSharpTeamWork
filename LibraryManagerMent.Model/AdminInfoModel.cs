using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerMent.Model
{
    public class AdminInfoModel
    {
        //--管理员信息：登录账号，管理员编号，姓名，密码
        string loginID;

        public string LoginID
        {
            get { return loginID; }
            set { loginID = value; }
        }
        string adminID;

        public string AdminID
        {
            get { return adminID; }
            set { adminID = value; }
        }
        string adminName;

        public string AdminName
        {
            get { return adminName; }
            set { adminName = value; }
        }
        string adminPwd;

        public string AdminPwd
        {
            get { return adminPwd; }
            set { adminPwd = value; }
        }


    }
}
