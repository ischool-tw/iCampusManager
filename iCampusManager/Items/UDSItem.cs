using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Campus;
using FISCA.DSA;
using FISCA;

namespace iCampusManager
{
    public partial class UDSItem : DetailContentImproved
    {
        private XElement UDS { get; set; }

        public UDSItem()
        {
            InitializeComponent();
            Group = "UDS";
        }

        protected override void OnPrimaryKeyChangedAsync()
        {
            ConnectionHelper conn = ConnectionHelper.GetConnection(PrimaryKey);

            Envelope rsp = conn.CallService("UDSManagerService.ListContracts", new Envelope());

            UDS = XElement.Parse(rsp.BodyContent.XmlString);
        }

        protected override void OnPrimaryKeyChangedComplete(Exception error)
        {
            dgvUDS.Rows.Clear();

            List<string> udsNames = new List<string>();

            foreach (XElement each in UDS.Elements("Contract"))
            {
                udsNames.Add(each.AttributeText("Name"));
            }

            udsNames.Sort();

            foreach (string each in udsNames)
            {
                DataGridViewRow row = new DataGridViewRow();

                row.CreateCells(dgvUDS, each);

                dgvUDS.Rows.Add(row);
            }
        }
    }
}
