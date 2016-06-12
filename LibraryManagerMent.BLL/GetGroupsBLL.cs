using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerMent.DAL;
using LibraryManagerMent.Model;

namespace LibraryManagerMent.BLL
{
    public class GetGroupsBLL
    {
        /// <summary>
        /// get all school news 
        /// </summary>
        /// <returns></returns>
        public List<SchoolGroup> getSchoolGroup()
        {
            GetGroups group = new GetGroups();
            return group.getSchoolGroup();
        }

        /// <summary>
        /// get college news by schoolID
        /// </summary>
        /// <returns></returns>
        public List<CollegeGroup> getCollegeGroup(string schoolID)
        {
            GetGroups group = new GetGroups();
            return group.getCollegeGroup(schoolID);
        }

        /// <summary>
        /// get profession news by collegeID
        /// </summary>
        /// <param name="collegeID"></param>
        /// <returns></returns>
        public List<ProfessionGroup> getProfessionGroup(string collegeID)
        {
            GetGroups group = new GetGroups();
            return group.getProfessionGroup(collegeID);
        }


        /// <summary>
        /// get book types
        /// </summary>
        /// <returns></returns>
        public List<BookTypeGroup> getBookTypeGroup()
        {
            GetGroups g = new GetGroups();
            return g.getBookTypeGroup();
        }

    }
}
