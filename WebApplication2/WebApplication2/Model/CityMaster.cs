namespace WebApplication2.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CityMaster")]
    public partial class CityMaster
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? StateID { get; set; }

        public virtual StateMaster StateMaster { get; set; }
    }
}
