using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    [Table("Floors")]
    public class Floors
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [Required, StringLength(5)]
        public string FloorsNo { get; set; }
        [Required, StringLength(30)]
        public string FloorsName { get; set; }

        public int? HotelsId { get; set; }
        [Column(TypeName = "date")]

        public DateTime CreatedOn { get; set; }

        [StringLength(10), DefaultValue("System")]
        public string CreatedUser { get; set; }
        public virtual Hotels Hotels { get; set; }
    }
}
