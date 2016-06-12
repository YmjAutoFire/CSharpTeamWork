﻿using LibraryManagerMent.BLL;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 获取登录的管理员
        /// </summary>
        /// <param name="admin"></param>
        public void getLoginAdmin(AdminInfoModel admin)
        {


            this.btnInfoList.Visible = true;
        }
        /// <summary>
        /// 获取登录的学生用户
        /// </summary>
        /// <param name="stu"></param>
        public void getLoginStudent(StudentInfoModel stu)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            firstLoadPnl();
        }
        #region“图书馆”事件

        //“图书馆”按钮单击事件
        private void btnLibrary_Click(object sender, EventArgs e)
        {
            firstLoadPnl();
        }
        /// <summary>
        /// 初次加载图书馆界面
        /// </summary>
        private void firstLoadPnl()
        {
            this.pnlForm.Controls.Clear();
            LibraryForm library = new LibraryForm();
            library.TopLevel = false;
            this.pnlForm.Controls.Add(library);
            library.Show();
        }

        #endregion

        #region   信息管理事件
        

        //“信息管理事件”按钮单击事件
        private void btnInfoList_Click(object sender, EventArgs e)
        {
            this.pnlForm.Controls.Clear();
            InfoListForm infoList = new InfoListForm();
            infoList.TopLevel = false;
            this.pnlForm.Controls.Add(infoList);
            infoList.Show();
        }

        #endregion


        #region “借阅查看”事件
        
        //“借阅查看”按钮单击事件
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            this.pnlForm.Controls.Clear();
            BorrowForm borrow = new BorrowForm();
            borrow.TopLevel = false;
            this.pnlForm.Controls.Add(borrow);
            borrow.Show();
        }

        #endregion

        

        #region “基本信息”事件
        //“基本信息”按钮单击事件
        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.pnlForm.Controls.Clear();
            InfoBaseForm infoBase = new InfoBaseForm();
            infoBase.TopLevel = false;
            this.pnlForm.Controls.Add(infoBase);
            infoBase.Show();
        }

        #endregion









    }
}