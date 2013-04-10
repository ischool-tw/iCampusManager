using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using FISCA.DSA;
using FISCA;

namespace iCampusManager
{
    public partial class UDMItem : DetailContentImproved
    {
        private XElement UDM { get; set; }

        public UDMItem()
        {
            InitializeComponent();
            Group = "UDM";
        }

        protected override void OnPrimaryKeyChangedAsync()
        {
            ConnectionHelper conn = ConnectionHelper.GetConnection(PrimaryKey);

            Envelope rsp = conn.CallService("UDMService.ListModules", new Envelope());

            UDM = XElement.Parse(rsp.BodyContent.XmlString);
        }

        protected override void OnPrimaryKeyChangedComplete(Exception error)
        {
            if (error != null)
            {
                RTOut.WriteError(error);
                throw error;
            }

            dgvUDM.Rows.Clear();

            Dictionary<string, XElement> udm = new Dictionary<string, XElement>();

            foreach (XElement each in UDM.Elements("Module"))
            {
                string name = each.ElementText("Name");
                udm.Add(name, each);
            }

            IOrderedEnumerable<KeyValuePair<string, XElement>> result = udm.OrderBy(x => x.Key);

            foreach (KeyValuePair<string, XElement> each in result)
            {
                DataGridViewRow row = new DataGridViewRow();

                string urlPart = each.Value.ElementText("URL").Replace("https://module.ischool.com.tw/module", "~");
                urlPart = urlPart.Replace("http://module.ischool.com.tw/module", "~");
                urlPart = urlPart.Replace("http://module.ischool.com.tw:8080/module", "~");
                urlPart = urlPart.Replace("https://module.ischool.com.tw:8080/module", "~");

                string version = each.Value.ElementText("Version");

                row.CreateCells(dgvUDM, each.Key, version, urlPart);
                row.Tag = each.Value;

                dgvUDM.Rows.Add(row);
            }
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            try
            {
                InputBox box = new InputBox();
                if (box.ShowDialog() != DialogResult.OK)
                    return;

                string url = box.InputString;
                XElement req = new XElement("Request", new XElement("URL", url));

                ConnectionHelper conn = ConnectionHelper.GetConnection(PrimaryKey);
                conn.CallService("UDMService.RegistryModule", new Envelope(new XStringHolder(req)));

                MessageBox.Show("註冊 UDM 完成。");
                OnPrimaryKeyChanged(EventArgs.Empty);
            }
            catch (Exception ex)
            {
                RTOut.WriteError(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCheckUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUDM.SelectedRows.Count <= 0)
                    return;

                DialogResult dr = MessageBox.Show("如果 UDM 包含 UDT 會一同刪除！您確定？", "Campus", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No)
                    return;

                DataGridViewRow row = dgvUDM.SelectedRows[0];
                string name = row.Cells["chName"].Value + "";
                XElement req = new XElement("Request", new XElement("ModuleName", name));

                ConnectionHelper conn = ConnectionHelper.GetConnection(PrimaryKey);
                conn.CallService("UDMService.RemoveModule", new Envelope(new XStringHolder(req)));

                MessageBox.Show("刪除 UDM 完成。");
                OnPrimaryKeyChanged(EventArgs.Empty);
            }
            catch (Exception ex)
            {
                RTOut.WriteError(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUDM_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvUDM.Rows[e.RowIndex];

            string xml = (row.Tag as XElement).ToString();

            SimpleDefContent udscontent = new SimpleDefContent();
            udscontent.Text = row.Cells["chName"].Value + "";
            udscontent.SetXmlContent(xml);
            udscontent.ShowDialog();
        }
    }
}
