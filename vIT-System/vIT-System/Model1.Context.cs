﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vIT_System
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class vITsEntities1 : DbContext
    {
        public vITsEntities1()
            : base("name=vITsEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ansokan> Ansokan { get; set; }
        public virtual DbSet<Anstallda> Anstallda { get; set; }
        public virtual DbSet<Fardmedel> Fardmedel { get; set; }
        public virtual DbSet<Forskott> Forskott { get; set; }
        public virtual DbSet<Traktamente> Traktamente { get; set; }
        public virtual DbSet<Uppehall> Uppehall { get; set; }
        public virtual DbSet<Utgifter> Utgifter { get; set; }
    }
}
