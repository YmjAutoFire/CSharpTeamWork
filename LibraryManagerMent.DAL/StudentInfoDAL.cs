using LibraryManagerMent.Common;
using LibraryManagerMent.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerMent.DAL
{
    public class StudentInfoDAL
    {

        /// <summary>
        /// get all Student information by List
        /// </summary>
        /// <returns></returns>
        public List<StudentInfoModel> getAllStudentInfoList()
        {
            List<StudentInfoModel> list = new List<StudentInfoModel>();
            string comd = "select stuid,stuname,stupwd,schoolname,headpath,collegename,professionname,stuclass,entrance,nowborrows,nowscredit from StudentInfo,schooltype,collegetype,professiontype where schooltype.schoolid=studentinfo.schoolid and collegetype.collegeid=studentinfo.collegeid and professiontype.professionid=studentinfo.professionid";
            SQLHelper h = new SQLHelper();
            using (SqlDataReader read = h.getDataReader(comd))
            {
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        FillModel(list, read);
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// 填充对象
        /// </summary>
        /// <param name="list"></param>
        /// <param name="read"></param>
        private static void FillModel(List<StudentInfoModel> list, SqlDataReader read)
        {
            StudentInfoModel stu = new StudentInfoModel();
            stu.StuID = read["stuID"].ToString();
            stu.StuName = read["stuName"].ToString();
            stu.StuPwd = read["stuPwd"].ToString();
            stu.SchoolID = read["schoolName"].ToString();
            stu.CollegeID = read["collegeName"].ToString();
            stu.ProfessionID = read["professionName"].ToString();
            stu.StuClass = read["stuClass"].ToString();
            stu.NowBorrows = Convert.ToInt32(read["nowBorrows"]);
            stu.NowsCredit = Convert.ToInt32(read["nowsCredit"]);
            stu.HeadPath = read["headPath"].ToString();
            stu.Entrance = Convert.ToDateTime(read["entrance"]);

            list.Add(stu);
        }

        /// <summary>
        /// get  Student information by page List by field
        /// </summary>
        public DataTable getStudentInfoListByPage(int beginNum, int endNum, string  field)
        {
            
            string comd = "select * from (select *,row_number() over(order by @feild desc)as number from StudentInfo ) as stunums where number >= @beginNum and number <= @endNum";
            SqlParameter[] ps ={
                                   new SqlParameter("@field",field),
                                   new SqlParameter("@beginNum",SqlDbType.Int){Value = beginNum},
                                   new SqlParameter("@endNum",SqlDbType.Int){Value = endNum}
                               };
            SQLHelper h = new SQLHelper();
            return h.getDataTable(comd, ps);
        }

        

        /// <summary>
        /// get login Student information by stuID
        /// </summary>
        public StudentInfoModel getStudentInfoByID(string stuID)
        {
           
            StudentInfoModel stu = null;
            string comd ="select stuid,stuname,stupwd,schoolid,headpath,collegeid,professionid,stuclass,entrance,nowborrows,nowscredit from StudentInfo where stuID = @stuID";
            SqlParameter[] ps = { new SqlParameter("@stuID", stuID) };
            SQLHelper h = new SQLHelper();
            using (SqlDataReader read = h.getDataReader(comd, ps)) 
            {
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        stu = new StudentInfoModel();
                        stu.StuID = read["stuID"].ToString();
                        stu.StuName = read["stuName"].ToString();
                        stu.StuPwd = read["stuPwd"].ToString();
                        stu.SchoolID = read["schoolID"].ToString();
                        stu.CollegeID = read["collegeID"].ToString();
                        stu.ProfessionID = read["professionID"].ToString();
                        stu.StuClass = read["stuClass"].ToString();
                        stu.NowBorrows = Convert.ToInt32(read["nowBorrows"]);
                        stu.NowsCredit = Convert.ToInt32(read["nowsCredit"]);
                        stu.HeadPath = read["headPath"].ToString();
                        stu.Entrance = Convert.ToDateTime(read["entrance"]);
                    }
                }
            }
            return stu;
        }



        public List<StudentInfoModel> getStudentInfoID(string stuID)
        {
            List<StudentInfoModel> list = new List<StudentInfoModel>();
            StudentInfoModel stu = null;
            string comd = "select stuid,stuname,stupwd,schoolid,headpath,collegeid,professionid,stuclass,entrance,nowborrows,nowscredit from StudentInfo where stuID = @stuID";
            SqlParameter[] ps = { new SqlParameter("@stuID", SqlDbType.VarChar) { Value = stuID } };
            SQLHelper h = new SQLHelper();
            using (SqlDataReader read = h.getDataReader(comd, ps))
            {
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        stu = new StudentInfoModel();
                        stu.StuID = read["stuID"].ToString();
                        stu.StuName = read["stuName"].ToString();
                        stu.StuPwd = read["stuPwd"].ToString();
                        stu.SchoolID = read["schoolID"].ToString();
                        stu.CollegeID = read["collegeID"].ToString();
                        stu.ProfessionID = read["professionID"].ToString();
                        stu.StuClass = read["stuClass"].ToString();
                        stu.NowBorrows = Convert.ToInt32(read["nowBorrows"]);
                        stu.NowsCredit = Convert.ToInt32(read["nowsCredit"]);
                        stu.HeadPath = read["headPath"].ToString();
                        stu.Entrance = Convert.ToDateTime(read["entrance"]);
                    }
                    list.Add(stu);
                }
            }
            return list;
        }




        /// <summary>
        /// insert one Student
        /// </summary>
        /// <param name="stu"></param>
        /// <returns></returns>
        public int insertStudentInfo(StudentInfoModel stu)
        {
            string comd = "insert into StudentInfo values(@stuID, @stuName, @schoolID, @collegeID, @professionID, @stuClass, @stuPwd, @nowBorrows, @nowsCredit, @headPath, @entrance  )";
            SqlParameter[] ps = { 
                    new SqlParameter("@stuID",stu.StuID),                
                    new SqlParameter("@stuName",stu.StuName),                
                    new SqlParameter("@schoolID",stu.SchoolID),                
                    new SqlParameter("@collegeID",stu.CollegeID),                
                    new SqlParameter("@professionID",stu.ProfessionID),                
                    new SqlParameter("@stuClass",stu.StuClass),                
                    new SqlParameter("@stuPwd",stu.StuPwd),                
                    new SqlParameter("@nowBorrows",stu.NowBorrows),                
                    new SqlParameter("@nowsCredit",stu.NowsCredit),                
                    new SqlParameter("@headPath",stu.HeadPath),                
                    new SqlParameter("@entrance",stu.Entrance),                
                };
            SQLHelper h = new SQLHelper();
            return h.ExecuteNonQuery(comd,ps);
        }

        /// <summary>
        /// update Student information by model
        /// </summary>
        /// <param name="stu"></param>
        /// <returns></returns>
        public int updateStudentInfo(StudentInfoModel stu)
        {
            string comd = "update StudentInfo set stuName=@stuName,stuPwd=@stuPwd,headPath=@headPath where stuID=@stuID ";
            SqlParameter[] ps = { 
                    new SqlParameter("@stuName",stu.StuName),   
                    new SqlParameter("@stuPwd",stu.StuPwd),
                    new SqlParameter("@headPath",stu.HeadPath),
                    new SqlParameter("@stuID",stu.StuID)
                };
            SQLHelper h = new SQLHelper();
            return h.ExecuteNonQuery(comd,ps);
        }

        /// <summary>
        /// updata student borrowing book's num by stuID
        /// </summary>
        public int updateStudenBorrowNumber(int num,string stuID)
        {
            string comd = "update StudentInfo set nowBorrows = nowBorrows + @num   where  stuID = @stuID";
            SqlParameter[] ps = { 
                    new SqlParameter("@num",SqlDbType.Int){Value = num},
                    new SqlParameter("@stuID",SqlDbType.NVarChar){Value = stuID}                
                };
            SQLHelper h = new SQLHelper();
            return h.ExecuteNonQuery(comd,ps);
        }

        public int updateStudentHeadPath(string stuID,string headPath)
        {
            string comd = "update StudentInfo set headpath=@headpath   where  stuID = @stuID";
            SqlParameter[] ps = { 
                    new SqlParameter("@headpath",SqlDbType.Int){Value = headPath},
                    new SqlParameter("@stuID",SqlDbType.NVarChar){Value = stuID}                
                };
            SQLHelper h = new SQLHelper();
            return h.ExecuteNonQuery(comd,ps);
        }


        /// <summary>
        /// delete Student by StudentID or StuID
        /// </summary>
        public int deleteStudentInfo(string stuID)
        {
            string comd = "delete from StudentInfo where stuID = @stuID";
            SqlParameter[] ps = { 
                    new SqlParameter("@stuID",SqlDbType.NVarChar){Value = stuID}                
                };
            SQLHelper h = new SQLHelper();
            return h.ExecuteNonQuery(comd,ps);
        }
        /// <summary>
        /// 获取学校的名字
        /// </summary>
        /// <returns></returns>
        public List<SchoolGroup> getSchoolName()
        {
            List<SchoolGroup> list = new List<SchoolGroup>();
            SchoolGroup stu = null;
            string comd = "select distinct schoolid from schooltype and schoolid in (select schoolid from schooltype)";
            SQLHelper h = new SQLHelper();
            using (SqlDataReader read = h.getDataReader(comd))
            {
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        stu = new SchoolGroup();
                        stu.SchoolID = read["schoolID"].ToString();
                        stu.SchoolName = read["schoolname"].ToString();

                        list.Add(stu);
                    }
                }
            }
            return list;
        }
        public int timeoutBorrowsBook(string stuID)
        {
            string comd = "select count(*) from borrowhistory where stuid=@stuid and timeliness=1";
            SQLHelper h = new SQLHelper();
            SqlParameter[] ps ={
                               new SqlParameter("@stuID",stuID)
                           };
             return Convert.ToInt32(h.ExecuteScalar(comd, ps));
        }
        /// <summary>
        /// 更改超期图书状态
        /// </summary>
        /// <param name="stuID"></param>
        public void RewriteBorrowState(string stuID)
        {
            string comd = "update BorrowHistory set timeLiness=0 where timeliness=1 and stuId=@stuID";
                SqlParameter[] ps={
                                      new SqlParameter("@stuID",stuID)
                                  };
           SQLHelper h=new SQLHelper();
            h.ExecuteNonQuery(comd,ps);

        }
    //    /// <summary>
    //    /// 获取学院名
    //    /// </summary>
    //    /// <returns></returns>
    //    public List<CollegeGroup> getCollegeName()
    //    {
    //        List<CollegeGroup> list = new List<CollegeGroup>();
    //        CollegeGroup stu = null;
    //        string comd = "select distinct colleid from collegetype where collegeid  in (select collegeid from collegetype)";
    //        SQLHelper h = new SQLHelper();
    //        using (SqlDataReader read = h.getDataReader(comd))
    //        {
    //            if (read.HasRows)
    //            {
    //                while (read.Read())
    //                {
    //                    stu = new CollegeGroup();
    //                    stu.CollegeID = read["collegeid"].ToString();
    //                    stu.CollegeName = read["collegename"].ToString();

    //                    list.Add(stu);
    //                }
    //            }
    //        }
    //        return list;
    //    }

    //   /// <summary>
    //   /// 获取专业名
    //   /// </summary>
    //   /// <returns></returns>
    //    public List<ProfessionGroup> getProfessionName()
    //    {
    //        List<ProfessionGroup> list = new List<ProfessionGroup>();
    //        ProfessionGroup stu = null;
    //        string comd = "select distinct professionid from professiontype where professionlid in (select professionid from professiontype)";
    //        SQLHelper h = new SQLHelper();
    //        using (SqlDataReader read = h.getDataReader(comd))
    //        {
    //            if (read.HasRows)
    //            {
    //                while (read.Read())
    //                {
    //                    stu = new ProfessionGroup();
    //                    stu.ProfessionID = read["professionid"].ToString();
    //                    stu.ProfessionName = read["professionname"].ToString();
    //                    list.Add(stu);
    //                }
    //            }
    //        }
    //        return list;
    //    }
 
    }
}
