using System.Collections.Generic;
namespace Verre.Domain.Interface.Service
{
    public interface IServiceBase<TEntity> where TEntity: class
    {
        void Add(TEntity obj);
        TEntity GetById(int Id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
