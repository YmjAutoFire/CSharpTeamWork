using LibraryManagerMent.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerMent.IDAL
{
     public interface StudentInfoIDAL
    {
        /// <summary>
        /// get all Student information by List
        /// </summary>
        /// <returns></returns>
         List<StudentInfoModel> getAllStudentInfoList();

         /// <summary>
        /// get  Student information by page List by field
        /// </summary>
        List<StudentInfoModel> getStudentInfoListByPage(int beginNum, int endNum, string field);

        /// <summary>
        /// get login Student information by StudentUserID
        /// </summary>
         StudentInfoModel getStudentInfoByID(string userID);

        /// <summary>
        /// insert one Student
        /// </summary>
        /// <param name="stu"></param>
        /// <returns></returns>
         int insertStudentInfo(StudentInfoModel stu);

        /// <summary>
         /// update Student information by model( many fields fuzzy query )
        /// </summary>
        /// <param name="stu"></param>
        /// <returns></returns>
         int updateStudentInfo(StudentInfoModel stu);

        /// <summary>
        /// updata student borrowing book's num by stuID
        /// </summary>
         int updateStudenBorrowNumber(int num, string stuID);


        /// <summary>
        /// delete Student by StudentID or StudentUserID
        /// </summary>
         int deleteStudentInfo(string stuID);
    }
}
