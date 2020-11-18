using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    public class ProductDescription
    {
        // 22222-03-05
        public int id { get; set; }
        public string colliNumber { get; set; }
        public string colliAmount { get; set; }
        public string name{ get; set; }
        public double volume{ get; set; }
        public double weight{ get; set; }
        public string color{ get; set; }
        public string category{ get; set; }

        public ProductDescription(int productID, string productColliNumber, string productColliAmount, string productName, double productVolume, double productWeight, string productColor, string productCategory)
        {
            id = productID;
            colliNumber = productColliNumber;
            colliAmount = productColliAmount;
            name = productName;
            volume = productVolume;
            weight = productWeight;
            color = productColor;
            category = productCategory;
        }
    }
}
