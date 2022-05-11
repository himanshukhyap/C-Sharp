namespace OwnerEmployee.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employeetbl")]
    public partial class Employeetbl
    {
        [Key]
        public int EmpId { get; set; }

        [StringLength(50)]
        public string Fname { get; set; }

        [StringLength(50)]
        public string Lname { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        public int OwnerId { get; set; }
    
        public virtual OwnerTbl OwnerTbl { get; set; }
    }
}
