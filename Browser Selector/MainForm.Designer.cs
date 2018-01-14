namespace Browser_Selector
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkBoxOnlineMode = new System.Windows.Forms.CheckBox();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.labelServerState = new System.Windows.Forms.Label();
            this.labelServerStateIcon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainNotifyIcon
            // 
            this.MainNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MainNotifyIcon.Icon")));
            this.MainNotifyIcon.Text = "浏览器选择器";
            this.MainNotifyIcon.Visible = true;
            this.MainNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainNotifyIcon_MouseDoubleClick);
            // 
            // checkBoxOnlineMode
            // 
            this.checkBoxOnlineMode.AutoSize = true;
            this.checkBoxOnlineMode.Location = new System.Drawing.Point(16, 13);
            this.checkBoxOnlineMode.Name = "checkBoxOnlineMode";
            this.checkBoxOnlineMode.Size = new System.Drawing.Size(120, 16);
            this.checkBoxOnlineMode.TabIndex = 0;
            this.checkBoxOnlineMode.Text = "使用在线规则列表";
            this.checkBoxOnlineMode.UseVisualStyleBackColor = true;
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(13, 35);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(180, 21);
            this.textBoxServer.TabIndex = 1;
            // 
            // labelServerState
            // 
            this.labelServerState.AutoSize = true;
            this.labelServerState.Location = new System.Drawing.Point(36, 63);
            this.labelServerState.Name = "labelServerState";
            this.labelServerState.Size = new System.Drawing.Size(137, 12);
            this.labelServerState.TabIndex = 2;
            this.labelServerState.Text = "当前正使用本地规则列表";
            // 
            // labelServerStateIcon
            // 
            this.labelServerStateIcon.AutoSize = true;
            this.labelServerStateIcon.ForeColor = System.Drawing.Color.Lime;
            this.labelServerStateIcon.Location = new System.Drawing.Point(14, 63);
            this.labelServerStateIcon.Name = "labelServerStateIcon";
            this.labelServerStateIcon.Size = new System.Drawing.Size(17, 12);
            this.labelServerStateIcon.TabIndex = 3;
            this.labelServerStateIcon.Text = "●";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 88);
            this.Controls.Add(this.labelServerStateIcon);
            this.Controls.Add(this.labelServerState);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.checkBoxOnlineMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "浏览器选择器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon MainNotifyIcon;
        private System.Windows.Forms.CheckBox checkBoxOnlineMode;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Label labelServerState;
        private System.Windows.Forms.Label labelServerStateIcon;
    }
}

