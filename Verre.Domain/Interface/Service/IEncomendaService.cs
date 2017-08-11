using System.Collections.Generic;
using Verre.Domain.Entities;

namespace Verre.Domain.Interface.Service
{
    public interface IEncomendaService: IServiceBase<Encomendas>
    {
        IEnumerable<Encomendas> PedidosAtrasados(string Chave);
     
    }
}
