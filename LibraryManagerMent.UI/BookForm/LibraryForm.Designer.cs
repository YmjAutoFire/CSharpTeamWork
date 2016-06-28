namespace LibraryManagerMent.UI
{
    partial class LibraryForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("图书类别分类");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryForm));
            this.txtTypeSearch = new System.Windows.Forms.TextBox();
            this.tvSearch = new System.Windows.Forms.TreeView();
            this.txtBookSearch = new System.Windows.Forms.TextBox();
            this.lblBookSearch = new System.Windows.Forms.Label();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBookSearch = new System.Windows.Forms.PictureBox();
            this.BookPage = new OwnPageControl.PageControl1();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTypeSearch
            // 
            this.txtTypeSearch.Location = new System.Drawing.Point(17, 16);
            this.txtTypeSearch.Margin = new System.Windows.Forms.Padding(8, 13, 3, 13);
            this.txtTypeSearch.Name = "txtTypeSearch";
            this.txtTypeSearch.Size = new System.Drawing.Size(136, 21);
            this.txtTypeSearch.TabIndex = 8;
            this.txtTypeSearch.WordWrap = false;
            this.txtTypeSearch.TextChanged += new System.EventHandler(this.txtTypeSearch_TextChanged);
            // 
            // tvSearch
            // 
            this.tvSearch.BackColor = System.Drawing.Color.White;
            this.tvSearch.Indent = 5;
            this.tvSearch.Location = new System.Drawing.Point(4, 49);
            this.tvSearch.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.tvSearch.Name = "tvSearch";
            treeNode1.Checked = true;
            treeNode1.Name = "节点0";
            treeNode1.Text = "图书类别分类";
            this.tvSearch.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvSearch.Size = new System.Drawing.Size(194, 390);
            this.tvSearch.TabIndex = 9;
            this.tvSearch.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvSearch_AfterSelect);
            this.tvSearch.DoubleClick += new System.EventHandler(this.tvSearch_DoubleClick);
            // 
            // txtBookSearch
            // 
            this.txtBookSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookSearch.Font = new System.Drawing.Font("宋体", 11F);
            this.txtBookSearch.Location = new System.Drawing.Point(373, 12);
            this.txtBookSearch.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.txtBookSearch.MaxLength = 30;
            this.txtBookSearch.Name = "txtBookSearch";
            this.txtBookSearch.Size = new System.Drawing.Size(315, 24);
            this.txtBookSearch.TabIndex = 10;
            this.txtBookSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookSearch_KeyDown);
            // 
            // lblBookSearch
            // 
            this.lblBookSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBookSearch.AutoSize = true;
            this.lblBookSearch.Font = new System.Drawing.Font("宋体", 10F);
            this.lblBookSearch.Location = new System.Drawing.Point(288, 18);
            this.lblBookSearch.Name = "lblBookSearch";
            this.lblBookSearch.Size = new System.Drawing.Size(77, 14);
            this.lblBookSearch.TabIndex = 11;
            this.lblBookSearch.Text = "图书查询：";
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgvBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvBook.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Author,
            this.Publish,
            this.BookType,
            this.BookID,
            this.BookName,
            this.BookStatus});
            this.dgvBook.Location = new System.Drawing.Point(232, 64);
            this.dgvBook.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.dgvBook.MultiSelect = false;
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowHeadersVisible = false;
            this.dgvBook.RowTemplate.Height = 23;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(662, 321);
            this.dgvBook.TabIndex = 12;
            this.dgvBook.DoubleClick += new System.EventHandler(this.dgvBook_DoubleClick);
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Author.DefaultCellStyle = dataGridViewCellStyle3;
            this.Author.HeaderText = "作者";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Publish
            // 
            this.Publish.DataPropertyName = "Publish";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Publish.DefaultCellStyle = dataGridViewCellStyle4;
            this.Publish.HeaderText = "出版社";
            this.Publish.Name = "Publish";
            this.Publish.ReadOnly = true;
            // 
            // BookType
            // 
            this.BookType.DataPropertyName = "TypeName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BookType.DefaultCellStyle = dataGridViewCellStyle5;
            this.BookType.HeaderText = "图书类型";
            this.BookType.Name = "BookType";
            this.BookType.ReadOnly = true;
            this.BookType.Width = 120;
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BookID.DefaultCellStyle = dataGridViewCellStyle6;
            this.BookID.HeaderText = "图书编号";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BookName.DefaultCellStyle = dataGridViewCellStyle7;
            this.BookName.HeaderText = "图书名称";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            this.BookName.Width = 135;
            // 
            // BookStatus
            // 
            this.BookStatus.DataPropertyName = "BookStatus";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BookStatus.DefaultCellStyle = dataGridViewCellStyle8;
            this.BookStatus.HeaderText = "可借状态";
            this.BookStatus.Name = "BookStatus";
            this.BookStatus.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(160, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 26);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // picBookSearch
            // 
            this.picBookSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picBookSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBookSearch.Image = ((System.Drawing.Image)(resources.GetObject("picBookSearch.Image")));
            this.picBookSearch.Location = new System.Drawing.Point(713, 11);
            this.picBookSearch.Margin = new System.Windows.Forms.Padding(5, 7, 3, 7);
            this.picBookSearch.Name = "picBookSearch";
            this.picBookSearch.Size = new System.Drawing.Size(29, 31);
            this.picBookSearch.TabIndex = 14;
            this.picBookSearch.TabStop = false;
            this.picBookSearch.Click += new System.EventHandler(this.picBookSearch_Click);
            // 
            // BookPage
            // 
            this.BookPage.BackColor = System.Drawing.Color.Transparent;
            this.BookPage.DataCount = 0;
            this.BookPage.Dgv = null;
            this.BookPage.Location = new System.Drawing.Point(252, 399);
            this.BookPage.Name = "BookPage";
            this.BookPage.PageCount = 0;
            this.BookPage.PageIndex = 1;
            this.BookPage.PageSize = 0;
            this.BookPage.Size = new System.Drawing.Size(631, 31);
            this.BookPage.TabIndex = 15;
            this.BookPage.PageChange_Click += new System.EventHandler(this.BookPage_PageChange_Click);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(931, 448);
            this.Controls.Add(this.BookPage);
            this.Controls.Add(this.txtTypeSearch);
            this.Controls.Add(this.tvSearch);
            this.Controls.Add(this.txtBookSearch);
            this.Controls.Add(this.lblBookSearch);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picBookSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibraryForm";
            this.Text = "LibraryForm";
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTypeSearch;
        private System.Windows.Forms.TreeView tvSearch;
        private System.Windows.Forms.TextBox txtBookSearch;
        private System.Windows.Forms.Label lblBookSearch;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBookSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publish;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookStatus;
        private OwnPageControl.PageControl1 BookPage;


    }
}