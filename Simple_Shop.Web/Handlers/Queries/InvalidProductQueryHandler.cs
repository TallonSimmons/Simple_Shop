using MediatR;
using Simple_Shop.Domain.Entities;
using Simple_Shop.Web.Helpers;
using Simple_Shop.Web.Queries;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Simple_Shop.Web.Handlers.Queries
{
    public class InvalidProductQueryHandler : IRequestHandler<InvalidProductQuery, IEnumerable<Product>>
    {
        public Task<IEnumerable<Product>> Handle(InvalidProductQuery request, CancellationToken cancellationToken)
        {
            var invalidProductList = new InvalidProductList();
            return Task.FromResult(new List<Product>()
            {
                invalidProductList.ProductWithInvalidPrice,
                invalidProductList.ProductWithNoTitle,
                invalidProductList.ProductWithUnsetProductTypeId
            }
            .AsEnumerable());
        }
    }
}
