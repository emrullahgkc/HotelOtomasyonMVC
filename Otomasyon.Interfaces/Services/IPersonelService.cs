using Entity;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Interfaces.Services
{
    public interface IPersonelService:IGenericServiceIF<Personels>
    {
  
        decimal Max(Expression<Func<Personels, bool>> predicate, Expression<Func<Personels, decimal>> column);
        decimal Min(Expression<Func<Personels, bool>> predicate, Expression<Func<Personels, decimal>> column);
        int? Max(Expression<Func<Personels, bool>> predicate, Expression<Func<Personels, Nullable<int>>>column);
        int? Min(Expression<Func<Personels, bool>> predicate, Expression<Func<Personels, Nullable<int>>>column);
        decimal Sum(Expression<Func<Personels, bool>> predicate, Expression<Func<Personels, Nullable<decimal>>>column);

    }
}
