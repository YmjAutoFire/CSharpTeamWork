using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagerMent.BLL;
using LibraryManagerMent.Model;
using LibraryManagerMent.Common;
using System.Data.SqlClient;


namespace LibraryManagerMent.UI
{
    public partial class InfoBaseForm : Form
    {
        public string stuID;
        //public string username;
        public InfoBaseForm()
        {
            InitializeComponent();
        }

        private void InfoBaseForm_Load(object sender, EventArgs e)
        {
            StudentInfoBLL stubll = new StudentInfoBLL();
            StudentInfoModel stuModel = new StudentInfoModel();
            GetGroupsBLL group = new GetGroupsBLL();

            stuModel = stubll.getStudentInfoByID(stuID);
            txtstuName.Text = stuModel.StuName;
            txtstuName.ReadOnly = true;

            txtstuID.Text = stuModel.StuID;
            txtstuID.ReadOnly = true;

            txtentrance.Text = stuModel.StuClass ;
            txtentrance.ReadOnly = true;

            BorrowHistoryBLL bll = new BorrowHistoryBLL();
            List<ShowBorrowHistory> list = bll.getListBorrowHisoryNow(stuModel.StuID);

            txtnowBorrows.Text = list.Count.ToString();




            string sql = "select schoolName from SchoolType where schoolid='"+stuModel.SchoolID+"'";
            SQLHelper h = new SQLHelper();
            SqlParameter[] psa = {
                                    new SqlParameter("@stuID",stuID),   
                                };
            string s = h.ExecuteScalar(sql, psa).ToString();
            txtschool.Text = s;
            txtschool.ReadOnly = true;

            string sqla = "select CollegeName from Collegetype where CollegeId=" + "'" + stuModel.CollegeID + "'";
            SQLHelper a = new SQLHelper();
            SqlParameter[] psb = {
                                    new SqlParameter("@stuID",stuID),   
                                };
            string t = a.ExecuteScalar(sqla, psb).ToString();
            txtcollege.Text = t;
            txtcollege.ReadOnly = true;

            string sqlb = "select ProfessionName from professiontype where ProfessionID=" + "'" + stuModel.ProfessionID + "'";
            SQLHelper b = new SQLHelper();
            SqlParameter[] psc = {
                                    new SqlParameter("@stuID",stuID),   
                                };
            string u = b.ExecuteScalar(sqlb, psc).ToString();
            txtprofession.Text = u;
            txtprofession.ReadOnly = true;

            txtstuClass.Text = stuModel.StuClass;
            txtstuClass.ReadOnly = true;
            StudentInfoBLL stublld=new StudentInfoBLL();
            
                int m=stublld.timeoutBorrowsBook(stuID);
                stuModel.NowsCredit =stuModel.NowsCredit- m;
                txtnowsCredit.Text = stuModel.NowsCredit.ToString();
                stublld.updateStudentInfo(stuModel); 
          
        }

        private void headPath_Click(object sender, EventArgs e)
        {
            
        }
        //头像选择
        private void btnpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            if (!string.IsNullOrEmpty(open.FileName))
            {
                string file = open.FileName;
                headPath.Image = Image.FromFile(file);
                StudentInfoBLL bll = new StudentInfoBLL();
                if (bll.updateStudentHeadpath(stuID, file) == 1)
                    MessageBox.Show("修改成功");
                else MessageBox.Show("修改失败");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePwd u=new UpdatePwd();
            u.stuID = stuID;
            u.Show();
        }
    }
}
