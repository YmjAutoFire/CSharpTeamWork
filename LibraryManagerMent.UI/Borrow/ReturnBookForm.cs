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
    public partial class ReturnBookForm : Form
    {
       
        public string ID;
        public string name;
        public string auth;
        public string pub;
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnBookBLL bll = new ReturnBookBLL();
            if(bll.retrunBook(ID)&&bll.changeBookState(ID))
                {
                    MessageBox.Show("还书成功！");
                }
           
            else
            {
                MessageBox.Show("还书失败！");
            }
            this.Close();
        }

        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            this.lblBookID.Text = ID;
            //不能加在构造方法里
            this.lblBookName.Text = name;
            this.lblBookAuthor.Text = auth;
            this.lblBookPublish.Text = pub;
        }
}


}
