using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iCampusManager
{
    internal class DetailItems
    {
        public DetailItems()
        {
            Program.MainPanel.RegisterDetailContent<BasicInfoItem>();
            Program.MainPanel.RegisterDetailContent<NetworkItem>();
        }
    }
}
