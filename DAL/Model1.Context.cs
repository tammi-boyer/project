﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ticketsEntities : DbContext
    {
        public ticketsEntities()
            : base("name=ticketsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<subcategory> subcategories { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
