using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace IntegrationTest
{
    public class TCPServer
    {
        private const int PORT_NO = 7777;
        private const string SERVER_IP = "127.0.0.1";
        public void Run()
        {
            HandleMessages msgHandler = new HandleMessages();
            IPAddress localAddress = IPAddress.Parse(SERVER_IP);
            TcpListener listener = new TcpListener(localAddress, PORT_NO);
            Console.WriteLine("Server started listening!");
            listener.Start();


            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();

                NetworkStream nwStream = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];

                int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);

                string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Received: " + dataReceived);
                
                
                string output = msgHandler.HandleInput(dataReceived);
                byte[] byteToSend = ASCIIEncoding.ASCII.GetBytes(output);
            
                Console.WriteLine("Sending back : " + output);
                nwStream.Write(byteToSend, 0, byteToSend.Length);
                client.Close();
            }
        }
    }
}