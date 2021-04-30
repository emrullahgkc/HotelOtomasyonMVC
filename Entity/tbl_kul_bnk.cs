namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_kul_bnk
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_kul_bnk()
        {
            tbl_kullanicihareket = new HashSet<tbl_kullanicihareket>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte id { get; set; }

        public byte? kullaniciid { get; set; }

        public byte? bankaid { get; set; }

        [StringLength(7)]
        public string iban { get; set; }

        [StringLength(5)]
        public string hesapno { get; set; }

        public virtual tbl_Banka tbl_Banka { get; set; }

        public virtual tbl_kullanici tbl_kullanici { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_kullanicihareket> tbl_kullanicihareket { get; set; }
    }
}
