using ProjetoDDD2PiP2.Domain.Entities;
using ProjetoDDD2PiP2.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
namespace ProjetoDDD2PiP2.Infra.Data.Context
{
    public class TwoPiPtoContext : DbContext
    {
        public TwoPiPtoContext()  :base("ProjetoDDD2PiP2Azure")
        {

        }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Entidade> Entidade { get; set; }
        public DbSet<Solutions> Soluctions { get; set; }
        public DbSet<Developers> Developers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Properties()
                .Where(p => p.Name==p.ReflectedType.Name+"Id")
                .Configure(p=>p.IsKey());
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("nvarchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(128));
            modelBuilder.Configurations.Add(new PersonaConfiguration());
            modelBuilder.Configurations.Add(new EntidadeConfiguration());
            modelBuilder.Configurations.Add(new SoluctionConfiguration());
            modelBuilder.Configurations.Add(new DeveloperConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreateDate") !=null))
            {
                if (entry.State==EntityState.Added)
                {
                    entry.Property("CreateDate").CurrentValue = DateTime.Now;
                }
                if (entry.State==EntityState.Modified)
                {
                    entry.Property("CreateDate").IsModified = false;
                }
            }
            return base.SaveChanges();
        }

       // public System.Data.Entity.DbSet<SolutionViewModel> SoluctionViewModels { get; set; }
       //       public System.Data.Entity.DbSet<PersonaViewModel> PersonaViewModels { get; set; }
    }
}
