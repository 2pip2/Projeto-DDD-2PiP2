using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brauna.Domain.Entities
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string PrimeiroNome { get; set; }
        public string SobreNome { get; set; }
        public string Empresa { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string CEP { get; set; }
        public string email { get; set; }


    }
}
