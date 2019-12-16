using Simple_Shop.Domain.DataModels;
using Simple_Shop.Domain.Entities;

namespace Simple_Shop.Domain.Models.Extensions
{
    public static class ProductExtensions
    {
        public static ProductDTO ToProductDTO(this Product product)
        {
            return new ProductDTO()
            {
                Id = product.Id,
                Title = product.Title,
                Price = product.Price,
                ProductTypeId = product.ProductTypeId
            };
        }
    }
}
