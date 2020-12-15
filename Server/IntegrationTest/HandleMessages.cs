namespace IntegrationTest
{
    public class HandleMessages
    {
        public string HandleInput(string data)
        {
            string output = "ERROR: UNKNOWN COMMAND";
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
            else if (data.StartsWith("add user"))
            {
                EmployeeTest pTest = new EmployeeTest();
                output = pTest.CreateNewEmployeeTest(data);
            }
            else if (data.StartsWith("authenticate"))
            {
                EmployeeTest pTest = new EmployeeTest();
                output = pTest.AuthenticateUser(data);
            }
            else if(data.StartsWith("edit info"))
            {
                ProductTests ptest = new ProductTests();
                output = ptest.EditTestProduct(data);
            }

            return output;
        }
    }
}