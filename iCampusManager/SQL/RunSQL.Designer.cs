namespace iCampusManager
{
    partial class RunSQL
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRunSql = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.btnNewSql = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colAdminUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHelp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.執行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRunSql
            // 
            this.btnRunSql.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRunSql.AutoSize = true;
            this.btnRunSql.BackColor = System.Drawing.Color.Transparent;
            this.btnRunSql.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRunSql.Location = new System.Drawing.Point(727, 487);
            this.btnRunSql.Name = "btnRunSql";
            this.btnRunSql.Size = new System.Drawing.Size(130, 25);
            this.btnRunSql.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRunSql.TabIndex = 0;
            this.btnRunSql.Text = "對選擇學校執行SQL";
            this.btnRunSql.Click += new System.EventHandler(this.btnRunSql_Click);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.Location = new System.Drawing.Point(863, 487);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "離開";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewSql
            // 
            this.btnNewSql.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNewSql.AutoSize = true;
            this.btnNewSql.BackColor = System.Drawing.Color.Transparent;
            this.btnNewSql.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNewSql.Location = new System.Drawing.Point(12, 487);
            this.btnNewSql.Name = "btnNewSql";
            this.btnNewSql.Size = new System.Drawing.Size(75, 25);
            this.btnNewSql.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNewSql.TabIndex = 3;
            this.btnNewSql.Text = "新增SQL";
            this.btnNewSql.Click += new System.EventHandler(this.btnNewSql_Click);
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.AllowUserToResizeRows = false;
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAdminUser,
            this.colType,
            this.colHelp,
            this.colContent});
            this.dataGridViewX1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewX1.MultiSelect = false;
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RowTemplate.Height = 24;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(926, 465);
            this.dataGridViewX1.TabIndex = 4;
            this.dataGridViewX1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewX1_CellMouseDoubleClick);
            // 
            // colAdminUser
            // 
            this.colAdminUser.HeaderText = "建立sql使用者";
            this.colAdminUser.Name = "colAdminUser";
            this.colAdminUser.ReadOnly = true;
            this.colAdminUser.Width = 200;
            // 
            // colType
            // 
            this.colType.HeaderText = "分類";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colHelp
            // 
            this.colHelp.HeaderText = "說明";
            this.colHelp.Name = "colHelp";
            this.colHelp.ReadOnly = true;
            this.colHelp.Width = 300;
            // 
            // colContent
            // 
            this.colContent.HeaderText = "內容";
            this.colContent.Name = "colContent";
            this.colContent.ReadOnly = true;
            this.colContent.Width = 400;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.執行ToolStripMenuItem,
            this.toolStripSeparator1,
            this.修改ToolStripMenuItem,
            this.刪除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 98);
            // 
            // 執行ToolStripMenuItem
            // 
            this.執行ToolStripMenuItem.Name = "執行ToolStripMenuItem";
            this.執行ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.執行ToolStripMenuItem.Text = "執行";
            this.執行ToolStripMenuItem.Click += new System.EventHandler(this.執行ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 刪除ToolStripMenuItem
            // 
            this.刪除ToolStripMenuItem.Name = "刪除ToolStripMenuItem";
            this.刪除ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.刪除ToolStripMenuItem.Text = "刪除";
            this.刪除ToolStripMenuItem.Click += new System.EventHandler(this.刪除ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // RunSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 520);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.btnNewSql);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRunSql);
            this.DoubleBuffered = true;
            this.Name = "RunSQL";
            this.Text = "SQL大神";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnRunSql;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX btnNewSql;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdminUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHelp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 執行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}