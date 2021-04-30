using DataAccessLayer.Abstrack;
using Entity;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfUsersRepository : EfGenericRepository2<Users>, IUsersRepository
    {
      
    }
}
