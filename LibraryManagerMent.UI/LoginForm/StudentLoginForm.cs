using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagerMent.Model;
using LibraryManagerMent.BLL;

namespace LibraryManagerMent.UI.LoginForm
{
    public partial class StudentLoginForm : Form
    {
        public StudentLoginForm()
        {
            InitializeComponent();
        }

        //注册
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtStuID.Text.Trim()=="")
            {
                MessageBox.Show("学号不能为空");
                return;
            }
            if(txtStuName.Text.Trim()=="")
            {
                MessageBox.Show("姓名不能为空");
                return;
            }
            StudentInfoModel stu = new StudentInfoModel();
            stu.StuID = txtStuID.Text.Trim();
            stu.StuName = txtStuName.Text.Trim();
            stu.StuPwd = stu.StuID;
            stu.NowBorrows = 0;
            stu.NowsCredit = 10;
            stu.SchoolID = ((SchoolGroup)combSchool.SelectedItem).SchoolID;
            stu.CollegeID = ((CollegeGroup)combCollege.SelectedItem).CollegeID;
            stu.ProfessionID = ((ProfessionGroup)combProfession.SelectedItem).ProfessionID;
            stu.HeadPath = txtpic.Text.Trim();
            stu.StuClass = numClass.Value.ToString();
            stu.Entrance = dtpEntrance.Value;
            StudentInfoBLL bll = new StudentInfoBLL();
            if (bll.insertStudentInfo(stu) == 1)
                MessageBox.Show("注册成功");
            else MessageBox.Show("注册失败");
            this.Close();
        }
        //窗体加载
        private void StudentLoginForm_Load(object sender, EventArgs e)
        {
            GetGroupsBLL bll = new GetGroupsBLL();
            combSchool.DataSource = bll.getSchoolGroup();
            combSchool.ValueMember = "SchoolName";
        }

        //选择学校后
        private void combSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetGroupsBLL bll = new GetGroupsBLL();
            string schoolID = ((SchoolGroup)(combSchool.SelectedItem)).SchoolID;
            combCollege.DataSource = bll.getCollegeGroup(schoolID);
            combCollege.ValueMember = "CollegeName";
        }
        /// <summary>
        /// 选择学院后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void combCollege_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetGroupsBLL bll = new GetGroupsBLL();
            string collegeID = ((CollegeGroup)combCollege.SelectedItem).CollegeID;
            combProfession.DataSource = bll.getProfessionGroup(collegeID);
            combProfession.ValueMember = "ProfessionName";
        }

        

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        //头像选择
        private void txtpic_Enter(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            if (!string.IsNullOrEmpty(open.FileName))
            {
                string file = open.FileName;
                txtpic.Text = file;
            }
        }
    }
}
