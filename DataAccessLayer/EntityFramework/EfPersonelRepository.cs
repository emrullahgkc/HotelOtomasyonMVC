using DataAccessLayer.Abstrack;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfPersonelRepository : EfGenericRepository2<Personels>, IPersonelRepository
    {
        public EfPersonelRepository() : base()
        {

        }
     
      
        public decimal Max(Expression<Func<Personels, bool>> predicate, Expression<Func<Personels, decimal>> column)
        {
            return context.Set<Personels>().Where(predicate).Max(column);
        }

        public int? Max(Expression<Func<Personels, bool>> predicate, Expression<Func<Personels, int?>> column)
        {
            return context.Set<Personels>().Where(predicate).Max(column);
        }

        public decimal Min(Expression<Func<Personels, bool>> predicate, Expression<Func<Personels, decimal>> column)
        {
            return context.Set<Personels>().Where(predicate).Min(column);
        }

        public int? Min(Expression<Func<Personels, bool>> predicate, Expression<Func<Personels, int?>> column)
        {
            return context.Set<Personels>().Where(predicate).Min(column);
        }
        public decimal Sum(Expression<Func<Personels, bool>> predicate, Expression<Func<Personels, decimal?>> column)
        {
            return context.Set<Personels>().Where(predicate).Sum(column) ?? 0;
        }
    }
}
