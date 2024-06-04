using NUnit.Framework;

namespace Assign2Ecommerce.Tests
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void CheckID43_Input43_TRUE()
        {
            var product = new Product(43, "Jacket", 60.40m, 40);

            var productId = product.ProductID;

            Assert.That(productId, Is.EqualTo(43));
        }

        [Test]
        public void CheckIDRange_Input60_TRUE()
        {
            var product = new Product(60, "Jacket", 123.99m, 550);

            var productId = product.ProductID;

            Assert.That(productId, Is.InRange(4, 40000));
        }

        [Test]
        public void CheckIDNullOrEmpty_Input90_FALSE()
        {
            var product = new Product(90, "Jacket", 123.99m, 550);

            var productId = product.ProductID;

            Assert.That(productId, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void CheckNameNullOrEmpty_InputJeans_FALSE()
        {
            var product = new Product(120, "Jeans", 199.99m, 50);

            var productName = product.ProductName;

            Assert.That(productName, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void CheckNameJeans_InputJeans_TRUE()
        {
            var product = new Product(120, "Jeans", 199.99m, 50);

            var productName = product.ProductName;

            Assert.That(productName, Is.EqualTo("Jeans"));
        }

        [Test]
        public void CheckNameNullOrEmpty_InputEmptyString_True()
        {
            var product = new Product(120, "", 199.99m, 50);

            var productName = product.ProductName;

            Assert.That(productName, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void CheckPriceRange_Input500_True()
        {
            var product = new Product(65, "Shoes", 500m, 50);

            var productPrice = product.Price;

            Assert.That(productPrice, Is.InRange(4, 4000));
        }

        [Test]
        public void CheckPriceNull_Input199_True()
        {
            var product = new Product(23, "Shoes", 199.00m, 50);

            var productPrice = product.Price;

            Assert.That(productPrice, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void CheckPrice560_Input560_True()
        {
            var product = new Product(45, "Shoes", 560.00m, 50);

            var productPrice = product.Price;

            Assert.That(productPrice, Is.EqualTo(560.00m));
        }

        [Test]
        public void CheckStockNull_Input50_True()
        {
            var product = new Product(65, "Shirt", 343.00m, 50);

            var productStock = product.Stock;

            Assert.That(productStock, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void CheckStock1000_Input1000_True()
        {
            var product = new Product(34, "Shirt", 199.00m, 1000);

            var productStock = product.Stock;

            Assert.That(productStock, Is.EqualTo(1000));
        }

        [Test]
        public void CheckStockRange_Input300_True()
        {
            var product = new Product(34, "Shirt", 234.00m, 300);

            var productStock = product.Stock;

            Assert.That(productStock, Is.InRange(0, 400000));
        }

        [Test]
        public void IncreaseStockBy40_Input240_280()
        {
            var product = new Product(45, "Shocks", 34.00m, 240);

            product.IncreaseStockCount(40);
             
            var productStock = product.Stock;

            Assert.That(productStock, Is.EqualTo(280));
        }

        [Test]
        public void IncreaseStockBy0_Input530_530()
        {
            var product = new Product(23, "Shocks", 12.00m, 530);

            product.IncreaseStockCount(0);
             
            var productStock = product.Stock;

            Assert.That(productStock, Is.EqualTo(530));
        }

        [Test]
        public void IncreaseStockByNegative_Input600_600()
        {
            var product = new Product(67, "Shocks", 23.00m, 600);

            product.IncreaseStockCount(-20);
             
            var productStock = product.Stock;

            Assert.That(productStock, Is.EqualTo(600));
        }

         [Test]
        public void DecreaseStockBy20_Input420_400()
        {
            var product = new Product(56, "HandGloves", 54.00m, 420);

            product.DecreaseStockCount(20);
             
            var productStock = product.Stock;

            Assert.That(productStock, Is.EqualTo(400));
        }

        [Test]
        public void DecreaseStockBy0_Input30_30()
        {
            var product = new Product(45, "HandGloves", 23.00m, 30);

            product.DecreaseStockCount(0);
             
            var productStock = product.Stock;

            Assert.That(productStock, Is.EqualTo(30));
        }

        [Test]
        public void DecreaseStockByNegative_Input100_100()
        {
            var product = new Product(34, "HandGloves", 34.00m, 100);

            product.DecreaseStockCount(-20);
             
            var productStock = product.Stock;

            Assert.That(productStock, Is.EqualTo(100));
        }
    }
}