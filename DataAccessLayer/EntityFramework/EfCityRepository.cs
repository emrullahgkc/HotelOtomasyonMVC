

using Entity.Models;
using Otomasyon.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCityRepository : EfGenericRepository<City>, ICityService
    {
        public EfCityRepository():base()
        {
                
        }

    
    }
}
