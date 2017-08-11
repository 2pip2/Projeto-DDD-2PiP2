
using ProjetoDDD2PiP2.Domain.Entities;
using ProjetoDDD2PiP2.Domain.Interface.Repositories;
using ProjetoDDD2PiP2.Domain.Interface.Service;
using System.Collections.Generic;
using System;

namespace ProjetoDDD2PiP2.Domain.Services
{
    public class EntidadeService: ServiceBase<Entidade>,IEntidadeService
    {
        private readonly IEntidadeRepository _entidaderepository;
        public EntidadeService(IEntidadeRepository entidadeRepository):base(entidadeRepository)
        {
            _entidaderepository = entidadeRepository;
        }

        public IEnumerable<Entidade> BuscaPorChave(string Chave)
        {
            return _entidaderepository.BuscarPorKeyWord(Chave);
        }

        public IEnumerable<Entidade> BuscaPorChave(IEnumerable<Entidade> enumerable)
        {
            throw new NotImplementedException();
        }



        //public IEnumerable<Entidade> BuscaPorChave (string Chave)
        //{
        //    return _entidaderepository.BuscarPorKeyWord(Chave);
        //}

    }
}
