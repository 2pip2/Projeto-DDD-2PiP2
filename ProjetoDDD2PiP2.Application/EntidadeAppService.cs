
using ProjetoDDD2PiP2.Application.Interface;
using ProjetoDDD2PiP2.Domain.Entities;
using ProjetoDDD2PiP2.Domain.Interface.Service;
using System.Collections.Generic;
using System;

namespace ProjetoDDD2PiP2.Application
{
    
    public class EntidadeAppService: AppServiceBase<Entidade>,IEntidadeAppService
    {
        private readonly IEntidadeService _entidadeService;
        public EntidadeAppService(IEntidadeService entidadeService):base(entidadeService)
        {
            _entidadeService = entidadeService;
        }

        public IEnumerable<Entidade> BuscarporChave(string Chave)
        {
            throw new NotImplementedException();
        }
    }
}
