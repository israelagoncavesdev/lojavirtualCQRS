using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MinhaLojaVirtual.Core.Communication.Mediator;
using MinhaLojaVirtual.Core.Messages.CommonMessages.Notifications;
using MinhaLojaVirtual.Vendas.Application.Queries;

namespace MinhaLojaVirtual.WebApp.MVC.Controllers
{
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoQueries _pedidoQueries;

        public PedidoController(IPedidoQueries pedidoQueries,
            INotificationHandler<DomainNotification> notifications,
            IMediatorHandler mediatorHandler) : base(notifications, mediatorHandler)
        {
            _pedidoQueries = pedidoQueries;
        }

        [Route("meus-pedidos")]
        public async Task<IActionResult> Index()
        {
            return View(await _pedidoQueries.ObterPedidosCliente(ClienteId));
        }
    }
}