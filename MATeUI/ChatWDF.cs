using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MATeV2;

namespace MATeUI
{
    public partial class ChatWDF : Form
    {
        Conversation _conversation;
        Person _user;
        static DetailProjectEmployeeUC detailemploy;
        [NonSerialized] static TcpListener _listener;
        [NonSerialized] TcpClient _client;
        //[NonSerialized] NetworkStream _stream;
        [NonSerialized] static bool _isListening = false;
        public static ChatWDF _thischat;

        public ChatWDF(Conversation c,Person user)
        {
            InitializeComponent();
            _conversation = c;
            _user = user;
            _thischat = this;
            detailemploy=DetailProjectEmployeeUC.detail;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            foreach (MessageP2P mes in _conversation.MessageList)
            {
                string message = "";
                if (mes.Sender == Authentification.CurrentCtxUser.CurrentUser)
                {
                    message = "You write on " + mes.DateTime.ToString() + " :" + mes.Text;
                }
                else { message = mes.Sender.Mail + " write on " + mes.DateTime.ToString() + " : " + mes.Text; }
                ListChat.Items.Add(message);
            }
        }

        public static void InitializeListener(Person user, int port)
        {
            if (_isListening == false)
            {
                _listener = new TcpListener(user.IP, port);
                Thread a = new Thread(() => StartReceiver(user));
                a.IsBackground = true;
                a.Start();
            }
        }
        static void StartReceiver(Person user)
        {
            _listener.Start();
            string incoming;
            string message;
            string sender;
            while (true)
            {
                TcpClient client = _listener.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                using (StreamReader streamer = new StreamReader(stream))
                {
                    incoming = streamer.ReadLine();
                }
                if (incoming.Contains("#"))
                {
                    user.ConversationDictionary.TryGetValue(user.Context.FindEmployee(incoming.Split('#')[1]), out Conversation other);
                    string[] info = incoming.Split('#');
                    message = info[0];
                    sender = info[1];
                    if (other != null)
                    {
                        MessageP2P ms = new MessageP2P(other, message, user.Context.FindEmployee(sender), user);
                        other.MessageList.Add(ms);
                        other.ToSee = true;
                    }
                    else
                    {
                        Conversation a = user.CreateConversation(user.Context.FindEmployee(sender), 1807);
                        MessageP2P ms = new MessageP2P(a, message, user.Context.FindEmployee(sender), user);
                        a.MessageList.Add(ms);
                        a.ToSee = true;
                        other = a;
                    }
                    DetailProjectEmployeeUC.detail._con = other;
                    Thread tt = new Thread(() => DetailProjectEmployeeUC.detail.Invoke(DetailProjectEmployeeUC.detail.myDelegate));
                    tt.IsBackground = true;
                    tt.Start();
                }
            }
        }
        void Showmessage()
        {
            ListChat.Clear();
            foreach (MessageP2P mes in _conversation.MessageList)
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
        public MessageP2P SendMessage(string msg)
        {
            _client = new TcpClient(_conversation.TheOtherOne.IP.ToString(),_conversation.Port);
            NetworkStream stream = _client.GetStream();
            MessageP2P ms = new MessageP2P(_conversation, msg.Split('#')[0], _conversation.Host, _conversation.TheOtherOne);
            try
            {
                using (StreamWriter write = new StreamWriter(stream))
                {
                    write.WriteLine(msg);
                }
                _conversation.MessageList.Add(ms);
            }
            catch
            {
            }
            finally
            {
                _client.Close();
            }
            return ms;
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            string message = Messagetxb.Text;
            string tosend = message + "#" + _user.Mail;
            SendMessage(tosend);
            ListChat.Items.Add("You: write on " + DateTime.Now.ToString() + " :" + message);
            Messagetxb.Clear();
        }
    }
}
