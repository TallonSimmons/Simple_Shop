using Simple_Shop.Domain.Entities;
using System.Collections.Generic;

namespace Simple_Shop.Web.ViewModels
{
    internal class ShopViewModel
    {
        public int Page { get; set; } = 1;
        public int CurrentProductIndex => (Page - 1) * 2;
        public ICollection<Product> ProductsToDisplay { get; set; } = new List<Product>();
        public int TotalProductCount { get; set; }
        public bool ReachedEndOfProductList => ProductsToDisplay.Count == TotalProductCount;
    }
}
