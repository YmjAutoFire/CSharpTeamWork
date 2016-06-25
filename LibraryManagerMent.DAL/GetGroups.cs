using LibraryManagerMent.Common;
using LibraryManagerMent.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerMent.DAL
{
    public class GetGroups
    {
        /// <summary>
        /// get all school news 
        /// </summary>
        /// <returns></returns>
        public List<SchoolGroup> getSchoolGroup()
        {
            List<SchoolGroup> list = null;
            string comd = "select * from SchoolType";
            SQLHelper sh = new SQLHelper();
            using(SqlDataReader read = sh.getDataReader(comd))
            {
                if(read.HasRows)
                {
                    while(read.Read())
                    {
                        SchoolGroup group = new SchoolGroup();
                        group.SchoolID = read["schoolID"].ToString();
                        group.SchoolName = read["schoolName"].ToString();
                        list.Add(group);
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// get college news by schoolID
        /// </summary>
        /// <returns></returns>
        public List<CollegeGroup> getCollegeGroup(string schoolID)
        {
            string comd = "select * from CollegeType where schoolID=@schoolID";
            SqlParameter[] ps = { new SqlParameter("@schoolID", schoolID) };
            SQLHelper sh = new SQLHelper();
            List<CollegeGroup> list = null;
            using(SqlDataReader read = sh.getDataReader(comd,ps))
            {
                if(read.HasRows)
                {
                    while(read.Read())
                    {
                        CollegeGroup group = new CollegeGroup();
                        group.CollegeID = read["collegeID"].ToString();
                        group.CollegeName = read["collegeName"].ToString();
                        group.SchoolID = read["schoolID"].ToString();
                        list.Add(group);
                    }
                }
            }
            return list;
        }


        /// <summary>
        /// get profession news by collegeID
        /// </summary>
        /// <param name="collegeID"></param>
        /// <returns></returns>
        public List<ProfessionGroup> getProfessionGroup(string collegeID)
        {
            string comd = "select * from ProfessionType where collegeID = @collegeID";
            SqlParameter[] ps = { new SqlParameter("@collegeID", collegeID) };
            SQLHelper sh = new SQLHelper();
            List<ProfessionGroup> list = null;
            using(SqlDataReader read=sh.getDataReader(comd,ps))
            {
                if(read.HasRows)
                {
                    while(read.Read())
                    {
                        ProfessionGroup group = new ProfessionGroup();
                        group.CollegeID = read["collegeID"].ToString();
                        group.ProfessionID = read["professionID"].ToString();
                        group.ProfessionName = read["professionName"].ToString();
                        list.Add(group);
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// get book types
        /// </summary>
        /// <returns></returns>
        public List<BookTypeGroup> getBookTypeGroup()
        {
            string comd = "select * from BookType";
            List<BookTypeGroup> list = new List<BookTypeGroup>();
            SQLHelper h = new SQLHelper();
            using(SqlDataReader read = h.getDataReader(comd))
            {
                if(read.HasRows)
                {
                    while(read.Read())
                    {
                        BookTypeGroup group = new BookTypeGroup();
                        group.TypeID = read["typeID"].ToString();
                        group.TypeName = read["typeName"].ToString();
                        group.ParentID = read["parentID"].ToString();
                        list.Add(group);
                    }
                }
            }
            return list;
        }



    }
}
