namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_hareket
    {
        public int id { get; set; }

        [StringLength(6)]
        public string gonderen { get; set; }

        [StringLength(6)]
        public string alici { get; set; }

        public decimal? tutar { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? tarih { get; set; }
    }
}
