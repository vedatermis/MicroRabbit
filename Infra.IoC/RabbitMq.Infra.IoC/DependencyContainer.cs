using Banking.Application.Interfaces;
using Banking.Application.Services;
using Banking.Data.Context;
using Banking.Data.Repository;
using Banking.Domain.CommandHandlers;
using Banking.Domain.Commands;
using Banking.Domain.Interfaces;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RabbitMq.Core.Bus;
using RabbitMq.Infra.Bus;
using Transfer.Application.Interfaces;
using Transfer.Application.Services;
using Transfer.Data.Context;
using Transfer.Data.Repository;
using Transfer.Domain.EventHandlers;
using Transfer.Domain.Events;
using Transfer.Domain.Interfaces;

namespace RabbitMq.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IEventBus, RabbitMqBus>();

            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IAccountRepository, AccountRepository>();

            services.AddTransient<ITransferService, TransferService>();
            services.AddTransient<ITransferRepository, TransferRepository>();

            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();

            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            services.AddTransient<BankingContext>();
            services.AddTransient<TransferContext>();

        }
    }
}