using System;
using Network;

namespace TestReceiverFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey!");
            ReceiveFile rc = new ReceiveFile();
            rc.ReceiveTCP(18000);
        }
    }
}
