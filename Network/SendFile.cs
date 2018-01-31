using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    public class SendFile
    {
        public void SendTCP(string path, string otherIp, Int32 PortN)
        {
            byte[] SendingBuffer = null;
            int BufferSize = 1024;
    TcpClient client = null;
            NetworkStream netstream = null;
            try
            {
               
                client = new TcpClient(otherIp, PortN);
                netstream = client.GetStream();
                FileStream Fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                int NoOfPackets = Convert.ToInt32
             (Math.Ceiling(Convert.ToDouble(Fs.Length) / Convert.ToDouble(BufferSize)));
                int TotalLength = (int)Fs.Length, CurrentPacketLength, counter = 0;
                for (int i = 0; i < NoOfPackets; i++)
                {
                    if (TotalLength > BufferSize)
                    {
                        CurrentPacketLength = BufferSize;
                        TotalLength = TotalLength - CurrentPacketLength;
                    }
                    else
                        CurrentPacketLength = TotalLength;
                    SendingBuffer = new byte[CurrentPacketLength];
                    Fs.Read(SendingBuffer, 0, CurrentPacketLength);
                    netstream.Write(SendingBuffer, 0, (int)SendingBuffer.Length);
                   
                }

                
                     Fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                netstream.Close();
                client.Close();
            }
        }
    }
}
