using Banking.Application.Interfaces;
using Banking.Application.Services;
using Banking.Data.Context;
using Banking.Data.Repository;
using Banking.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using RabbitMq.Core.Bus;
using RabbitMq.Infra.Bus;

namespace RabbitMq.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IEventBus, RabbitMqBus>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingContext>();

        }
    }
}