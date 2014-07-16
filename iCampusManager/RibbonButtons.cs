using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FISCA.Presentation;
using FISCA.UDT;

namespace iCampusManager
{
    class RibbonButtons
    {
        public RibbonButtons()
        {
            Program.MainPanel.RibbonBarItems["管理"]["新增"].Image = Properties.Resources.atom_add_128;
            Program.MainPanel.RibbonBarItems["管理"]["新增"].Size = RibbonBarButton.MenuButtonSize.Large;
            Program.MainPanel.RibbonBarItems["管理"]["新增"].Click += delegate
            {
                DialogResult dr = new AddNewForm().ShowDialog();
                if (dr == DialogResult.OK)
                    Program.RefreshFilteredSource();
            };

            Program.MainPanel.RibbonBarItems["管理"]["刪除"].Image = Properties.Resources.atom_close_128;
            Program.MainPanel.RibbonBarItems["管理"]["刪除"].Size = RibbonBarButton.MenuButtonSize.Large;
            Program.MainPanel.RibbonBarItems["管理"]["刪除"].Click += delegate
            {
                DialogResult dr = MessageBox.Show("刪除選擇的學校？", "Campus", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    AccessHelper ah = new AccessHelper();
                    List<School> schools = ah.Select<School>(Program.MainPanel.SelectedSource);

                    schools.ForEach((x) => x.Deleted = true);
                    schools.SaveAll();
                    Program.RefreshFilteredSource();
                }
            };
        }
    }
}
