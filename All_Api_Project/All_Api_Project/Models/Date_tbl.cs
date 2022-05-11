namespace All_Api_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Date_tbl
    {
        [Key]
        public int DateId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? OnlyDate { get; set; }

        public TimeSpan? OnlyTime { get; set; }

        public DateTime? OnlyDateTime { get; set; }

        public int? Year { get; set; }

        public int? Month { get; set; }

        [StringLength(50)]
        public string MonthName { get; set; }

        [StringLength(50)]
        public string day { get; set; }
    }
}
