using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerMent.Model
{
    public class ProfessionGroup
    {
        string professionID;
        //专业编号
        public string ProfessionID
        {
            get { return professionID; }
            set { professionID = value; }
        }
        string professionName;
        //专业名称
        public string ProfessionName
        {
            get { return professionName; }
            set { professionName = value; }
        }
        string collegeID;
        //所属学院
        public string CollegeID
        {
            get { return collegeID; }
            set { collegeID = value; }
        }
    }
}
