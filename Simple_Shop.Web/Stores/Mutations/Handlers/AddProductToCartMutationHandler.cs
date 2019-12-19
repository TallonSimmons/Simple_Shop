using StoreX;
using System.Threading;
using System.Threading.Tasks;

namespace Simple_Shop.Web.Stores.Mutations.Handlers
{
    internal class AddProductToCartMutationHandler : StoreXMutationHandler<AddProductToCartMutation>
    {
        private readonly AppStore store;

        public AddProductToCartMutationHandler(AppStore store)
        {
            this.store = store;
        }

        protected override Task Handle(AddProductToCartMutation request, CancellationToken cancellationToken)
        {
            store.AddProductToCart(request.Product);

            return Task.CompletedTask;
        }
    }
}
