using DataAccessLayer.Abstrack;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    class EfFloorsRepository:EfGenericRepository2<Floors>,IFloorsRepository
    {

      
    }
}
