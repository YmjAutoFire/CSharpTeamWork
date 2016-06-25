using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibraryManagerMent.Model;
using LibraryManagerMent.Common;
using System.Data.SqlClient;

namespace LibraryManagerMent.DAL
{
    public class AdminInfoDAL
    {
        /// <summary>
        /// get all admin information by List
        /// </summary>
        /// <returns></returns>
        public List<AdminInfoModel> getAllAdminInfoList()
        {
            List<AdminInfoModel> list = new List<AdminInfoModel>();
            string comd = "select * from AdminInfo";
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
        /// 填充admin对象
        /// </summary>
        /// <param name="list"></param>
        /// <param name="read"></param>
        private static void FillModel(List<AdminInfoModel> list, SqlDataReader read)
        {
            AdminInfoModel admin = new AdminInfoModel();
            admin.AdminID = read["adminID"].ToString();
            admin.AdminName = read["adminName"].ToString();
            admin.AdminPwd = read["adminPwd"].ToString();
            admin.LoginID = read["loginID"].ToString();

            list.Add(admin);
        }

        /// <summary>
        /// get login admin information by loginID
        /// </summary>
        public AdminInfoModel getAdminInfoByID(string loginID)
        {
            AdminInfoModel admin = null;
            string comd = "select * from AdminInfo where loginID = @loginID";
            SqlParameter[] ps = { new SqlParameter("@loginID", SqlDbType.VarChar) { Value = loginID } };
            SQLHelper h = new SQLHelper();
            using(SqlDataReader read = h.getDataReader(comd,ps))
            {
                if(read.HasRows)
                {
                    read.Read();
                    admin = new AdminInfoModel();
                    admin.AdminID = read["adminID"].ToString();
                    admin.AdminName = read["adminName"].ToString();
                    admin.AdminPwd = read["adminPwd"].ToString();
                    admin.LoginID = read["loginID"].ToString();
                }
            }
            return admin;
        }

        /// <summary>
        /// insert one admin
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public int insertAdminInfo(AdminInfoModel admin)
        {
            string comd = "insert into AdminInfo values( @loginID ,@adminID ,@adminName,@adminPwd  )";
            SqlParameter[] ps = { 
                    new SqlParameter("@loginID",SqlDbType.NVarChar){Value = admin.LoginID}   ,             
                    new SqlParameter("@adminID",SqlDbType.NVarChar){Value = admin.AdminID} ,               
                    new SqlParameter("@adminName",SqlDbType.NVarChar){Value = admin.AdminName}  ,              
                    new SqlParameter("@adminPwd",SqlDbType.NVarChar){Value = admin.AdminPwd}                
                };
            SQLHelper h = new SQLHelper();
            return h.ExecuteNonQuery(comd);
        }

        /// <summary>
        /// update admin information by model
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public int updateAdminInfo(AdminInfoModel admin)
        {
            string comd = "update AdminInfo set adminName=@adminName,adminPwd=@adminPwd    where  adminID=@adminID    ";
            SqlParameter[] ps = { 
                    new SqlParameter("@adminName",SqlDbType.NVarChar){Value = admin.AdminName},                
                    new SqlParameter("@adminPwd",SqlDbType.NVarChar){Value = admin.AdminPwd},                
                    new SqlParameter("@adminID",SqlDbType.NVarChar){Value = admin.AdminID}               
                };
            SQLHelper h = new SQLHelper();
            return h.ExecuteNonQuery(comd);
        }

        /// <summary>
        /// delete admin by model
        /// </summary>
        public int deleteAdminInfo(AdminInfoModel admin)
        {
            string comd = "delete from AdminInfo where adminPwd=@adminPwd and loginID = @loginID  ";
            SqlParameter[] ps = { 
                    new SqlParameter("@adminPwd",SqlDbType.NVarChar){Value = admin.AdminPwd}   ,             
                    new SqlParameter("@loginID",SqlDbType.NVarChar){Value = admin.LoginID}          
                };
            SQLHelper h = new SQLHelper();
            return h.ExecuteNonQuery(comd);
        }
        /// <summary>
        /// delete admin by adminID or adminUserID
        /// </summary>
        public int deleteAdminInfo(string adminID)
        {
            string comd = "delete from AdminInfo where  adminID = @adminID or loginID = @adminID";
            SqlParameter[] ps = { 
                    new SqlParameter("@adminID",SqlDbType.VarChar){Value = adminID}                
                };
            SQLHelper h = new SQLHelper();
            return h.ExecuteNonQuery(comd);
        }


    }
}
