namespace ProjetoDDD2PiP2.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Developers",
            //    c => new
            //        {
            //            DeveloperId = c.String(nullable: false, maxLength: 128),
            //            FirstName = c.String(maxLength: 128),
            //            LastName = c.String(nullable: false, maxLength: 150),
            //            Name = c.String(maxLength: 128),
            //            email = c.String(maxLength: 128),
            //            CreateDate = c.DateTime(nullable: false),
            //            Activated = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.DeveloperId);
            
            //CreateTable(
            //    "dbo.Entidade",
            //    c => new
            //        {
            //            EntidadeId = c.String(nullable: false, maxLength: 128),
            //            PalavraChave = c.String(nullable: false, maxLength: 250),
            //        })
            //    .PrimaryKey(t => t.EntidadeId);
            
            //CreateTable(
            //    "dbo.AspNetUsers",
            //    c => new
            //        {
            //            Id = c.String(nullable: false, maxLength: 128),
            //            Email = c.String(nullable: false, maxLength: 256),
            //            EmailConfirmed = c.Boolean(nullable: false),
            //            PasswordHash = c.String(maxLength: 128),
            //            SecurityStamp = c.String(maxLength: 128),
            //            PhoneNumber = c.String(maxLength: 128),
            //            PhoneNumberConfirmed = c.Boolean(nullable: false),
            //            TwoFactorEnabled = c.Boolean(nullable: false),
            //            LockoutEndDateUtc = c.DateTime(),
            //            LockoutEnabled = c.Boolean(nullable: false),
            //            AccessFailedCount = c.Int(nullable: false),
            //            UserName = c.String(nullable: false, maxLength: 256),
            ////        })
            ////    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.Solutions",
            //    c => new
            //        {
            //            SolutionId = c.String(nullable: false, maxLength: 128),
            //            Soluciton = c.String(nullable: false, maxLength: 250),
            //            Scope = c.String(nullable: false, maxLength: 500),
            //            Price = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            Activate = c.Boolean(nullable: false),
            //            url = c.String(maxLength: 128),
            //            Image = c.Binary(),
            //        })
            //    .PrimaryKey(t => t.SolutionId);
            
            //CreateTable(
            //    "dbo.EntidadeDevelopers",
            //    c => new
            //        {
            //            Entidade_EntidadeId = c.String(nullable: false, maxLength: 128),
            //            Developers_DeveloperId = c.String(nullable: false, maxLength: 128),
            //        })
            //    .PrimaryKey(t => new { t.Entidade_EntidadeId, t.Developers_DeveloperId })
            //    .ForeignKey("dbo.Entidade", t => t.Entidade_EntidadeId)
            //    .ForeignKey("dbo.Developers", t => t.Developers_DeveloperId)
            //    .Index(t => t.Entidade_EntidadeId)
            //    .Index(t => t.Developers_DeveloperId);
            
            CreateTable(
                "dbo.PersonaEntidade",
                c => new
                    {
                        Persona_Id = c.String(nullable: false, maxLength: 128),
                        Entidade_EntidadeId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Persona_Id, t.Entidade_EntidadeId })
                .ForeignKey("dbo.AspNetUsers", t => t.Persona_Id)
                .ForeignKey("dbo.Entidade", t => t.Entidade_EntidadeId)
                .Index(t => t.Persona_Id)
                .Index(t => t.Entidade_EntidadeId);
            
            //CreateTable(
            //    "dbo.SolutionsDevelopers",
            //    c => new
            //        {
            //            Solutions_SolutionId = c.String(nullable: false, maxLength: 128),
            //            Developers_DeveloperId = c.String(nullable: false, maxLength: 128),
            //        })
            //    .PrimaryKey(t => new { t.Solutions_SolutionId, t.Developers_DeveloperId })
            //    .ForeignKey("dbo.Solutions", t => t.Solutions_SolutionId)
            //    .ForeignKey("dbo.Developers", t => t.Developers_DeveloperId)
            //    .Index(t => t.Solutions_SolutionId)
            //    .Index(t => t.Developers_DeveloperId);
            
            CreateTable(
                "dbo.SolutionsPersona",
                c => new
                    {
                        Solutions_SolutionId = c.String(nullable: false, maxLength: 128),
                        Persona_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Solutions_SolutionId, t.Persona_Id })
                .ForeignKey("dbo.Solutions", t => t.Solutions_SolutionId)
                .ForeignKey("dbo.AspNetUsers", t => t.Persona_Id)
                .Index(t => t.Solutions_SolutionId)
                .Index(t => t.Persona_Id);
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.SolutionsPersona", "Persona_Id", "dbo.AspNetUsers");
            //DropForeignKey("dbo.SolutionsPersona", "Solutions_SolutionId", "dbo.Solutions");
            //DropForeignKey("dbo.SolutionsDevelopers", "Developers_DeveloperId", "dbo.Developers");
            //DropForeignKey("dbo.SolutionsDevelopers", "Solutions_SolutionId", "dbo.Solutions");
            //DropForeignKey("dbo.PersonaEntidade", "Entidade_EntidadeId", "dbo.Entidade");
            //DropForeignKey("dbo.PersonaEntidade", "Persona_Id", "dbo.AspNetUsers");
            //DropForeignKey("dbo.EntidadeDevelopers", "Developers_DeveloperId", "dbo.Developers");
            //DropForeignKey("dbo.EntidadeDevelopers", "Entidade_EntidadeId", "dbo.Entidade");
            //DropIndex("dbo.SolutionsPersona", new[] { "Persona_Id" });
            //DropIndex("dbo.SolutionsPersona", new[] { "Solutions_SolutionId" });
            //DropIndex("dbo.SolutionsDevelopers", new[] { "Developers_DeveloperId" });
            //DropIndex("dbo.SolutionsDevelopers", new[] { "Solutions_SolutionId" });
            //DropIndex("dbo.PersonaEntidade", new[] { "Entidade_EntidadeId" });
            //DropIndex("dbo.PersonaEntidade", new[] { "Persona_Id" });
            //DropIndex("dbo.EntidadeDevelopers", new[] { "Developers_DeveloperId" });
            //DropIndex("dbo.EntidadeDevelopers", new[] { "Entidade_EntidadeId" });
            //DropTable("dbo.SolutionsPersona");
            //DropTable("dbo.SolutionsDevelopers");
            //DropTable("dbo.PersonaEntidade");
            //DropTable("dbo.EntidadeDevelopers");
            //DropTable("dbo.Solutions");
            //DropTable("dbo.AspNetUsers");
            //DropTable("dbo.Entidade");
            //DropTable("dbo.Developers");
        }
    }
}
