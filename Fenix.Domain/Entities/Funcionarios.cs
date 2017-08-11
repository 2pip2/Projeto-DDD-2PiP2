using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Domain.Entities
{
    public class Funcionarios
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public int ConsumoLubrificanteId { get; set; }
        public int DiarioAtividadeId { get; set; }
        public int OrdemServicoId { get; set; }
        public IEnumerable<Consumo_Lubrificante> Consumo_Lubrificante { get; set; }
        public IEnumerable<Diario_de_Atividade> Diario_de_Atividade { get; set; }
        public IEnumerable<Ordem_de_Servico> Ordem_de_Servico { get; set; }


    }
}
