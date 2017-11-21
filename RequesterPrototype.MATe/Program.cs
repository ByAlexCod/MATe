using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network;
using System.Net;
using System.Threading;

namespace RequesterPrototype.MATe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================");
            Console.WriteLine("==============MATe=============");
            Console.WriteLine("===============================");
            Console.WriteLine("");
            int Count = 0;
            IPAddress[] localsIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (var loc in localsIP)
            {
                Console.WriteLine(Count + " - " + loc);
            }
            Console.WriteLine("Etrez le numéro de l'ip que vous souhaitez utiliser");
            int index = Convert.ToInt32(Console.ReadLine());


            Console.Write("ENTREZ L'IP DU BOSS :");
            string ipboss = Console.ReadLine();

            Console.Write("ENTREZ VOTRE EMAIL :");
            string eMail = Console.ReadLine();

            Console.Write("ENTREZ VOTRE MDP :");
            string mdp = Console.ReadLine();

            Requester req = new Requester(ipboss, eMail, mdp, index);
            req.Send();
            Thread.Sleep(2000);
            Console.ReadLine();
            Console.WriteLine("JOB DONE");
        }
    }
}
