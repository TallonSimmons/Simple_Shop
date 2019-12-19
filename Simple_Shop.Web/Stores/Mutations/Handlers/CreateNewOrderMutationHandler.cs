using StoreX;
using System.Threading;
using System.Threading.Tasks;

namespace Simple_Shop.Web.Stores.Mutations.Handlers
{
    public class CreateNewOrderMutationHandler : StoreXMutationHandler<CreateNewOrderMutation>
    {
        private readonly AppStore store;

        public CreateNewOrderMutationHandler(AppStore store)
        {
            this.store = store;
        }

        protected override Task Handle(CreateNewOrderMutation request, CancellationToken cancellationToken)
        {
            store.CreateNewOrder();

            return Task.CompletedTask;
        }
    }
}
