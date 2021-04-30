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
   public interface IProductRepository:IGenericRepository<Personels>
    {
        //IQueryable<TResult> ProductGetAll<TResult>(Expression<Func<ProductViewModel, TResult>> select);
        //IQueryable<TResult> ProductGetAll<TResult>(Expression<Func<ProductViewModel, bool>> predicate, Expression<Func<ProductViewModel, TResult>> select);
        //List<ProductViewModel> ProductList();
        //List<ProductViewModel> ProductList(int id);
        
        //bool ProductRegister(Product product);
        //bool ProductUpdate(Product product);
    }
}
