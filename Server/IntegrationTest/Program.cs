using System;

namespace IntegrationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TCPServer server = new TCPServer();
            server.Run();
        }
    }
}