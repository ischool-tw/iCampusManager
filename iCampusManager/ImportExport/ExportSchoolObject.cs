using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FISCA.UDT;
using SmartSchool.API.PlugIn;

namespace iCampusManager
{
    class ExportSchoolObject : SmartSchool.API.PlugIn.Export.Exporter
    {
        //建構子
        public ExportSchoolObject()
        {
            this.Image = null;
            this.Text = "匯出學校記錄";
        }

        //覆寫
        public override void InitializeExport(SmartSchool.API.PlugIn.Export.ExportWizard wizard)
        {
            List<School> GraduateList = tool._A.Select<School>(Program.MainPanel.SelectedSource);
            wizard.ExportableFields.AddRange("學校系統編號", "學校名稱", "DSNS", "群組", "註解");

            wizard.ExportPackage += (sender, e) =>
            {
                for (int i = 0; i < GraduateList.Count; i++)
                {
                    RowData row = new RowData();
                    row.ID = GraduateList[i].UID;
                    foreach (string field in e.ExportFields)
                    {
                        if (wizard.ExportableFields.Contains(field))
                        {
                            switch (field)
                            {
                                case "學校系統編號": row.Add(field, "" + GraduateList[i].UID); break;
                                case "學校名稱": row.Add(field, "" + GraduateList[i].Title); break;
                                case "DSNS": row.Add(field, "" + GraduateList[i].DSNS); break;
                                case "群組": row.Add(field, "" + GraduateList[i].Group); break;
                                case "註解": row.Add(field, "" + GraduateList[i].Comment); break;
                            }
                        }
                    }

                    e.Items.Add(row);
                }
            };
        }
    }
}
