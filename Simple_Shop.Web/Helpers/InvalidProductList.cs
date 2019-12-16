using Simple_Shop.Domain.Entities;

namespace Simple_Shop.Web.Helpers
{
    public class InvalidProductList
    {
        public Product ProductWithNoTitle = new Product()
        {
            ProductTypeId = (int)ProductType.Taxable,
            Price = 10M
        };

        public Product ProductWithUnsetProductTypeId = new Product()
        {
            Title = "Product with unset product type",
            Price = 10M
        };

        public Product ProductWithInvalidPrice = new Product()
        {
            Title = "Product with invalid price",
            Price = 0M
        };
    }
}
