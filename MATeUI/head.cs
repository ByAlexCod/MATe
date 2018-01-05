using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MATeV2;
using Network;
using System.Threading;
namespace MATeUI
{
    public partial class head : UserControl
    {
        ContextAndUserManager _ctxuser = Authentification.CurrentCtxUser;
        public head()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            _ctxuser.SaveAs("-Context.MATe");
            //using(var ct = _ctxuser.ObtainAccessor())
            //{
            //    Context ctx = ct.Context;
            //    Thread.Sleep(5000);
            //}
            MessageBox.Show("SUCCESS");
        }

        private void SyncBtn_Click(object sender, EventArgs e)
        {
            SyncerSender syncsender = new SyncerSender(_ctxuser);
            syncsender.PrepareDatas("-Context.MATe", "sync", "temp.zip", 15000);
            Thread thread = new Thread(syncsender.SpreadDatas);
            thread.IsBackground = true;
            thread.Start();

        }
    }
}
