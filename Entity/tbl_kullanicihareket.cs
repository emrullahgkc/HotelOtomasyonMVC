namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_kullanicihareket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte id { get; set; }

        public byte? alici_klnciid { get; set; }

        public byte? alici_bnkid { get; set; }

        [StringLength(5)]
        public string harekettur { get; set; }

        public decimal miktar { get; set; }

        public byte? gon_klncid { get; set; }

        public byte? gon_bnkid { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? tarih { get; set; }

        public virtual tbl_kul_bnk tbl_kul_bnk { get; set; }

        public virtual tbl_kullanici tbl_kullanici { get; set; }

        public virtual tbl_kullanici tbl_kullanici1 { get; set; }
    }
}
