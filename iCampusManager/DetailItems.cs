using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesktopLib;

namespace iCampusManager
{
    internal class DetailItems
    {
        public DetailItems()
        {
            Program.MainPanel.RegisterDetailContent<BasicInfoItem>();
        }
    }
}
