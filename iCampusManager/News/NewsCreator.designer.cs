namespace iCampusManager
{
    partial class NewsCreator
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該公開 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewsCreator));
            this.btnAnnounce = new DevComponents.DotNetBar.ButtonX();
            this.txtUsers = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMessage = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUrl = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new EnhancedErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnnounce
            // 
            this.btnAnnounce.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAnnounce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnounce.BackColor = System.Drawing.Color.Transparent;
            this.btnAnnounce.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAnnounce.Location = new System.Drawing.Point(577, 581);
            this.btnAnnounce.Name = "btnAnnounce";
            this.btnAnnounce.Size = new System.Drawing.Size(80, 25);
            this.btnAnnounce.TabIndex = 8;
            this.btnAnnounce.Text = "發佈";
            this.btnAnnounce.Click += new System.EventHandler(this.btnAnnounce_Click);
            // 
            // txtUsers
            // 
            this.txtUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtUsers.Border.Class = "TextBoxBorder";
            this.txtUsers.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUsers.Location = new System.Drawing.Point(9, 89);
            this.txtUsers.Multiline = true;
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUsers.Size = new System.Drawing.Size(820, 101);
            this.txtUsers.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtMessage.Border.Class = "TextBoxBorder";
            this.txtMessage.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMessage.Location = new System.Drawing.Point(9, 223);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(820, 276);
            this.txtMessage.TabIndex = 5;
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtUrl.Border.Class = "TextBoxBorder";
            this.txtUrl.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUrl.Location = new System.Drawing.Point(9, 536);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUrl.Size = new System.Drawing.Size(820, 37);
            this.txtUrl.TabIndex = 7;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(9, 62);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(114, 21);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "要發給哪些使用者";
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(9, 196);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(60, 21);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "訊息內容";
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(9, 507);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(99, 21);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "詳細說明 (網址)";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(663, 581);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 25);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(749, 581);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 25);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "刪除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(382, 9);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(442, 73);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "發送規則說明:\r\n*/* 所有學校/所有使用者\r\ndev.jh_kh/* 內部測試/所有使用者\r\ndev.jh_kh/*,demo.ischool.j/* 內部測" +
    "試/所有使用者,外部展示/所有使用者";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(136, 64);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(107, 17);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "(發送給測試環境)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // NewsCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 614);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtUsers);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAnnounce);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "NewsCreator";
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "發佈消息";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnAnnounce;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUsers;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMessage;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUrl;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private EnhancedErrorProvider errorProvider1;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}