using DataAccessLayer.Abstrack;
using DataAccessLayer.EntityFramework;
using Entity.Models;
using Otomasyon.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Managers
{
   public class PersonelManager:GenericManager<Personels>,IPersonelService
    {



        EfPersonelRepository efPersonelRepository = new EfPersonelRepository();

     

  


        public decimal Max(Expression<Func<Personels, bool>> predicate, Expression<Func<Personels, decimal>> column)
        {
            return efPersonelRepository.Max(predicate, column);
        }

        public int? Max(Expression<Func<Personels, bool>> predicate, Expression<Func<Personels, int?>> column)
        {
            return efPersonelRepository.Max(predicate, column);
        }

        public decimal Min(Expression<Func<Personels, bool>> predicate, Expression<Func<Personels, decimal>> column)
        {
            return efPersonelRepository.Min(predicate, column);
        }

        public int? Min(Expression<Func<Personels, bool>> predicate, Expression<Func<Personels, int?>> column)
        {
            return efPersonelRepository.Min(predicate, column);
        }

        public decimal Sum(Expression<Func<Personels, bool>> predicate, Expression<Func<Personels, decimal?>> column)
        {
            return efPersonelRepository.Sum(predicate, column);
        }
    }
}
