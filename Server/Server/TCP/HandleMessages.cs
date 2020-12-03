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
            LogsHandler logsHandler = new LogsHandler();
            if (clientInput.StartsWith("find product"))
            {
                ProductHandler pHandler = new ProductHandler();
                output = pHandler.ProductById(Int32.Parse(input[1]), input[2], input[3]);
                logsHandler.WriteToLog(input[1], input[2], input[3], input[4], "Searched for a product");
            }
            else if (input[0].StartsWith("remove product"))
            {
                ProductHandler pHandler = new ProductHandler();
                output = pHandler.RemoveProductFromDB(Int32.Parse(input[1]), input[2], input[3]);
            }
            else if (clientInput.StartsWith("edit product"))
            {
                ProductHandler pHandler = new ProductHandler();
                output = pHandler.EditProductDetails(clientInput);
                string[] splittedForLog = clientInput.Split('\n');
                logsHandler.WriteToLog(splittedForLog[1].Split(" = ")[1],splittedForLog[7].Split(" = ")[1],splittedForLog[8].Split(" = ")[1], splittedForLog[10], "Edited a product!");
            }
            else if (clientInput.StartsWith("get products"))
            {
                ProductHandler pHandler = new ProductHandler();
                output = pHandler.GetAllProducts();
                logsHandler.WriteToLog(null, null, null, input[1], "Viewed all products!");

            }
            else if (input[0].StartsWith("add product"))
            {
                ProductHandler pHandler = new ProductHandler();
                string[] splittedId = input[1].Split('-');
                output = pHandler.AddProductToDatabase(Int32.Parse(splittedId[0]), splittedId[1], splittedId[2],
                    input[2], Double.Parse(input[3]), Double.Parse(input[5]), input[4], null, "");
                logsHandler.WriteToLog(splittedId[0], splittedId[1], splittedId[2], input[7], "Added a new product!");

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
                output = eHandler.AddUserToDB(Int32.Parse(input[2]), input[4], input[1], input[3]);
                logsHandler.WriteToLog(input[2]+"(User)",input[3] + "(Role)",null, input[5], "Added user to system.");
            }
            else if (input[0].StartsWith("authenticate"))
            {
                EmployeeHandler eHandler = new EmployeeHandler();
                output = eHandler.AuthenticateUser(Int32.Parse(input[1]), input[2]);
                logsHandler.WriteToLog(null, null,null, input[1], "Logged in!");
            }
            else if (input[0].StartsWith("logout"))
            {
                output = "Logged out!";
                logsHandler.WriteToLog(null, null,null, input[1], "Logged out!");
            }
            else if (input[0].StartsWith("edit employee"))
            {
                EmployeeHandler eHandler = new EmployeeHandler();
                output = eHandler.ChangeUserCredentials(Int32.Parse(input[1]), input[2], input[3]);
            }
            else if (input[0].StartsWith("get employees"))
            {
                EmployeeHandler eHandler = new EmployeeHandler();
                output = eHandler.GetAllEmployees();
            }
            else
            {
                output = "ERROR: Unknown query.";
            }

            return output;
        }
    }
}