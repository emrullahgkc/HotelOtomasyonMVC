using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Interfaces.Services
{
   public interface IGenericServiceIF<T>:IDisposable where T:class
    {
        T Add(T entity);
        List<T> ListAll();
        List<T> ListAll(Expression<Func<T, bool>> predicate);
        T Update(T entity);
        bool Remove(int id);
        bool Remove(T entity);
         int Insert(T obj);
        object Updates(T obj);
        int Delete(T obj);
        T List(int id);
        //T Find(int id);
        T Find(Expression<Func<T,bool>>where);
        int Count(Expression<Func<T, bool>> predicate);

        IQueryable<TResult> ListAll<TResult>(Expression<Func<T, TResult>> select);
        IQueryable<TResult> ListAll<TResult>(Expression<Func<T, bool>> predicate, Expression<Func<T, TResult>> select);
    }
}
