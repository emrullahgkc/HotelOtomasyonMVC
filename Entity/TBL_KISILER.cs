namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_KISILER
    {
        public short id { get; set; }

        [StringLength(20)]
        public string ad { get; set; }

        [StringLength(20)]
        public string soyad { get; set; }

        [StringLength(11)]
        public string tc { get; set; }

        [StringLength(15)]
        public string tlf { get; set; }

        [StringLength(6)]
        public string hesap_no { get; set; }

        [StringLength(10)]
        public string sifre { get; set; }
    }
}
