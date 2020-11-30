using System;
using Server.SQL;

namespace Server.TCP
{
    public class HandleMessages
    {
        public string HandleInput(string clientInput)
        {
            string[] input = clientInput.Split(" ! ");
            string output;
            if (clientInput.StartsWith("find product"))
            {
                Console.WriteLine("hello");
                ProductHandler pHandler = new ProductHandler();
                output = pHandler.ProductById(Int32.Parse(input[1]), input[2], input[3]);
            } 
            else if (input[0].StartsWith("remove product"))
            {
                ProductHandler pHandler = new ProductHandler();
                output = pHandler.RemoveProductFromDB(Int32.Parse(input[1]), input[2], input[3]);
            } 
            else if (input[0].StartsWith("find employee"))
            {
                EmployeeHandler eHandler = new EmployeeHandler();
                output = eHandler.GetEmployeeById(Int32.Parse(input[1]));
            }
            else if (input[0].StartsWith("remove employee"))
            {
                EmployeeHandler eHandler = new EmployeeHandler();
                output = eHandler.DeleteEmployeeFromDB(Int32.Parse(input[1]));
            }
            else if (input[0].StartsWith("add employee"))
            {
                EmployeeHandler eHandler = new EmployeeHandler();
                output = eHandler.AddUserToDB(Int32.Parse(input[1]), input[2], input[3], input[4]);
            }
            else if (input[0].StartsWith("authenticate"))
            {
                EmployeeHandler eHandler = new EmployeeHandler();
                output = eHandler.AuthenticateUser(Int32.Parse(input[1]), input[2]);
            }
            else if (input[0].StartsWith("edit employee"))
            {
                EmployeeHandler eHandler = new EmployeeHandler();
                output = eHandler.ChangeUserCredentials(Int32.Parse(input[1]), input[2], input[3]);
            }
            else
            {
                output = "ERROR: Unknown query.";
            }
            return output;
        }

        private void createProduct(string clientMsg)
        {
            
        }
    }
}