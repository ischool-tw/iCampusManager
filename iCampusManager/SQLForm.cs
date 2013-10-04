using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iCampusManager
{
    public partial class SQLForm : Form
    {
        public SQLForm()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SQLText = txtSQL.Text;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        public string SQLText { get; set; }
    }
}
