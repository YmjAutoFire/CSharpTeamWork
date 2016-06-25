using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerMent.Factory
{
    public class AbstractIBLLFactory
    {
        private readonly string classPath = System.Configuration.ConfigurationManager.AppSettings["IBLLClassPath"];
        private readonly string assemblyPath = System.Configuration.ConfigurationManager.AppSettings["IBLLAssemblyPath"];

        //AdminInfoIBLL
        public IBLL.AdminInfoIBLL CreateAdminIBLL()
        {
            string fullClassPath = classPath + "AdminInfoBLL";
            return CreateInstance(fullClassPath) as IBLL.AdminInfoIBLL;
        }
        //BookInfoIBLL
        public IBLL.BookInfoIBLL CreateBookIBLL()
        {
            string fullClassPath = classPath + "BookInfoBLL";
            return CreateInstance(fullClassPath) as IBLL.BookInfoIBLL;
        }
        //StudentInfoIBLL
        public IBLL.StudentInfoIBLL CreateStudentIBLL()
        {
            string fullClassPath = classPath + "StudentInfoBLL";
            return CreateInstance(fullClassPath) as IBLL.StudentInfoIBLL;
        }




        private object CreateInstance(string fullClassPath)
        {
            Assembly ass = Assembly.Load(assemblyPath);
            //create arm assembly's class
            return ass.CreateInstance(fullClassPath);
        }
    }
}
