using System.Data.Entity.ModelConfiguration;
using Verre.Domain.Entities;

namespace Verre.Infra.Data.EntityConfig
{
    public class FabricaConfiguration : EntityTypeConfiguration<Fabrica>
    {
        public FabricaConfiguration()
        {
            HasKey(p => p.FabricaId); 
            

        }       
    }
}
