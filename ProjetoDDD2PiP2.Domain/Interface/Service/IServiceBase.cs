using System.Collections.Generic;
namespace ProjetoDDD2PiP2.Domain.Interface.Service
{
    public interface IServiceBase<TEntity> where TEntity: class
    {
        void Add(TEntity obj);
        TEntity GetById(string Id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
