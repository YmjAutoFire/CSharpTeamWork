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
    public partial class BookTypeTree : Form
    {
        public BookTypeTree()
        {
            InitializeComponent();
        }

        public BookAddForm f;

        private void BookTypeTree_Load(object sender, EventArgs e)
        {
            GetGroupsBLL bll = new GetGroupsBLL();
            List<BookTypeGroup> list = bll.getBookTypeGroup();
            ControlLoad load = new ControlLoad();
            //初始化树列表
            load.LoadBookTypeTree("0", this.tvSearch.Nodes[0], list);
            this.tvSearch.SelectedNode = this.tvSearch.Nodes[0];
            this.tvSearch.SelectedNode.Expand();
        }
        //返回图书类型
        public delegate void getType(string typeID);

        /// <summary>
        /// 双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvSearch_DoubleClick(object sender, EventArgs e)
        {
            TreeNode node = tvSearch.SelectedNode;
            if (node != null)
            {
                if (node.Nodes.Count == 0)
                {
                    BookTypeGroup model = node.Tag as BookTypeGroup;
                    getType g = new getType(f.loadType);
                    g(model.TypeID);
                    this.Close();
                    this.Dispose();
                }
            }
        }
    }
}
