namespace IntegrationTest
{
    public class HandleMessages
    {
        public string HandleInput(string data)
        {
            string output = "ERROR: UNKNOWN COMMAND";
            string[] command = data.Split(" ! ");
            if (data.StartsWith("get product"))
            {
                ProductTests pTest = new ProductTests();
                output = pTest.GetLatestProduct();
            }
            else if (data.StartsWith("add product"))
            {
                ProductTests pTest = new ProductTests();
                output = pTest.AddTestProduct(data);
            }
            else if (data.StartsWith("delete product"))
            {
                ProductTests pTest = new ProductTests();
                output = pTest.DeleteTestProduct();
            }

            return output;
        }
    }
}