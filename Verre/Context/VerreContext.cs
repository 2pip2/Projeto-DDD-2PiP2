using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Verre.Domain.Entities;
using Verre.Infra.Data.EntityConfig;

namespace Verre.Infra.Data.Context
{
    public class VerreContext : DbContext
    {
        public VerreContext()  :base("Verre")
        {

        }

        public DbSet<Persona> Persona { get; set; }
        public DbSet<Conta> Conta { get; set; }
        public DbSet<Encomendas> Encomendas { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Fabrica> Fabrica { get; set; }
        public DbSet<TransformacaoProduto> TransformacaoProduto { get; set; }
        public DbSet<NotasFiscais> NotasFiscais { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Properties()
                .Where(p => p.Name==p.ReflectedType.Name+"Id")
                .Configure(p=>p.IsKey());
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));
            modelBuilder.Configurations.Add(new PersonaConfiguration());
            modelBuilder.Configurations.Add(new ContaConfiguration());
            modelBuilder.Configurations.Add(new EncomendaConfiguration());
            modelBuilder.Configurations.Add(new FabricaConfiguration());
            modelBuilder.Configurations.Add(new NotasFiscaisConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
            
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
    }
}
