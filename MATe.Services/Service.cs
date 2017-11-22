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
        
        public static Person Start(string password, string mail, int ipIndex)
        {
            // only for boss for now
            if (Context.GetContext().Login(mail, password) != null)
            {
                //MultiThreading
                Person a = Context.GetContext().Login(mail, password);
                if (a == Context.GetContext().getBoss())
                {
                    ContextManager c = new ContextManager();
                    c.Load(Context.GetContext());
                    Network.Boss bobo = new Network.Boss(c, ipIndex);

                    
                    Thread lii = new Thread(bobo.Start);
                    lii.IsBackground = true;
                    lii.Start();

                }
                else
                {
                    // nothing now
                }
                return a;
            }
            else return null;
        }
    }
}
