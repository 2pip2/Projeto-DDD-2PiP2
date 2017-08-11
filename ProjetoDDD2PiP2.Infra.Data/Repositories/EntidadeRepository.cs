using ProjetoDDD2PiP2.Domain.Entities;
using ProjetoDDD2PiP2.Domain.Interface.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoDDD2PiP2.Infra.Data.Repositories
{
    public class EntidadeRepository : RepositoryBase<Entidade>, IEntidadeRepository
    {
        public IEnumerable<Entidade> BuscarPorKeyWord(string KeyWord)
        {
            return Db.Entidade.Where(e => e.PalavraChave == KeyWord);
        }
    }
}
