using Microsoft.Extensions.DependencyInjection;
using Simple_Shop.Domain.Events.Interfaces;

namespace Simple_Shop.Events.Configuration
{
    public static class DomainEventDependencyConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddSingleton<IDomainEventDispatcher, DomainEventDispatcher>();
        }
    }
}
