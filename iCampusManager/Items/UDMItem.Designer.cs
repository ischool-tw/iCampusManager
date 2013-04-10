namespace iCampusManager
{
    partial class UDMItem
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnInstall = new DevComponents.DotNetBar.ButtonX();
            this.dgvUDM = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.chName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCheckUpdate = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUDM)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Location = new System.Drawing.Point(13, 329);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "刪除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInstall.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInstall.Location = new System.Drawing.Point(462, 329);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 23);
            this.btnInstall.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInstall.TabIndex = 4;
            this.btnInstall.Text = "註冊";
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // dgvUDM
            // 
            this.dgvUDM.AllowUserToAddRows = false;
            this.dgvUDM.AllowUserToDeleteRows = false;
            this.dgvUDM.AllowUserToResizeRows = false;
            this.dgvUDM.BackgroundColor = System.Drawing.Color.White;
            this.dgvUDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUDM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chName,
            this.chVersion,
            this.chUrl});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUDM.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUDM.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvUDM.Location = new System.Drawing.Point(13, 8);
            this.dgvUDM.MultiSelect = false;
            this.dgvUDM.Name = "dgvUDM";
            this.dgvUDM.ReadOnly = true;
            this.dgvUDM.RowHeadersVisible = false;
            this.dgvUDM.RowHeadersWidth = 25;
            this.dgvUDM.RowTemplate.Height = 24;
            this.dgvUDM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUDM.Size = new System.Drawing.Size(524, 315);
            this.dgvUDM.TabIndex = 3;
            this.dgvUDM.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUDM_CellMouseDoubleClick);
            // 
            // chName
            // 
            this.chName.DataPropertyName = "Name";
            this.chName.HeaderText = "名稱";
            this.chName.Name = "chName";
            this.chName.ReadOnly = true;
            this.chName.Width = 160;
            // 
            // chVersion
            // 
            this.chVersion.DataPropertyName = "Version";
            this.chVersion.HeaderText = "版本";
            this.chVersion.Name = "chVersion";
            this.chVersion.ReadOnly = true;
            this.chVersion.Width = 70;
            // 
            // chUrl
            // 
            this.chUrl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chUrl.DataPropertyName = "Url";
            this.chUrl.HeaderText = "位置";
            this.chUrl.Name = "chUrl";
            this.chUrl.ReadOnly = true;
            // 
            // btnCheckUpdate
            // 
            this.btnCheckUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheckUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheckUpdate.Location = new System.Drawing.Point(381, 329);
            this.btnCheckUpdate.Name = "btnCheckUpdate";
            this.btnCheckUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCheckUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheckUpdate.TabIndex = 5;
            this.btnCheckUpdate.Text = "檢查更新";
            this.btnCheckUpdate.Click += new System.EventHandler(this.btnCheckUpdate_Click);
            // 
            // UDMItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCheckUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.dgvUDM);
            this.Name = "UDMItem";
            this.Size = new System.Drawing.Size(550, 365);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUDM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnInstall;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvUDM;
        private DevComponents.DotNetBar.ButtonX btnCheckUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn chName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn chUrl;
    }
}
