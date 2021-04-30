using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class CustomerViewModel
    {
        public int ClientID { get; set; }
        public int RoomId { get; set; }
        public string RoomNo { get; set; }
        public int UserRolid { get; set; }
        public string UserRolName { get; set; }
        public bool? IsWebRegister { get; set; }
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public  DateTime entryDate { get; set; }
        public DateTime leavingDate { get; set; }
       

    }
}
