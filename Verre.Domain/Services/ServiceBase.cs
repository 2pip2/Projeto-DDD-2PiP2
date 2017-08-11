using System;
using System.Collections.Generic;
using Verre.Domain.Interface.Repositories;
using Verre.Domain.Interface.Service;

namespace Verre.Domain.Services
{
    public class ServiceBase<TEntity>: IDisposable, IServiceBase<TEntity> where TEntity: class
    {
        private readonly IRepositoryBase<TEntity> _repository;
        private ITransformacaoProdutoRepository transformacaoProdutoRepository;

        //private IPersonaRepository personaRepository;
        //private IEntidadeRepository entidadeRepository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public ServiceBase(ITransformacaoProdutoRepository transformacaoProdutoRepository)
        {
            this.transformacaoProdutoRepository = transformacaoProdutoRepository;
        }

        //public ServiceBase(IPersonaRepository personaRepository)
        //{
        //   // this.personaRepository = personaRepository;
        //}

        //public ServiceBase(IEntidadeRepository entidadeRepository)
        //{
        //    //this.entidadeRepository = entidadeRepository;
        //}

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }
        public TEntity GetById(int id)
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
