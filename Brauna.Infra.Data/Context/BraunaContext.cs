using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brauna.Infra.Data.Context
{
    public class BraunaContext: DbContext
    {
        public BraunaContext():base("Brauna")
        {

        }
    }
}
