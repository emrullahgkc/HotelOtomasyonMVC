using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Interfaces.Services
{
   public interface IUsersRolService
    {
        List<PersonelViewModel> PersonelList();
        List<PersonelViewModel> PersonelList(Expression<Func<PersonelViewModel, bool>> predicate);
        IQueryable<TResult> PersonelList<TResult>(Expression<Func<PersonelViewModel, TResult>> select);
        IQueryable<TResult> PersonelList<TResult>(Expression<Func<PersonelViewModel, bool>> predicate, Expression<Func<PersonelViewModel, TResult>> select);
        List<CustomerViewModel> CustomerList();
        List<CustomerViewModel> CustomerList(Expression<Func<CustomerViewModel, bool>> predicate);
        IQueryable<TResult> CustomerList<TResult>(Expression<Func<CustomerViewModel, TResult>> select);
        IQueryable<TResult> CustomerList<TResult>(Expression<Func<CustomerViewModel, bool>> predicate, Expression<Func<CustomerViewModel, TResult>> select);

    }
}
