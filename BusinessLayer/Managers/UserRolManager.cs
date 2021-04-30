using DataAccessLayer.EntityFramework;
using Entity.ViewModels;
using Otomasyon.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Managers
{
    public class UserRolManager : IUsersRolService
    {
        EfUsersRolRepository efUsersRolRepository = new EfUsersRolRepository();
        public List<CustomerViewModel> CustomerList()
        {
            return efUsersRolRepository.CustomerList();
        }

        public List<CustomerViewModel> CustomerList(Expression<Func<CustomerViewModel, bool>> predicate)
        {
            return efUsersRolRepository.CustomerList(predicate);
        }

        public IQueryable<TResult> CustomerList<TResult>(Expression<Func<CustomerViewModel, TResult>> select)
        {
            return efUsersRolRepository.CustomerList(select);
        }

        public IQueryable<TResult> CustomerList<TResult>(Expression<Func<CustomerViewModel, bool>> predicate, Expression<Func<CustomerViewModel, TResult>> select)
        {
            return efUsersRolRepository.CustomerList(predicate,select);
        }

        public List<PersonelViewModel> PersonelList()
        {
            return efUsersRolRepository.PersonelList();
        }

        public List<PersonelViewModel> PersonelList(Expression<Func<PersonelViewModel, bool>> predicate)
        {
            return efUsersRolRepository.PersonelList(predicate);
        }

        public IQueryable<TResult> PersonelList<TResult>(Expression<Func<PersonelViewModel, TResult>> select)
        {
            return efUsersRolRepository.PersonelList(select);
        }

        public IQueryable<TResult> PersonelList<TResult>(Expression<Func<PersonelViewModel, bool>> predicate, Expression<Func<PersonelViewModel, TResult>> select)
        {
            return efUsersRolRepository.PersonelList(predicate, select);
        }
    }
}
