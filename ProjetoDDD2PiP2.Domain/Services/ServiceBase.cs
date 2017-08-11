using ProjetoDDD2PiP2.Domain.Interface.Repositories;
using ProjetoDDD2PiP2.Domain.Interface.Service;
using System;
using System.Collections.Generic;

namespace ProjetoDDD2PiP2.Domain.Services
{
    public class ServiceBase<TEntity>: IDisposable, IServiceBase<TEntity> where TEntity: class
    {
        private readonly IRepositoryBase<TEntity> _repository;
        
        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }
        
        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }
        public TEntity GetById(string id)
        {
            return _repository.GetById(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }
        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }
        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
