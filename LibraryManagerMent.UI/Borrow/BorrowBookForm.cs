using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibraryManagerMent.BLL;//!!!
using LibraryManagerMent.Model;//!!!


namespace LibraryManagerMent.UI
{
    public partial class BorrowBookForm : Form
    {
        public string stuID;//学号
        public string ID;
        public string name;
        public string auth;
        public string pub;
        public string sta;
        public string type;
        public bool judge;
        public BorrowBookForm()
        {
            InitializeComponent();
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            BorrowBookBLL bll = new BorrowBookBLL();//需将BorrowBookBll类声明为public
            if (bll.judgeBookState(judge) == true)
            {
                if (bll.borrowBook(stuID, ID) &&bll.changeBookState(ID))
                {
                    MessageBox.Show("借书成功！");
                    
                }
            }
            else
            {
                MessageBox.Show("借书失败！");
            }
            this.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BorrowBook_Load(object sender, EventArgs e)
        {
            this.lblBookID.Text = ID;
            //不能加在构造方法里
            this.lblBookName.Text = name;
            this.lblBookAuthor.Text = auth;
            this.lblBookPublish.Text = pub;
            this.lblType.Text = type;
            this.lblBookState.Text = sta;
           
            if (judge == false)
            {
                this.btn1.Enabled = false;
            }

        }
        
    }
}
