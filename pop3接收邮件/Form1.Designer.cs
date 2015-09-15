namespace pop3接收邮件
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.Disconnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MailNum = new System.Windows.Forms.TextBox();
            this.BackupChBox = new System.Windows.Forms.CheckBox();
            this.Retrieve = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.PopServer = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "POP3服务器地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码：";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(340, 12);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 3;
            this.Connect.Text = "连接";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(340, 45);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(75, 23);
            this.Disconnect.TabIndex = 4;
            this.Disconnect.Text = "断开连接";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "信息：";
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(19, 122);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(396, 181);
            this.Message.TabIndex = 6;
            this.Message.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "邮件编号：";
            // 
            // MailNum
            // 
            this.MailNum.Location = new System.Drawing.Point(90, 309);
            this.MailNum.Name = "MailNum";
            this.MailNum.Size = new System.Drawing.Size(100, 21);
            this.MailNum.TabIndex = 8;
            // 
            // BackupChBox
            // 
            this.BackupChBox.AutoSize = true;
            this.BackupChBox.Location = new System.Drawing.Point(197, 310);
            this.BackupChBox.Name = "BackupChBox";
            this.BackupChBox.Size = new System.Drawing.Size(156, 16);
            this.BackupChBox.TabIndex = 9;
            this.BackupChBox.Text = "在邮件服务器上保留备份";
            this.BackupChBox.UseVisualStyleBackColor = true;
            // 
            // Retrieve
            // 
            this.Retrieve.Location = new System.Drawing.Point(360, 309);
            this.Retrieve.Name = "Retrieve";
            this.Retrieve.Size = new System.Drawing.Size(75, 23);
            this.Retrieve.TabIndex = 10;
            this.Retrieve.Text = "收取邮件";
            this.Retrieve.UseVisualStyleBackColor = true;
            this.Retrieve.Click += new System.EventHandler(this.Retrieve_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "状态：";
            // 
            // PopServer
            // 
            this.PopServer.Location = new System.Drawing.Point(121, 13);
            this.PopServer.Name = "PopServer";
            this.PopServer.Size = new System.Drawing.Size(213, 21);
            this.PopServer.TabIndex = 13;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(121, 41);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(213, 21);
            this.Username.TabIndex = 14;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(121, 76);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(213, 21);
            this.Password.TabIndex = 15;
            // 
            // Status
            // 
            this.Status.FormattingEnabled = true;
            this.Status.ItemHeight = 12;
            this.Status.Location = new System.Drawing.Point(21, 349);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(403, 76);
            this.Status.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 426);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.PopServer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Retrieve);
            this.Controls.Add(this.BackupChBox);
            this.Controls.Add(this.MailNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "POP3邮件接收程序";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Message;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MailNum;
        private System.Windows.Forms.CheckBox BackupChBox;
        private System.Windows.Forms.Button Retrieve;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PopServer;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.ListBox Status;

    }
}

