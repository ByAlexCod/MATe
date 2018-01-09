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

namespace MATeUI
{
    public partial class ChatWDF : Form
    {
        Conversation _conversation;
        public ChatWDF(Conversation c)
        {
            InitializeComponent();
            _conversation = c;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            foreach(MessageP2P mes in _conversation.MessageList)
            {
                string message = "";
                if (mes.Sender == Authentification.CurrentCtxUser.CurrentUser)
                {
                    message = "You: write on " + mes.DateTime.ToString() + " :" + mes.Text;
                }
                else { message = mes.Sender.Mail + " write on " + mes.DateTime.ToString() + " :" + mes.Text; }
                ListChat.Items.Add(message);
            }
        }
    }
}
