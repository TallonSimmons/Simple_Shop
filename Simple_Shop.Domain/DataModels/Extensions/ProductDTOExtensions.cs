using Simple_Shop.Domain.Entities;
using Simple_Shop.Domain.Models;

namespace Simple_Shop.Domain.DataModels.Extensions
{
    public static class ProductDTOExtensions
    {
        public static Product ToProduct(this ProductDTO productData)
        {
            return new Product
            {
                Id = productData.Id,
                Title = productData.Title,
                Price = productData.Price,
                Imported = productData.Imported,
                ProductTypeId = productData.ProductTypeId
            };
        }
    }
}
