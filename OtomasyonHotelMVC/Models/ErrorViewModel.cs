using Entity.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OtomasyonHotelMVC.Models
{
    public class ErrorViewModel:NotifyViewModelBase<ErrorMessageObj>
    {
        public ErrorViewModel()
        {
            Title = "Hata !";
        }
    }
}