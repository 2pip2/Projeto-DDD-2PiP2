using System.Collections.Generic;

namespace Verre.Domain.Entities
{
    public class Conta
    {
        public int ContaId { get; set; }
        public string NomeEmpresa { get; set; }
        public string EnderecoCobranca { get; set; }
        public string CNPJ { get; set; }
        public string CEP { get; set; }
        public string Telefone { get; set; }
        public IEnumerable<Persona> Persona { get; set; }
        public IEnumerable<Encomendas> Encomenda { get; set; }

    }
}
