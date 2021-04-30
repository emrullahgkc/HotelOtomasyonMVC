using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstrack
{
   public interface ICountryRepository:IGenericRepository<Country>
    {
        Country RegisterCountry(Country entity);
        Country UpdateCountry(Country entity);
        bool RemoveCountry(int id);
        bool RemoveCountry(Country entity);
    }
}
