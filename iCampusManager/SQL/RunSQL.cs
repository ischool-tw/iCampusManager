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
    public partial class RunSQL : BaseForm
    {
        public RunSQL()
        {
            InitializeComponent();

            SetForm();
        }

        private void SetForm()
        {
            dataGridViewX1.Rows.Clear();

            List<SQLRecord> SQLList = tool._A.Select<SQLRecord>();
            foreach (SQLRecord each in SQLList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewX1);

                row.Cells[0].Value = each.Admin;
                row.Cells[1].Value = each.Type;
                row.Cells[2].Value = each.Comment;
                row.Cells[3].Value = each.SQLQuery;
                row.Tag = each;

                dataGridViewX1.Rows.Add(row);
            }
        }

        /// <summary>
        /// 新增一個SQL記錄
        /// </summary>
        private void btnNewSql_Click(object sender, EventArgs e)
        {
            NewSql sqlForm = new NewSql();
            sqlForm.ShowDialog();

            SetForm();
        }

        /// <summary>
        /// 執行本SQL
        /// </summary>
        private void btnRunSql_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count > 0 && dataGridViewX1.SelectedRows.Count <= 2)
            {
                DataGridViewRow row = dataGridViewX1.SelectedRows[0];

                SQLRecord sql = (SQLRecord)row.Tag;

                new ExportQueryData().ExecuteTasks(sql.SQLQuery.Replace("\n\t", ""));

            }
            else
            {
                MsgBox.Show("需選擇一筆資料!!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewX1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            NewSql sqlForm = new NewSql((SQLRecord)dataGridViewX1.Rows[e.RowIndex].Tag);
            sqlForm.ShowDialog();

            SetForm();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSql sqlForm = new NewSql((SQLRecord)dataGridViewX1.SelectedRows[0].Tag);
            sqlForm.ShowDialog();

            SetForm();

        }

        private void 執行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count > 0 && dataGridViewX1.SelectedRows.Count <= 2)
            {
                DataGridViewRow row = dataGridViewX1.SelectedRows[0];

                SQLRecord sql = (SQLRecord)row.Tag;

                new ExportQueryData().ExecuteTasks(sql.SQLQuery.Replace("\n\t", ""));

            }
            else
            {
                MsgBox.Show("需選擇一筆資料!!");
            }
        }

        private void 刪除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count > 0 && dataGridViewX1.SelectedRows.Count <= 2)
            {
                if (MsgBox.Show("您確定要刪除此資料?", MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    DataGridViewRow row = dataGridViewX1.SelectedRows[0];

                    SQLRecord sql = (SQLRecord)row.Tag;

                    tool._A.DeletedValues(new List<SQLRecord> { sql });
                    MsgBox.Show("刪除成功!!");

                    SetForm();
                }
            }
            else
            {
                MsgBox.Show("需選擇一筆資料!!");
            }

        }
    }
}
