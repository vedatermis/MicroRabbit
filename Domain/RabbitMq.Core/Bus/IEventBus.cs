using System.Threading.Tasks;
using RabbitMq.Core.Commands;
using RabbitMq.Core.Events;

namespace RabbitMq.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;
        void Publish<T>(T @event) where T : Event;
        void Subscribe<T, TH>() where T : Event where TH : IEventHandler<T>;

    }
}