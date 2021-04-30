using DataAccessLayer.Abstrack;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfUsersRolRepository : IUsersRolRepository
    {
        public DatabaseContext context;

        public EfUsersRolRepository():base()
        {

        }
      
        public List<CustomerViewModel> CustomerList()
        {
            
            string sql = @"select u.UserId,u.Photo,u.Tc,u.NameSurname,u.Email,u.Telephone,
                                                                u.Password,u.CreatedOn,u.CreatedUser,u.Status ,
                                                                p.PersonelId as PersonelID,p.Salary,p.ShiftEnd,p.ShiftStart,p.Reference,
                                                                pt.Level,st.ServiceName,ht.HotelName,ur.Id from UserRol ur
                                                                left outer join Personels p on(p.UserRolId=ur.Id)
                                                                left outer join Users u on(u.UserId=ur.UserId)
                                                                left outer join position pt on(pt.Id=p.PositionId)
                                                                left outer join ServiceType st on(st.Id=pt.ServiceTypeId)
                                                                left outer join Hotels ht on (ht.Id=p.HotelId)
                                                                where ur.RolId=1
                                                                order by pt.Level";
            return context.Database.SqlQuery<CustomerViewModel>(sql).ToList();



            //return context.Set<CustomerViewModel>().ToList();

        }

        public List<CustomerViewModel> CustomerList(Expression<Func<CustomerViewModel, bool>> predicate)
        {

            return context.Set<CustomerViewModel>().Where(predicate).ToList();
        }

        public IQueryable<TResult> CustomerList<TResult>(Expression<Func<CustomerViewModel, TResult>> select)
        {
            return context.Set<CustomerViewModel>().Select(select);
        }

        public IQueryable<TResult> CustomerList<TResult>(Expression<Func<CustomerViewModel, bool>> predicate, Expression<Func<CustomerViewModel, TResult>> select)
        {
            return context.Set<CustomerViewModel>().Where(predicate).Select(select).Cast<TResult>();
        }

        public List<PersonelViewModel> PersonelList()
        {
            //yukarisi intid eklenecek 
            int rolid=2;
            string sql = @"select u.Id as UserID,u.Photo,u.Tc,u.NameSurname,u.Email,u.Telephone,u.Password,u.CreatedOn,u.CreatedUser,u.Status ,p.Id as PersonelID,p.Salary,p.ShiftEnd,p.ShiftStart,p.Reference,pt.Level,st.Service,ht.HotelName,ur.Id
                                                                 from UserRol ur
                                                                left outer join Personel p on(p.UserRolid=ur.Id)
                                                                left outer join Users u on(u.Id=ur.Userid)
                                                                left outer join Position pt on(pt.Id=p.Positionid)
                                                                left outer join ServiceType st on(st.Id=pt.ServiceType)
                                                                left outer join Hotels ht on (ht.Id=p.Hotelid)
                                                                where ur.RoLid='" + rolid + "'order by pt.Level";
            return context.Database.SqlQuery<PersonelViewModel>(sql,rolid).ToList();
        }

        public List<PersonelViewModel> PersonelList(Expression<Func<PersonelViewModel, bool>> predicate)
        {
          
            string sql = @"select u.Id as UserID,u.Photo,u.Tc,u.NameSurname,u.Email,u.Telephone,u.Password,u.CreatedOn,u.CreatedUser,u.Status ,p.Id as PersonelID,p.Salary,p.ShiftEnd,p.ShiftStart,p.Reference,pt.Level,st.Service,ht.HotelName,ur.Id
                                                                 from UserRol ur
                                                                left outer join Personel p on(p.UserRolid=ur.Id)
                                                                left outer join Users u on(u.Id=ur.Userid)
                                                                left outer join Position pt on(pt.Id=p.Positionid)
                                                                left outer join ServiceType st on(st.Id=pt.ServiceType)
                                                                left outer join Hotels ht on (ht.Id=p.Hotelid)
                                                                where ur.RoLid='" + predicate + "'order by pt.Level";
            return context.Database.SqlQuery<PersonelViewModel>(sql).ToList();

        }

        public IQueryable<TResult> PersonelList<TResult>(Expression<Func<PersonelViewModel, TResult>> select)
        {
           throw new NotImplementedException();
        }

        public IQueryable<TResult> PersonelList<TResult>(Expression<Func<PersonelViewModel, bool>> predicate, Expression<Func<PersonelViewModel, TResult>> select)
        {
            throw new NotImplementedException();


        }
    }
}
