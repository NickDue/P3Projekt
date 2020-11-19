using System;
using Server.SQL;

namespace Server.TCP
{
    public class HandleMessages
    {
        public string HandleInput(string clientInput)
        {
            string[] input = clientInput.ToLower().Split(" ! ");
            string output = "";
            if (input[0].Contains("find product"))
            {
                ProductHandler pHandler = new ProductHandler();
                output = pHandler.ProductById(Int32.Parse(input[1]), input[2], input[3]);
                return output;
            }
            return "ERROR OCCOURED!";
        }

        private void createProduct(string clientMsg)
        {
            
        }
    }
}