using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace OwnerEmployee.Models
{
    public partial class OwnerEmpConnection : DbContext
    {
        public OwnerEmpConnection()
            : base("name=OwnerEmpConnection")
        {
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.LazyLoadingEnabled = true;
        }

        public virtual DbSet<Employeetbl> Employeetbls { get; set; }
        public virtual DbSet<OwnerTbl> OwnerTbls { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OwnerTbl>()
                .HasMany(e => e.Employeetbls)
                .WithRequired(e => e.OwnerTbl)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<OwnerTbl>()
            //    .HasOptional(e => e.OwnerTbl1)
            //    .WithRequired(e => e.OwnerTbl2);
        }
    }
}
