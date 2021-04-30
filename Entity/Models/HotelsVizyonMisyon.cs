namespace Entity.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HotelsVizyonMisyon")]
    public partial class HotelsVizyonMisyon
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        public int? HotelsId { get; set; }

        public string Vizyon { get; set; }

        public string Misyon { get; set; }
        public virtual Hotels Hotels { get; set; }

    }
}
