﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hranitel.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HranitelPROEntities : DbContext
    {
        private static HranitelPROEntities _context;
        public HranitelPROEntities()
            : base("name=HranitelPROEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        public static HranitelPROEntities getContext()
        {
            if (_context == null )
            {
                _context = new HranitelPROEntities();
               
            }
            return _context;
        }
    
        public virtual DbSet<CelPos> CelPos { get; set; }
        public virtual DbSet<DefUser> DefUsers { get; set; }
        public virtual DbSet<InformationAboutTourist> InformationAboutTourists { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TypeZayavk> TypeZayavks { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Zayavki> Zayavkis { get; set; }
    }
}
