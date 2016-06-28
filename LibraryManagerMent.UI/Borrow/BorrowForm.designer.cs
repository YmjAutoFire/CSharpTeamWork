namespace LibraryManagerMent.UI
{
    partial class BorrowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnNow = new System.Windows.Forms.Button();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.bookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shouldReturnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPage = new OwnPageControl.PageControl1();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(539, 33);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(156, 27);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Text = "历史借阅";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnNow
            // 
            this.btnNow.Location = new System.Drawing.Point(228, 33);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(156, 27);
            this.btnNow.TabIndex = 3;
            this.btnNow.Text = "当前借阅";
            this.btnNow.UseVisualStyleBackColor = true;
            this.btnNow.Click += new System.EventHandler(this.btnNow_Click);
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.AllowUserToAddRows = false;
            this.dgvBorrow.AllowUserToDeleteRows = false;
            this.dgvBorrow.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookID,
            this.bookName,
            this.author,
            this.publish,
            this.borrowTime,
            this.shouldReturnTime});
            this.dgvBorrow.Location = new System.Drawing.Point(138, 88);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.ReadOnly = true;
            this.dgvBorrow.RowTemplate.Height = 23;
            this.dgvBorrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrow.Size = new System.Drawing.Size(649, 313);
            this.dgvBorrow.TabIndex = 2;
            this.dgvBorrow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrow_CellContentClick);
            this.dgvBorrow.DoubleClick += new System.EventHandler(this.dgvBorrow_DoubleClick);
            // 
            // bookID
            // 
            this.bookID.DataPropertyName = "bookID";
            this.bookID.HeaderText = "图书编号";
            this.bookID.Name = "bookID";
            this.bookID.ReadOnly = true;
            // 
            // bookName
            // 
            this.bookName.DataPropertyName = "bookName";
            this.bookName.HeaderText = "图书名称";
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            // 
            // author
            // 
            this.author.DataPropertyName = "author";
            this.author.HeaderText = "作者";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // publish
            // 
            this.publish.DataPropertyName = "publish";
            this.publish.HeaderText = "出版社";
            this.publish.Name = "publish";
            this.publish.ReadOnly = true;
            // 
            // borrowTime
            // 
            this.borrowTime.DataPropertyName = "BorrowTime";
            this.borrowTime.HeaderText = "借阅日期";
            this.borrowTime.Name = "borrowTime";
            this.borrowTime.ReadOnly = true;
            // 
            // shouldReturnTime
            // 
            this.shouldReturnTime.DataPropertyName = "ReturnTime";
            this.shouldReturnTime.HeaderText = "应归还日期";
            this.shouldReturnTime.Name = "shouldReturnTime";
            this.shouldReturnTime.ReadOnly = true;
            // 
            // BookPage
            // 
            this.BookPage.BackColor = System.Drawing.Color.Transparent;
            this.BookPage.DataCount = 0;
            this.BookPage.Dgv = null;
            this.BookPage.Location = new System.Drawing.Point(138, 407);
            this.BookPage.Name = "BookPage";
            this.BookPage.PageCount = 0;
            this.BookPage.PageIndex = 1;
            this.BookPage.PageSize = 0;
            this.BookPage.Size = new System.Drawing.Size(631, 31);
            this.BookPage.TabIndex = 16;
            this.BookPage.PageChange_Click += new System.EventHandler(this.BookPage_PageChange_Click);
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(931, 448);
            this.Controls.Add(this.BookPage);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnNow);
            this.Controls.Add(this.dgvBorrow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowForm";
            this.Text = "BorrowForm";
            this.Load += new System.EventHandler(this.BorrowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnNow;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn publish;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn shouldReturnTime;
        private OwnPageControl.PageControl1 BookPage;
    }
}