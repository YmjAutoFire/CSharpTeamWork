using LibraryManagerMent.BLL;
using LibraryManagerMent.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagerMent.UI
{
    public partial class BookAddForm : Form
    {
        public BookAddForm()
        {
            InitializeComponent();
        }

        

        /// <summary>
        /// 查看类型树
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBookType_Click(object sender, EventArgs e)
        {
            BookTypeTree tree = new BookTypeTree();
            tree.f = this;
            tree.ShowDialog();
        }

        public void loadType(string typeID)
        {
            txtBookType.Text = typeID;
        }

        /// <summary>
        ///浏览文件，查找图片 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "选择照片";
            open.Filter = "图片|*.jpg;*.jpeg;*.png";
            open.Multiselect = false;
            open.ShowDialog();
            if(!string.IsNullOrEmpty( open.FileName))
            {
                Image img = Image.FromFile(open.FileName);
                if(File.Exists("Images"))
                {

                }
            }
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookInfoModel book = new BookInfoModel();
            book.Author = txtAuthor.Text.Trim();
            book.Publish = txtPublish.Text.Trim();
            book.BookID = txtBookID.Text.Trim();
            book.BookName = txtBookName.Text.Trim();
            book.BookType = txtBookType.ToString();
            book.PicPath = txtBookPic.Text.Trim();
            BookInfoBLL bll = new BookInfoBLL();
            if(bll.insertBookInfo(book)==1)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("添加错误，请检查一下内容");
            }
        }
        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBookPic.Clear();
            txtAuthor.Clear();
            txtBookID.Clear();
            txtBookName.Clear();
            txtBookPic.Clear();
            txtBookType.Clear();
            txtPublish.Clear();
        }

        
    }
}
