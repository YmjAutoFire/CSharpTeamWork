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
    public partial class BorrowForm : Form
    {
        public BorrowForm()
        {
            InitializeComponent();
        }
        public string stuID;
        //记录当前借阅还是历史借阅(true/false)
        bool IsBorrowHistoryNow = false;
        /// <summary>
        /// 当前借阅列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNow_Click(object sender, EventArgs e)
        {
            IsBorrowHistoryNow = true;
            //点击当前借阅的按钮时，值为true！！
            this.dgvBorrow.Columns[5].HeaderText = "应归还日期";
            BorrowHistoryBLL bll = new BorrowHistoryBLL();
            List<ShowBorrowHistory> list = bll.getListBorrowHisoryNow(stuID);
            this.dgvBorrow.DataSource = list;
            BookPage.DataCount = bll.getBorrowNowCount(stuID);
            BookPage.PageIndex = 1;
            //加载字体！
            LoadBorrowNowFont();
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            BookPage.PageSize = 20;//!!!!
            BookPage.PageCount = 0;
            //MessageBox.Show(stuID);
            this.dgvBorrow.AutoGenerateColumns = false;
            //设置了AutoGenerateColumns=true，就能够根据数据源的实际情况，自动生成gridview表格列;
            //如果设置为AutoGenerateColumns=flase，那么必须要手动编写gridview控件的columns集合，否则即使正确帮定了数据，gridvew也什么都不显示，因为没有定义列，同时也没有自动让他自己生成列 
            
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.dgvBorrow.Columns[5].HeaderText = "归还日期";
            BorrowHistoryBLL bll = new BorrowHistoryBLL();
            List<ShowBorrowHistory> list = bll.getListBorrowHisoryAll(stuID);
            this.dgvBorrow.DataSource = list;
            BookPage.DataCount = bll.getBorrowAllCount(stuID);
            BookPage.PageIndex = 1;
            //加载字体
            LoadBorrowAllFont();
        }
        
        /// <summary>
        /// 加载当前借阅的字体
        /// </summary>
        private void LoadBorrowNowFont()
        {
            BorrowHistoryBLL bll = new BorrowHistoryBLL();
            foreach (DataGridViewRow row in this.dgvBorrow.Rows)
            {
                string bookID = row.Cells[0].Value.ToString();
                if(bll.judgeOverDateNow(stuID,bookID)==true)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        row.Cells[i].Style.ForeColor = Color.Red;
                    }
                }
                else 
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        row.Cells[i].Style.ForeColor = Color.Green;
                    }
                    
                }
            }
        }
        /// <summary>
        /// 加载历史借阅时的字体
        /// </summary>
        private void LoadBorrowAllFont()
        {
            BorrowHistoryBLL bll = new BorrowHistoryBLL();
            foreach (DataGridViewRow row in this.dgvBorrow.Rows)
            {
                string bookID = row.Cells[0].Value.ToString();
                if (bll.judgeOverDateAll(stuID, bookID) == true)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        row.Cells[i].Style.ForeColor = Color.Red;
                    }
                }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        row.Cells[i].Style.ForeColor = Color.Green;
                    }

                }
            }
        }
        /// <summary>
        /// 换页事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookPage_PageChange_Click(object sender, EventArgs e)
        {
            if (IsBorrowHistoryNow)
            {
                BorrowHistoryBLL bll = new BorrowHistoryBLL();
                List<ShowBorrowHistory> list = bll.getListBorrowHisoryNow(stuID);
                this.dgvBorrow.DataSource = list;
                //加载字体！！！
                LoadBorrowNowFont();
            }
            else
            {
                BorrowHistoryBLL bll = new BorrowHistoryBLL();
                List<ShowBorrowHistory> list = bll.getListBorrowHisoryAll(stuID);
                this.dgvBorrow.DataSource = list;
                //加载字体！！！
                LoadBorrowAllFont();
            }
            
        }

        private void dgvBorrow_DoubleClick(object sender, EventArgs e)
        {
            ReturnBookForm returnbook = new ReturnBookForm();
            MainForm main = new MainForm();

            if (this.dgvBorrow.SelectedRows.Count > 0)
            {
               
                string bookID = dgvBorrow.SelectedRows[0].Cells[0].Value.ToString();
                returnbook.ID = bookID;
                string bookName = dgvBorrow.SelectedRows[0].Cells[1].Value.ToString();
                returnbook.name = bookName;
                string author = dgvBorrow.SelectedRows[0].Cells[2].Value.ToString();
                returnbook.auth = author;
                string publish = dgvBorrow.SelectedRows[0].Cells[3].Value.ToString();
                returnbook.pub = publish;
                returnbook.Show();
            }

        }

        private void dgvBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// 选中某一行时触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
       
    }
}
