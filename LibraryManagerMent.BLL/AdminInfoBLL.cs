using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerMent.DAL;
using LibraryManagerMent.Model;

namespace LibraryManagerMent.BLL
{
    public class AdminInfoBLL
    {
         
        /// <summary>
        /// get all admin information by List
        /// </summary>
        /// <returns></returns>
        public List<AdminInfoModel> getAllAdminInfoList()
        {
            AdminInfoDAL dal = new AdminInfoDAL();
            return dal.getAllAdminInfoList();
        }

        /// <summary>
        /// get login admin information by adminUserID
        /// </summary>
        public AdminInfoModel getAdminInfoByID(string userID)
        {
            AdminInfoDAL dal = new AdminInfoDAL();
            return dal.getAdminInfoByID(userID);
        }

         /// <summary>
        /// insert one admin
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public int insertAdminInfo(AdminInfoModel admin)
        {
            AdminInfoDAL dal = new AdminInfoDAL();
            return dal.insertAdminInfo(admin);
        }

        /// <summary>
        /// update admin information by model
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public int updateAdminInfo(AdminInfoModel admin)
        {
            AdminInfoDAL dal = new AdminInfoDAL();
            return dal.insertAdminInfo(admin);
        }

        /// <summary>
        /// delete admin by model
        /// </summary>
        public int deleteAdminInfo(AdminInfoModel admin)
        {
            AdminInfoDAL dal = new AdminInfoDAL();
            return dal.deleteAdminInfo(admin);
        }
        /// <summary>
        /// delete admin by adminID or adminUserID
        /// </summary>
        public int deleteAdminInfo(string adminID)
        {
            AdminInfoDAL dal = new AdminInfoDAL();
            return dal.deleteAdminInfo(adminID);
        }
    }
}
