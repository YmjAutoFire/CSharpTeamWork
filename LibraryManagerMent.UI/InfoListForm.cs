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
    public partial class InfoListForm : Form
    {
        public InfoListForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.dgvBook.AutoGenerateColumns = false;


        }

        #region  选项卡的切换事件

        /// <summary>
        /// 开始绘制左侧选项卡按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tcInfoManager_DrawItem(object sender, DrawItemEventArgs e)
        {
            StringFormat sf = new StringFormat();
            //设置文字排列
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            //开始绘制选项卡
            e.Graphics.DrawString(((TabControl)sender).TabPages[e.Index].Text,new Font("仿宋2312",10,FontStyle.Regular), new SolidBrush(Color.Blue), e.Bounds, sf);
        }
        /// <summary>
        /// 选项卡选中之后的显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tcInfoManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLL.BookInfoBLL bll = new BLL.BookInfoBLL();
            TabControl control = sender as TabControl;
            string name = control.TabPages[control.SelectedIndex].Text;
            if(name == "学生管理")
            {

            }
            else if(name == "图书管理")
            {
                this.txtBookSearch.Focus();
                dgvBook.DataSource = bll.getAllBookInfoList(1);
                LoadDgvFont(dgvBook);
                BookPage.DataCount = bll.getBookCount();
            }
            else if(name == "管理员")
            {

            }
        }


        #endregion

        #region   控件的各种绘制事件

        /// <summary>
        /// 判断字符串之后重新加载字体类型
        /// </summary>
        private void LoadDgvFont(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[row.Cells.Count-1].Value.ToString() == "可借")
                {
                    row.Cells[row.Cells.Count - 1].Style.ForeColor = Color.Green;
                }
                else if (row.Cells[row.Cells.Count - 1].Value.ToString() == "借出")
                {
                    row.Cells[row.Cells.Count - 1].Style.ForeColor = Color.Red;
                }
            }
        }

        #endregion


        #region  图书管理管理事件

        /// <summary>
        /// 控件的换页事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookPage_PageChange_Click(object sender, EventArgs e)
        {
            BookInfoBLL bll = new BookInfoBLL();
            dgvBook.DataSource = bll.getAllBookInfoList(BookPage.PageIndex);
        }

        //要操作的图书类的存储空间
        protected BookInfoModel model = null;

        /// <summary>
        /// 单击“+”图片添加图书信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picAdd_Click(object sender, EventArgs e)
        {
            BookAddForm bf = new BookAddForm();

            bf.ShowDialog();
        }


        /// <summary>
        /// 查看内容(快捷菜单)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvBook.SelectedCells.Count == 0) return;
            LoadPnlModify();
        }
        /// <summary>
        /// 修改内容(快捷菜单)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookModify_Click(object sender, EventArgs e)
        {
            if (dgvBook.SelectedCells.Count == 0) return;
            LoadPnlModify();
            txtAuthor.ReadOnly = false;
            txtBookName.ReadOnly = false;
            txtPublish.ReadOnly = false;
            btnBookAdd.Visible = true;
            btnBookReset.Visible = true;
            
        }
        /// <summary>
        /// 删除内容(快捷菜单)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookDelete_Click(object sender, EventArgs e)
        {
            if (dgvBook.SelectedRows.Count == 0) return;
            
            if(MessageBox.Show("确定要删除图书吗？","提示",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.OK)
            {
                BookInfoModel book = dgvBook.SelectedRows[0].DataBoundItem as BookInfoModel;
                BLL.BookInfoBLL bll = new BLL.BookInfoBLL();
                int result = bll.deleteBookInfo(book.BookID);
                if (result == 1) MessageBox.Show("删除成功");
                else if (result > 1) MessageBox.Show("删除了多条记录");
                else if (result == 0) MessageBox.Show("未执行删除操作");
                else MessageBox.Show("删除失败");
                //更新数据源
                this.dgvBook.DataSource = bll.getAllBookInfoList(BookPage.PageIndex);
            }
            
        }

        /// <summary>
        /// 双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBook_DoubleClick(object sender, EventArgs e)
        {
            if(dgvBook.SelectedRows.Count>0)
            {
                LoadPnlModify();
            }
        }
        /// <summary>
        /// 加载图书信息
        /// </summary>
        private void LoadPnlModify()
        {
            BookInfoModel model = (dgvBook.SelectedRows[0].DataBoundItem as BookInfoModel);
            pnlModify.Tag = model;
            FillText(model);
            pnlModify.Visible = true;

            //初始化只读状态
            txtAuthor.ReadOnly = true;
            txtBookName.ReadOnly = true;
            txtBookStatus.ReadOnly = true;
            txtBookStatus.ReadOnly = true;
            txtBookType.ReadOnly = true;
            txtHisTimes.ReadOnly = true;

            btnBookAdd.Visible = false;
            btnBookReset.Visible = false;
        }

       


        #endregion

        

        #region  显示图书信息容器里的事件

        /// <summary>
        /// 返回上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlModify.Visible = false;
        }

        /// <summary>
        /// 只读状态变化时的背景变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadOnlyChanged(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            if (!box.ReadOnly) box.BackColor = Color.White;
            else box.BackColor = Color.Khaki;
        }

        /// <summary>
        /// 确定修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            BookInfoModel book = this.pnlModify.Tag as BookInfoModel;
            book.BookName = txtBookName.Text;
            book.Author = txtAuthor.Text;
            book.Publish = txtAuthor.Text;
            BookInfoBLL bll = new BookInfoBLL();
            int res = bll.updateBookInfoModel(book);
            if(res == 1)
            {
                MessageBox.Show("修改成功");
                this.pnlModify.Visible = false;
            }
            else if(res < 1)
            {
                MessageBox.Show("修改失败");
            }
            else if(res > 1)
            {
                MessageBox.Show("修改多于一条记录");
                this.pnlModify.Visible = false;
            }
        }

        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBookReset_Click(object sender, EventArgs e)
        {
            FillText(this.pnlModify.Tag as BookInfoModel);
        }




        #endregion
        




        /// <summary>
        /// 填充文本
        /// </summary>
        /// <param name="model"></param>
        private void FillText(BookInfoModel model)
        {
            txtBookName.Text = model.BookName;
            txtAuthor.Text = model.Author;
            txtPublish.Text = model.Publish;
            //图书借阅次数--------
            //txtHisTimes.Text
            if (!string.IsNullOrEmpty(model.PicPath)) picAdd.Image = Image.FromFile(model.PicPath);
            txtBookStatus.Text = model.BookStatus;
        }
        
        



    }
}
