namespace OwnerEmployee.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OwnerTbl")]
    public partial class OwnerTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OwnerTbl()
        {
           Employeetbls = new HashSet<Employeetbl>();
        }

        [Key]
        public int OwnerId { get; set; }

        [StringLength(50)]
        public string Fname { get; set; }

        [StringLength(50)]
        public string Lname { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //[NotMapped]
        public virtual ICollection<Employeetbl> Employeetbls { get; set; }
        //[NotMapped]
        //public virtual OwnerTbl OwnerTbl1 { get; set; }
        //public virtual OwnerTbl OwnerTbl2 { get; set; }
    }
}
