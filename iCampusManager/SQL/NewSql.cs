using FISCA.Presentation.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iCampusManager
{
    public partial class NewSql : BaseForm
    {
        public NewSql()
        {
            InitializeComponent();

            this.Text = "新增 SQL內容";
        }

        SQLRecord _sql { get; set; }
        public NewSql(SQLRecord sql)
        {
            InitializeComponent();

            this.Text = "更新 SQL內容";

            _sql = sql;

            tbType.Text = _sql.Type; //分類
            tbComment.Text = _sql.Comment; //說明
            tbSQLQuery.Text = _sql.SQLQuery; //內容
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_sql == null)
            {
                //新增
                SQLRecord sql = new SQLRecord();
                sql.Type = tbType.Text;
                sql.Comment = tbComment.Text;
                sql.SQLQuery = tbSQLQuery.Text;
                sql.Admin = FISCA.Authentication.DSAServices.UserAccount;

                List<SQLRecord> list = tool._A.Select<SQLRecord>(tool._A.InsertValues(new List<SQLRecord>() { sql }));
                if (list.Count > 0)
                    _sql = list[0];

                MsgBox.Show("儲存成功!!");
            }
            else
            {
                //更新
                _sql.Type = tbType.Text;
                _sql.Comment = tbComment.Text;
                _sql.SQLQuery = tbSQLQuery.Text;
                _sql.Admin = FISCA.Authentication.DSAServices.UserAccount;
                tool._A.UpdateValues(new List<SQLRecord>() { _sql });

                MsgBox.Show("更新成功!!");

            }
        }
    }
}
