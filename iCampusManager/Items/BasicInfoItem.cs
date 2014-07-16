﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FISCA.UDT;
using FISCA.DSA;
using System.Threading.Tasks;
using System.Threading;
using DesktopLib;

namespace iCampusManager
{
    public partial class BasicInfoItem : DetailContentImproved
    {
        private School SchoolData { get; set; }

        private string PhysicalUrl { get; set; }

        public BasicInfoItem()
        {
            InitializeComponent();
            Group = "基本資料";
        }

        protected override void OnInitializeComplete(Exception error)
        {
            WatchChange(new TextBoxSource(txtTitle));
            WatchChange(new TextBoxSource(txtGroup));
            WatchChange(new TextBoxSource(txtComment));
        }

        protected override void OnSaveData()
        {
            if (SchoolData != null)
            {
                SchoolData.Title = txtTitle.Text;
                SchoolData.Group = txtGroup.Text;
                SchoolData.Comment = txtComment.Text;
                SchoolData.Save();
                Program.RefreshFilteredSource();
                ConnectionHelper.ResetConnection(PrimaryKey);
            }
            ResetDirtyStatus();
        }

        protected override void OnPrimaryKeyChangedAsync()
        {
            AccessHelper access = new AccessHelper();
            List<School> schools = access.Select<School>(string.Format("uid='{0}'", PrimaryKey));

            if (schools.Count > 0)
                SchoolData = schools[0];
            else
                SchoolData = null;
        }

        private void ResolveUrl()
        {
            PhysicalUrl = string.Empty;
            if (SchoolData != null)
            {
                AccessPoint ap;
                if (AccessPoint.TryParse(SchoolData.DSNS, out ap))
                    PhysicalUrl = ap.Url;
            }
        }

        protected override void OnPrimaryKeyChangedComplete(Exception error)
        {
            if (SchoolData != null)
            {
                BeginChangeControlData();
                txtTitle.Text = SchoolData.Title;
                txtGroup.Text = SchoolData.Group;
                txtComment.Text = SchoolData.Comment;

                ResetDirtyStatus();
            }
            else
                throw new Exception("無查資料：" + PrimaryKey);
        }

        private void BasicInfoItem_Load(object sender, EventArgs e)
        {
            InitDetailContent();
        }
    }
}
