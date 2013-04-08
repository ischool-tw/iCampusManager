using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iCampusManager
{
    class RibbonButtons
    {
        public RibbonButtons()
        {
            Program.MainPanel.RibbonBarItems["功能"]["功能"].Click += delegate
            {
                //這是測試 git 註解。
                new SearchForm().ShowDialog();
            };
        }
    }
}
