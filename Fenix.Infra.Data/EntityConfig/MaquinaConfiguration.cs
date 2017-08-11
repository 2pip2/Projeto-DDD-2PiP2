using Fenix.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD2PiP2.Infra.Data.EntityConfig.Fenix
{
    public class MaquinaConfiguration: EntityTypeConfiguration<Maquinas>
    {
        public MaquinaConfiguration()
        {
            HasKey(m => m.MaquinasId);
            Property(m => m.TAG)
                .IsRequired()
                .HasMaxLength(250);            
            HasRequired(m => m.Tag)
                    .WithMany()
                    .HasForeignKey(m => m.TagId);
        }
    }
}
