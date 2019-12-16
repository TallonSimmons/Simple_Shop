using NUnit.Framework;
using Simple_Shop.Domain.Entities;

namespace Simple_Shop.Tests
{
    [TestFixture]
    public class ProductShouldNot
    {
        [Test]
        public void ChargeTaxOnNonTaxableProducts()
        {

            var product = new Product()
            {
                Imported = true,
                Price = 10M,
                ProductTypeId = (int)ProductType.NonTaxable
            };

            Assert.AreEqual(product.Tax, 0M);
        }

        [Test]
        public void ChargeImportFeesOnNonImportedProducts()
        {

            var product = new Product()
            {
                Imported = false,
                Price = 10M,
                ProductTypeId = (int)ProductType.Taxable
            };

            Assert.AreEqual(product.ImportFee, 0M);
        }
    }
}
