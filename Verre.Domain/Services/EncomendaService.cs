
using System.Collections.Generic;
using System;
using Verre.Domain.Entities;
using Verre.Domain.Interface.Service;
using Verre.Domain.Interface.Repositories;

namespace Verre.Domain.Services
{
    public class EncomendaService: ServiceBase<Encomendas>,IEncomendaService
    {
        private readonly IEncomendasRepository _encomendarepository;
        public EncomendaService(IEncomendasRepository encomendaRepository):base(encomendaRepository)
        {
            _encomendarepository = encomendaRepository;
        }

        public IEnumerable<Encomendas> PedidosAtrasados(string Chave)
        {
            throw new NotImplementedException();
        }
    }
}
