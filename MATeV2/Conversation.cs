using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MATeV2
{
    public class Conversation
    {
        readonly Dictionary<int, Message> _messageDictionary = new Dictionary<int, Message>();
        readonly Person _host;
        readonly Person _theOtherOne;
        readonly int _port;

        public Conversation(Person host, Person theOtherOne, int port)
        {
            if (host.IP == null) throw new ArgumentNullException("You cannot start a conversation if host IP is not registered.", nameof(host.IP));

            _host = host;
            _theOtherOne = theOtherOne;
            _port = port;

        }

        public void Start()
        {
            Thread sender = new Thread(Sender);
            sender.IsBackground = true;
            sender.Start();


            Thread receiver = new Thread(Receiver);
            receiver.IsBackground = true;
            receiver.Start();
        }


        public int Port => _port;
        public Person Host => _host;
        public Person TheOtherOne => _theOtherOne;
        internal Dictionary<int, Message> MessageDictionary => _messageDictionary;






        void Sender()
        {
            TcpListener listener = new TcpListener(Host.IP, Port);
            listener.Start();
        }
        void Receiver()
        {

        }
    }
}
