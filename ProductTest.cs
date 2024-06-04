using NUnit.Framework;

namespace Assign2Ecommerce.Tests
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void ProductID_Input43_TRUE()
        {
            var product = new Product(43, "Jacket", 60.40m, 40);

            var productId = product.ProductID;

            Assert.That(productId, Is.EqualTo(43));
        }

        [Test]
        public void ProductID_Input60_TRUE()
        {
            var product = new Product(60, "Jacket", 123.99m, 550);

            var productId = product.ProductID;
            
            Assert.That(productId, Is.InRange(4, 40000));
        }

        [Test]
        public void ProductID_Input90_FALSE()
        {
            var product = new Product(90, "Jacket", 123.99m, 550);

            var productId = product.ProductID;
            
            Assert.That(productId, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void ProductName_InputJeans_FALSE()
        {
            var product = new Product(120, "Jeans", 199.99m, 50);

            var productName = product.ProductName;
            
            Assert.That(productName, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void ProductName_InputJeans_TRUE()
        {
            var product = new Product(120, "Jeans", 199.99m, 50);

            var productName = product.ProductName;
            
            Assert.That(productName, Is.EqualTo("Jeans"));
        }

        [Test]
        public void ProductName_InputEmptyString_True()
        {
            var product = new Product(120, "", 199.99m, 50);

            var productName = product.ProductName;
            
            Assert.That(productName, Is.Not.Null.Or.Empty);
        }
    }
}