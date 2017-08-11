
using System;
using System.Collections.Generic;

namespace ProjetoDDD2PiP2.Domain.Entities
{
    public class Entidade
    {
        public Entidade()
        {
            EntidadeId= Guid.NewGuid().ToString();
        }
        public string EntidadeId { get; set; }
        public string PalavraChave { get; set; }
        public virtual ICollection<Persona> Persona { get; set; }
        public virtual ICollection<Developers> Developer { get; set; }
    }
} 
