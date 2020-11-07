using System.Threading.Tasks;
using RabbitMq.Core.Events;

namespace RabbitMq.Core.Bus
{
    public interface IEventHandler<in TEvent>: IEventHandler where TEvent: Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {

    }
}