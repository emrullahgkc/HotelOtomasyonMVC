using Entity.Models;
using Otomasyon.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Managers
{
  public  class CustomerManager:GenericManager<Customer>,ICustomerService
    {
    }
}
