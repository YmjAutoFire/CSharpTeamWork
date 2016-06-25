namespace LibraryManagerMent.UI
{
    partial class InfoListForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoListForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcInfoManager = new System.Windows.Forms.TabControl();
            this.tpStudent = new System.Windows.Forms.TabPage();
            this.tpBook = new System.Windows.Forms.TabPage();
            this.pnlModify = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBookReset = new System.Windows.Forms.Button();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.pbBook = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBookType = new System.Windows.Forms.TextBox();
            this.txtBookStatus = new System.Windows.Forms.TextBox();
            this.txtHisTimes = new System.Windows.Forms.TextBox();
            this.txtPublish = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.BookPage = new OwnPageControl.PageControl1();
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookSearch = new System.Windows.Forms.TextBox();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.publish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsToolBook = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BookSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.BookDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.BookModify = new System.Windows.Forms.ToolStripMenuItem();
            this.tpAdmin = new System.Windows.Forms.TabPage();
            this.tcInfoManager.SuspendLayout();
            this.tpBook.SuspendLayout();
            this.pnlModify.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.cmsToolBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcInfoManager
            // 
            this.tcInfoManager.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcInfoManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcInfoManager.Controls.Add(this.tpStudent);
            this.tcInfoManager.Controls.Add(this.tpBook);
            this.tcInfoManager.Controls.Add(this.tpAdmin);
            this.tcInfoManager.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcInfoManager.HotTrack = true;
            this.tcInfoManager.ItemSize = new System.Drawing.Size(30, 80);
            this.tcInfoManager.Location = new System.Drawing.Point(1, 3);
            this.tcInfoManager.Margin = new System.Windows.Forms.Padding(0);
            this.tcInfoManager.Multiline = true;
            this.tcInfoManager.Name = "tcInfoManager";
            this.tcInfoManager.SelectedIndex = 0;
            this.tcInfoManager.Size = new System.Drawing.Size(932, 446);
            this.tcInfoManager.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcInfoManager.TabIndex = 0;
            this.tcInfoManager.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcInfoManager_DrawItem);
            this.tcInfoManager.SelectedIndexChanged += new System.EventHandler(this.tcInfoManager_SelectedIndexChanged);
            // 
            // tpStudent
            // 
            this.tpStudent.BackColor = System.Drawing.Color.LightCyan;
            this.tpStudent.Location = new System.Drawing.Point(84, 4);
            this.tpStudent.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.tpStudent.Name = "tpStudent";
            this.tpStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tpStudent.Size = new System.Drawing.Size(844, 438);
            this.tpStudent.TabIndex = 0;
            this.tpStudent.Text = "学生管理";
            // 
            // tpBook
            // 
            this.tpBook.BackColor = System.Drawing.Color.LightCyan;
            this.tpBook.Controls.Add(this.pnlModify);
            this.tpBook.Controls.Add(this.picAdd);
            this.tpBook.Controls.Add(this.BookPage);
            this.tpBook.Controls.Add(this.btnBookSearch);
            this.tpBook.Controls.Add(this.label1);
            this.tpBook.Controls.Add(this.txtBookSearch);
            this.tpBook.Controls.Add(this.dgvBook);
            this.tpBook.Location = new System.Drawing.Point(84, 4);
            this.tpBook.Name = "tpBook";
            this.tpBook.Padding = new System.Windows.Forms.Padding(3);
            this.tpBook.Size = new System.Drawing.Size(844, 438);
            this.tpBook.TabIndex = 2;
            this.tpBook.Text = "图书管理";
            // 
            // pnlModify
            // 
            this.pnlModify.Controls.Add(this.groupBox1);
            this.pnlModify.Controls.Add(this.linkLabel1);
            this.pnlModify.Location = new System.Drawing.Point(33, 23);
            this.pnlModify.Name = "pnlModify";
            this.pnlModify.Size = new System.Drawing.Size(779, 393);
            this.pnlModify.TabIndex = 7;
            this.pnlModify.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBookReset);
            this.groupBox1.Controls.Add(this.btnBookAdd);
            this.groupBox1.Controls.Add(this.pbBook);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBookType);
            this.groupBox1.Controls.Add(this.txtBookStatus);
            this.groupBox1.Controls.Add(this.txtHisTimes);
            this.groupBox1.Controls.Add(this.txtPublish);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.txtBookName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(165, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 366);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图书信息";
            // 
            // btnBookReset
            // 
            this.btnBookReset.Location = new System.Drawing.Point(258, 337);
            this.btnBookReset.Name = "btnBookReset";
            this.btnBookReset.Size = new System.Drawing.Size(75, 23);
            this.btnBookReset.TabIndex = 10;
            this.btnBookReset.Text = "重置";
            this.btnBookReset.UseVisualStyleBackColor = true;
            this.btnBookReset.Visible = false;
            this.btnBookReset.Click += new System.EventHandler(this.btnBookReset_Click);
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(99, 337);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBookAdd.TabIndex = 9;
            this.btnBookAdd.Text = "确定修改";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Visible = false;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // pbBook
            // 
            this.pbBook.Location = new System.Drawing.Point(165, 20);
            this.pbBook.Name = "pbBook";
            this.pbBook.Size = new System.Drawing.Size(108, 91);
            this.pbBook.TabIndex = 8;
            this.pbBook.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F);
            this.label7.Location = new System.Drawing.Point(97, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "图书类型：";
            // 
            // txtBookType
            // 
            this.txtBookType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBookType.Location = new System.Drawing.Point(168, 266);
            this.txtBookType.Name = "txtBookType";
            this.txtBookType.ReadOnly = true;
            this.txtBookType.Size = new System.Drawing.Size(134, 21);
            this.txtBookType.TabIndex = 6;
            // 
            // txtBookStatus
            // 
            this.txtBookStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBookStatus.Location = new System.Drawing.Point(168, 300);
            this.txtBookStatus.Name = "txtBookStatus";
            this.txtBookStatus.ReadOnly = true;
            this.txtBookStatus.Size = new System.Drawing.Size(134, 21);
            this.txtBookStatus.TabIndex = 5;
            // 
            // txtHisTimes
            // 
            this.txtHisTimes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtHisTimes.Location = new System.Drawing.Point(168, 232);
            this.txtHisTimes.Name = "txtHisTimes";
            this.txtHisTimes.ReadOnly = true;
            this.txtHisTimes.Size = new System.Drawing.Size(134, 21);
            this.txtHisTimes.TabIndex = 5;
            // 
            // txtPublish
            // 
            this.txtPublish.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPublish.Location = new System.Drawing.Point(168, 198);
            this.txtPublish.Name = "txtPublish";
            this.txtPublish.ReadOnly = true;
            this.txtPublish.Size = new System.Drawing.Size(134, 21);
            this.txtPublish.TabIndex = 5;
            this.txtPublish.ReadOnlyChanged += new System.EventHandler(this.ReadOnlyChanged);
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAuthor.Location = new System.Drawing.Point(168, 164);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(134, 21);
            this.txtAuthor.TabIndex = 5;
            this.txtAuthor.ReadOnlyChanged += new System.EventHandler(this.ReadOnlyChanged);
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBookName.Location = new System.Drawing.Point(168, 130);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(134, 21);
            this.txtBookName.TabIndex = 5;
            this.txtBookName.ReadOnlyChanged += new System.EventHandler(this.ReadOnlyChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "当前借阅状态：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "被借阅次数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "出版社：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "作者：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "图书名称：";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.CausesValidation = false;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("宋体", 11F);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.Location = new System.Drawing.Point(25, 15);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 15);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "←返回";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // picAdd
            // 
            this.picAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAdd.BackgroundImage")));
            this.picAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAdd.Location = new System.Drawing.Point(608, 22);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(42, 28);
            this.picAdd.TabIndex = 6;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // BookPage
            // 
            this.BookPage.BackColor = System.Drawing.Color.Transparent;
            this.BookPage.DataCount = 0;
            this.BookPage.Dgv = null;
            this.BookPage.Location = new System.Drawing.Point(109, 390);
            this.BookPage.Name = "BookPage";
            this.BookPage.PageCount = 0;
            this.BookPage.PageIndex = 0;
            this.BookPage.PageSize = 0;
            this.BookPage.Size = new System.Drawing.Size(603, 31);
            this.BookPage.TabIndex = 5;
            this.BookPage.PageChange_Click += new System.EventHandler(this.BookPage_PageChange_Click);
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.BackColor = System.Drawing.Color.Snow;
            this.btnBookSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBookSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.btnBookSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBookSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookSearch.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.btnBookSearch.Location = new System.Drawing.Point(522, 26);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(55, 24);
            this.btnBookSearch.TabIndex = 3;
            this.btnBookSearch.Text = "查询";
            this.btnBookSearch.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(177, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "图书查询：";
            // 
            // txtBookSearch
            // 
            this.txtBookSearch.Font = new System.Drawing.Font("宋体", 11F);
            this.txtBookSearch.Location = new System.Drawing.Point(268, 26);
            this.txtBookSearch.Name = "txtBookSearch";
            this.txtBookSearch.Size = new System.Drawing.Size(243, 24);
            this.txtBookSearch.TabIndex = 1;
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.publish,
            this.author,
            this.bookType,
            this.bookID,
            this.bookName,
            this.bookStatus});
            this.dgvBook.ContextMenuStrip = this.cmsToolBook;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBook.Location = new System.Drawing.Point(72, 72);
            this.dgvBook.MultiSelect = false;
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBook.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvBook.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBook.RowTemplate.Height = 23;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(706, 310);
            this.dgvBook.TabIndex = 0;
            this.dgvBook.DoubleClick += new System.EventHandler(this.dgvBook_DoubleClick);
            // 
            // publish
            // 
            this.publish.DataPropertyName = "Publish";
            this.publish.HeaderText = "出版社";
            this.publish.Name = "publish";
            this.publish.ReadOnly = true;
            this.publish.Width = 102;
            // 
            // author
            // 
            this.author.DataPropertyName = "Author";
            this.author.HeaderText = "作者";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Width = 120;
            // 
            // bookType
            // 
            this.bookType.DataPropertyName = "BookType";
            this.bookType.HeaderText = "图书类型";
            this.bookType.Name = "bookType";
            this.bookType.ReadOnly = true;
            this.bookType.Width = 150;
            // 
            // bookID
            // 
            this.bookID.DataPropertyName = "BookID";
            this.bookID.HeaderText = "图书编号";
            this.bookID.Name = "bookID";
            this.bookID.ReadOnly = true;
            // 
            // bookName
            // 
            this.bookName.DataPropertyName = "BookName";
            this.bookName.HeaderText = "图书名称";
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            this.bookName.Width = 130;
            // 
            // bookStatus
            // 
            this.bookStatus.DataPropertyName = "BookStatus";
            this.bookStatus.HeaderText = "借阅状态";
            this.bookStatus.Name = "bookStatus";
            this.bookStatus.ReadOnly = true;
            // 
            // cmsToolBook
            // 
            this.cmsToolBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BookSelect,
            this.BookDelete,
            this.BookModify});
            this.cmsToolBook.Name = "cmsToolBook";
            this.cmsToolBook.Size = new System.Drawing.Size(101, 70);
            // 
            // BookSelect
            // 
            this.BookSelect.Name = "BookSelect";
            this.BookSelect.Size = new System.Drawing.Size(100, 22);
            this.BookSelect.Text = "查看";
            this.BookSelect.Click += new System.EventHandler(this.查看ToolStripMenuItem_Click);
            // 
            // BookDelete
            // 
            this.BookDelete.Name = "BookDelete";
            this.BookDelete.Size = new System.Drawing.Size(100, 22);
            this.BookDelete.Text = "删除";
            this.BookDelete.Click += new System.EventHandler(this.BookDelete_Click);
            // 
            // BookModify
            // 
            this.BookModify.Name = "BookModify";
            this.BookModify.Size = new System.Drawing.Size(100, 22);
            this.BookModify.Text = "修改";
            this.BookModify.Click += new System.EventHandler(this.BookModify_Click);
            // 
            // tpAdmin
            // 
            this.tpAdmin.BackColor = System.Drawing.Color.LightCyan;
            this.tpAdmin.Location = new System.Drawing.Point(84, 4);
            this.tpAdmin.Name = "tpAdmin";
            this.tpAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdmin.Size = new System.Drawing.Size(844, 438);
            this.tpAdmin.TabIndex = 1;
            this.tpAdmin.Text = "管理员";
            // 
            // InfoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(931, 448);
            this.Controls.Add(this.tcInfoManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoListForm";
            this.Text = "InfoListForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcInfoManager.ResumeLayout(false);
            this.tpBook.ResumeLayout(false);
            this.tpBook.PerformLayout();
            this.pnlModify.ResumeLayout(false);
            this.pnlModify.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.cmsToolBook.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcInfoManager;
        private System.Windows.Forms.TabPage tpStudent;
        private System.Windows.Forms.TabPage tpAdmin;
        private System.Windows.Forms.TabPage tpBook;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.TextBox txtBookSearch;
        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsToolBook;
        private System.Windows.Forms.ToolStripMenuItem BookSelect;
        private System.Windows.Forms.ToolStripMenuItem BookModify;
        private System.Windows.Forms.ToolStripMenuItem BookDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn publish;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookType;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookStatus;
        private OwnPageControl.PageControl1 BookPage;
        private System.Windows.Forms.Panel pnlModify;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBookType;
        private System.Windows.Forms.TextBox txtBookStatus;
        private System.Windows.Forms.TextBox txtHisTimes;
        private System.Windows.Forms.TextBox txtPublish;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.Button btnBookReset;
        private System.Windows.Forms.Button btnBookAdd;

    }
}