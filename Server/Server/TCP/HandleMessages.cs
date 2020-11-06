using System;

namespace Server.TCP
{
    public class HandleMessages
    {
        public void HandleInput(string clientInput)
        {
            string input = clientInput.ToLower();

            switch (input)
            {
                case "newproduct":
                    createProduct(input);
                    break;
                case "newemployee":
                    break;
                case "picklist":
                    break;
                case "save":
                    break;
                case "reload":
                    break;
                default:
                    throw new ArgumentException("Unknown client input!");
            }
        }

        private void createProduct(string clientMsg)
        {
            
        }
    }
}