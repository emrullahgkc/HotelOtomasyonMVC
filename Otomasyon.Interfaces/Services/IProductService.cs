using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Interfaces.Services
{
    public interface IProductService:IGenericServiceIF<Personels>
    {
       
        //IQueryable<TResult> ProductGetAll<TResult>(Expression<Func<ProductViewModel, TResult>>select);
        //IQueryable<TResult> ProductGetAll<TResult>(Expression<Func<ProductViewModel, bool>>predicate,Expression<Func<ProductViewModel, TResult>>select);
        //List<ProductViewModel> ProductList();
        //List<ProductViewModel> ProductList(int id);

        //bool ProductRegister(Product product);
        //bool ProductUpdate(Product product);
    }
}
