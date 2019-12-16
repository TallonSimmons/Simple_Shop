using MediatR;
using Simple_Shop.Domain.Entities;
using Simple_Shop.Web.Helpers;
using Simple_Shop.Web.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Simple_Shop.Web.Handlers.Queries
{
    public class SavedShoppingCartsQueryHandler : IRequestHandler<SavedShoppingCartsQuery, IEnumerable<ShoppingCart>>
    {
        public Task<IEnumerable<ShoppingCart>> Handle(SavedShoppingCartsQuery request, CancellationToken cancellationToken)
        {
            var productList = new ProductList();
            var shoppingCarts = new List<ShoppingCart>();

            var shoppingCart1 = new ShoppingCart();
            shoppingCart1.AddProductToCart(productList.Book);
            shoppingCart1.AddProductToCart(productList.Book);
            shoppingCart1.AddProductToCart(productList.Cd);
            shoppingCart1.AddProductToCart(productList.Chocolate);

            var shoppingCart2 = new ShoppingCart();
            shoppingCart2.AddProductToCart(productList.ImportedChocolate1);
            shoppingCart2.AddProductToCart(productList.ImportedPerfume2);


            var shoppingCart3 = new ShoppingCart();
            shoppingCart3.AddProductToCart(productList.ImportedChocolate2);
            shoppingCart3.AddProductToCart(productList.ImportedChocolate2);
            shoppingCart3.AddProductToCart(productList.ImportedPerfume1);
            shoppingCart3.AddProductToCart(productList.Perfume);
            shoppingCart3.AddProductToCart(productList.Pills);

            shoppingCarts.Add(shoppingCart1);
            shoppingCarts.Add(shoppingCart2);
            shoppingCarts.Add(shoppingCart3);

            return Task.FromResult(shoppingCarts.AsEnumerable());
        }
    }
}
