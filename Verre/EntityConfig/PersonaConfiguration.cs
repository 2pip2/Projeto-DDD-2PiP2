using System.Data.Entity.ModelConfiguration;
using Verre.Domain.Entities;

namespace Verre.Infra.Data.EntityConfig
{
    public class PersonaConfiguration : EntityTypeConfiguration<Persona>
    {
        public PersonaConfiguration()
        {
            HasKey(p => p.PersonaId); 
            Property(p => p.SobreNome)
                .IsRequired()
                .HasMaxLength(150);
            Property(p => p.Telefone)
                .IsRequired();
          

        }       
    }
}
