using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MATeV2;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;

namespace Network
{
    public class Requester
    {
        string _message;
        //Context _ctx;
        string localComuterName = Dns.GetHostName();
        static IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
        IPAddress _locAdd;
        static int _basicPort = 10101;
        TcpListener _listener; 
        TcpClient _client;
        string _ipBoss;

        public Requester(string ipBoss, string mail, string password, int indexIp)
        {
            _ipBoss = ipBoss;
            
            _locAdd = localIPs[indexIp];
            _message = mail + "#" + password + "#" + _locAdd;
            _client = new TcpClient(ipBoss, _basicPort);
            _listener = new TcpListener(_locAdd, _basicPort + 1);


        }
        public void Send()
        {
            NetworkStream stream = _client.GetStream();
            
            using(StreamWriter write = new StreamWriter(stream))
            {
                write.WriteLine(_message);
                Console.WriteLine("Sent : {0}", _message);

            }
            stream.Close();
            _client.Close();
            Listen();

        }

        internal void Listen()
        {
            _listener.Start();
            while (true)
            {
                //TcpClient cl = _listener.AcceptTcpClient();
                //NetworkStream stream = cl.GetStream();
                //byte[] b;

                //using (BinaryReader read = new BinaryReader(stream))
                //{
                //    b = read.ReadBytes();
                //}

                //if(b!= null)
                //{
                //    Thread.Sleep(2000);
                //    Create(b);
                //}


                using (var client = _listener.AcceptTcpClient())
                using (var stream = client.GetStream())
                using (var output = File.Create("-Session.MATe"))
                {
                    Console.WriteLine("Client connected. Starting to receive the file");

                    // read the file in chunks of 1KB
                    var buffer = new byte[1024];
                    int bytesRead;
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        output.Write(buffer, 0, bytesRead);
                    }
                }
                Context ctx = (Context)Serialization.Deserialize();
            }
        }
    }
}
