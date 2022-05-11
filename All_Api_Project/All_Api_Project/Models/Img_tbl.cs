namespace All_Api_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    public partial class Img_tbl
    {
        [Key]
        public int ImgId { get; set; }

        public double? Width { get; set; }

        public double? Height { get; set; }

        [StringLength(500)]
        public string Path { get; set; }

        [StringLength(50)]
        public string Format { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        [NotMapped]
        public HttpPostedFileBase FileName { get; set; }
        
        public DateTime? Date_Created { get; set; }

        public DateTime? Date_Modifield { get; set; }
    }
}
