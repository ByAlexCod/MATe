using System;
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
    public partial class BossWindow : Form
    {
        ContextAndUserManager _currentCtx = Authentification.CurrentCtxUser;
        public BossWindow()
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
            ModifyAccount changeCount = new ModifyAccount(Authentification.CurrentCtxUser.CurrentUser);
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
            string filename = Application.StartupPath + @"\Read Me.txt";
            
            System.Diagnostics.Process.Start(filename);
        }

        private void bodyUC1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProfilForm pf = new ProfilForm();
            pf.ShowDialog();
            //MessageBox.Show("My IP Adress : " + _currentCtx.CurrentUser.IP);
        }

        //public delegate void ContextMenuStrip(object sender, EventArgs e);
    }
}
