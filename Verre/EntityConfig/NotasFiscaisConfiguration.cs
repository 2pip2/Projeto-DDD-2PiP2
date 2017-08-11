using System.Data.Entity.ModelConfiguration;
using Verre.Domain.Entities;

namespace Verre.Infra.Data.EntityConfig
{
    public class NotasFiscaisConfiguration : EntityTypeConfiguration<NotasFiscais>
    {
        public NotasFiscaisConfiguration()
        {
            HasKey(p => p.NotaFiscalId);
            Property(p => p.Numero)
                .IsRequired();
            Property(p => p.DataFaturamento)
                .IsRequired();
            Property(p => p.Chave)
                  .IsRequired();

        }       
    }
}
