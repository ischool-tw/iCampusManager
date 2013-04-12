using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Collections;
using System.Xml.Linq;
using FISCA.DSA;
using FISCA;
using System.Xml.XPath;
using System.Threading.Tasks;
using FISCA.Net;

namespace iCampusManager
{
    public partial class WebGadgetItem : DetailContentImproved
    {
        public static string Web2Url = "https://web2.ischool.com.tw/deployment";

        private XElement PackagesData { get; set; }

        private XElement SelectedPackage { get; set; }

        public WebGadgetItem()
        {
            InitializeComponent();
            dgvGadgets.AutoGenerateColumns = false;
            Group = "Web2 Gadget";
            PackagesData = new XElement("Response");
            SelectedPackage = null;
        }

        protected override void OnPrimaryKeyChangedAsync()
        {
            ConnectionHelper conn = ConnectionHelper.GetConnection(PrimaryKey);
            Envelope rsp = conn.CallService("SelectWebPackage", new Envelope());
            XElement rspxml = XElement.Parse(rsp.BodyContent.XmlString);
            PackagesData = rspxml;
        }

        protected override void OnPrimaryKeyChangedComplete(Exception error)
        {
            if (error != null)
            {
                RTOut.WriteError(error);
                throw error;
            }

            XElement target = PackagesData.XPathSelectElement("Package[TargetType='Guest']");
            tabGuest.Tag = target;

            target = PackagesData.XPathSelectElement("Package[TargetType='Teacher']");
            tabTeacher.Tag = target;

            target = PackagesData.XPathSelectElement("Package[TargetType='Student']");
            tabStudent.Tag = target;

            target = PackagesData.XPathSelectElement("Package[TargetType='Parent']");
            tabParent.Tag = target;

            target = PackagesData.XPathSelectElement("Package[TargetType='Administrator']");
            tabAdmin.Tag = target;

            PuplateTabData(tabs.SelectedTab);
        }

        private void PuplateTabData(SuperTabItem superTabItem)
        {
            dgvGadgets.DataSource = null;
            SelectedPackage = superTabItem.Tag as XElement;

            if (SelectedPackage != null)
            {
                List<GadgetGridRow> rows = new List<GadgetGridRow>();
                foreach (XElement gadget in SelectedPackage.XPathSelectElements("Definition/Package/Gadgets/Gadget"))
                    rows.Add(new GadgetGridRow(gadget.AttributeText("deployPath")));

                dgvGadgets.DataSource = new BindingList<GadgetGridRow>(rows);
            }
        }

        private void tabs_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {
            PuplateTabData(e.NewValue as SuperTabItem);
        }

        internal class GadgetGridRow : INotifyPropertyChanged
        {
            public GadgetGridRow(string deployPath)
            {
                Title = "讀取中...";
                DeployPath = deployPath;
                Description = DeployPath;

                Task task = Task.Factory.StartNew(() =>
                {
                    string url = string.Format(Web2Url + "/{0}/description.xml", DeployPath);
                    try
                    {
                        GadgetDescription = XElement.Load(url);

                        Title = GadgetDescription.Element("ModulePrefs").AttributeText("title");
                        Description = GadgetDescription.Element("ModulePrefs").AttributeText("description");
                    }
                    catch (Exception ex)
                    {
                        Title = "讀取錯誤...";
                        Description = ex.Message;
                    }
                }, System.Threading.CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default);

                //task.ContinueWith((x) =>
                //{
                //    if (GadgetDescription == null)
                //        return;

                //    Title = GadgetDescription.Element("ModulePrefs").AttributeText("title");
                //    Description = GadgetDescription.Element("ModulePrefs").AttributeText("description");

                //}, TaskScheduler.FromCurrentSynchronizationContext());
            }

            private string _title = string.Empty;
            public string Title
            {
                get { return _title; }
                set
                {
                    _title = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Title"));
                }
            }

            private string _description = string.Empty;
            public string Description
            {
                get { return _description; }
                set
                {
                    _description = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Description"));
                }
            }

            public string DeployPath { get; private set; }

            public XElement GadgetDescription { get; set; }

            #region INotifyPropertyChanged 成員

            public event PropertyChangedEventHandler PropertyChanged;

            #endregion
        }
    }
}