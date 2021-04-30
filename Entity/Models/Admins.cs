using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    [Table("Admins")]
    public class Admins
    {
        [ForeignKey("Users")]
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int AdminId { get; set; }
        public Guid Guid { get; set; }
        public virtual Users Users { get; set; }

    }
}
