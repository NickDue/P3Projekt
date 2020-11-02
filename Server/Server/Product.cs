namespace Server
{
    public class Product : ProductDescription
    {
        public int amount;

        public Product(int productID, string productName, int productVolume, int productWeight, int productColli, string productColor) : base(productID, productName, productVolume, productWeight, productColli, productColor)
        {
            
        }
        //ProductDescription fuck = new ProductDescription(123, "sdfs", 123, 123, 1, "red");
    }
}
