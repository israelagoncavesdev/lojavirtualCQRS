using System.Threading.Tasks;
using MinhaLojaVirtual.Core.Messages;

namespace MinhaLojaVirtual.Core.Bus
{
    public interface IMediatrHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
    }
}