using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MATeUI;
using MATeV2;
using System.IO;

namespace MATe.Services
{
    public class Service
    {
        public static Person Login(string password, string mail)
        {
            // only for boss for now
            if (Context.GetContext().Login(mail, password) != null)
            {
                //MultiThreading
                Person a = Context.GetContext().Login(mail, password);
                if(a == Context.GetContext().getBoss())
                {

                }else
                {
                    // nothing now
                }
                return a;
            }
            else return null;
            

        }
    }
}
