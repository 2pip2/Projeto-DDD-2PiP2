using System;
using Microsoft.AspNet.Identity.EntityFramework;
using Portal.Infra.CrossCutting.Identity.Model;

namespace Portal.Infra.CrossCutting.Identity.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDisposable
    {
        public ApplicationDbContext()
            : base("ProjetoDDD2PiP2Azure", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}