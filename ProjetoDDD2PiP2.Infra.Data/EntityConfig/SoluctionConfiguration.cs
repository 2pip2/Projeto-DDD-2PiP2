using ProjetoDDD2PiP2.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoDDD2PiP2.Infra.Data.EntityConfig
{
    public class SoluctionConfiguration : EntityTypeConfiguration<Solutions> 
    {
        public SoluctionConfiguration()
        {
            HasKey(s => s.SolutionId);
            Property(s => s.Soluciton)
                .IsRequired()
                .HasMaxLength(250);
            Property(s => s.Scope)
                .IsRequired()
                .HasMaxLength(500);
            Property(s => s.Price)
                .IsRequired();          
           
            
        }
    }
}
