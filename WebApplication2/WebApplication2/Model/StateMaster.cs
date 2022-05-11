namespace WebApplication2.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StateMaster")]
    public partial class StateMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StateMaster()
        {
            CityMasters = new HashSet<CityMaster>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? CountryID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CityMaster> CityMasters { get; set; }

        public virtual CountryMaster CountryMaster { get; set; }
    }
}
