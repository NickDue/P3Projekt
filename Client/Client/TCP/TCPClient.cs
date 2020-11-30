using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Client.TCP
{
    public class TCPClient
    {
        private const int PORT_NO = 7777;
        private const string CLIENT_IP = "127.0.0.1";
        public string Connect(string dataToSend)
        {
            string Recieved = "";
            Console.WriteLine("Sent: {0}", dataToSend);


            TcpClient client = new TcpClient(CLIENT_IP, PORT_NO);
            
            byte[] dataSent =ASCIIEncoding.ASCII.GetBytes(dataToSend);
            
            NetworkStream stream = client.GetStream();
            stream.Write(dataSent, 0, dataSent.Length);

            byte[] dataRecieved = new byte[client.ReceiveBufferSize];
            int byteRead = stream.Read(dataRecieved, 0, client.ReceiveBufferSize);
            Recieved = Encoding.ASCII.GetString(dataRecieved, 0, byteRead);
            client.Close();
            return Recieved;
                
        }

    }
}
