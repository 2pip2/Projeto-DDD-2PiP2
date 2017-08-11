using ProjetoDDD2PiP2.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ProjetoDDD2PiP2.Domain.Interface.Repositories
{
    public interface IPersonaRepository: IRepositoryBase<Persona>, IDisposable
    {
    }
}
