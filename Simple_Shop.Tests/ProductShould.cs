using NUnit.Framework;
using Simple_Shop.Domain.Entities;

namespace Simple_Shop.Tests
{
    [TestFixture]
    public class ProductShould
    {
        [Test]
        public void Tax5PercentWhenImported()
        {
            var product = new Product()
            {
                Imported = true,
                Price = 10M,
                ProductTypeId = (int)ProductType.NonTaxable
            };

            Assert.AreEqual(product.TotalPrice, 10.50M);
        }

        [Test]
        public void Tax10PercentWhenTaxable()
        {
            var product = new Product()
            {
                Imported = false,
                Price = 10M,
                ProductTypeId = (int)ProductType.Taxable
            };

            Assert.AreEqual(product.TotalPrice, 11M);
        }

        [Test]
        public void IncludeTaxAndImportFeesInTotalPrice()
        {
            var product = new Product()
            {
                Imported = true,
                Price = 10M,
                ProductTypeId = (int)ProductType.Taxable
            };

            Assert.AreEqual(product.TotalPrice, 11.5M);
        }
    }
}
