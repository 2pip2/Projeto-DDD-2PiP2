using ProjetoDDD2PiP2.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace ProjetoDDD2PiP2.Infra.Data.EntityConfig
{
    public class DeveloperConfiguration : EntityTypeConfiguration<Developers>
    {
        public DeveloperConfiguration()
        {
            HasKey(d => d.DeveloperId);
            Property(d => d.LastName)
                .IsRequired()
                .HasMaxLength(150);
          

        }

    }
}
