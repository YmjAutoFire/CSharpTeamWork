namespace LibraryManagerMent.UI.LoginForm
{
    partial class StudentLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentLoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStuID = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtpic = new System.Windows.Forms.TextBox();
            this.dtpEntrance = new System.Windows.Forms.DateTimePicker();
            this.numClass = new System.Windows.Forms.NumericUpDown();
            this.combProfession = new System.Windows.Forms.ComboBox();
            this.combCollege = new System.Windows.Forms.ComboBox();
            this.combSchool = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numClass)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "学校：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "学院：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "专业：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "班级：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "入学时间：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "头像：";
            // 
            // txtStuID
            // 
            this.txtStuID.Location = new System.Drawing.Point(142, 32);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.Size = new System.Drawing.Size(142, 21);
            this.txtStuID.TabIndex = 0;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(142, 75);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(142, 21);
            this.txtStuName.TabIndex = 1;
            // 
            // txtpic
            // 
            this.txtpic.Location = new System.Drawing.Point(142, 333);
            this.txtpic.Name = "txtpic";
            this.txtpic.ReadOnly = true;
            this.txtpic.Size = new System.Drawing.Size(142, 21);
            this.txtpic.TabIndex = 7;
            this.txtpic.Enter += new System.EventHandler(this.txtpic_Enter);
            // 
            // dtpEntrance
            // 
            this.dtpEntrance.Location = new System.Drawing.Point(142, 287);
            this.dtpEntrance.Name = "dtpEntrance";
            this.dtpEntrance.Size = new System.Drawing.Size(142, 21);
            this.dtpEntrance.TabIndex = 6;
            // 
            // numClass
            // 
            this.numClass.Location = new System.Drawing.Point(142, 248);
            this.numClass.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numClass.Name = "numClass";
            this.numClass.Size = new System.Drawing.Size(142, 21);
            this.numClass.TabIndex = 5;
            this.numClass.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // combProfession
            // 
            this.combProfession.FormattingEnabled = true;
            this.combProfession.Location = new System.Drawing.Point(142, 204);
            this.combProfession.Name = "combProfession";
            this.combProfession.Size = new System.Drawing.Size(142, 20);
            this.combProfession.TabIndex = 4;
            // 
            // combCollege
            // 
            this.combCollege.FormattingEnabled = true;
            this.combCollege.Location = new System.Drawing.Point(142, 161);
            this.combCollege.Name = "combCollege";
            this.combCollege.Size = new System.Drawing.Size(142, 20);
            this.combCollege.TabIndex = 3;
            this.combCollege.SelectedIndexChanged += new System.EventHandler(this.combCollege_SelectedIndexChanged);
            // 
            // combSchool
            // 
            this.combSchool.FormattingEnabled = true;
            this.combSchool.Location = new System.Drawing.Point(142, 118);
            this.combSchool.Name = "combSchool";
            this.combSchool.Size = new System.Drawing.Size(142, 20);
            this.combSchool.TabIndex = 2;
            this.combSchool.SelectedIndexChanged += new System.EventHandler(this.combSchool_SelectedIndexChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(85, 394);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "注册";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(191, 394);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "取消";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // StudentLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(359, 466);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.combSchool);
            this.Controls.Add(this.combCollege);
            this.Controls.Add(this.combProfession);
            this.Controls.Add(this.numClass);
            this.Controls.Add(this.dtpEntrance);
            this.Controls.Add(this.txtpic);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.txtStuID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentLoginForm";
            this.Text = "学生用户注册";
            this.Load += new System.EventHandler(this.StudentLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStuID;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtpic;
        private System.Windows.Forms.DateTimePicker dtpEntrance;
        private System.Windows.Forms.NumericUpDown numClass;
        private System.Windows.Forms.ComboBox combProfession;
        private System.Windows.Forms.ComboBox combCollege;
        private System.Windows.Forms.ComboBox combSchool;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReset;
    }
}