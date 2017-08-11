using System.Data.Entity.ModelConfiguration;
using Verre.Domain.Entities;

namespace Verre.Infra.Data.EntityConfig
{
    public class EncomendaConfiguration : EntityTypeConfiguration<Encomendas>
    {
        public EncomendaConfiguration()
        {
            HasKey(p => p.EncomendaId); 
            Property(p => p.DataPrevisaoEntrega)
                .IsRequired();
            Property(p => p.NumeroEncomenda)
                .IsRequired();
          

        }       
    }
}
