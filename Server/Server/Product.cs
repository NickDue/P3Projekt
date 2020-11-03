using System;
using System.Collections.Generic;

namespace Server
{
    public class Product
    {
        public static Dictionary<String, Product> allProducts = new Dictionary<String, Product>();

        public ProductDescription description { get; }
        public int amount { get; set; }

        public Product(ProductDescription d)
        {
            description = d;
            amount = 0;
        }
        public Product(ProductDescription d, int savedAmount)
        {
            description = d;
            amount = savedAmount;
        }

        public void EditAttribute(string[] newValues)
        {
            for (int i = 0; i < newValues.Length; i++)
            {
                if(newValues[i] != null)
                    edit(i,newValues[i]);
            }
        }

        private void edit(int index, string value)
        {
            switch (index)
            {
                case 0:
                    description.id = value;
                    break;
                case 1:
                    description.name = value;
                    break;
                case 2:
                    description.volume = Double.Parse(value);
                    break;
                case 3:
                    description.weight = Double.Parse(value);
                    break;
                case 4:
                    description.colli = value;
                    break;
                case 5:
                    description.color = value;
                    break;
                case 6:
                    // todo
                    break;
                case 7:
                    amount = Int32.Parse(value);
                    break;
            }
        }
        

        //public Product(int productID, string productName, int productVolume, int productWeight, int productColli, string productColor) : base(productID, productName, productVolume, productWeight, productColli, productColor) { }
        //ProductDescription fuck = new ProductDescription(123, "sdfs", 123, 123, 1, "red");
    }
}
