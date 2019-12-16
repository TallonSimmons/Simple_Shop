using Simple_Shop.Domain.Entities;
using Simple_Shop.Domain.Events;

namespace Simple_Shop.Web
{
    public class AppState
    {
        public ShoppingCart ShoppingCart { get; private set; } = new ShoppingCart();
        public Order CurrentOrder { get; private set; } = new Order();

        public void AddProductToCart(Product product)
        {
            ShoppingCart.AddProductToCart(product);
        }

        public void CreateNewOrder()
        {
            CurrentOrder = Order.FromShoppingCart(ShoppingCart);
            CurrentOrder.Events?.Add(new OrderPlacedEvent());
            ShoppingCart.EmptyCart();
        }
    }
}
