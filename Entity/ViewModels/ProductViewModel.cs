using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class ProductViewModel
    {
        [Required]

        public int ProducID { get; set; }
        public string ProductPhoto { get; set; }
        public string ProductNo { get; set; }
        public string ProductBarcode { get; set; }
        public string ProductName { get; set; }
        public string ProductExplanation { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTime CreatedOn { get; set; }
        
        public string CategoryName { get; set; }

        public string HotelName { get; set; }
        public bool IsCampaign { get; set; }
        public int MyProperty { get; set; }

    }
}
