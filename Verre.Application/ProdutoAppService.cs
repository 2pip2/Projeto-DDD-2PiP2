using System;
using System.Collections.Generic;
#pragma warning disable CS0234 // The type or namespace name 'Domain' does not exist in the namespace 'Verre' (are you missing an assembly reference?)
using Verre.Domain.Entities;
#pragma warning restore CS0234 // The type or namespace name 'Domain' does not exist in the namespace 'Verre' (are you missing an assembly reference?)
#pragma warning disable CS0234 // The type or namespace name 'Domain' does not exist in the namespace 'Verre' (are you missing an assembly reference?)
using Verre.Domain.Interface.Service;
#pragma warning restore CS0234 // The type or namespace name 'Domain' does not exist in the namespace 'Verre' (are you missing an assembly reference?)

namespace Verre.Application
{
#pragma warning disable CS0246 // The type or namespace name 'Produto' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning disable CS0246 // The type or namespace name 'IProdutoService' could not be found (are you missing a using directive or an assembly reference?)
    public class ProdutoAppService:AppServiceBase<Produto>,IProdutoService
#pragma warning restore CS0246 // The type or namespace name 'IProdutoService' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning restore CS0246 // The type or namespace name 'Produto' could not be found (are you missing a using directive or an assembly reference?)
    {
#pragma warning disable CS0246 // The type or namespace name 'IProdutoService' could not be found (are you missing a using directive or an assembly reference?)
        private readonly IProdutoService _produtoService;
#pragma warning restore CS0246 // The type or namespace name 'IProdutoService' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning disable CS0246 // The type or namespace name 'IProdutoService' could not be found (are you missing a using directive or an assembly reference?)
        public ProdutoAppService(IProdutoService produtoService):base(produtoService)
#pragma warning restore CS0246 // The type or namespace name 'IProdutoService' could not be found (are you missing a using directive or an assembly reference?)
        {
            _produtoService = produtoService;
        }

#pragma warning disable CS0246 // The type or namespace name 'Produto' could not be found (are you missing a using directive or an assembly reference?)
        public new void Add(Produto obj)
#pragma warning restore CS0246 // The type or namespace name 'Produto' could not be found (are you missing a using directive or an assembly reference?)
        {
            throw new NotImplementedException();
        }

#pragma warning disable CS0246 // The type or namespace name 'Produto' could not be found (are you missing a using directive or an assembly reference?)
        public new void Remove(Produto obj)
#pragma warning restore CS0246 // The type or namespace name 'Produto' could not be found (are you missing a using directive or an assembly reference?)
        {
            throw new NotImplementedException();
        }

#pragma warning disable CS0246 // The type or namespace name 'Produto' could not be found (are you missing a using directive or an assembly reference?)
        public new void Update(Produto obj)
#pragma warning restore CS0246 // The type or namespace name 'Produto' could not be found (are you missing a using directive or an assembly reference?)
        {
            throw new NotImplementedException();
        }

#pragma warning disable CS0538 // 'IServiceBase<Produto>' in explicit interface declaration is not an interface
#pragma warning disable CS0246 // The type or namespace name 'IServiceBase<>' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning disable CS0246 // The type or namespace name 'Produto' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning disable CS0246 // The type or namespace name 'Produto' could not be found (are you missing a using directive or an assembly reference?)
        IEnumerable<Produto> IServiceBase<Produto>.GetAll()
#pragma warning restore CS0246 // The type or namespace name 'Produto' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning restore CS0246 // The type or namespace name 'Produto' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning restore CS0246 // The type or namespace name 'IServiceBase<>' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning restore CS0538 // 'IServiceBase<Produto>' in explicit interface declaration is not an interface
        {
            throw new NotImplementedException();
        }

#pragma warning disable CS0538 // 'IServiceBase<Produto>' in explicit interface declaration is not an interface
#pragma warning disable CS0246 // The type or namespace name 'Produto' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning disable CS0246 // The type or namespace name 'IServiceBase<>' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning disable CS0246 // The type or namespace name 'Produto' could not be found (are you missing a using directive or an assembly reference?)
        Produto IServiceBase<Produto>.GetById(int Id)
#pragma warning restore CS0246 // The type or namespace name 'Produto' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning restore CS0246 // The type or namespace name 'IServiceBase<>' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning restore CS0246 // The type or namespace name 'Produto' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning restore CS0538 // 'IServiceBase<Produto>' in explicit interface declaration is not an interface
        {
            throw new NotImplementedException();
        }
    }

}
