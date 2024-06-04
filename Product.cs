namespace Assign2Ecommerce
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Product(int productId, string productName, decimal productPrice, int productStock)
        {
            ProductID = productId;
            ProductName = productName;
            Price = productPrice;
            Stock = productStock;
        }

        public void IncreaseStockCount(int productStock)
        {
            if (productStock > 0)
            {
                Stock = Stock + productStock;
            }
        }

        public void DecreaseStockCount(int productStock)
        {
            if (productStock > 0)
            {
                Stock = Stock - productStock;
            }
        }
    }
}
