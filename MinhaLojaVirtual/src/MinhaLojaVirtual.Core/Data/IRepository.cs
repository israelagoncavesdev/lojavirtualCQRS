using System;
using MinhaLojaVirtual.Core.DomainObjects;

namespace MinhaLojaVirtual.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}