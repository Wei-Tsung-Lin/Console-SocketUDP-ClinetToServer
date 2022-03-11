using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    class MainProgram
    {

        static void ReceivedMessage(IPEndPoint ip, UdpClient udpClient)
        {
            Console.WriteLine(System.Text.Encoding.UTF8.GetString(udpClient.Receive(ref ip)));
        }

        static void Main()
        {
 
            Console.WriteLine("This is Server...\n");

            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 5555);

            UdpClient udpclient = new UdpClient(ip.Port);

            while (true)
            {
                ReceivedMessage(ip,udpclient);
            }

        }
    }
}
