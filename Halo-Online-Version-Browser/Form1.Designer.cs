namespace HaloOnlineVersionBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbVersion = new System.Windows.Forms.GroupBox();
            this.lbVersion = new System.Windows.Forms.ListBox();
            this.gbContent = new System.Windows.Forms.GroupBox();
            this.DownLoadStatespb = new System.Windows.Forms.ProgressBar();
            this.CommitTimeTilelab = new System.Windows.Forms.Label();
            this.commitIdlb = new System.Windows.Forms.LinkLabel();
            this.Devlab = new System.Windows.Forms.Label();
            this.Welcomelab = new System.Windows.Forms.Label();
            this.FileSizelb = new System.Windows.Forms.Label();
            this.Authorlb = new System.Windows.Forms.Label();
            this.FileSizeTilelb = new System.Windows.Forms.Label();
            this.commitTimelb = new System.Windows.Forms.Label();
            this.branchlb = new System.Windows.Forms.Label();
            this.AuthorTitlelb = new System.Windows.Forms.Label();
            this.commitMessagelb = new System.Windows.Forms.Label();
            this.Versionlb = new System.Windows.Forms.Label();
            this.commitTitlelb = new System.Windows.Forms.Label();
            this.VersionTitlelb = new System.Windows.Forms.Label();
            this.DownLoadbtn = new System.Windows.Forms.Button();
            this.gbVersion.SuspendLayout();
            this.gbContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVersion
            // 
            this.gbVersion.Controls.Add(this.lbVersion);
            this.gbVersion.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbVersion.Location = new System.Drawing.Point(13, 12);
            this.gbVersion.Name = "gbVersion";
            this.gbVersion.Size = new System.Drawing.Size(124, 257);
            this.gbVersion.TabIndex = 0;
            this.gbVersion.TabStop = false;
            this.gbVersion.Text = "版本列表";
            // 
            // lbVersion
            // 
            this.lbVersion.FormattingEnabled = true;
            this.lbVersion.ItemHeight = 17;
            this.lbVersion.Location = new System.Drawing.Point(6, 21);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(112, 225);
            this.lbVersion.TabIndex = 0;
            this.lbVersion.Click += new System.EventHandler(this.lbVersion_Click);
            // 
            // gbContent
            // 
            this.gbContent.Controls.Add(this.DownLoadStatespb);
            this.gbContent.Controls.Add(this.CommitTimeTilelab);
            this.gbContent.Controls.Add(this.commitIdlb);
            this.gbContent.Controls.Add(this.Devlab);
            this.gbContent.Controls.Add(this.Welcomelab);
            this.gbContent.Controls.Add(this.FileSizelb);
            this.gbContent.Controls.Add(this.Authorlb);
            this.gbContent.Controls.Add(this.FileSizeTilelb);
            this.gbContent.Controls.Add(this.commitTimelb);
            this.gbContent.Controls.Add(this.branchlb);
            this.gbContent.Controls.Add(this.AuthorTitlelb);
            this.gbContent.Controls.Add(this.commitMessagelb);
            this.gbContent.Controls.Add(this.Versionlb);
            this.gbContent.Controls.Add(this.commitTitlelb);
            this.gbContent.Controls.Add(this.VersionTitlelb);
            this.gbContent.Controls.Add(this.DownLoadbtn);
            this.gbContent.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbContent.Location = new System.Drawing.Point(144, 12);
            this.gbContent.Name = "gbContent";
            this.gbContent.Size = new System.Drawing.Size(447, 257);
            this.gbContent.TabIndex = 1;
            this.gbContent.TabStop = false;
            this.gbContent.Text = "版本信息";
            // 
            // DownLoadStatespb
            // 
            this.DownLoadStatespb.Location = new System.Drawing.Point(9, 229);
            this.DownLoadStatespb.Name = "DownLoadStatespb";
            this.DownLoadStatespb.Size = new System.Drawing.Size(351, 23);
            this.DownLoadStatespb.TabIndex = 17;
            // 
            // CommitTimeTilelab
            // 
            this.CommitTimeTilelab.AutoSize = true;
            this.CommitTimeTilelab.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.CommitTimeTilelab.Location = new System.Drawing.Point(32, 181);
            this.CommitTimeTilelab.Name = "CommitTimeTilelab";
            this.CommitTimeTilelab.Size = new System.Drawing.Size(90, 21);
            this.CommitTimeTilelab.TabIndex = 16;
            this.CommitTimeTilelab.Text = "更新时间：";
            // 
            // commitIdlb
            // 
            this.commitIdlb.AutoSize = true;
            this.commitIdlb.Location = new System.Drawing.Point(73, 210);
            this.commitIdlb.Name = "commitIdlb";
            this.commitIdlb.Size = new System.Drawing.Size(66, 17);
            this.commitIdlb.TabIndex = 15;
            this.commitIdlb.TabStop = true;
            this.commitIdlb.Text = "linkLabel1";
            this.commitIdlb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.commitIdlb_LinkClicked);
            // 
            // Devlab
            // 
            this.Devlab.AutoSize = true;
            this.Devlab.Location = new System.Drawing.Point(96, 64);
            this.Devlab.Name = "Devlab";
            this.Devlab.Size = new System.Drawing.Size(257, 119);
            this.Devlab.TabIndex = 0;
            this.Devlab.Text = "欢迎使用Halo Online版本浏览器\r\n\r\n感谢halo.click提供版本api\r\n\r\n作者:FDKPIBC\r\n\r\n如有问题请发送邮件到:t18511075" +
    "4@live.com";
            // 
            // Welcomelab
            // 
            this.Welcomelab.AutoSize = true;
            this.Welcomelab.Location = new System.Drawing.Point(60, 79);
            this.Welcomelab.Name = "Welcomelab";
            this.Welcomelab.Size = new System.Drawing.Size(0, 17);
            this.Welcomelab.TabIndex = 13;
            // 
            // FileSizelb
            // 
            this.FileSizelb.AutoSize = true;
            this.FileSizelb.Location = new System.Drawing.Point(124, 95);
            this.FileSizelb.Name = "FileSizelb";
            this.FileSizelb.Size = new System.Drawing.Size(57, 17);
            this.FileSizelb.TabIndex = 12;
            this.FileSizelb.Text = "1289469";
            // 
            // Authorlb
            // 
            this.Authorlb.AutoSize = true;
            this.Authorlb.Location = new System.Drawing.Point(96, 64);
            this.Authorlb.Name = "Authorlb";
            this.Authorlb.Size = new System.Drawing.Size(55, 17);
            this.Authorlb.TabIndex = 11;
            this.Authorlb.Text = "emoose";
            // 
            // FileSizeTilelb
            // 
            this.FileSizeTilelb.AutoSize = true;
            this.FileSizeTilelb.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.FileSizeTilelb.Location = new System.Drawing.Point(28, 91);
            this.FileSizeTilelb.Name = "FileSizeTilelb";
            this.FileSizeTilelb.Size = new System.Drawing.Size(90, 21);
            this.FileSizeTilelb.TabIndex = 10;
            this.FileSizeTilelb.Text = "更新大小：";
            // 
            // commitTimelb
            // 
            this.commitTimelb.AutoSize = true;
            this.commitTimelb.Location = new System.Drawing.Point(128, 185);
            this.commitTimelb.Name = "commitTimelb";
            this.commitTimelb.Size = new System.Drawing.Size(111, 17);
            this.commitTimelb.TabIndex = 9;
            this.commitTimelb.Text = "7/7/2015 9:42 PM";
            // 
            // branchlb
            // 
            this.branchlb.AutoSize = true;
            this.branchlb.Location = new System.Drawing.Point(6, 210);
            this.branchlb.Name = "branchlb";
            this.branchlb.Size = new System.Drawing.Size(48, 17);
            this.branchlb.TabIndex = 7;
            this.branchlb.Text = "branch";
            this.branchlb.Visible = false;
            // 
            // AuthorTitlelb
            // 
            this.AuthorTitlelb.AutoSize = true;
            this.AuthorTitlelb.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.AuthorTitlelb.Location = new System.Drawing.Point(28, 60);
            this.AuthorTitlelb.Name = "AuthorTitlelb";
            this.AuthorTitlelb.Size = new System.Drawing.Size(62, 21);
            this.AuthorTitlelb.TabIndex = 6;
            this.AuthorTitlelb.Text = "更新者:";
            // 
            // commitMessagelb
            // 
            this.commitMessagelb.AutoSize = true;
            this.commitMessagelb.Location = new System.Drawing.Point(51, 154);
            this.commitMessagelb.Name = "commitMessagelb";
            this.commitMessagelb.Size = new System.Drawing.Size(104, 17);
            this.commitMessagelb.TabIndex = 5;
            this.commitMessagelb.Text = "commitMessage";
            // 
            // Versionlb
            // 
            this.Versionlb.AutoSize = true;
            this.Versionlb.Location = new System.Drawing.Point(183, 33);
            this.Versionlb.Name = "Versionlb";
            this.Versionlb.Size = new System.Drawing.Size(50, 17);
            this.Versionlb.TabIndex = 4;
            this.Versionlb.Text = "version";
            // 
            // commitTitlelb
            // 
            this.commitTitlelb.AutoSize = true;
            this.commitTitlelb.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.commitTitlelb.Location = new System.Drawing.Point(28, 123);
            this.commitTitlelb.Name = "commitTitlelb";
            this.commitTitlelb.Size = new System.Drawing.Size(78, 21);
            this.commitTitlelb.TabIndex = 2;
            this.commitTitlelb.Text = "更新说明:";
            // 
            // VersionTitlelb
            // 
            this.VersionTitlelb.AutoSize = true;
            this.VersionTitlelb.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VersionTitlelb.Location = new System.Drawing.Point(28, 29);
            this.VersionTitlelb.Name = "VersionTitlelb";
            this.VersionTitlelb.Size = new System.Drawing.Size(149, 21);
            this.VersionTitlelb.TabIndex = 1;
            this.VersionTitlelb.Text = "ElDorito - master :";
            // 
            // DownLoadbtn
            // 
            this.DownLoadbtn.Location = new System.Drawing.Point(366, 229);
            this.DownLoadbtn.Name = "DownLoadbtn";
            this.DownLoadbtn.Size = new System.Drawing.Size(75, 23);
            this.DownLoadbtn.TabIndex = 1;
            this.DownLoadbtn.Text = "下载";
            this.DownLoadbtn.UseVisualStyleBackColor = false;
            this.DownLoadbtn.Click += new System.EventHandler(this.DownLoadbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 276);
            this.Controls.Add(this.gbContent);
            this.Controls.Add(this.gbVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Halo Online版本浏览器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbVersion.ResumeLayout(false);
            this.gbContent.ResumeLayout(false);
            this.gbContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVersion;
        private System.Windows.Forms.ListBox lbVersion;
        private System.Windows.Forms.GroupBox gbContent;
        private System.Windows.Forms.Label VersionTitlelb;
        private System.Windows.Forms.Button DownLoadbtn;
        private System.Windows.Forms.Label Versionlb;
        private System.Windows.Forms.Label commitTitlelb;
        private System.Windows.Forms.Label commitMessagelb;
        private System.Windows.Forms.Label AuthorTitlelb;
        private System.Windows.Forms.Label branchlb;
        private System.Windows.Forms.Label FileSizelb;
        private System.Windows.Forms.Label Authorlb;
        private System.Windows.Forms.Label FileSizeTilelb;
        private System.Windows.Forms.Label commitTimelb;
        private System.Windows.Forms.Label Welcomelab;
        private System.Windows.Forms.Label Devlab;
        private System.Windows.Forms.LinkLabel commitIdlb;
        private System.Windows.Forms.Label CommitTimeTilelab;
        private System.Windows.Forms.ProgressBar DownLoadStatespb;
    }
}

