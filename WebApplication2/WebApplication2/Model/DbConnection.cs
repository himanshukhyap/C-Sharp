using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication2.Model
{
    public partial class DbConnection : DbContext
    {
        public DbConnection()
            : base("name=DbConnection")
        {
        }

        public virtual DbSet<CityMaster> CityMasters { get; set; }
        public virtual DbSet<CountryMaster> CountryMasters { get; set; }
        public virtual DbSet<StateMaster> StateMasters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CountryMaster>()
                .Property(e => e.CountryCode)
                .IsUnicode(false);

            modelBuilder.Entity<CountryMaster>()
                .HasMany(e => e.StateMasters)
                .WithOptional(e => e.CountryMaster)
                .HasForeignKey(e => e.CountryID);

            modelBuilder.Entity<StateMaster>()
                .HasMany(e => e.CityMasters)
                .WithOptional(e => e.StateMaster)
                .HasForeignKey(e => e.StateID);
        }
    }
}
