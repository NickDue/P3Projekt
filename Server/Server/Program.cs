using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using Server.LocalStorage;
using Server.SQL;
using Server.TCP;

namespace Server
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
