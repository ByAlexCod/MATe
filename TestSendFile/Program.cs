using System;
using Network;
using System.IO.Compression;


namespace TestSendFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are the sender");
            ZipFile.CreateFromDirectory("bonjour", "bonjour.zip");

            SendFile a = new SendFile();
            a.SendTCP("bonjour.zip", "192.168.1.21", 18000);
            Console.ReadLine();

        }
    }
}
