using ProjetoDDD2PiP2.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDDD2PiP2.Domain.Interface.Repositories
{
    public interface IEntidadeRepository: IRepositoryBase<Entidade>
    {
        IEnumerable<Entidade> BuscarPorKeyWord(string PalavraChave);
    }
}
