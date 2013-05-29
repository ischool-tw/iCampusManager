using System;
using System.Collections.Generic;
using System.Text;
using ActiproSoftware.SyntaxEditor.Addons.Xml;
using System.Drawing;

namespace DesktopLib
{
    public class BaseXmlSyntaxLanguage : XmlSyntaxLanguage
    {
        public BaseXmlSyntaxLanguage()
        {
            IsUpdating = true;
            LexicalMacros.Remove(LexicalMacros["TagNameMacro"]);
            LexicalMacros.Add(new ActiproSoftware.SyntaxEditor.Addons.Dynamic.LexicalMacro("TagNameMacro", @"[a-zA-Z_0-9\-:\.\u2F00-\u9FFF]"));
            IsUpdating = false;
        }
    }
}
