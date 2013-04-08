using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iCampusManager
{
    internal class SearchSchool
    {
        public SearchSchool()
        {
            Program.MainPanel.RibbonBarItems["管理"]["搜尋"].Size = FISCA.Presentation.RibbonBarButton.MenuButtonSize.Large;
            Program.MainPanel.RibbonBarItems["管理"]["搜尋"].Click += delegate
            {
                new SearchForm().ShowDialog();
            };
        }
    }
}
