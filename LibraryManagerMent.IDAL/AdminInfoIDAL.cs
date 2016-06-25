using LibraryManagerMent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerMent.IDAL
{
     public interface AdminInfoIDAL
    {
        /// <summary>
        /// get all admin information by List
        /// </summary>
        /// <returns></returns>
         List<AdminInfoModel> getAllAdminInfoList();

        /// <summary>
        /// get login admin information by adminUserID
        /// </summary>
         AdminInfoModel getAdminInfoByID(string userID);
        
        /// <summary>
        /// insert one admin
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
         int insertAdminInfo(AdminInfoModel admin);

         /// <summary>
        /// update admin information by model
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
         int updateAdminInfo(AdminInfoModel admin);

        /// <summary>
        /// delete admin by model
        /// </summary>
         int deleteAdminInfo(AdminInfoModel admin);

         /// <summary>
        /// delete admin by adminID or adminUserID
        /// </summary>
         int deleteAdminInfo(string adminID);


    }
}
