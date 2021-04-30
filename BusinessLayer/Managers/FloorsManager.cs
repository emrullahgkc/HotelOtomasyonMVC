using DataAccessLayer.Abstrack;
using DataAccessLayer.EntityFramework;
using Entity.Models;
using Otomasyon.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Managers
{
    public class FloorsManager: GenericManager<Floors>, IFloorsService
    {
        EfGenericRepository2<Floors> efFloorsRepository = new EfGenericRepository2<Floors>();
  

    }
}
