namespace Server
{
    public class Product : IProductDescription
    {
        public int amount;

        public int id { get; set; }
        public string name { get; set; }
        public int volume { get; set; }
        public int weight { get; set; }
        public int colli { get; set; }
        public string color { get; set; }

        public Product(int productID, string productName, int productVolume, int productWeight, int productColli, string productColor)
        {
            id = productID;
            name = productName;
            volume = productVolume;
            weight = productWeight;
            colli = productColli;
            color = productColor;
        }

        //public Product(int productID, string productName, int productVolume, int productWeight, int productColli, string productColor) : base(productID, productName, productVolume, productWeight, productColli, productColor) { }
        //ProductDescription fuck = new ProductDescription(123, "sdfs", 123, 123, 1, "red");
    }
}
