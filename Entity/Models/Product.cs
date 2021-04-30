using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(50)]
        public string ProductPhoto { get; set; }
        [StringLength(200)]
        public string ProductName { get; set; }
        public int? HotelsId { get; set; }
        public virtual Hotels Hotels { get; set; }
        public virtual ProductDetail ProductDetail { get; set; }

    }
}
