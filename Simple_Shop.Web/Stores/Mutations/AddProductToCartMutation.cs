using MediatR;
using Simple_Shop.Domain.Entities;
using StoreX;

namespace Simple_Shop.Web.Stores.Mutations
{
    public class AddProductToCartMutation : StoreXMutation
    {
        internal Product Product { get; private set; }

        public AddProductToCartMutation(Product product)
        {
            this.Product = product;
        }
    }
}
