using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Domain.Entities
{
    public class Atividades
    {
        public int AtividadeId { get; set; }
        public string Descricao { get; set; }
        public bool Producao { get; set; }
        public bool TNP { get; set; }
        public bool MotivoParada { get; set; }
        public bool Modelo { get; set; }
        public int GrupoAtividadeId { get; set; }
        public int HorasProgramadasId { get; set; }
        public int ManutencaoAtividadeModeloId { get; set; }
        public int DiarioAtividadeId { get; set; }
        public int RelacionaAtividadesId { get; set; }
        public IEnumerable<Grupo_de_Atividade> Grupo_de_Atividade { get; set; }
        public IEnumerable<Horas_Programadas> Horas_Programadas { get; set; }
        public IEnumerable<Manutencao_Atividade_Modelo> Manutencao_Atividade_Modelo { get; set; }
        public IEnumerable<Diario_de_Atividade> Diario_de_Atividade { get; set; }
        public IEnumerable<Relaciona_Atividades> Relaciona_Atividades { get; set; }

    }
}
