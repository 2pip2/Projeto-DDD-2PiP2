using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verre.Domain.Entities
{
    public class ContaViewModel
    {
        public int ContaId { get; set; }
        public string NomeEmpresa { get; set; }
        public string EnderecoCobranca { get; set; }
        public string CNPJ { get; set; }
        public string CEP { get; set; }
        public IEnumerable<Persona> Persona { get; set; }
        public IEnumerable<Encomendas> Encomenda { get; set; }

    }
}
