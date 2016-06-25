using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerMent.Common
{
    public class MD5Helper
    {
        /// <summary>
        /// Compile String for MD5
        /// </summary>
        /// <param name="arm">the arm string </param>
        /// <returns></returns>
        public string CreateStringMD5(string arm)
        {
            StringBuilder build = new StringBuilder();
            using (MD5 md = MD5.Create())
            {
                byte[] buffer = System.Text.Encoding.Default.GetBytes(arm);
                byte[] hash = md.ComputeHash(buffer);
                md.Clear();
                for (int i = 0; i < hash.Length; i++)
                {
                    build.Append(hash[i].ToString("x2"));
                }
            }
            return build.ToString();
        }

        /// <summary>
        /// Compile File for MD5 by filePath(though i think it's not useful)
        /// </summary>
        /// <param name="filePath">the arm filePath</param>
        /// <returns></returns>
        public String CreateFilePathMD5(string filePath)
        {
            StringBuilder build = new StringBuilder();
            using(FileStream fsread = new FileStream(filePath,FileMode.Open,FileAccess.Read))
            {
                using(MD5 md = MD5.Create())
                {
                    byte[] buffer = md.ComputeHash(fsread);
                    md.Clear();
                    for(int i=0;i<buffer.Length; i++)
                    {
                        build.Append(buffer[i].ToString("x2"));
                    }
                }
            }
            return build.ToString();
        }




    }
}
