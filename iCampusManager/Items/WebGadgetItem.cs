using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iCampusManager
{
    public partial class WebGadgetItem : DetailContentImproved
    {
        public WebGadgetItem()
        {
            InitializeComponent();
            Group = "Web2 Gadget";
        }

        protected override void OnPrimaryKeyChangedAsync()
        {
        }

        protected override void OnPrimaryKeyChangedComplete(Exception error)
        {
        }
    }
}