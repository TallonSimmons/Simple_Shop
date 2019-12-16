using MediatR;
using Simple_Shop.Domain.Entities;
using System.Collections.Generic;

namespace Simple_Shop.Web.Queries
{
    public class InvalidProductQuery : IRequest<IEnumerable<Product>>
    {
    }
}
