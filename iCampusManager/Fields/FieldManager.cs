using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iCampusManager
{
    internal class FieldManager
    {
        internal static TitleField TitleField { get; private set; }

        internal static GroupField GroupField { get; private set; }

        public FieldManager()
        {

            TitleField = new iCampusManager.TitleField();
            GroupField = new iCampusManager.GroupField();

            TitleField.Register(Program.MainPanel);
            GroupField.Register(Program.MainPanel);
        }
    }
}
