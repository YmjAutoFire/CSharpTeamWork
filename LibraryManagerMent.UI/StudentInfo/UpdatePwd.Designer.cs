namespace LibraryManagerMent.UI
{
    partial class UpdatePwd
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
            this.btnSure = new System.Windows.Forms.Button();
            this.lblp = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtp = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(179, 173);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(68, 23);
            this.btnSure.TabIndex = 0;
            this.btnSure.Text = "确认";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // lblp
            // 
            this.lblp.AutoSize = true;
            this.lblp.Location = new System.Drawing.Point(18, 65);
            this.lblp.Name = "lblp";
            this.lblp.Size = new System.Drawing.Size(53, 12);
            this.lblp.TabIndex = 1;
            this.lblp.Text = "新密码：";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(18, 120);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(65, 12);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "确认密码：";
            // 
            // txtp
            // 
            this.txtp.Location = new System.Drawing.Point(89, 62);
            this.txtp.Name = "txtp";
            this.txtp.PasswordChar = '*';
            this.txtp.Size = new System.Drawing.Size(135, 21);
            this.txtp.TabIndex = 3;
            this.txtp.TextChanged += new System.EventHandler(this.txtp_TextChanged);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(89, 111);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(135, 21);
            this.txtPwd.TabIndex = 4;
            this.txtPwd.Leave += new System.EventHandler(this.txtPwd_Leave);
            // 
            // UpdatePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtp);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblp);
            this.Controls.Add(this.btnSure);
            this.Name = "UpdatePwd";
            this.Text = "Pwd";
            this.Load += new System.EventHandler(this.UpdatePwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.Label lblp;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.TextBox txtPwd;
    }
}



