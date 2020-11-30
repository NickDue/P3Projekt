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
        private const int PORT_NO = 7777;
        private const string SERVER_IP = "127.0.0.1";
        static void Main(string[] args)
        {
            string result = "";
            //EmployeeHandler handler = new EmployeeHandler();
            //ProductHandler pHandler = new ProductHandler();
            //pHandler.GetProductByID("21188", "01", "03");
            //handler.DeleteEmployeeFromDB(22222);
            //handler.AddUserToDB(51, "helloWorld","Test subject", Employee.Role.FloorWorker);
            //handler.ChangeUserCredentials(15, "Office", "role");
            //Console.WriteLine(handler.AuthenticateUser(1, "dick"));
            //Employee e = handler.GetEmployeeById(10);
            //Console.WriteLine(e.employeeName);
           // result = pHandler.AddProductToDatabase(34, "02", "06", "Sej Sofa", 2.4D, 1.6D, "Green", "Couch",
              // "HAL1-B2-20");
            //Console.WriteLine(result);
            //result = pHandler.ProductById(21188, "02", "03");
            //Console.WriteLine(result);
            TCPServer server = new TCPServer();
            server.Run();
        }

        /*static void TestProduct()
        {
            Product p = new Product(new ProductDescription("22222-01 ","sofa",2.3D, 2.3D,"03","green",Category.Bed));
            Console.WriteLine(p.description.id);
            string idToInt = p.description.id.Split("-")[0];
            Console.WriteLine(idToInt);
            LoadedDatabase.AllProducts.Add(idToInt,p);
            Console.WriteLine(LoadedDatabase.AllProducts[idToInt].description.color);
        }*/

        static void TestEmployee()
        {
            //Employee mister = new Employee(12345, "AssWord", "Mister Boombastic", Employee.Role.OfficeWorker);
            //Console.WriteLine(mister.role);
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
