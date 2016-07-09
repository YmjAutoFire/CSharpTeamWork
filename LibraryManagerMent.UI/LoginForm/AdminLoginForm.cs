using LibraryManagerMent.BLL;
using LibraryManagerMent.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagerMent.UI.LoginForm
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }
        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        //注册
        private void btnRegist_Click(object sender, EventArgs e)
        {
            if(txtLoginID.Text.Trim()=="")
            {
                MessageBox.Show("用户名不能为空");
                return;
            }
            if(txtName.Text.Trim()=="")
            {
                MessageBox.Show("姓名不能为空");
                return;
            }
            if(txtpwd.Text.Trim()=="")
            {
                MessageBox.Show("密码不能为空");
                return;
            }
            if(txtpwd.Text.Trim()!=txtpwds.Text.Trim())
            {
                MessageBox.Show("两次密码不一致");
                return;
            }
            AdminInfoModel admin = new AdminInfoModel();
            admin.LoginID = txtLoginID.Text.Trim();
            admin.AdminName = txtName.Text.Trim();
            admin.AdminPwd = txtpwd.Text.Trim();
            AdminInfoBLL bll = new AdminInfoBLL();
            if (bll.insertAdminInfo(admin) == 1)
            {
                MessageBox.Show("注册成功");
            }
            else
                MessageBox.Show("注册失败");
            this.Close();
        }
    }
}
