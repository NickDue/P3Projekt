using System;
using Server.SQL;

namespace Server.TCP
{
    public class HandleMessages
    {
        public string HandleInput(string clientInput)
        {
            string[] input = clientInput.ToLower().Split(" ! ");
            string output = "ERROR OCCOURED";
            if (input[0].Contains("find product"))
            {
                ProductHandler pHandler = new ProductHandler();
                output = pHandler.ProductById(Int32.Parse(input[1]), input[2], input[3]);
            } else if (input[0].Contains("remove product"))
            {
                ProductHandler pHandler = new ProductHandler();
                output = pHandler.RemoveProductFromDB(Int32.Parse(input[1]), input[2], input[3]);
            }
            return output;
        }

        private void createProduct(string clientMsg)
        {
            
        }
    }
}