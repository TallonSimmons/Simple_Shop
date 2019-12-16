using System.Collections.Generic;
using System.Linq;

namespace Simple_Shop.Domain.Entities
{
    public class Order : BaseEntity
    {
        public ICollection<Product> Products { get; set; }
        public decimal Tax => GetTax();
        public decimal Total => GetTotal();

        public static Order FromShoppingCart(ShoppingCart shoppingCart)
        {
            return new Order
            {
                Products = shoppingCart.ProductsInCart
            };
        }

        decimal GetTax()
        {
            var taxableProducts = Products.Where(x => x.Taxable || x.Imported);
            var tax = 0M;

            foreach (var product in taxableProducts)
            {
                tax += product.Tax;
                tax += product.ImportFee;
            }

            return tax;
        }

        decimal GetTotal()
        {
            var total = 0M;
            foreach (var product in Products)
            {
                total += product.TotalPrice;
            }

            return total;
        }
    }
}
