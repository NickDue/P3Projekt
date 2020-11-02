using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    public class ProductDescription
    {
        public int ID;
        public string Name;
        public int volume;
        public int weight;
        public int colli;
        public string color;

        public ProductDescription(int productID, string productName, int productVolume, int productWeight, int productColli, string productColor)
        {
            this.ID = productID;
            this.Name = productName;
            this.volume = productVolume;
            this.weight = productWeight;
            this.colli = productColli;
            this.color = productColor;
        }
    }
}
