using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace All_Api_Project.Models
{
    public partial class ImgDataConnection : DbContext
    {
        public ImgDataConnection()
            : base("name=ImgDataConnection")
        {
        }

        public virtual DbSet<Img_tbl> Img_tbl { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
