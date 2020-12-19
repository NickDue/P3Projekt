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
                //logsHandler.WriteToLog(input[1], input[2], input[3], input[4], "Searched for a product");
            }
            else if (clientInput.StartsWith("edit product"))
            {
                ProductHandler pHandler = new ProductHandler();
                output = pHandler.EditProductDetails(clientInput);
                string[] splittedForLog = clientInput.Split('\n');
                logsHandler.WriteToLog(splittedForLog[1].Split(" = ")[1],splittedForLog[7].Split(" = ")[1],splittedForLog[8].Split(" = ")[1], splittedForLog[10], "Edited a product");
            }
            else if (clientInput.StartsWith("get products"))
            {
                ProductHandler pHandler = new ProductHandler();
                output = pHandler.GetAllProducts();
                //logsHandler.WriteToLog("null", "null", "null", input[1], "Viewed all products!");
            }
            else if (clientInput.StartsWith("delete product"))
            {
                ProductHandler pHandler = new ProductHandler();
                output = pHandler.DeleteProduct(input[1], input[2], input[3]);
                logsHandler.WriteToLog(input[1], input[2], input[3], input[4], "Deleted a product");
            }
            else if (clientInput.StartsWith("related"))
            {
                ProductHandler pHandler = new ProductHandler();
                output = pHandler.GetRelatedProducts(input[1]);
            }
            else if (input[0].StartsWith("add product"))
            {
                ProductHandler pHandler = new ProductHandler();
                string[] splittedId = input[1].Split('-');
                output = pHandler.AddProductToDatabase(Int32.Parse(splittedId[0]), splittedId[1], splittedId[2],
                    input[2], Double.Parse(input[3]), Double.Parse(input[5]), input[4], null, "");
                logsHandler.WriteToLog(splittedId[0], splittedId[1], splittedId[2], input[7], "Added a new product");

            }
            else if (input[0].StartsWith("remove employee"))
            {
                EmployeeHandler eHandler = new EmployeeHandler();
                output = eHandler.DeleteEmployeeFromDB(Int32.Parse(input[1]));
                logsHandler.WriteToLog(input[1], "null", "null", input[2], "Removed an employee");
            }
            else if (input[0].StartsWith("add employee"))
            {
                EmployeeHandler eHandler = new EmployeeHandler();
                output = eHandler.AddUserToDB(Int32.Parse(input[2]), input[4], input[1], input[3]);
                logsHandler.WriteToLog(input[2],input[3],"null", input[5], "Added user to system");
            }
            else if (input[0].StartsWith("authenticate"))
            {
                try
                {
                    EmployeeHandler eHandler = new EmployeeHandler();
                    output = eHandler.AuthenticateUser(input[1], input[2]);
                    if(!output.StartsWith("ERROR"))
                        logsHandler.WriteToLog("null", "null","null", input[1], "Logged in");

                }
                catch(FormatException)
                {
                    return input[1] + input[2];
                }
            }
            else if (input[0].StartsWith("logout"))
            {
                output = "Logged out!";
                logsHandler.WriteToLog("null","null","null", input[1], "Logged out");
            }
            else if (input[0].StartsWith("edit employee"))
            {
                EmployeeHandler eHandler = new EmployeeHandler();
                output = eHandler.ChangeUserCredentials(Int32.Parse(input[2]), input[1], input[3],input[4]);
                logsHandler.WriteToLog(input[2], "null","null",input[5],"Edited Employee information");
            }
            else if (input[0].StartsWith("get employees"))
            {
                EmployeeHandler eHandler = new EmployeeHandler();
                output = eHandler.GetAllEmployees();
            }
            else if (input[0].StartsWith("get logs"))
            {
                output = logsHandler.GetAllLogs();
                //logsHandler.WriteToLog("null","null","null", input[1], "Viewed all logs!");
            }
            else
            {
                output = "ERROR: Unknown query";
            }

            return output;
        }
    }
}