using System;
using System.Collections.Generic;

namespace ProjetoDDD2PiP2.Domain.Entities
{
    public class Solutions
    {
        //Trata-se da solução criada e disponível ou não para uso
        public Solutions()
        {
            SolutionId= Guid.NewGuid().ToString();
        }
        public string SolutionId { get; set; }
        public string Soluciton { get; set; }
        public string Scope { get; set; }
        public decimal Price { get; set; }
        public bool Activate { get; set; }
        public string url { get; set; }
        public byte[] Image { get; set; }
        public virtual ICollection<Persona> Persona { get; set; }
        public virtual ICollection<Developers> Developer { get; set; }
    }
}
