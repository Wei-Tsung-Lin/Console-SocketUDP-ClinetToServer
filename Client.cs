using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class MainProgram
    {
        static void Main()
        {
            Console.WriteLine("This is Client...\n");

            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5555);

            UdpClient udpclient = new UdpClient();

            string message = Console.ReadLine();

            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(message);

            udpclient.Send(buffer, buffer.Length, ip);
                  
            Main();
          
        }
    }
}
