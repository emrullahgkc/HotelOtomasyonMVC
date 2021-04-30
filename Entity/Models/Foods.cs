using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    [Table("Foods")]

    public class Foods
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [StringLength(50)]
        public string FoodPhoto { get; set; }
        [StringLength(200)]
        public string  FoodName{ get; set; }
        public int? HotelsId { get; set; }
        public virtual FoodsDetail FoodsDetail { get; set; }

        public virtual Hotels Hotels { get; set; }
    }
}
