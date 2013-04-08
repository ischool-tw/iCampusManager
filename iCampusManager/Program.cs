using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Campus;
using Campus.Configuration;
using FISCA;
using FISCA.Authentication;
using FISCA.Data;
using FISCA.Permission.UI;
using FISCA.Presentation;
using FISCA.UDT;

namespace iCampusManager
{
    public static class Program
    {
        public static UserConfigManager User { get; private set; }

        public static ConfigurationManager App { get; private set; }

        public static ConfigurationManager Global { get; private set; }

        public static NLDPanel MainPanel { get; private set; }

        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [MainMethod]
        public static void Main()
        {
            DSAServices.AutoDisplayLoadingMessageOnMotherForm();

            InitAsposeLicense();
            InitStartMenu();
            InitConfigurationStorage();
            InitMainPanel();

            new ImportSchool();//匯入學校資料
            new FieldManager();
            new SearchSchool();
            new DetailItems();
            new RibbonButtons();

            RefreshFilteredSource();

            FISCA.Presentation.MotherForm.Form.Text = GetTitleText();
        }

        private static void InitMainPanel()
        {
            MainPanel = new NLDPanel();
            MainPanel.Group = "學校";

            MotherForm.AddPanel(MainPanel);
            MainPanel.AddView(new DefaultView());
        }

        internal static void RefreshFilteredSource()
        {
            RefreshFilteredSource(null);
        }

        internal static void RefreshFilteredSource(Action callback)
        {
            List<string> schoolids = new List<string>();
            Task task = Task.Factory.StartNew(() =>
            {
                QueryHelper query = new QueryHelper();

                DataTable dt = query.Select("select uid from $school");

                foreach (DataRow row in dt.Rows)
                    schoolids.Add(row["uid"] + "");

            }, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default);

            task.ContinueWith((x) =>
            {
                MainPanel.SetFilteredSource(schoolids);

                if (callback != null)
                    callback();
            }, TaskScheduler.Default);
        }

        private static void InitConfigurationStorage()
        {
            User = new UserConfigManager(new ConfigProvider_User(), DSAServices.UserAccount);
            App = new ConfigurationManager(new ConfigProvider_App());
            Global = new ConfigurationManager(new ConfigProvider_Global());
        }

        private static void InitStartMenu()
        {
            MotherForm.StartMenu["安全性"]["使用者管理"].Click += delegate
            {
                new FISCA.Permission.UI.UserManager().ShowDialog();
            };

            FISCA.Presentation.MotherForm.StartMenu["重新登入"].BeginGroup = true;
            FISCA.Presentation.MotherForm.StartMenu["重新登入"].Click += delegate
            {
                Application.Restart();
            };
        }

        private static void InitAsposeLicense()
        {
            //設定 ASPOSE 元件的 License。
            System.IO.Stream stream = new System.IO.MemoryStream(Properties.Resources.Aspose_Total);
            new Aspose.Cells.License().SetLicense(stream);
        }

        /// <summary>
        /// 設定ischool標頭
        /// </summary>
        private static string GetTitleText()
        {
            string user = DSAServices.UserAccount;

            string version = "0.0.0.0";
            try
            {
                string path = Path.Combine(Application.StartupPath, "release.xml");
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                version = doc.DocumentElement.GetAttribute("Version");
            }
            catch (Exception) { }

            return string.Format("ischool 監控中心〈FISCA：{0}〉〈{1}〉", version, user);
        }
    }
}
