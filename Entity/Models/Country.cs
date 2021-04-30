using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    [Table("Country")]

    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [Required, StringLength(50)]
        public string CountryName { get; set; }
        [StringLength(70)]
        public string Flag { get; set; }
        [StringLength(50)]
        public string CurrencyUnit { get; set; }
        [StringLength(50)]
        public string NativeLanguage { get; set; }
        public int? IdentityCardTypeId { get; set; }
        public virtual IdentityCardType IdentityCardType { get; set; }
        public virtual ICollection<Region> Region { get; set; }
        public virtual ICollection<Hotels> Hotels { get; set; }

    }
}
