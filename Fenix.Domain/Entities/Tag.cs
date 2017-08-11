using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fenix.Domain.Entities
{
    public class Tag
    {
        public int TagId { get; set; }
        public virtual Maquinas Maquinas { get; set; }

    }
}
