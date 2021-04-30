using BusinessLayer.Managers;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtomasyonHotelMVC.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        UsersManager usersManager = new UsersManager();
        PersonelManager personelManager = new PersonelManager();
        CustomerManager customerManager = new CustomerManager();
        HotelsManager hotelsManager = new HotelsManager();
        UserRolManager userRolManager = new UserRolManager();
        public ActionResult Index()
        {
            //var list=    usersManager.GetAll();
            var list = usersManager.ListAll();
            return View(list);
        }
        // GET: Admin/Users
        public ActionResult PersonelList (int Rolid)
        {
            var kontrol = userRolManager.PersonelList(x => x.UserRolid==Rolid);
            PersonelViewModel s = new PersonelViewModel();
            userRolManager.PersonelList();
                return View(); 
        }
        public ActionResult CustomerList()
        {
            return View();
        }
    }
}