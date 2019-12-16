using MediatR;
using Simple_Shop.Domain.DataModels;
using Simple_Shop.Domain.Repositories;
using Simple_Shop.Web.Queries;
using System.Threading;
using System.Threading.Tasks;

namespace Simple_Shop.Web.Handlers.Queries
{
    public class ProductCountQueryHandler : IRequestHandler<ProductCountQuery, int>
    {
        private readonly IRepository repository;

        public ProductCountQueryHandler(IRepository repository)
        {
            this.repository = repository;
        }
        public Task<int> Handle(ProductCountQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(repository.Count<ProductDTO>());
        }
    }
}
