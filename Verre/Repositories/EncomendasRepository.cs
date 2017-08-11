using System;
using System.Collections.Generic;
using Verre.Domain.Entities;
using Verre.Domain.Interface.Repositories;

namespace Verre.Infra.Data.Repositories
{
    public class EncomendasRepository : RepositoryBase<Encomendas>, IEncomendasRepository
    {
        public IEnumerable<Encomendas> PedidosAtrasados(string PalavraChave)
        {
            throw new NotImplementedException();
        }
    }
}
