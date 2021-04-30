using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{[Table("IdentityCardType")]
   public class IdentityCardType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [Required,StringLength(75)]
        public string IdentityName { get; set; }
        public virtual ICollection<Country> Countries{ get; set; }
    }
}
