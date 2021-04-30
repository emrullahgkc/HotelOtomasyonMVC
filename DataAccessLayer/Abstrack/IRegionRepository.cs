using Entity;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstrack
{
   public interface IRegionRepository:IGenericRepository<Region>
    {
        Region RegionRegister(Region entity);


    }
}
