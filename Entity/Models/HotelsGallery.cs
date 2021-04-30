namespace Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HotelGallery")]
    public partial class HotelsGallery
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [StringLength(500)]
        public string Explanation { get; set; }

        [StringLength(50)]
        public string Photo { get; set; }

        public int? HotelsId { get; set; }
        [Column(TypeName = "date")]

        public DateTime? CreatedOn { get; set; }

        [StringLength(10), DefaultValue("System")]
        public string CreatedUser { get; set; }
        public virtual Hotels Hotels  { get; set; }

    }
}
