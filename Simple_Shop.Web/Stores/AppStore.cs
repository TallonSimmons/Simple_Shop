using Simple_Shop.Domain.Entities;
using StoreX;

namespace Simple_Shop.Web.Stores
{
    public class AppStore : StoreXStore
    {
        public ShoppingCart ShoppingCart { get; private set; } = new ShoppingCart();
        public Order CurrentOrder { get; private set; } = new Order();

        internal void AddProductToCart(Product product)
        {
            ShoppingCart.AddProductToCart(product);
            NotifyStoreMutated();
        }

        internal void CreateNewOrder()
        {
            CurrentOrder = Order.FromShoppingCart(ShoppingCart);
            ShoppingCart.EmptyCart();
            NotifyStoreMutated();
        }
    }
}
