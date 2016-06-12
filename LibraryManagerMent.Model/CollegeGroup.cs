using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerMent.Model
{
    public class CollegeGroup
    {
        string collegeID;
        //学院编号
        public string CollegeID
        {
            get { return collegeID; }
            set { collegeID = value; }
        }
        string collegeName;
        //学院名称
        public string CollegeName
        {
            get { return collegeName; }
            set { collegeName = value; }
        }
        string schoolID;
        //所属学校
        public string SchoolID
        {
            get { return schoolID; }
            set { schoolID = value; }
        }
    }
}
