using Otomasyon.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
  public  class EfGenericRepository<T> : IGenericServiceIF<T> where T : class
    {// yeni sistem için 
        public DatabaseContext context;
        public EfGenericRepository()
        {
            context = new DatabaseContext();
        }
        public T Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
            return entity;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool dispose)
        {
            if (dispose)
            {
                context.Dispose();
            }
        }

        public T List(int id)
        {
            var entity = context.Set<T>().Find(id);
            context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;//silme izni
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;//düzenleme izni
            return entity;
        }

        public List<T> ListAll()
        {
            //return context.Set<T>().AsNoTracking().ToList();//her defasinda sorgulama yaptirir asnotracking yapmazsan sorguyu yenilemez veri tabanindan çeker ve veriler üzerinden değişiklik yapmayada izin verir.
            return context.Set<T>().ToList();
        }

        public List<T> ListAll(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Where(predicate).ToList();
            //return context.Set<T>().AsNoTracking().Where(predicate).ToList();
        }

        public bool Remove(int id)
        {
            return Remove(List(id));
        }

        public bool Remove(T entity)
        {
            context.Set<T>().Remove(entity);
            return context.SaveChanges() > 0;
        }

        public T Update(T entity)
        {
            context.Set<T>().AddOrUpdate(entity);//addorupdate veri varsa güncelleme yapar yoksa kaydetme yapar.
            context.SaveChanges();
            return entity;
        }

        public bool Delete(int id)
        {

            return Remove(List(id));
        }

        public IQueryable<TResult> ListAll<TResult>(Expression<Func<T, TResult>> select)
        {
            return context.Set<T>().Select(select);
        }

        public IQueryable<TResult> ListAll<TResult>(Expression<Func<T, bool>> predicate, Expression<Func<T, TResult>> select)
        {
            return context.Set<T>().Where(predicate).Select(select).Cast<TResult>();
        }


        //public T Find(int id)
        //{
        //    return context.Set<T>().Find(id);
        //}
        public T Find(Expression<Func<T, bool>> where)
        {
            return context.Set<T>().FirstOrDefault(where);

        }

        public int Count(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Where(predicate).Count();
        }

        public int Insert(T obj)
        {
            context.Set<T>().Add(obj);
            int statu = context.SaveChanges();
            return statu;
        }

        public object Updates(T obj)
        {
  context.Set<T>().AddOrUpdate(obj);//addorupdate veri varsa güncelleme yapar yoksa kaydetme yapar.
            int statu= context.SaveChanges();
            return statu;        }

        public int Delete(T obj)
        {
            context.Set<T>().Remove(obj);
            int statu=context.SaveChanges();
            return statu;
        }
    }
}

