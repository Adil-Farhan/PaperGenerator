//------------------------------------------------------------------------------
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
    
    public partial class DB_PAPEREntities : DbContext
    {
        public DB_PAPEREntities()
            : base("name=DB_PAPEREntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DB_CHAPTER> DB_CHAPTER { get; set; }
        public virtual DbSet<DB_LONGQ> DB_LONGQ { get; set; }
        public virtual DbSet<DB_MCQ> DB_MCQ { get; set; }
        public virtual DbSet<DB_SHORTQ> DB_SHORTQ { get; set; }
        public virtual DbSet<DB_SUBJECTs> DB_SUBJECTs { get; set; }
    }
}
