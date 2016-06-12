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
            // 
            // btnNow
            // 
            this.btnNow.Location = new System.Drawing.Point(228, 33);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(156, 27);
            this.btnNow.TabIndex = 3;
            this.btnNow.Text = "当前借阅";
            this.btnNow.UseVisualStyleBackColor = true;
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Location = new System.Drawing.Point(61, 79);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.RowTemplate.Height = 23;
            this.dgvBorrow.Size = new System.Drawing.Size(820, 326);
            this.dgvBorrow.TabIndex = 2;
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(931, 448);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnNow);
            this.Controls.Add(this.dgvBorrow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowForm";
            this.Text = "BorrowForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnNow;
        private System.Windows.Forms.DataGridView dgvBorrow;
    }
}