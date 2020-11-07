using System.Threading;
using System.Threading.Tasks;
using Banking.Domain.Commands;
using Banking.Domain.Events;
using MediatR;
using RabbitMq.Core.Bus;

namespace Banking.Domain.CommandHandlers
{
    public class TransferCommandHandler: IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _eventBus;

        public TransferCommandHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            _eventBus.Publish(new TransferCreatedEvent(request.From, request.To, request.Amount));
            return Task.FromResult(true);
        }
    }
}