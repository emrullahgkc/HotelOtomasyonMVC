using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtomasyonHotelMVC.Controllers
{
    public class HomePageController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TEST()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TEST(string firstname,string lastname,string email,string password)
        {
            return View();
        }
    }
}