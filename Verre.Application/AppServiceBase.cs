using System;
using System.Collections.Generic;
using Verre.Application.Interface;
#pragma warning disable CS0234 // The type or namespace name 'Domain' does not exist in the namespace 'Verre' (are you missing an assembly reference?)
using Verre.Domain.Interface.Service;
#pragma warning restore CS0234 // The type or namespace name 'Domain' does not exist in the namespace 'Verre' (are you missing an assembly reference?)

namespace Verre.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private Interface.ITransformacaoProdutoService transformacaoprodutoService;
#pragma warning disable CS0246 // The type or namespace name 'IServiceBase<>' could not be found (are you missing a using directive or an assembly reference?)
        private readonly IServiceBase<TEntity> _serviceBase;
#pragma warning restore CS0246 // The type or namespace name 'IServiceBase<>' could not be found (are you missing a using directive or an assembly reference?)

        public AppServiceBase(Interface.ITransformacaoProdutoService transformacaoprodutoService)
        {
            this.transformacaoprodutoService = transformacaoprodutoService;
        }

#pragma warning disable CS0246 // The type or namespace name 'IServiceBase<>' could not be found (are you missing a using directive or an assembly reference?)
        public AppServiceBase(IServiceBase<TEntity> serviceBase)
#pragma warning restore CS0246 // The type or namespace name 'IServiceBase<>' could not be found (are you missing a using directive or an assembly reference?)
        {
            _serviceBase = serviceBase;
        }
        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public IEnumerable<TEntity> GetAll()
        {
           return _serviceBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }
    }
}
