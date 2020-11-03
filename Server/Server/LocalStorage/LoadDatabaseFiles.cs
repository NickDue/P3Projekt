using System;

namespace Server.LocalStorage
{
    public class LoadDatabaseFiles
    {
        public static void Load()
        {
            // todo: enter the functions
            LoadProducts();
        }

        private static void LoadProducts()
        {
            string toSplit = AccessDatabase.ReadData("Test");
            string[] splitted = toSplit.Split("\n");
            for (int i = 0; i < splitted.Length-1; i++)
            {
                string[] productSplitted = splitted[i].Split("?");
                Console.WriteLine(productSplitted[0]);
                ProductDescription pd = new ProductDescription(productSplitted[0],productSplitted[1],
                    Double.Parse(productSplitted[2]), Double.Parse(productSplitted[3]), productSplitted[4], productSplitted[5], (Category)Enum.Parse(typeof(Category),productSplitted[6])
                    );
                Product p  = new Product(pd, Int32.Parse(productSplitted[7]));
                Product.allProducts.Add(productSplitted[0],p );
            }
        }

        private static void LoadEmployees()
        {
            string toSplit = AccessDatabase.ReadData("EmployeeTest");
            string[] splitted = toSplit.Split("\n");
            for (int i = 0; i < splitted.Length - 1; i++)
            {
                string[] employeeSplitted = splitted[i].Split("?");
                Console.WriteLine(employeeSplitted[0]);
                Employee em = new Employee(Int32.Parse(employeeSplitted[0]), employeeSplitted[1], employeeSplitted[2], (Employee.Role)Enum.Parse(typeof(Employee.Role),employeeSplitted[3]));

            }
        }
    }
}