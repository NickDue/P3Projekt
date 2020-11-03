using System;

namespace Server.LocalStorage
{
    public class LoadDatabaseFiles
    {
        public static void load()
        {
            // todo: enter the functions
            loadProducts();
        }

        private static void loadAccounts()
        {
            
        }

        private static void loadProducts()
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
        
    }
}