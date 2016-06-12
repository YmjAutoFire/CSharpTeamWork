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
    public partial class LibraryForm : Form
    {
        public LibraryForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LibraryForm_Load(object sender, EventArgs e)
        {
            dgvBook.AutoGenerateColumns = false;//取消自动添加列
            GetGroupsBLL bll = new GetGroupsBLL();
            List<BookTypeGroup> list = bll.getBookTypeGroup();
            ControlLoad load = new ControlLoad();
            //初始化树列表
            load.LoadBookTypeTree("0", this.tvSearch.Nodes[0], list);
            this.tvSearch.SelectedNode = this.tvSearch.Nodes[0];
            this.tvSearch.SelectedNode.Expand();

            
            
        }
        /// <summary>
        /// 容器绘制事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(200, -2), new Point(200, 452));
        }


        #region   左侧类型树的各种事件

        
        /// <summary>
        /// 图书类型搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClearBGColor(this.tvSearch.Nodes);
            string name = txtTypeSearch.Text.Trim();
            if (name.Length > 0)
                SearchTypeByTxt(name, this.tvSearch.Nodes[0]);
        }

        /// <summary>
        /// 根据搜索文本框的内容递归模糊查找
        /// </summary>
        protected void SearchTypeByTxt(string name, TreeNode n)
        {
            foreach(TreeNode child in n.Nodes)
            {
               if(child.Text.ToUpper().Contains(name))
               {
                   if(child.Nodes.Count == 0)
                   child.BackColor = Color.Turquoise;
                   child.EnsureVisible();
               }
               SearchTypeByTxt(name, child);
            }
        }

        /// <summary>
        /// 清除背景色
        /// </summary>
        /// <param name="nodes"></param>
        protected void ClearBGColor(TreeNodeCollection nodes)
        {
            foreach(TreeNode node in nodes)
            {
                node.BackColor = Color.White;
                ClearBGColor(node.Nodes);
            }
        }
        /// <summary>
        /// 动态模糊查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTypeSearch_TextChanged(object sender, EventArgs e)
        {
            ClearBGColor(this.tvSearch.Nodes);
            string name = txtTypeSearch.Text.Trim();
                if(name.Length>0)
            SearchTypeByTxt(name, this.tvSearch.Nodes[0]);
        }

        /// <summary>
        /// 内容被选择之后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvSearch_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvSearch.SelectedNode == null)
            {
                return;
            }
            tvSearch.SelectedNode.Expand();
        }

        /// <summary>
        /// treeView双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvSearch_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = tvSearch.SelectedNode;
            if(node != null)
            {
                if(node.Nodes.Count == 0)
                {
                    IsTreeOrSearch = false;
                    BookInfoBLL bll = new BookInfoBLL();
                    BookTypeGroup model = node.Tag as BookTypeGroup;
                    searchStr = model.TypeID;
                    List<BookInfoModel> list = bll.getBookInfoByType(model.TypeID, 1);
                    this.dgvBook.DataSource = list;
                    BookPage.PageIndex = 1;
                    BookPage.DataCount = bll.getBookCount(model.TypeID);
                    LoadDgvFont();
                }
            }
        }

        #endregion

        #region   右侧图书列表的操作
        /// <summary>
        /// 单击搜索图片进行搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picBookSearch_Click(object sender, EventArgs e)
        {
            beginSearch();
        }
        /// <summary>
        /// 按下回车开始搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBookSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                beginSearch();
            }
        }
        /// <summary>
        /// 重构出来的根据图书姓名模糊查询出来的结果
        /// </summary>
        protected void beginSearch()
        {
            if(!string.IsNullOrEmpty( this.txtBookSearch.Text.Trim()))
            {
                IsTreeOrSearch = true;
                BookInfoBLL bll = new BookInfoBLL();
                searchStr = this.txtBookSearch.Text.Trim();
                List<BookInfoModel> list = bll.getBookInfoLikeName(this.txtBookSearch.Text.Trim(),1);
                this.dgvBook.DataSource = list;
                BookPage.DataCount = bll.getBookCountLike(searchStr);
                BookPage.PageIndex = 1;
                LoadDgvFont();
            }
        }
        /// <summary>
        /// 判断字符串之后重新加载字体类型
        /// </summary>
        private void LoadDgvFont()
        {
            foreach(DataGridViewRow row in this.dgvBook.Rows)
            {
                if(row.Cells[5].Value.ToString() == "可借")
                {
                    row.Cells[5].Style.ForeColor = Color.Green;
                }
                else if(row.Cells[5].Value.ToString() == "借出")
                {
                    row.Cells[5].Style.ForeColor = Color.Red;
                }
            }
        }

        #endregion


        //记录是类型树双击事件还是搜索框事件(false/true)
        bool IsTreeOrSearch = false;
        //查询的字符串
        string searchStr;

        #region  分页控件的数据绑定事件

        /// <summary>
        /// 换页事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookPage_PageChange_Click(object sender, EventArgs e)
        {
            if(IsTreeOrSearch)
            {
                BookInfoBLL bll = new BookInfoBLL();
                List<BookInfoModel> list = bll.getBookInfoLikeName(searchStr, BookPage.PageIndex);
                this.dgvBook.DataSource = list;
                LoadDgvFont();
            }
            else
            {
                BookInfoBLL bll = new BookInfoBLL();
                List<BookInfoModel> list = bll.getBookInfoByType(searchStr, BookPage.PageIndex);
                this.dgvBook.DataSource = list;
                LoadDgvFont();
            }
        }

        #endregion

        

        
        

        

        





    }
}
