using ProjetoDDD2PiP2.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
namespace ProjetoDDD2PiP2.Infra.Data.EntityConfig

{
    public class PersonaConfiguration : EntityTypeConfiguration<Persona>
    {
        public PersonaConfiguration()
        {
            HasKey(p => p.Id); 
            Property(p => p.Id)
                .IsRequired()
                .HasMaxLength(128);
            Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(256);
            Property(p => p.UserName)
                .IsRequired()
                .HasMaxLength(256);
            ToTable("AspNetUsers");
        }       
    }
}
