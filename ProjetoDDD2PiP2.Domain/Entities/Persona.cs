﻿using System;
using System.Collections.Generic;

namespace ProjetoDDD2PiP2.Domain.Entities
{
    public class Persona
    {
        public Persona()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public virtual string Email { get; set; }
        public virtual bool EmailConfirmed { get; set; }
        public virtual string PasswordHash { get; set; }
        public virtual string SecurityStamp { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual bool PhoneNumberConfirmed { get; set; }
        public virtual bool TwoFactorEnabled { get; set; }
        public virtual DateTime? LockoutEndDateUtc { get; set; }
        public virtual bool LockoutEnabled { get; set; }
        public virtual int AccessFailedCount { get; set; }
        public virtual string UserName { get; set; }
        public virtual ICollection<Entidade> Entidade { get; set; }
        public virtual ICollection<Solutions> Soluction { get; set; }
    }
}
