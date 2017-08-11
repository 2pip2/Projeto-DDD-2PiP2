using System.Data.Entity.ModelConfiguration;
using Verre.Domain.Entities;

namespace Verre.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.ProdutoId); 
            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);
            Property(p => p.Valor)
                .IsRequired();          

        }       
    }
}
