using Simple_Shop.Domain.Entities.Exceptions;
using System.Collections.Generic;

namespace Simple_Shop.Domain.Entities
{
    public class ShoppingCart : BaseEntity
    {
        List<Product> productsInCart = new List<Product>();

        public ICollection<Product> ProductsInCart
        {
            get
            {
                return productsInCart.AsReadOnly();
            }
        }

        public void EmptyCart()
        {
            productsInCart = new List<Product>();
        }

        public void AddProductToCart(Product product)
        {
            product.Validate();
            productsInCart.Add(product);
        }
    }
}
