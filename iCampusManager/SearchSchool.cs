using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FISCA.Presentation;

namespace iCampusManager
{
    internal class SearchSchool
    {
        public SearchSchool()
        {
            Program.MainPanel.RibbonBarItems["管理"]["深度搜尋"].Image = Properties.Resources.lamp_search_128;
            Program.MainPanel.RibbonBarItems["管理"]["深度搜尋"].Size = RibbonBarButton.MenuButtonSize.Large;
            Program.MainPanel.RibbonBarItems["管理"]["深度搜尋"].Click += delegate
            {
                new SearchForm().ShowDialog();
            };
        }
    }
}
