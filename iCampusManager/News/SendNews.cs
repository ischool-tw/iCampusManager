using FISCA.DSAUtil;
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
    public partial class SendNews : FISCA.Presentation.Controls.BaseForm
    {
        /// <summary>
        /// 學校ID清單
        /// </summary>
        List<string> _SchoolUIDList { get; set; }
        /// <summary>
        /// 學校Record清單
        /// </summary>
        List<School> SchoolList { get; set; }

        public SendNews(List<string> SchoolUIDList)
        {
            InitializeComponent();

            _SchoolUIDList = SchoolUIDList;

            SchoolList = tool._A.Select<School>(_SchoolUIDList);
            foreach (School each in SchoolList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewX1);
                row.Cells[0].Value = each.Title;
                row.Cells[1].Value = each.DSNS;

                dataGridViewX1.Rows.Add(row);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSendString.Text))
                MsgBox.Show("請輸入內容!!");


            if (dataGridViewX1.Rows.Count == 0)
                MsgBox.Show("沒有學校可發送!!");

            //發送最新消息給選擇學校
            string SendPTH = "/*,";

            List<string> list = new List<string>();

            foreach (School each in SchoolList)
            {
                if (!list.Contains(each.DSNS))
                {
                    list.Add(each.DSNS);
                }
            }

            string SendString = string.Join(SendPTH, list);
            SendString += "/*";
            string[] each_user = SendString.Split(',');
            DSXmlHelper userHelper = new DSXmlHelper("To");
            foreach (string each in each_user)
                userHelper.AddElement(".", "User", each.Trim());

            DSXmlHelper helper = new DSXmlHelper("Request");
            helper.AddElement(".", "To", userHelper.GetRawXml(), true);
            helper.AddElement(".", "Message", tbSendString.Text);
            helper.AddElement(".", "Url", tbSendURL.Text);

            try
            {
                Service.InsertNews(new DSRequest(helper));
            }
            catch (Exception ex)
            {
                SmartSchool.ErrorReporting.ReportingService.ReportException(ex);
                MessageBox.Show(ex.Message);
            }

            MsgBox.Show("發送完成!!");

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
