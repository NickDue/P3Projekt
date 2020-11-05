using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using Server.LocalStorage;

namespace Server
{
    class Program
    {
        private const int PORT_NO = 7777;
        private const string SERVER_IP = "127.0.0.1";
        static void Main(string[] args)
        {
            /*IPAddress localAddress = IPAddress.Parse(SERVER_IP);
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
            
                Console.WriteLine("Sending back : " + dataReceived);
                nwStream.Write(buffer, 0, bytesRead);
                client.Close();
            }*/
            LoadDatabaseFiles.Load();
            Console.WriteLine(LoadedDatabase.AllProducts["22222-02"].placement.PrintPlacement());
            
            //TestPicklist();
        }

        static void TestProduct()
        {
            Product p = new Product(new ProductDescription("22222-01 ","sofa",2.3D, 2.3D,"03","green",Category.Bed));
            Console.WriteLine(p.description.id);
            string idToInt = p.description.id.Split("-")[0];
            Console.WriteLine(idToInt);
            LoadedDatabase.AllProducts.Add(idToInt,p);
            Console.WriteLine(LoadedDatabase.AllProducts[idToInt].description.color);
        }

        static void TestEmployee()
        {
            Employee mister = new Employee(12345, "AssWord", "Mister Boombastic", Employee.Role.OfficeWorker);
            Console.WriteLine(mister.role);
        }

        static void TestPicklist()
        {
            PicklistLine pline1 = new PicklistLine(2,3,"sofa",3,2,"0");
            PicklistLine pline2 = new PicklistLine(5,3,"sofa",3,2,"0");
            PicklistLine pline3 = new PicklistLine(6,3,"sofa",3,2,"0");
            Picklist p = new Picklist(3030,"Svendborg", "Online",true,new List<PicklistLine>());
            p.AddLine(pline1);
            p.AddLine(pline2);
            p.AddLine(pline3);
            Picklist.CreatePicklist(p);
            Picklist temp = LoadedDatabase.FindPicklist(p.picklistID);
            if (temp != null)
            {
                temp.FinishPicklist();
            }
        }
    }
}
