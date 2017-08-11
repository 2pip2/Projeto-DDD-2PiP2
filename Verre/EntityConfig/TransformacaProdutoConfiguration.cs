using System.Data.Entity.ModelConfiguration;
using Verre.Domain.Entities;

namespace Verre.Infra.Data.EntityConfig
{
    public class TransformacaoProdutoConfiguration : EntityTypeConfiguration<TransformacaoProduto>
    {
        public TransformacaoProdutoConfiguration()
        {
            HasKey(p => p.TransformacaoProdutoId); 
            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);
            

        }       
    }
}
