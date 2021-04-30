using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ValueObjects
{
   public  class RegionRegViewModel
    {
        [
             DisplayName("Bölge Adı"),
             Required(ErrorMessage = " {0} alanı Boş Geçilemez."),
             StringLength(100, ErrorMessage = "{0} Max.{1} Karakteri Olmalı")
             ]
        public string RegionName { get; set; }

    }
}
