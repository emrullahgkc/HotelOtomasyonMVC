using DataAccessLayer.Abstrack;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class Repository<T> : RepositoryBase
    {
        //private DbSet<T> _objectSet;
        //public Repository()
        //{
        //    _objectSet = context.Set<T>();
        //}
        //public int Delete(T obj)
        //{
        //    _objectSet.Remove(obj);
        //    return Save();

        //}

        //public T Find(Expression<Func<T, bool>> where)
        //{
        //    return _objectSet.FirstOrDefault(where);
        //}

        //public int Insert(T obj)
        //{
        //    _objectSet.Add(obj);
          
        //    return Save();
        //}

        //public List<T> List()
        //{
        //    return _objectSet.ToList();
        //}

        //public List<T> List(Expression<Func<T, bool>> where)
        //{
        //    return _objectSet.Where(where).ToList();
        //}

        //public IQueryable<T> ListQueryable()
        //{
        //    return _objectSet.AsQueryable<T>();
        //}

        //public IQueryable<T> ListQueryable(Expression<Func<T, bool>> where)
        //{
        //    return _objectSet.Where(where);
        //}

        //public int Save()
        //{
        //    return context.SaveChanges();
        //}

        //public int Update(T obj)
        //{
           
        //    return Save();
        //}
    }
}
