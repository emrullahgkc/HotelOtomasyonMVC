namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_kullanici()
        {
            tbl_kul_bnk = new HashSet<tbl_kul_bnk>();
            tbl_kullanicihareket = new HashSet<tbl_kullanicihareket>();
            tbl_kullanicihareket1 = new HashSet<tbl_kullanicihareket>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte id { get; set; }

        [StringLength(20)]
        public string ad { get; set; }

        [StringLength(20)]
        public string soyad { get; set; }

        [StringLength(11)]
        public string tc { get; set; }

        [StringLength(15)]
        public string telefon { get; set; }

        [StringLength(20)]
        public string sifre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_kul_bnk> tbl_kul_bnk { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_kullanicihareket> tbl_kullanicihareket { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_kullanicihareket> tbl_kullanicihareket1 { get; set; }
    }
}
