using MediatR;
using Simple_Shop.Domain.Entities;
using System.Collections.Generic;

namespace Simple_Shop.Web.Queries
{
    public class ProductsInRangeQuery : IRequest<IAsyncEnumerable<Product>>
    {
        public ProductsInRangeQuery(int startIndex, int numberOfProductsToFetch)
        {
            StartIndex = startIndex;
            NumberOfProductsToFetch = numberOfProductsToFetch;
        }

        public int StartIndex { get; }
        public int NumberOfProductsToFetch { get; }
    }
}
