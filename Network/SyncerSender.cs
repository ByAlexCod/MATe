﻿using System;
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
    public class SyncerSender
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
                if (!Directory.Exists(otherContextesPath)) Directory.CreateDirectory(otherContextesPath);
                File.Delete(otherContextesPath + @"\" + ctx.Owner.Mail + ".MATe");
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
                if (ctx.Owner != ctx.Boss)
                {
                    try
                    {
                        Socket cic = new Socket(AddressFamily.InterNetwork,
                        SocketType.Stream, ProtocolType.Tcp);/*_client.Client;*/
                        cic.Connect(ctx.Boss.IP, _port);



                        cic.SendFile(_zipTempFilePath);
                        cic.Shutdown(SocketShutdown.Both);
                        cic.Close();
                    } catch { }
                }
                foreach (var person in ctx.PersonsDictionary)
                {

                    if (person.Value != ctx.Owner && person.Value.IP != null && person.Value.IP != ctx.Owner.IP)
                    {
                        try
                        {
                            //_client = new TcpClient(_incomingIP, _basicPort + 1);
                            Socket cc = new Socket(AddressFamily.InterNetwork,
                            SocketType.Stream, ProtocolType.Tcp);/*_client.Client;*/
                            cc.SendTimeout = 1000;
                            cc.ReceiveTimeout = 1000;
                            cc.Connect(person.Value.IP, _port);



                            cc.SendFile(_zipTempFilePath);
                            cc.Shutdown(SocketShutdown.Both);
                            cc.Close();
                        } catch
                        {
                            //BOF
                        }
                    }
                }
                //_client = new TcpClient(_incomingIP, _basicPort + 1);

                
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
