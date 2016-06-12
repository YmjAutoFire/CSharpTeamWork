namespace LibraryManagerMent.UI
{
    partial class BookAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookAddForm));
            this.gbBook = new System.Windows.Forms.GroupBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBookPic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBookType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPublish = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBook
            // 
            this.gbBook.Controls.Add(this.btnFile);
            this.gbBook.Controls.Add(this.txtBookID);
            this.gbBook.Controls.Add(this.label7);
            this.gbBook.Controls.Add(this.txtBookPic);
            this.gbBook.Controls.Add(this.label5);
            this.gbBook.Controls.Add(this.txtBookType);
            this.gbBook.Controls.Add(this.label4);
            this.gbBook.Controls.Add(this.txtPublish);
            this.gbBook.Controls.Add(this.label3);
            this.gbBook.Controls.Add(this.txtAuthor);
            this.gbBook.Controls.Add(this.label2);
            this.gbBook.Controls.Add(this.txtBookName);
            this.gbBook.Controls.Add(this.label1);
            this.gbBook.Location = new System.Drawing.Point(39, 42);
            this.gbBook.Name = "gbBook";
            this.gbBook.Size = new System.Drawing.Size(327, 311);
            this.gbBook.TabIndex = 0;
            this.gbBook.TabStop = false;
            this.gbBook.Text = "填写信息";
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.Font = new System.Drawing.Font("宋体", 8.5F);
            this.btnFile.Location = new System.Drawing.Point(183, 241);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(59, 21);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "浏览";
            this.btnFile.UseVisualStyleBackColor = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(98, 164);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(144, 21);
            this.txtBookID.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "图书编号：";
            // 
            // txtBookPic
            // 
            this.txtBookPic.Location = new System.Drawing.Point(98, 242);
            this.txtBookPic.Name = "txtBookPic";
            this.txtBookPic.Size = new System.Drawing.Size(75, 21);
            this.txtBookPic.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "图书封面：";
            // 
            // txtBookType
            // 
            this.txtBookType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBookType.Location = new System.Drawing.Point(98, 203);
            this.txtBookType.Name = "txtBookType";
            this.txtBookType.ReadOnly = true;
            this.txtBookType.Size = new System.Drawing.Size(144, 21);
            this.txtBookType.TabIndex = 1;
            this.txtBookType.Click += new System.EventHandler(this.txtBookType_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "图书类型：";
            // 
            // txtPublish
            // 
            this.txtPublish.Location = new System.Drawing.Point(98, 125);
            this.txtPublish.Name = "txtPublish";
            this.txtPublish.Size = new System.Drawing.Size(144, 21);
            this.txtPublish.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "出版社：";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(98, 86);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(144, 21);
            this.txtAuthor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "作者：";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(98, 47);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(144, 21);
            this.txtBookName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书名称：";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(92, 359);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(222, 359);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // BookAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(413, 403);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbBook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加图书信息";
            this.gbBook.ResumeLayout(false);
            this.gbBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBook;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBookPic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBookType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPublish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFile;
    }
}