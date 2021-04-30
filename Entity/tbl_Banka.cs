namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Banka
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Banka()
        {
            tbl_kul_bnk = new HashSet<tbl_kul_bnk>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte id { get; set; }

        [StringLength(50)]
        public string bankaad { get; set; }

        [StringLength(20)]
        public string bankakod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_kul_bnk> tbl_kul_bnk { get; set; }
    }
}
