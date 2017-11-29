using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network;
using MATeV2;
using System.IO;
using System.Threading;

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
                }
                
                return a;
            }
            else return null;
        }
    }
}
