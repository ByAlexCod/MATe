using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MATeV2;
using System.Threading;
using System.IO.Compression;

namespace Network
{
    public class SyncerReceiver
    {
        IPAddress _ip;
        int _port;
        TcpListener _listener;
        string _tempReceiverPath;
        string _contextStoragePath;
        string _tempUnZipped;
        ContextAndUserManager _baseCtxUser;


        public SyncerReceiver(IPAddress ip, int port, string contextesStoragePath, string tempReceiverPath, string tempUnZipped, ContextAndUserManager baseCtxUser)
        {
            if (!Directory.Exists(contextesStoragePath)) Directory.CreateDirectory(contextesStoragePath);
            if (!Directory.Exists(tempUnZipped)) Directory.CreateDirectory(tempUnZipped);
            _contextStoragePath = contextesStoragePath;
            _tempReceiverPath = tempReceiverPath;
            _tempUnZipped = tempUnZipped;
            _ip = ip;
            _port = port;
            _listener = new TcpListener(ip, port);
        }
        public void Start()
        {
            _listener.Start();
            while (true)
            {

                
                using (var client = _listener.AcceptTcpClient())
                using (var stream = client.GetStream())
                using (FileStream output = File.Open(_tempReceiverPath, FileMode.OpenOrCreate))
                {
                    Console.WriteLine("Client connected. Starting to receive the file");

                    // read the file in chunks of 1KB
                    var buffer = new byte[1024];
                    int bytesRead;
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        output.Write(buffer, 0, bytesRead);
                    }
                    Thread a = new Thread(new ThreadStart(End));
                    a.IsBackground = true;
                    a.Start();
                    
                }
                
            }
        }
        void End()
        {
            Context b = (Context)Serialization.Deserialize();
            DirectoryInfo di = new DirectoryInfo(_tempUnZipped);
            foreach(var file in di.GetFiles())
            {
                file.Delete();
            }
            Directory.Delete(_tempUnZipped);
            Directory.CreateDirectory(_tempUnZipped);
            ZipFile.ExtractToDirectory(_tempReceiverPath, _tempUnZipped);
            DirectoryInfo d = new DirectoryInfo(_tempUnZipped);
            foreach (var a in d.GetFiles("*.MATe"))
            {
                ContextAndUserManager ctxuser = new ContextAndUserManager(b.CompanyName, true);
                ctxuser.Load(a.FullName);
                if (File.Exists(_contextStoragePath + @"\" + Path.GetFileName(a.FullName)))
                {
                    ContextAndUserManager before = new ContextAndUserManager(b.CompanyName, true);
                    before.Load(_contextStoragePath + @"\" + Path.GetFileName(a.FullName));

                    using (var beforeuh = before.ObtainAccessor())
                    using (var after = ctxuser.ObtainAccessor())
                    {
                        Context beforeuuh = beforeuh.Context;
                        Context aftereuh = after.Context;

                        if(aftereuh.ModifyDate > beforeuuh.ModifyDate)
                        {
                            File.Delete(_contextStoragePath + @"\" + Path.GetFileName(a.FullName));
                            a.CopyTo(_contextStoragePath + @"\" + Path.GetFileName(a.FullName));
                            b.Merge(aftereuh);
                        }
                    }
                } else
                {
                    a.CopyTo(_contextStoragePath + @"\" + Path.GetFileName(a.FullName));
                }
            }
            



        }

    }
}
