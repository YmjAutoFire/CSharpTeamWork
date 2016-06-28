using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibraryManagerMent.Model;
using LibraryManagerMent.BLL;
using LibraryManagerMent.UI.LoginForm;

namespace LibraryManagerMent.UI
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            PageSize = 20;
            PageCount = 0;
            this.dgvStudent.AutoGenerateColumns = false;
        }
      
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string txtstuid =textBox1.Text;
            StudentInfoBLL stubll = new StudentInfoBLL();
           List<StudentInfoModel> list=stubll.getStudentInfoID(txtstuid);
           this.dgvStudent.DataSource = list;
                                                                              
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            StudentLoginForm a=new StudentLoginForm();
            a.Show();
           
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            StudentInfoBLL stubll = new StudentInfoBLL();
            List<StudentInfoModel> list = stubll.getAllStudentInfoList();
            this.dgvStudent.DataSource = list;
        }



        public int PageSize { get; set; }

        public int PageCount { get; set; }

        private void btndelete_Click(object sender, EventArgs e)
        {
            StudentInfoBLL stubll = new StudentInfoBLL();
            string p = (string)dgvStudent.CurrentRow.Cells[0].Value;
            stubll.deleteStudentInfo(p);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
          
           StudentInfoModel stu = new StudentInfoModel();
           stu = (StudentInfoModel)dgvStudent.CurrentRow.DataBoundItem; 
            StudentInfoBLL stubll = new StudentInfoBLL();
           stubll.updateStudentInfo(stu);
        }

        private void dgvStudent_DoubleClick(object sender, EventArgs e)
        {
            if (this.dgvStudent.SelectedRows.Count > 0)
            {
                foreach (DataGridViewCell cel in this.dgvStudent.SelectedRows[0].Cells)
                {
                    cel.ReadOnly = false;
                }
            }
        }
    }
}
