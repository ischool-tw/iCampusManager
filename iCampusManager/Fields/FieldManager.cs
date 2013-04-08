using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iCampusManager
{
    internal class FieldManager
    {
        internal static TitleField TitleField { get; private set; }

        internal static DSNSField DSNSField { get; private set; }

        internal static GroupField GroupField { get; private set; }

        public FieldManager()
        {

            TitleField = new iCampusManager.TitleField();
            GroupField = new iCampusManager.GroupField();
            DSNSField = new iCampusManager.DSNSField();

            TitleField.Register(Program.MainPanel);
            DSNSField.Register(Program.MainPanel);
            GroupField.Register(Program.MainPanel);
        }
    }
}
