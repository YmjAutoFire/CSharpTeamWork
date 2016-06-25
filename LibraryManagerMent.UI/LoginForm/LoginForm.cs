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

namespace LibraryManagerMent.UI
{
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
        }

        //学生登录委托
        delegate void getLoginStudent(StudentInfoModel student);
      
        //管理员登录委托
        delegate void getLoginAdmin(AdminInfoModel admin);

        /// <summary>
        /// ----   begin log in
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            lblP.Visible = false;
            lblU.Visible = false;
            MainForm main = new MainForm();
            if (this.rdoUser.Checked == true)
            {
                StudentInfoModel student = new StudentInfoModel();

                if (checkStudent(student))
                {
                    getLoginStudent login = new getLoginStudent(main.getLoginStudent);
                    login(student);
                    main.Show();

                    this.Hide();
                }
            }
            else
            {
                AdminInfoModel admin = new AdminInfoModel();

                if (checkAdmin(admin))
                {
                    getLoginAdmin login = new getLoginAdmin(main.getLoginAdmin);
                    login(admin);
                    main.Show();

                    this.Hide();
                }
            }

            
            
        }

        

        //check student whether exist
        private bool checkStudent(StudentInfoModel stu)
        {
            StudentInfoBLL bll = new StudentInfoBLL();
            stu =  bll.getStudentInfoByID(txtUser.Text.Trim());
            if (stu == null)
            {
                lblU.Visible = true;
                return false;
            }
            else
            {
                if (stu.StuPwd == txtPwd.Text.Trim())
                {
                    return true;
                }
                else
                {
                    lblP.Visible = true;
                    return false;
                }
            }
        }
        //check admin whether exist
        private bool checkAdmin(AdminInfoModel admin)
        {
            AdminInfoBLL bll = new AdminInfoBLL();
            admin = bll.getAdminInfoByID(txtUser.Text.Trim());
            if (admin == null)
            {
                lblU.Visible = true;
                return false;
            }
            else if (admin.AdminPwd == txtPwd.Text.Trim())
                return true;
            else
            {
                lblP.Visible = true;
                return false;
            }
        }
        /// <summary>
        /// 勾画标题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginFrom_Paint(object sender, PaintEventArgs e)
        {
            string name = "任性图书馆";
            Graphics g = e.Graphics;
            string[] fonts = { "微软雅黑", "仿宋gb2312", "华文琥珀", "楷体" };
            Color[] c = {Color.Blue,Color.Purple,Color.Violet,Color.Tomato,Color.SeaGreen};
            Random r = new Random();
            Point[] ps = new Point[6];
            for(int i=1;i<=name.Length;i++)
            {
                ps[i-1] = new Point(32+50 * i, 40 + i * r.Next(-9, 12));
            }
            for(int i=0;i<name.Length;i++)
            {
                g.DrawString(name[i].ToString(), new Font(fonts[r.Next(0, fonts.Length)], 43, FontStyle.Italic), new SolidBrush(c[r.Next(0, c.Length)]), ps[i]);
            }
        }

        private void LoginFrom_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 注册新用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void llblRegist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            lblP.Visible = false;
            lblU.Visible = false;
        }

        private void txtPwd_Enter(object sender, EventArgs e)
        {
            lblP.Visible = false;
            lblU.Visible = false;
        }




    }
}
