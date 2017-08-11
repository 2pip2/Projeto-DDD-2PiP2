using System;
using System.Collections.Generic;
using Verre.Domain.Entities;
using Verre.Domain.Interface.Repositories;

namespace Verre.Infra.Data.Repositories
{
    public class PersonaRepository : RepositoryBase<Persona>, IPersonaRepository
    {
        public IEnumerable<Persona> Clientes(string PalavraChave)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Persona> Lead(string PalavraChave)
        {
            throw new NotImplementedException();
        }
    }
}
