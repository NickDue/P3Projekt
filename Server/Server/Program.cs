using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Program
    {
        private const int PORT_NO = 7777;
        private const string SERVER_IP = "127.0.0.1";
        static void Main(string[] args)
        {
            IPAddress localAddress = IPAddress.Parse(SERVER_IP);
            TcpListener listener = new TcpListener(localAddress, PORT_NO);
            Console.WriteLine("Server started listening!");
            listener.Start();


            TcpClient client = listener.AcceptTcpClient();

            NetworkStream nwStream = client.GetStream();
            byte[] buffer = new byte[client.ReceiveBufferSize];

            int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);

            string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Console.WriteLine("Received: " + dataReceived);
            
            
        }
    }
}
