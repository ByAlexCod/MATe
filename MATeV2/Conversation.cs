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
        readonly Dictionary<int, Message> _messageDictionary = new Dictionary<int, Message>();
        readonly Person _host;
        readonly Person _theOtherOne;
        readonly int _port;
        bool _toSee = false;
        static TcpListener _listener;
        TcpClient _client;
        NetworkStream _stream;
        [NonSerialized] static bool _isListening = false;


        public Conversation(Person host, Person theOtherOne, int port)
        {
            if (host.IP == null) throw new ArgumentNullException("You cannot start a conversation if host IP is not registered.", nameof(host.IP));

            _host = host;
            _theOtherOne = theOtherOne;
            _port = port;

        }

        public static void InitializeListener(Person user, int port)
        {
            if (_isListening == false)
            {
                _listener = new TcpListener(user.IP, port);
                _listener.Start();
                foreach(var use in user.ConversationDictionary)
                {
                    StartReceiver(user);
                }
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
        internal Dictionary<int, Message> MessageDictionary => _messageDictionary;





        
        void StartSender()
        {
            
            

           
        }
    
        static void StartReceiver(Person user)
        {

            string incoming;
            while (true)
            {
                TcpClient client = _listener.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                using(StreamReader streamer = new StreamReader(stream))
                {
                    incoming = streamer.ReadLine();
                }
                if(incoming.Contains("#" ))
                {
                    user.ConversationDictionary.TryGetValue(user.Context.FindEmployee(incoming.Split('#')[1]), out Conversation other);
                    if(other != null)
                    {
                        Message ms = new Message(other, incoming.Split('#')[0], user, user.Context.FindEmployee(incoming.Split('#')[1]));
                        Random x = new Random();
                        int xx = x.Next(9999999);
                        other.MessageDictionary.Add(xx, ms);
                        other.ToSee = true;
                    } else
                    {
                        Conversation a = user.CreateConversation(user.Context.FindEmployee(incoming.Split('#')[1]), 1807);
                        Message ms = new Message(a, incoming.Split('#')[0], user, user.Context.FindEmployee(incoming.Split('#')[1]));

                        Random xi = new Random();
                        int xxi = xi.Next(9999999);
                        other.MessageDictionary.Add(xxi, ms);
                        other.ToSee = true;
                    }
                    
                }
            }
        }


        public void SendMessage(string msg)
        {
            _client = new TcpClient(TheOtherOne.IP.ToString(), Port);
            _stream = _client.GetStream();
            Message ms = new Message(this, msg, Host, TheOtherOne);
            
            try
            {
                using (StreamWriter write = new StreamWriter(_stream))
                {
                    write.WriteLine(ms.Text);
                }
                Random x = new Random();
                int xx = x.Next(9999999);
                MessageDictionary.Add(xx, ms);


            } catch
            {

            }
            finally
            {
                _client.Close();
            }

        }
        
        
    }
}
