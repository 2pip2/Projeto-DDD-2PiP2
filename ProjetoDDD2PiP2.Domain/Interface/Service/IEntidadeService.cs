using ProjetoDDD2PiP2.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDDD2PiP2.Domain.Interface.Service
{
    public interface IEntidadeService: IServiceBase<Entidade>
    {
        IEnumerable<Entidade> BuscaPorChave(string Chave);
        IEnumerable<Entidade> BuscaPorChave(IEnumerable<Entidade> enumerable);
    }
}
