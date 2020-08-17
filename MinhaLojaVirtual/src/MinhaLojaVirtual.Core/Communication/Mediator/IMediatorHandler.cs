using System.Threading.Tasks;
using MinhaLojaVirtual.Core.Messages;
using MinhaLojaVirtual.Core.Messages.CommonMessages.DomainEvents;
using MinhaLojaVirtual.Core.Messages.CommonMessages.Notifications;

namespace MinhaLojaVirtual.Core.Communication.Mediator
{
    public interface IMediatorHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
        Task<bool> EnviarComando<T>(T comando) where T : Command;
        Task PublicarNotificacao<T>(T notificacao) where T : DomainNotification;
        Task PublicarDomainEvent<T>(T notificacao) where T : DomainEvent;
    }
}