namespace iCampusManager
{
    partial class UDSItem
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
            this.dgvUDS = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.chName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUDS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUDS
            // 
            this.dgvUDS.AllowUserToAddRows = false;
            this.dgvUDS.AllowUserToDeleteRows = false;
            this.dgvUDS.BackgroundColor = System.Drawing.Color.White;
            this.dgvUDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chName});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUDS.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUDS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvUDS.Location = new System.Drawing.Point(13, 8);
            this.dgvUDS.Name = "dgvUDS";
            this.dgvUDS.ReadOnly = true;
            this.dgvUDS.RowHeadersWidth = 25;
            this.dgvUDS.RowTemplate.Height = 24;
            this.dgvUDS.Size = new System.Drawing.Size(524, 338);
            this.dgvUDS.TabIndex = 0;
            // 
            // chName
            // 
            this.chName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chName.HeaderText = "名稱";
            this.chName.Name = "chName";
            this.chName.ReadOnly = true;
            // 
            // UDSItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvUDS);
            this.Name = "UDSItem";
            this.Size = new System.Drawing.Size(550, 360);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvUDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn chName;
    }
}
