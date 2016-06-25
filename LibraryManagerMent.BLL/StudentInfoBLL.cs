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



    }
}
