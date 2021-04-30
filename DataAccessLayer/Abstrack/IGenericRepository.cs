using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstrack
{
    public interface IGenericRepository<T>:IDisposable where T:class
    {
        T Add(T entity);
        List<T> ListAll();
        T List(int id);
        List<T> ListAll(Expression<Func<T, bool>> predicate);
        T Update(T entity);
        bool Remove(int id);
        bool Remove(T entity);
        T Find(int id);
        IQueryable<TResult> ListAll<TResult>(Expression<Func<T, TResult>> select);
        IQueryable<TResult> ListAll<TResult>(Expression<Func<T, bool>> predicate, Expression<Func<T, TResult>> select);
    }
}
