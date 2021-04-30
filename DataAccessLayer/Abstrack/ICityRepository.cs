using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstrack
{
   public interface ICityRepository:IGenericRepository<City>
    {
      
        int Count(Expression<Func<City, bool>> predicate);



    }
}
