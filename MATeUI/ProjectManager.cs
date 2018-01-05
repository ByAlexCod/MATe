﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MATeV2;
using Network;
using System.Threading;

namespace MATeUI
{
    public partial class ProjectManager : Form
    {
        ContextAndUserManager _currentCtx = Authentification.CurrentCtxUser;
        public ProjectManager()
        {
            InitializeComponent();
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentCtx.SaveAs("-Context.MATe");
            //using(var ct = _ctxuser.ObtainAccessor())
            //{
            //    Context ctx = ct.Context;
            //    Thread.Sleep(5000);
            //}
            MessageBox.Show("SUCCESS");
           
        }

        private void synchronizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SyncerSender syncsender = new SyncerSender(_currentCtx);
            syncsender.PrepareDatas("-Context.MATe", "sync", "temp.zip", 15000);
            Thread thread = new Thread(syncsender.SpreadDatas);
            thread.IsBackground = true;
            thread.Start();
            MessageBox.Show("Synchronize");
        }

        
        private void myAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeCount changeCount = new ChangeCount(Authentification.CurrentCtxUser.CurrentUser);
            changeCount.ShowDialog();
        }

        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Authentification auth = new Authentification();
            auth.Show();
        }

        private void readMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("????????????");
        }

        //public delegate void ContextMenuStrip(object sender, EventArgs e);
    }
}
