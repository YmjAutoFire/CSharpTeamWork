using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerMent.Factory
{
    public class AbstractIDALFactory
    {
        private readonly string classPath = System.Configuration.ConfigurationManager.AppSettings["IDALClassPath"];
        private readonly string assemblyPath = System.Configuration.ConfigurationManager.AppSettings["IDALAssemblyPath"];

        //AdminInfoIDAL
        public IDAL.AdminInfoIDAL CreateAdminIDAL()
        {
            string fullClassPath = classPath + "AdminInfoDAL";
            return CreateInstance(fullClassPath) as IDAL.AdminInfoIDAL;
        }

        //StudentInfoIDAL
        public IDAL.StudentInfoIDAL CreateStudentIDAL()
        {
            string fullClassPath = classPath + "StudentInfoDAL";
            return CreateInstance(fullClassPath) as IDAL.StudentInfoIDAL;
        }

        //BookInfoIDAL
        public IDAL.BookInfoIDAL CreateBookIDAL()
        {
            string fullClassPath = classPath + "BookInfoDAL";
            return CreateInstance(fullClassPath) as IDAL.BookInfoIDAL;
        }


        private object CreateInstance(string fullClassPath)
        {
            Assembly ass = Assembly.Load(assemblyPath);
            return ass.CreateInstance(fullClassPath);
        }
        
    }
}
