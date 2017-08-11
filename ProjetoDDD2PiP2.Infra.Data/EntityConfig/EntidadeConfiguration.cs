using ProjetoDDD2PiP2.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoDDD2PiP2.Infra.Data.EntityConfig
{
    public class EntidadeConfiguration : EntityTypeConfiguration<Entidade>
    {
        public EntidadeConfiguration()
        {
            HasKey(e => e.EntidadeId);
            Property(e=> e.PalavraChave)
                .IsRequired()
                .HasMaxLength(250);            
        }
    }
}
