using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MATeV2;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Network
{
    public class Boss
    {
        Context _ctx;
        string localComuterName = Dns.GetHostName();
        static IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
        IPAddress _locAdd;
        static int _basicPort = 10101;
        TcpListener _listener; 
        //TcpClient _client;
        string _incoming;
        string _incomingIP;
        bool _continue;
        int _ipIndex;

        public Boss(Context ctx, int ipIndex)
        {
            _ctx = ctx;
            _ipIndex = ipIndex;
            _locAdd = localIPs[ipIndex];
            
        }
        public void Start()
        {
            while (true)
            {
                _continue = true;
                _listener = new TcpListener(_locAdd, _basicPort);
                _listener.Start();

                while (_continue != false)
                {
                    TcpClient cl = _listener.AcceptTcpClient();
                    NetworkStream stream = cl.GetStream();

                    using (StreamReader read = new StreamReader(stream))
                    {
                        _incoming = read.ReadLine();
                    }
                    if (_incoming.Contains("#"))
                    {
                        SendContext(VerifyLogin());
                    }
                }
            }
            
        }
        internal bool VerifyLogin()
        {
            _continue = false;
            Thread.Sleep(2000);
            _listener.Stop();
            string[] comingChain = _incoming.Split('#');
            string mail = comingChain[0];
            string password = comingChain[1];
            if (_ctx.PersonList.ContainsKey(mail))
            {
                _incomingIP = comingChain[2];
                if (_ctx.PersonList.TryGetValue(mail, out Employee value) && value.Password == password) return true;
                else return false;
            }
            else return false;
        }

        internal void SendContext(bool valid)
        {
            
            if (valid == true)
            {

                //_client = new TcpClient(_incomingIP, _basicPort + 1);
                Socket cc = new Socket(AddressFamily.InterNetwork,
        SocketType.Stream, ProtocolType.Tcp);/*_client.Client;*/
                cc.Connect(_incomingIP, _basicPort + 1);
                cc.SendFile(_ctx.Name + "-Session.MATe");
                cc.Shutdown(SocketShutdown.Both);
                cc.Close();
                ///
                

                //NetworkStream stream = _client.GetStream();
                //using (StreamWriter write = new StreamWriter(stream))
                //{


                //    write.Write(File.ReadAllBytes(_ctx.Name + "-Session.MATe"));
                //}
            }
        }
    }
}
