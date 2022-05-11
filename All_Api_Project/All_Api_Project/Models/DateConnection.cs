using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace All_Api_Project.Models
{
    public partial class DateConnection : DbContext
    {
        public DateConnection()
            : base("name=DateConnection")
        {
        }

        public virtual DbSet<Date_tbl> Date_tbl { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
