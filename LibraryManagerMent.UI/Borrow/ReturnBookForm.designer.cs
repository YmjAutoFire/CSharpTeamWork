namespace LibraryManagerMent.UI
{
    partial class ReturnBookForm
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblBookPublish = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(243, 281);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(138, 40);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "归还";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblBookPublish
            // 
            this.lblBookPublish.AutoSize = true;
            this.lblBookPublish.Location = new System.Drawing.Point(431, 200);
            this.lblBookPublish.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBookPublish.Name = "lblBookPublish";
            this.lblBookPublish.Size = new System.Drawing.Size(21, 21);
            this.lblBookPublish.TabIndex = 21;
            this.lblBookPublish.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 200);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "出版社：";
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Location = new System.Drawing.Point(431, 147);
            this.lblBookAuthor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(21, 21);
            this.lblBookAuthor.TabIndex = 19;
            this.lblBookAuthor.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "图书作者：";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(431, 97);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(21, 21);
            this.lblBookName.TabIndex = 17;
            this.lblBookName.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "图书名称：";
            // 
            // lblBookID
            // 
            this.lblBookID.AccessibleName = "";
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(431, 48);
            this.lblBookID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(21, 21);
            this.lblBookID.TabIndex = 15;
            this.lblBookID.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "图书编号：";
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(667, 394);
            this.Controls.Add(this.lblBookPublish);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblBookAuthor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ReturnBookForm";
            this.Text = "归还图书";
            this.Load += new System.EventHandler(this.ReturnBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblBookPublish;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label label1;
    }
}