using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerMent.DAL;
using LibraryManagerMent.Model;
using System.Data;

namespace LibraryManagerMent.BLL
{
    public class StudentInfoBLL
    {
        /// <summary>
        /// get all Student information by List
        /// </summary>
        /// <returns></returns>
        public List<StudentInfoModel> getAllStudentInfoList()
        {
            StudentInfoDAL dal = new StudentInfoDAL();
            return dal.getAllStudentInfoList();
        }

        /// <summary>
        /// get  Student information by page table by field
        /// </summary>
        public DataTable getStudentInfoListByPage(int beginNum, int endNum, string  field)
        {
            string condition = (checkField(field) == null) ? "entrance" : checkField(field);
            StudentInfoDAL dal = new StudentInfoDAL();
            return dal.getStudentInfoListByPage(beginNum, endNum, condition);
        }

        //check field
        private string checkField(string field)
        {
            string f = null;
            switch (field)
            {
                case "入学时间": f = "entrance";
                    break;
                case "学号": f = "stuID"; break;
                case "当前借阅量": f = "nowBorrows"; break;
                case "当前信誉值": f = "nowsCredit"; break;
                default: break;
            }
            return f;
        }

        /// <summary>
        /// get login Student information by StudentUserID
        /// </summary>
        public StudentInfoModel getStudentInfoByID(string userID)
        {
            StudentInfoDAL dal = new StudentInfoDAL();
            return dal.getStudentInfoByID(userID);
        }


        public List<StudentInfoModel> getStudentInfoID(string userID)
        {
            StudentInfoDAL dal = new StudentInfoDAL();
            return dal.getStudentInfoID(userID);
        }


        /// <summary>
        /// insert one Student
        /// </summary>
        /// <param name="stu"></param>
        /// <returns></returns>
        public int insertStudentInfo(StudentInfoModel stu)
        {
            StudentInfoDAL dal = new StudentInfoDAL();
            return dal.insertStudentInfo(stu);
        }

        /// <summary>
        /// update Student information by model
        /// </summary>
        /// <param name="stu"></param>
        /// <returns></returns>
        public int updateStudentInfo(StudentInfoModel stu)
        {
            StudentInfoDAL dal = new StudentInfoDAL();
            return dal.updateStudentInfo(stu);
        }

        ///<sumary>
        ///update student's headpath
        /// </sumary>
        public int updateStudentHeadpath(string stuID,string headPath)
        {
            StudentInfoBLL bll = new StudentInfoBLL();
            return bll.updateStudentHeadpath(stuID, headPath);
        }

        /// <summary>
        /// updata student borrowing book's num by stuID
        /// </summary>
        public int updateStudenBorrowNumber(int num,string stuID)
        {
            StudentInfoDAL dal = new StudentInfoDAL();
            return dal.updateStudenBorrowNumber(num, stuID);
        }

        /// <summary>
        /// delete Student by StudentID or StudentUserID
        /// </summary>
        public int deleteStudentInfo(string stuID)
        {
            StudentInfoDAL dal = new StudentInfoDAL();
            return dal.deleteStudentInfo(stuID);
        }
        /// <summary>
        /// delete Student by list about StudentID or StudentUserID ( the productive is too low )
        /// may use another way
        /// </summary>
        public int deleteStudentInfo(List<string> stuID)
        {
            StudentInfoDAL dal = new StudentInfoDAL();
            int success = 0;
              return success;
        }

        public List<SchoolGroup> getSchoolName()
        {
            GetGroups dal = new GetGroups();
            return dal.getSchoolGroup();
        }

        //public List<CollegeGroup> getCollegeName(string schoolID)
        //{
        //    GetGroups dal = new GetGroups();
        //    return dal.getCollegeGroup(schoolID);
        //}
        public List<CollegeGroup> getCollegeName(string schoolID)
        {
            GetGroups dal = new GetGroups();
            return dal.getCollegeGroup(schoolID);
        }
        public List<ProfessionGroup> getProfessionName(string collegeID)
        {
            GetGroups dal = new GetGroups();
            return dal.getProfessionGroup(collegeID);
        }
        /// <summary>
        /// /超期书的总数
        /// </summary>
        /// <param name="stuID"></param>
        /// <returns></returns>
        public int timeoutBorrowsBook(string stuID)
        {
            StudentInfoDAL dal = new StudentInfoDAL();
          int n=dal.timeoutBorrowsBook(stuID);
          dal.RewriteBorrowState(stuID);

          return n;
            

        }
    }
}
