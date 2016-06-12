namespace LibraryManagerMent.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnInfoList = new System.Windows.Forms.Button();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblShowName = new System.Windows.Forms.Label();
            this.lblShowID = new System.Windows.Forms.Label();
            this.picHead = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHead)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInfoList
            // 
            this.btnInfoList.BackColor = System.Drawing.Color.LightCyan;
            this.btnInfoList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoList.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInfoList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnInfoList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnInfoList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoList.Font = new System.Drawing.Font("华文楷体", 10F, System.Drawing.FontStyle.Bold);
            this.btnInfoList.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnInfoList.Location = new System.Drawing.Point(377, 31);
            this.btnInfoList.Name = "btnInfoList";
            this.btnInfoList.Size = new System.Drawing.Size(112, 32);
            this.btnInfoList.TabIndex = 4;
            this.btnInfoList.Text = "信息管理";
            this.btnInfoList.UseVisualStyleBackColor = false;
            this.btnInfoList.Visible = false;
            this.btnInfoList.Click += new System.EventHandler(this.btnInfoList_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.BackColor = System.Drawing.Color.LightCyan;
            this.btnLibrary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibrary.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLibrary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnLibrary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrary.Font = new System.Drawing.Font("华文楷体", 10F, System.Drawing.FontStyle.Bold);
            this.btnLibrary.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnLibrary.Location = new System.Drawing.Point(517, 31);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(112, 32);
            this.btnLibrary.TabIndex = 4;
            this.btnLibrary.Text = "图书馆";
            this.btnLibrary.UseVisualStyleBackColor = false;
            this.btnLibrary.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.LightCyan;
            this.btnBorrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrow.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBorrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnBorrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Font = new System.Drawing.Font("华文楷体", 10F, System.Drawing.FontStyle.Bold);
            this.btnBorrow.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnBorrow.Location = new System.Drawing.Point(657, 31);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(112, 32);
            this.btnBorrow.TabIndex = 4;
            this.btnBorrow.Text = "借阅查看";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.LightCyan;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("华文楷体", 10F, System.Drawing.FontStyle.Bold);
            this.btnInfo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnInfo.Location = new System.Drawing.Point(797, 31);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(112, 32);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "基本信息";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlForm.BackColor = System.Drawing.Color.LightCyan;
            this.pnlForm.Location = new System.Drawing.Point(1, 62);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(931, 448);
            this.pnlForm.TabIndex = 0;
            // 
            // lblShowName
            // 
            this.lblShowName.AutoSize = true;
            this.lblShowName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShowName.Location = new System.Drawing.Point(101, 35);
            this.lblShowName.Name = "lblShowName";
            this.lblShowName.Size = new System.Drawing.Size(41, 12);
            this.lblShowName.TabIndex = 7;
            this.lblShowName.Text = "label1";
            // 
            // lblShowID
            // 
            this.lblShowID.AutoSize = true;
            this.lblShowID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShowID.Location = new System.Drawing.Point(87, 13);
            this.lblShowID.Name = "lblShowID";
            this.lblShowID.Size = new System.Drawing.Size(41, 12);
            this.lblShowID.TabIndex = 6;
            this.lblShowID.Text = "编号：";
            // 
            // picHead
            // 
            this.picHead.Location = new System.Drawing.Point(12, 4);
            this.picHead.Name = "picHead";
            this.picHead.Size = new System.Drawing.Size(55, 55);
            this.picHead.TabIndex = 5;
            this.picHead.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 511);
            this.Controls.Add(this.lblShowName);
            this.Controls.Add(this.lblShowID);
            this.Controls.Add(this.picHead);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnLibrary);
            this.Controls.Add(this.btnInfoList);
            this.Controls.Add(this.pnlForm);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "任性图书馆";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInfoList;
        private System.Windows.Forms.Button btnLibrary;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblShowName;
        private System.Windows.Forms.Label lblShowID;
        private System.Windows.Forms.PictureBox picHead;


    }
}