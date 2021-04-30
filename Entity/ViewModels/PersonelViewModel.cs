using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class PersonelViewModel
    {
        public int PersonelId { get; set; }
        public int PositionId { get; set; }
        public string PositionName { get; set; }
        public decimal Salary { get; set; }
        public int UserRolid { get; set; }
        public string UserRolName { get; set; }
        public string Reference { get; set; }

        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public DateTime shiftStart { get; set; }
        public DateTime shiftEnd { get; set; }
    }
}
