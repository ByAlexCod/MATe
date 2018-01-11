using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MATeV2
{
    [Serializable]
    public class Conversation
    {
        readonly internal List<MessageP2P> _messageList;
        readonly Person _host;
        readonly Person _theOtherOne;
        readonly int _port;
        bool _toSee = false;
        [NonSerialized] static TcpListener _listener;
        [NonSerialized] TcpClient _client;
        [NonSerialized] NetworkStream _stream;
        [NonSerialized] static bool _isListening = false;


        public Conversation(Person host, Person theOtherOne, int port)
        {
            if (host.IP == null) throw new ArgumentNullException("You cannot start a conversation if host IP is not registered.", nameof(host.IP));

            _host = host;
            _theOtherOne = theOtherOne;
            _port = port;
            _messageList = new List<MessageP2P>();
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

        public static void Start(Person user, int Port)
        {
            Thread receiver = new Thread(() => InitializeListener(user, Port));
            receiver.IsBackground = true;
            receiver.Start();
        }

        public int Port => _port;
        public Person Host => _host;
        public bool ToSee
        {
            get { return _toSee; }
            set { _toSee = value; }
        }
        public Person TheOtherOne => _theOtherOne;

        public List<MessageP2P> MessageList => _messageList;

        void StartSender()
        {
        }
    
        static void StartReceiver(Person user)
        {
            _listener.Start();
            string incoming;
            while (true)
            {
                TcpClient client = _listener.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                using (StreamReader streamer = new StreamReader(stream))
                {
                    incoming = streamer.ReadLine();
                }
                if(incoming.Contains("#" ))
                {
                    user.ConversationDictionary.TryGetValue(user.Context.FindEmployee(incoming.Split('#')[1]), out Conversation other);
                    if(other != null)
                    {
                        MessageP2P ms = new MessageP2P(other, incoming.Split('#')[0], user, user.Context.FindEmployee(incoming.Split('#')[1]));
                        other.MessageList.Add(ms);
                        other.ToSee = true;
                    } else
                    {
                        Conversation a = user.CreateConversation(user.Context.FindEmployee(incoming.Split('#')[1]), 1807);
                        MessageP2P ms = new MessageP2P(a, incoming.Split('#')[0], user, user.Context.FindEmployee(incoming.Split('#')[1]));
                        other.MessageList.Add(ms);
                        other.ToSee = true;
                    }
                }
            }
        }


        public MessageP2P SendMessage(string msg)
        {
            _client = new TcpClient(TheOtherOne.IP.ToString(), Port);
            NetworkStream stream = _client.GetStream();
            MessageP2P ms = new MessageP2P(this, msg, Host, TheOtherOne);
            try
            {
                using (StreamWriter write = new StreamWriter(stream))
                {
                    write.WriteLine(ms.Text);
                }
                MessageList.Add(ms);
            } catch
            {
            }
            finally
            {
                _client.Close();
            }
            return ms;
        }
    }
}
