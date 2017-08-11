using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Domain.Entities
{
    public class Area_de_Trabalho
    {
        public int AreaId { get; set; }
        public string AreaTrabaho { get; set; }
        public int FuncionarioId { get; set; }
        public IEnumerable<Funcionarios> Funcionarios { get; set; }

    }
}
