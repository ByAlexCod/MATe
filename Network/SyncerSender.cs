using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MATeV2;
using System.IO;
using System.IO.Compression;
using System.Net.Sockets;

namespace Network
{
    class SyncerSender
    {
        ContextAndUserManager _ctxuser;

        string _ownerContextPath;
        string _otherContextesxPath;
        string _zipTempFilePath;
        int _port;

        public SyncerSender(ContextAndUserManager ctxuser)
        {
            _ctxuser = ctxuser;
        }
        
        public void PrepareDatas(string ownerContextPath, string otherContextesPath, string ZipTempFilePath, int port)
        {
            _ownerContextPath = ownerContextPath;
            _otherContextesxPath = otherContextesPath;
            _zipTempFilePath = ZipTempFilePath;
            _port = port;
            using(var ct = _ctxuser.ObtainAccessor())
            {
                Context ctx = ct.Context;
                File.Copy(ownerContextPath, otherContextesPath + @"\" + ctx.Owner.Mail + ".MATe");
                if (File.Exists(ZipTempFilePath)) File.Delete(ZipTempFilePath);
                ZipFile.CreateFromDirectory(otherContextesPath, ZipTempFilePath);
            }
        }

        public void SpreadDatas()
        {
            using(var ct = _ctxuser.ObtainAccessor())
            {
                Context ctx = ct.Context;

                foreach (var person in ctx.PersonsDictionary)
                {

                    if (person.Value != ctx.Owner)
                    {
                        //_client = new TcpClient(_incomingIP, _basicPort + 1);
                        Socket cc = new Socket(AddressFamily.InterNetwork,
                        SocketType.Stream, ProtocolType.Tcp);/*_client.Client;*/
                        cc.Connect(person.Value.IP, _port);



                        cc.SendFile(_zipTempFilePath);
                        cc.Shutdown(SocketShutdown.Both);
                        cc.Close();
                    }
                }
            }
        }
        public void SpreadDatas(List<string> ipsList)
        {
            using (var ct = _ctxuser.ObtainAccessor())
            {
                Context ctx = ct.Context;

                foreach (var ip in ipsList)
                {

                    if (ip != ctx.Owner.IP.ToString())
                    {
                        //_client = new TcpClient(_incomingIP, _basicPort + 1);
                        Socket cc = new Socket(AddressFamily.InterNetwork,
                        SocketType.Stream, ProtocolType.Tcp);/*_client.Client;*/
                        cc.Connect(ip, _port);



                        cc.SendFile(_zipTempFilePath);
                        cc.Shutdown(SocketShutdown.Both);
                        cc.Close();
                    }
                }
            }
        }
    }
}
