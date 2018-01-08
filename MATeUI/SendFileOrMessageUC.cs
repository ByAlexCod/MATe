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
using System.Threading;

namespace MATeUI
{
    public partial class SendFileOrMessageUC : UserControl
    {
        ContextAndUserManager _ctxuser = Authentification.CurrentCtxUser;
        public SendFileOrMessageUC()
        {
            InitializeComponent();
            AutomaticMessage();
        }
        internal void AutomaticMessage()
        {
            //using (var ct = _ctxuser.ObtainAccessor())
            //{
            //    Context ctx = ct.Context;
            //    foreach (var ms in _ctxuser.CurrentUser.ConversationDictionary)
            //    {
            //        if (ms.Value.ToSee == true)
            //        {

            //            _lvMessages.Rows.Add(ms.Value.TheOtherOne.Firstname + " " + ms.Value.TheOtherOne.Lastname + " - Nouveau message !", ms);
            //        }
            //        else
            //        {
            //            Item ii = new Item();
            //            //ii.strText;
            //            //_lvMessages.Rows.Add(;

            //        }
            //    }
            //}
            //while (true)
            //{
            //    using (var ct = _ctxuser.ObtainAccessor())
            //    {
            //        Context ctx = ct.Context;
            //        //foreach (var convin in _lvMessages.Rows)
            //        //{
            //        //    _ctxuser.CurrentUser.ConversationDictionary.TryGetValue(convin, out Conversation value);

            //        //}
            //        Thread.Sleep(5500);
            //    }
            //}
        }

        //Delegate declaration
        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public delegate void RadioEventHandler(object sender, EventArgs e);

        //Event declaration
        public event RadioEventHandler CheckedOption;
        public event ButtonClickedEventHandler SendButtonClicked;
        public event EventHandler FolderBrowser;


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _sendFileRbtn.CheckedChanged += new EventHandler(ShowPanel);
            _sendBtn.Click += new EventHandler(ButtonSendClicked);
            _chooseFolderLbl.Click += new EventHandler(OpenDialogueBrowser);
        }

        private void OpenDialogueBrowser(object sender, EventArgs e) => FolderBrowser?.Invoke(this, e);

        private void ShowPanel(object sender, EventArgs e) => CheckedOption?.Invoke(this, e);
        
        private void ButtonSendClicked(object sender, EventArgs e) => SendButtonClicked?.Invoke(this, e);
    }
}
