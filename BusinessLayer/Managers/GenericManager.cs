using DataAccessLayer.EntityFramework;
using Otomasyon.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Managers
{
   public class GenericManager<T>: IGenericServiceIF<T> where T:class
    {
        EfGenericRepository<T> efGenericRepository = new EfGenericRepository<T>();
        public T Add(T entity)
        {
            return efGenericRepository.Add(entity);  
        }
        //Başharfi Büyük Kontrolü
        public static string ToTitleCase(string value)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
        }   

        public List<T> ListAll()
        {
            return efGenericRepository.ListAll();
        }
        
        public T List(int id)
        {
            return efGenericRepository.List(id);
        }

        public List<T> ListAll(Expression<Func<T, bool>> predicate)
        {
            return efGenericRepository.ListAll(predicate);
        }

        public T Update(T entity)
        {
            return efGenericRepository.Update(entity);
        }

        public bool Remove(int id)
        {
            return efGenericRepository.Remove(id);
        }

        public bool Remove(T entity)
        {
            return efGenericRepository.Remove(entity);
        }

        //public T Find(int id)
        //{
        //    return efGenericRepository.Find(id);    
        //}
        public T Find(Expression<Func<T, bool>> where)
        {
            return efGenericRepository.Find(where);
        }
        public IQueryable<TResult> ListAll<TResult>(Expression<Func<T, TResult>> select)
        {
            return efGenericRepository.ListAll<TResult>(select);
        }

        public IQueryable<TResult> ListAll<TResult>(Expression<Func<T, bool>> predicate, Expression<Func<T, TResult>> select)
        {
            return efGenericRepository.ListAll<TResult>(predicate, select);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<T, bool>> predicate)
        {
            return efGenericRepository.Count(predicate);        }

        public int Insert(T obj)
        {
            return efGenericRepository.Insert(obj);        }

        public object Updates(T obj)
        {

           return  efGenericRepository.Insert(obj);
        }

        public int Delete(T obj)
        {
            return efGenericRepository.Delete(obj);
        }
    }
}
