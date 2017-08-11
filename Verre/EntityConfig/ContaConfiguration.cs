using System.Data.Entity.ModelConfiguration;
using Verre.Domain.Entities;

namespace Verre.Infra.Data.EntityConfig
{
    public class ContaConfiguration : EntityTypeConfiguration<Conta>
    {
        public ContaConfiguration()
        {
            HasKey(p => p.ContaId); 
            Property(p => p.NomeEmpresa)
                .IsRequired()
                .HasMaxLength(150);
            Property(p => p.EnderecoCobranca)
                .IsRequired();
          

        }       
    }
}
