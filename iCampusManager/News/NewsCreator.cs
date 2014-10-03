using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using FISCA.Presentation.Controls;
using FISCA.DSAUtil;

namespace iCampusManager
{
    public partial class NewsCreator : BaseForm
    {
        private string _news_id;

        public NewsCreator()
        {
            InitializeComponent();
        }

        public NewsCreator(DSXmlHelper helper)
            : this()
        {
            _news_id = helper.GetText("@ID");
            //目的是讓Text分行分段 by dylan
            txtMessage.Text = helper.GetText("Message").ToString().Replace("\n", "\r\n");
            txtUrl.Text = helper.GetText("Url");

            foreach (XmlElement each_user in helper.GetElements("To/To/User"))
            {
                if (!string.IsNullOrEmpty(txtUsers.Text)) txtUsers.Text += ", ";
                txtUsers.Text += each_user.InnerText;
            }

            btnAnnounce.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        public NewsCreator(List<string> user_list)
            : this()
        {
            foreach (string user in user_list)
            {
                if (!string.IsNullOrEmpty(txtUsers.Text)) txtUsers.Text += ", ";
                txtUsers.Text += user;
            }
        }

        private void btnAnnounce_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtUsers.Text))
                errorProvider1.SetError(labelX1, "不可空白");
            if (string.IsNullOrEmpty(txtMessage.Text))
                errorProvider1.SetError(labelX2, "不可空白");
            if (errorProvider1.HasError)
                return;

            string[] each_user = txtUsers.Text.Split(',');
            DSXmlHelper userHelper = new DSXmlHelper("To");
            foreach (string each in each_user)
                userHelper.AddElement(".", "User", each.Trim());

            DSXmlHelper helper = new DSXmlHelper("Request");
            helper.AddElement(".", "To", userHelper.GetRawXml(), true);
            helper.AddElement(".", "Message", txtMessage.Text);
            helper.AddElement(".", "Url", txtUrl.Text);

            try
            {
                Service.InsertNews(new DSRequest(helper));
            }
            catch (Exception ex)
            {
                SmartSchool.ErrorReporting.ReportingService.ReportException(ex);
                MessageBox.Show(ex.Message);
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("對象:" + txtUsers.Text);
            sb.AppendLine("內容:" + txtMessage.Text);
            sb.AppendLine("URL:" + txtUrl.Text);
            FISCA.LogAgent.ApplicationLog.Log("[特殊歷程]", "發佈最新消息", sb.ToString());

            MsgBox.Show("發送完成!!");
            this.DialogResult = DialogResult.OK;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtUsers.Text))
                errorProvider1.SetError(labelX1, "不可空白");
            if (string.IsNullOrEmpty(txtMessage.Text))
                errorProvider1.SetError(labelX2, "不可空白");
            if (errorProvider1.HasError)
                return;

            string[] each_user = txtUsers.Text.Split(',');
            DSXmlHelper userHelper = new DSXmlHelper("To");
            foreach (string each in each_user)
                userHelper.AddElement(".", "User", each.Trim());

            DSXmlHelper helper = new DSXmlHelper("Request");
            helper.AddElement(".", "To", userHelper.GetRawXml(), true);
            helper.AddElement(".", "Message", txtMessage.Text);
            helper.AddElement(".", "Url", txtUrl.Text);
            helper.AddElement("Condition");
            helper.AddElement("Condition", "ID", _news_id);

            try
            {
                Service.UpdateNews(new DSRequest(helper));
            }
            catch (Exception ex)
            {
                SmartSchool.ErrorReporting.ReportingService.ReportException(ex);
                MessageBox.Show(ex.Message);
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("對象:" + txtUsers.Text);
            sb.AppendLine("內容:" + txtMessage.Text);
            sb.AppendLine("URL:" + txtUrl.Text);
            FISCA.LogAgent.ApplicationLog.Log("[特殊歷程]", "發佈最新消息", sb.ToString());

            MsgBox.Show("更新完成!!");
            this.DialogResult = DialogResult.OK;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Service.DeleteNews(_news_id);
            }
            catch (Exception ex)
            {
                SmartSchool.ErrorReporting.ReportingService.ReportException(ex);
                MessageBox.Show(ex.Message);
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("對象:" + txtUsers.Text);
            sb.AppendLine("內容:" + txtMessage.Text);
            sb.AppendLine("URL:" + txtUrl.Text);
            FISCA.LogAgent.ApplicationLog.Log("[特殊歷程]", "刪除最新消息", sb.ToString());
            MsgBox.Show("刪除完成!!");
            this.DialogResult = DialogResult.OK;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUsers.Text = "dev.sh_d/*,dev.sh_n/*,dev.jh_kh/*,dev.jh_hs/*,demo.ischool.h/*,demo.ischool.j/*,test.kh.edu.tw/*,test.hc.edu.tw/*";
        }
    }
}