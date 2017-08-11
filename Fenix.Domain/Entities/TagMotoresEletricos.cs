using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Domain.Entities
{
    public class TagMotoresEletricos
    {
        public int TagMotorEletricoId { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool StatusMotor { get; set; }
        public int TagId { get; set; }
        public IEnumerable<Tag> TagEquipamento { get; set; }
        public int LocalManutencaoId { get; set; }
        public IEnumerable<Local_Manutecao> Local_Manutecao { get; set; }
        public string LocacaoEstoque { get; set; }
        public int FabricanteId { get; set; }
        public IEnumerable<Fabricante> Fabricante { get; set; }
        public int CarcacaId { get; set; }
        public IEnumerable<Carcaca> Carcaca { get; set; }
        public int NumeroFabrica { get; set; }
        public int NumeroPolos { get; set; }
        public int Isolacao { get; set; }
        public int CategoriaId { get; set; }
        public IEnumerable<Categoria> Categorias { get; set; }
        public int IP_IN { get; set; }
        public int CosAlfa { get; set; }
        public int Rotacao { get; set; }
        public int Frequencia { get; set; }
        public int IP { get; set; }
        public int F5 { get; set; }
        public int Peso { get; set; }
        public int Rendimento { get; set; }
        public int Tensao1 { get; set; }
        public int Tensao2 { get; set; }
        public int Tensao3 { get; set; }
        public int Tensao4 { get; set; }
        public int Corrente1 { get; set; }
        public int Corrente2 { get; set; }
        public int Corrente3 { get; set; }
        public int Corrente4 { get; set; }
        public int Aterramento { get; set; }
        public int RolamentoLAId { get; set; }
        public int RolamentoLOAId { get; set; }
        public IEnumerable<Rolamento> RolamentoLA { get; set; }
        public IEnumerable<Rolamento> RolamentoLOA { get; set; }
        public int GraxaId { get; set; }
        public IEnumerable<Graxa> Graxa { get; set; }
        public int Potencia { get; set; }
        public int UnidadePotencia { get; set; }
        public int Alimentacao { get; set; }
        public int Freio { get; set; }
        public int VentilacaoForcada { get; set; }
        public bool Ativo { get; set; }



    }
}
