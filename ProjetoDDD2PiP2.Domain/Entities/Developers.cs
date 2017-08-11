using System;
using System.Collections.Generic;
namespace ProjetoDDD2PiP2.Domain.Entities
{
    public class Developers
    {
        public Developers()
        {
            DeveloperId= Guid.NewGuid().ToString(); 
        }
        public string DeveloperId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Activated { get; set; }
        public virtual ICollection<Solutions> Soluction { get; set; }
        public virtual ICollection<Entidade> Entidade { get; set; }
    }
}
