using Simple_Shop.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Shop.Web.ViewModels
{
    public class CheckoutViewModel
    {
        public CheckoutViewModel(Order order)
        {
            Order = order;
        }

        public Order Order { get; private set; }

        public IEnumerable<IGrouping<int, Product>> ProductGroupings => Order.Products.GroupBy(x => x.Id);
    }
}
