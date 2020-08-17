using System.Threading.Tasks;

namespace MinhaLojaVirtual.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}