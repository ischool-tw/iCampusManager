namespace iCampusManager
{
    partial class SendNews
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendNews));
            this.btnSend = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.tbSendString = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tbSendURL = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colSchoolName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSchoolDSNS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSend.AutoSize = true;
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSend.Location = new System.Drawing.Point(816, 457);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 25);
            this.btnSend.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "發送";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.Location = new System.Drawing.Point(897, 457);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "離開";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbSendString
            // 
            // 
            // 
            // 
            this.tbSendString.Border.Class = "TextBoxBorder";
            this.tbSendString.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbSendString.Location = new System.Drawing.Point(306, 40);
            this.tbSendString.Multiline = true;
            this.tbSendString.Name = "tbSendString";
            this.tbSendString.Size = new System.Drawing.Size(666, 345);
            this.tbSendString.TabIndex = 2;
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
            this.labelX1.Location = new System.Drawing.Point(306, 9);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(101, 21);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "請輸入發送內容";
            // 
            // tbSendURL
            // 
            // 
            // 
            // 
            this.tbSendURL.Border.Class = "TextBoxBorder";
            this.tbSendURL.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbSendURL.Location = new System.Drawing.Point(306, 418);
            this.tbSendURL.Name = "tbSendURL";
            this.tbSendURL.Size = new System.Drawing.Size(666, 25);
            this.tbSendURL.TabIndex = 4;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(306, 391);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(32, 21);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "URL";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.AllowUserToResizeRows = false;
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSchoolName,
            this.colSchoolDSNS});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RowHeadersVisible = false;
            this.dataGridViewX1.RowTemplate.Height = 24;
            this.dataGridViewX1.Size = new System.Drawing.Size(278, 403);
            this.dataGridViewX1.TabIndex = 6;
            // 
            // colSchoolName
            // 
            this.colSchoolName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSchoolName.HeaderText = "學校名稱";
            this.colSchoolName.Name = "colSchoolName";
            this.colSchoolName.Width = 85;
            // 
            // colSchoolDSNS
            // 
            this.colSchoolDSNS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSchoolDSNS.HeaderText = "DSNS";
            this.colSchoolDSNS.Name = "colSchoolDSNS";
            this.colSchoolDSNS.Width = 67;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(13, 13);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(60, 21);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "學校清單";
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
            this.labelX4.Location = new System.Drawing.Point(13, 459);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(372, 20);
            this.labelX4.TabIndex = 8;
            this.labelX4.Text = resources.GetString("labelX4.Text");
            // 
            // SendNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 494);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.tbSendURL);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.tbSendString);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSend);
            this.DoubleBuffered = true;
            this.Name = "SendNews";
            this.Text = "發送最新消息";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnSend;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.Controls.TextBoxX tbSendString;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbSendURL;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSchoolName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSchoolDSNS;
        private DevComponents.DotNetBar.LabelX labelX4;
    }
}