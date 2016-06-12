namespace LibraryManagerMent.UI
{
    partial class LoginFrom
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrom));
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.rdoUser = new System.Windows.Forms.RadioButton();
            this.rdoAdmin = new System.Windows.Forms.RadioButton();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.llblForget = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llblRegist = new System.Windows.Forms.LinkLabel();
            this.lblU = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUser.Location = new System.Drawing.Point(99, 160);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(64, 16);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "用户名：";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPwd.Location = new System.Drawing.Point(113, 199);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(50, 16);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "密码：";
            this.lblPwd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rdoUser
            // 
            this.rdoUser.AutoSize = true;
            this.rdoUser.Checked = true;
            this.rdoUser.Location = new System.Drawing.Point(29, 7);
            this.rdoUser.Name = "rdoUser";
            this.rdoUser.Size = new System.Drawing.Size(47, 16);
            this.rdoUser.TabIndex = 2;
            this.rdoUser.TabStop = true;
            this.rdoUser.Text = "用户";
            this.rdoUser.UseVisualStyleBackColor = true;
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.AutoSize = true;
            this.rdoAdmin.Location = new System.Drawing.Point(99, 7);
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Size = new System.Drawing.Size(59, 16);
            this.rdoAdmin.TabIndex = 3;
            this.rdoAdmin.Text = "管理员";
            this.rdoAdmin.UseVisualStyleBackColor = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(178, 160);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(147, 21);
            this.txtUser.TabIndex = 4;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(178, 199);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(147, 21);
            this.txtPwd.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.Location = new System.Drawing.Point(107, 279);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 49);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // llblForget
            // 
            this.llblForget.AutoSize = true;
            this.llblForget.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.llblForget.Location = new System.Drawing.Point(284, 227);
            this.llblForget.Name = "llblForget";
            this.llblForget.Size = new System.Drawing.Size(60, 11);
            this.llblForget.TabIndex = 7;
            this.llblForget.TabStop = true;
            this.llblForget.Text = "忘了密码？";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoUser);
            this.panel1.Controls.Add(this.rdoAdmin);
            this.panel1.Location = new System.Drawing.Point(116, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 31);
            this.panel1.TabIndex = 8;
            // 
            // llblRegist
            // 
            this.llblRegist.AutoSize = true;
            this.llblRegist.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.llblRegist.Location = new System.Drawing.Point(277, 300);
            this.llblRegist.Name = "llblRegist";
            this.llblRegist.Size = new System.Drawing.Size(37, 15);
            this.llblRegist.TabIndex = 9;
            this.llblRegist.TabStop = true;
            this.llblRegist.Text = "注册";
            this.llblRegist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRegist_LinkClicked);
            // 
            // lblU
            // 
            this.lblU.AutoSize = true;
            this.lblU.ForeColor = System.Drawing.Color.Red;
            this.lblU.Location = new System.Drawing.Point(328, 163);
            this.lblU.Name = "lblU";
            this.lblU.Size = new System.Drawing.Size(77, 12);
            this.lblU.TabIndex = 10;
            this.lblU.Text = "×用户不存在";
            this.lblU.Visible = false;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.ForeColor = System.Drawing.Color.Red;
            this.lblP.Location = new System.Drawing.Point(328, 202);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(77, 12);
            this.lblP.TabIndex = 10;
            this.lblP.Text = "×密码不正确";
            this.lblP.Visible = false;
            // 
            // LoginFrom
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 352);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblU);
            this.Controls.Add(this.llblRegist);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.llblForget);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(446, 391);
            this.MinimumSize = new System.Drawing.Size(446, 391);
            this.Name = "LoginFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "任性登录";
            this.Load += new System.EventHandler(this.LoginFrom_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginFrom_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.RadioButton rdoUser;
        private System.Windows.Forms.RadioButton rdoAdmin;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel llblForget;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llblRegist;
        private System.Windows.Forms.Label lblU;
        private System.Windows.Forms.Label lblP;
    }
}

