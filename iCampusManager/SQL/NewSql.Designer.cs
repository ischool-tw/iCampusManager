namespace iCampusManager
{
    partial class NewSql
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
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.tbSQLQuery = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbHelp1 = new DevComponents.DotNetBar.LabelX();
            this.tbType = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbComment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbHelp2 = new DevComponents.DotNetBar.LabelX();
            this.lbHelp3 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(660, 419);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "儲存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.Location = new System.Drawing.Point(741, 419);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "離開";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbSQLQuery
            // 
            this.tbSQLQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbSQLQuery.Border.Class = "TextBoxBorder";
            this.tbSQLQuery.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbSQLQuery.Location = new System.Drawing.Point(61, 58);
            this.tbSQLQuery.Multiline = true;
            this.tbSQLQuery.Name = "tbSQLQuery";
            this.tbSQLQuery.Size = new System.Drawing.Size(755, 351);
            this.tbSQLQuery.TabIndex = 2;
            // 
            // lbHelp1
            // 
            this.lbHelp1.AutoSize = true;
            this.lbHelp1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbHelp1.BackgroundStyle.Class = "";
            this.lbHelp1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbHelp1.Location = new System.Drawing.Point(13, 23);
            this.lbHelp1.Name = "lbHelp1";
            this.lbHelp1.Size = new System.Drawing.Size(34, 21);
            this.lbHelp1.TabIndex = 3;
            this.lbHelp1.Text = "分類";
            // 
            // tbType
            // 
            // 
            // 
            // 
            this.tbType.Border.Class = "TextBoxBorder";
            this.tbType.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbType.Location = new System.Drawing.Point(61, 21);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(166, 25);
            this.tbType.TabIndex = 4;
            // 
            // tbComment
            // 
            this.tbComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbComment.Border.Class = "TextBoxBorder";
            this.tbComment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbComment.Location = new System.Drawing.Point(289, 21);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(527, 25);
            this.tbComment.TabIndex = 6;
            // 
            // lbHelp2
            // 
            this.lbHelp2.AutoSize = true;
            this.lbHelp2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbHelp2.BackgroundStyle.Class = "";
            this.lbHelp2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbHelp2.Location = new System.Drawing.Point(241, 23);
            this.lbHelp2.Name = "lbHelp2";
            this.lbHelp2.Size = new System.Drawing.Size(34, 21);
            this.lbHelp2.TabIndex = 5;
            this.lbHelp2.Text = "說明";
            // 
            // lbHelp3
            // 
            this.lbHelp3.AutoSize = true;
            this.lbHelp3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbHelp3.BackgroundStyle.Class = "";
            this.lbHelp3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbHelp3.Location = new System.Drawing.Point(13, 58);
            this.lbHelp3.Name = "lbHelp3";
            this.lbHelp3.Size = new System.Drawing.Size(34, 21);
            this.lbHelp3.TabIndex = 7;
            this.lbHelp3.Text = "內容";
            // 
            // NewSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 452);
            this.Controls.Add(this.lbHelp3);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.lbHelp2);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.lbHelp1);
            this.Controls.Add(this.tbSQLQuery);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.DoubleBuffered = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "NewSql";
            this.Text = "SQL內容";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.Controls.TextBoxX tbSQLQuery;
        private DevComponents.DotNetBar.LabelX lbHelp1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbType;
        private DevComponents.DotNetBar.Controls.TextBoxX tbComment;
        private DevComponents.DotNetBar.LabelX lbHelp2;
        private DevComponents.DotNetBar.LabelX lbHelp3;
    }
}