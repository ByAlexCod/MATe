using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network;
using System.Net;
using System.Threading;
using MATeV2;

namespace RequesterPrototype.MATe
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Context 1 :");
            ContextAndUserManager uno = new ContextAndUserManager("Context", true);
            using(var ct = uno.ObtainAccessor())
            {
                Context un = ct.Context;

                un.CreateEmployee("Alex", "Spitz", "a@ex.comi");
                un.CreateEmployee("Alexi", "Spitzi", "a@ex.comii");
                un.CreateEmployee("Alexii", "Spitzii", "a@ex.comiii");




            }
            uno.Login("a@ex.comi");
            Thread.Sleep(2000);
            ContextAndUserManager dos = new ContextAndUserManager("Context", true);
            using (var ct = dos.ObtainAccessor())
            {
                Context un = ct.Context;

                Employee i = un.CreateEmployee("Alex", "SPIR", "a@ex.comi");
                un.CreateEmployee("Alexi", "Spitzi", "a@ex.comii");



            }
            dos.Login("b");
            using (var ct = dos.ObtainAccessor())
            using (var ct1 = uno.ObtainAccessor())
            {
                Context un = ct1.Context;
                Context dosi = ct.Context;

                un.Merge(dosi);
                foreach(var emp in un.PersonsDictionary)
                {
                    Console.WriteLine(emp.Value.Firstname + emp.Value.Lastname);
                }

            }
            Console.ReadKey();
            

        }
    }
}
