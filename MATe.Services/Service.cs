using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network;
using MATeV2;
using System.IO;
using System.Threading;
using System.Net;

namespace MATe.Services
{
    public class Service
    {
        
        public static Person Start(ContextAndUserManager ctxuser, string mail, int ipIndex)
        {
            // only for boss for now
            if (ctxuser.Login(mail) != false)
            {
                //MultiThreading
                Person a = ctxuser.CurrentUser;
                using(var z = ctxuser.ObtainAccessor())
                {
                    IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
                    Context ctx = z.Context;
                    if (a == ctx.Boss)
                    {
                        
                        Network.Boss bobo = new Network.Boss(ctxuser, ipIndex);
                        

                        Thread lii = new Thread(bobo.Start);
                        lii.IsBackground = true;
                        lii.Start();

                    }
                    else
                    {
                        
                        // nothing now
                    }
                    IPAddress ip = localIPs[ipIndex];
                    SyncerReceiver abc = new SyncerReceiver(ip, 15000, "sync", "temp.zip", "zipsync");

                    Thread sec = new Thread(abc.Start);
                    sec.IsBackground = true;
                    sec.Start();
                }
                
                return a;
            }
            else return null;
        }
        
    }
}
