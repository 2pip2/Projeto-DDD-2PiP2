using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verre.Domain.Entities
{
    public class PersonaViewModel
    {
        public int PersonaId { get; set; }
        public string PrimeiroNome { get; set; }
        public string SobreNome { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string email { get; set; }
        public string Status { get; set; }
    }
}
