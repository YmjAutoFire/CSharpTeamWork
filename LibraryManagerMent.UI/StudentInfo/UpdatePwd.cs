using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using LibraryManagerMent.Model;
using LibraryManagerMent.BLL;

namespace LibraryManagerMent.UI
{
    public partial class UpdatePwd : Form
    {
        public string stuID;
        public UpdatePwd()
        {
            InitializeComponent();
        }

        private void UpdatePwd_Load(object sender, EventArgs e)
        {

        }

        private void txtp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPwd_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            string pwd = txtp.Text;
            string pp = txtPwd.Text;
            if (pwd != pp)
                MessageBox.Show("密码不一致", "错误");
            else
            {

                StudentInfoBLL stubll = new StudentInfoBLL();
                StudentInfoModel stu = stubll.getStudentInfoByID(stuID);
                stu.StuPwd = pwd;
                if (stubll.updateStudentInfo(stu) == 1)
                {
                    this.Close();
                    this.Dispose();
                }
            }
        }
    }
}
