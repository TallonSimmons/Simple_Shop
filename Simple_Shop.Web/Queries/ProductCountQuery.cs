using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple_Shop.Web.Queries
{
    public class ProductCountQuery : IRequest<int>
    {
    }
}
