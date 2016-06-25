namespace LibraryManagerMent.UI
{
    partial class BookTypeTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookTypeTree));
            this.tvSearch = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tvSearch
            // 
            this.tvSearch.BackColor = System.Drawing.Color.White;
            this.tvSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvSearch.Indent = 5;
            this.tvSearch.Location = new System.Drawing.Point(0, 0);
            this.tvSearch.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.tvSearch.Name = "tvSearch";
            treeNode1.Checked = true;
            treeNode1.Name = "节点0";
            treeNode1.Text = "图书类别分类";
            this.tvSearch.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvSearch.Size = new System.Drawing.Size(256, 361);
            this.tvSearch.TabIndex = 10;
            this.tvSearch.DoubleClick += new System.EventHandler(this.tvSearch_DoubleClick);
            // 
            // BookTypeTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 361);
            this.Controls.Add(this.tvSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookTypeTree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书类型";
            this.Load += new System.EventHandler(this.BookTypeTree_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvSearch;

    }
}