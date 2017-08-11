using System.Collections.Generic;
using Verre.Domain.Entities;

namespace Verre.Domain.Interface.Repositories
{
    public interface IEncomendasRepository: IRepositoryBase<Encomendas>
    {
        IEnumerable<Encomendas> PedidosAtrasados(string PalavraChave);
    }
}
