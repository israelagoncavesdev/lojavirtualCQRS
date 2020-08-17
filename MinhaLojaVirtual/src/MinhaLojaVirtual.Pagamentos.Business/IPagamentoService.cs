using System.Threading.Tasks;
using MinhaLojaVirtual.Core.DomainObjects.DTO;

namespace MinhaLojaVirtual.Pagamentos.Business
{
    public interface IPagamentoService
    {
        Task<Transacao> RealizarPagamentoPedido(PagamentoPedido pagamentoPedido);
    }
}