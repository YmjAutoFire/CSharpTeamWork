using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OwnPageControl
{
    public partial class PageControl1 : UserControl
    {
        public PageControl1()
        {
            InitializeComponent(); 
        }

        private int pageIndex=1;
        /// <summary>
        /// 当前页
        /// </summary>
        public int PageIndex
        {
            get { return pageIndex; }
            set
            {
                pageIndex = value;
                if (pageIndex < 1) pageIndex = 1;
                else if (pageIndex > pageCount) pageIndex = pageCount;
            }
        }

        private int pageCount;
        /// <summary>
        /// 记录总页数
        /// </summary>
        public int PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }

        private int dataCount;
        /// <summary>
        /// 记录总条数
        /// </summary>
        public int DataCount
        {
            get { return dataCount; }
            set { dataCount = value; Compute(); }
        }

        /// <summary>
        /// 单页面记录条数
        /// </summary>
        private int pageSize;

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value; Compute(); }
        }
        
        

        private DataGridView dgv;
        /// <summary>
        /// 进行绑定的控件
        /// </summary>
        public DataGridView Dgv
        {
            get { return dgv; }
            set { dgv = value; }
        }

        /// <summary>
        /// 计算页面数据
        /// </summary>
        private void Compute()
        {
            if (dataCount > 0)
            {
                if (pageSize == 0) pageSize = 20;
                pageCount = Convert.ToInt32(Math.Ceiling(dataCount / (double)pageSize));
            }
            LoadControl();
        }

        /// <summary>
        /// 首页跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            pageIndex = 1;
            btnFirst.Enabled = false;
            btnPrev.Enabled = false;
            btnLast.Enabled = true;
            btnNext.Enabled = true;
            txtNum.Text = pageIndex.ToString();
            PageChange_Click(sender, e);
        }

        /// <summary>
        /// 上一页跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (pageIndex > 2)
            {
                btnFirst.Enabled = true;
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
                btnLast.Enabled = true;
                pageIndex--;
                txtNum.Text = pageIndex.ToString();
                PageChange_Click(sender, e);
            }
            else if (pageIndex == 2)
            {
                btnFirst.Enabled = false;
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
                btnLast.Enabled = true;
                pageIndex--;
                txtNum.Text = pageIndex.ToString();
                PageChange_Click(sender, e);
            }
            else
            {
                btnFirst.Enabled = false;
                btnPrev.Enabled = false;
            }

        }

        /// <summary>
        /// 任意页跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGO_Click(object sender, EventArgs e)
        {
            int num;
            bool b = int.TryParse(txtNum.Text, out num);
            if (b)
            {
                if (num <= 1)
                {
                    pageIndex = 1;
                    btnFirst.Enabled = false;
                    btnPrev.Enabled = false;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                    
                }
                else if (num >= pageCount)
                {
                    pageIndex = pageCount;
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                    btnPrev.Enabled = true;
                    btnFirst.Enabled = true;
                    
                }
                else
                {
                    pageIndex = num;
                    btnPrev.Enabled = true;
                    btnFirst.Enabled = true;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                }
                txtNum.Text = pageIndex.ToString();
                PageChange_Click(sender, e);
            }
            else
            {
                MessageBox.Show("输入正确数字");
            }
        }


        /// <summary>
        /// 回车快捷跳转页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnGO_Click(sender, e);
            }
        }

        /// <summary>
        /// 下一页跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {

            if (pageIndex < pageCount - 1)
            {
                btnNext.Enabled = true;
                btnLast.Enabled = true;
                btnPrev.Enabled = true;
                btnFirst.Enabled = true;
                pageIndex++;
                txtNum.Text = pageIndex.ToString();
                PageChange_Click(sender, e);
            }
            else if (pageIndex == pageCount - 1)
            {
                btnNext.Enabled = false;
                btnLast.Enabled = false;
                btnPrev.Enabled = true;
                btnFirst.Enabled = true;
                pageIndex++;
                txtNum.Text = pageIndex.ToString();
                PageChange_Click(sender, e);
            }
            else
            {
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }

        }

        /// <summary>
        /// 尾页跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLast_Click(object sender, EventArgs e)
        {
            pageIndex = pageCount;
            btnNext.Enabled = false;
            btnLast.Enabled = false;
            btnFirst.Enabled = true;
            btnPrev.Enabled = true;
            txtNum.Text = pageIndex.ToString();
            PageChange_Click(sender, e);
        }

        /// <summary>
        /// 将查询的结果绑定到控件
        /// </summary>
        public void DataBind()
        {

        }

        //数值加载
        private void PageControl1_Load(object sender, EventArgs e)
        {
            Compute();
            
            
        }

        /// <summary>
        /// 加载控件数据
        /// </summary>
        private void LoadControl()
        {
            lblDataCount.Text = "共:" + dataCount.ToString() + "条记录";
            lblPageSize.Text = "每页" + pageSize.ToString() + "条记录";
            lblGO.Text = "/" + pageCount.ToString() + "页";
            if (pageIndex <= 1)
            {
                btnFirst.Enabled = false;
                btnPrev.Enabled = false;
                btnLast.Enabled = true;
                btnNext.Enabled = true;
                txtNum.Text = "1";
            }
            else if (pageIndex >= pageCount)
            {
                btnFirst.Enabled = true;
                btnPrev.Enabled = true;
                btnLast.Enabled = false;
                btnNext.Enabled = false;
                txtNum.Text = pageCount.ToString();
            }
            else
            {
                txtNum.Text = pageIndex.ToString();
            }
        }

        /// <summary>
        /// 页改变的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void PageChange();

        /// <summary>
        /// 页改变的委托事件
        /// </summary>
        public event EventHandler PageChange_Click;




    }
}
