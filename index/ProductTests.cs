using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Product.Tests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void TestIndexerByInt()
        {
            Product product = new Product(102, "Smartphone", "Electronics", 599.99, 200);

            Assert.AreEqual(102, product[0]);
            Assert.AreEqual("Smartphone", product[1]);
            Assert.AreEqual("Electronics", product[2]);
            Assert.AreEqual(599.99, product[3]);
            Assert.AreEqual(200, product[4]);
        }

        [TestMethod]
        public void TestIndexerByString()
        {
            Product product = new Product(103, "Tablet", "Electronics", 299.99, 150);

            Assert.AreEqual(103, product["productid"]);
            Assert.AreEqual("Tablet", product["productname"]);
            Assert.AreEqual("Electronics", product["category"]);
            Assert.AreEqual(299.99, product["price"]);
            Assert.AreEqual(150, product["stockquantity"]);
        }

        [TestMethod]
        public void TestSetIndexerByInt()
        {
            Product product = new Product(0, "", "", 0, 0);

            product[0] = 104;
            product[1] = "Headphones";
            product[2] = "Accessories";
            product[3] = 49.99;
            product[4] = 300;

            Assert.AreEqual(104, product[0]);
            Assert.AreEqual("Headphones", product[1]);
            Assert.AreEqual("Accessories", product[2]);
            Assert.AreEqual(49.99, product[3]);
            Assert.AreEqual(300, product[4]);
        }

        [TestMethod]
        public void TestSetIndexerByString()
        {
            Product product = new Product(0, "", "", 0, 0);

            product["productid"] = 105;
            product["productname"] = "Smartwatch";
            product["category"] = "Wearables";
            product["price"] = 199.99;
            product["stockquantity"] = 100;

            Assert.AreEqual(105, product["productid"]);
            Assert.AreEqual("Smartwatch", product["productname"]);
            Assert.AreEqual("Wearables", product["category"]);
            Assert.AreEqual(199.99, product["price"]);
            Assert.AreEqual(100, product["stockquantity"]);
        }

        [TestMethod]
        public void TestInvalidIndexer()
        {
            Product product = new Product(106, "Camera", "Photography", 799.99, 30);

            Assert.IsNull(product[5]); // Invalid index
            Assert.IsNull(product["unknown"]); // Invalid attribute name
        }
    }
}
