using MediatR;
using Microsoft.EntityFrameworkCore;
using Simple_Shop.Domain.DataModels;
using Simple_Shop.Domain.DataModels.Extensions;
using Simple_Shop.Domain.Entities;
using Simple_Shop.Domain.Repositories;
using Simple_Shop.Web.Queries;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Shop.Web.Handlers.Queries
{
    public class ProductsInRangeQueryHandler : RequestHandler<ProductsInRangeQuery, IAsyncEnumerable<Product>>
    {
        private readonly IRepository repository;

        public ProductsInRangeQueryHandler(IRepository repository)
        {
            this.repository = repository;
        }
        protected override async IAsyncEnumerable<Product> Handle(ProductsInRangeQuery request)
        {
            var products = repository
                .GetAll<ProductDTO>()
                .Skip(request.StartIndex)
                .Take(request.NumberOfProductsToFetch)
                .AsAsyncEnumerable();

            await foreach (var productDto in products)
            {
                yield return productDto.ToProduct();
            }
        }
    }
}



