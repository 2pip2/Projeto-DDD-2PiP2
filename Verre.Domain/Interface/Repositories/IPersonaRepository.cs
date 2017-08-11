

using System.Collections.Generic;
using Verre.Domain.Entities;

namespace Verre.Domain.Interface.Repositories
{
    public interface IPersonaRepository: IRepositoryBase<Persona>
    {
        IEnumerable<Persona> Lead(string PalavraChave);
        IEnumerable<Persona> Clientes(string PalavraChave);
    }
}
