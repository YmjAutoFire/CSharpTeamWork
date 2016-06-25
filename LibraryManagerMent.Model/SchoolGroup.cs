using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerMent.Model
{
    public class SchoolGroup
    {
        string schoolID;
        //学校编号
        public string SchoolID
        {
            get { return schoolID; }
            set { schoolID = value; }
        }
        string schoolName;
        //学校名称
        public string SchoolName
        {
            get { return schoolName; }
            set { schoolName = value; }
        }
    }
}
