using BusinessLayer.Managers;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtomasyonHotelMVC.Areas.Admin.Controllers
{
    public class HotelsController : Controller
    {
        #region Eklenecekler
        //ActivityManager activityManager = new ActivityManager();
        //ActivityHistory
        //    Campaign
        //     CampaignQuantityTypeManager;
        //    CampaignQuantityTypeHistoryManager;
        //    CampaignStatusManager;
        //    CampaignUsingManager;
        //    CampaignUsingHistoryManager;
        //    CampaignCategoryManager;
        //    CampaignCategoryHistoryManager;
        //    CampaignCode;
        //    CampaignCodeHistory ;
        //    CampaignHistory;
        //    Client ;
        //    ClientUserHistory;
        //    Complaint ;
        //    ComplaintHistory ;
        //    Floors ;
        //    FloorsHistory ;
        //    Food ;
        //    FoodCategory;
        //    FoodCategoryHistory;
        //    FoodDetail ;
        //    FoodHistory );
        //    FoodMenu ;
        //    FoodMenuHistory ;
        //    FoodTime ;
        //    FoodTimeHistory ;
        //    HotelGallery ;
        //    HotelGalleryHistory ;
        //    Order ;
        //    OrderHistory ;
        //    Personel ;
        //    PersonelUserHistory;
        //    Position ;
        //    PositionHistory ;

        //    ProductCategory ;
        //    ProductCategoryHistory ;
        //    ProductDetail ;
        //    ProductHistory ;
        //    ProductQuantityType;
        //    ProductQuantityTypeHistory ;
        //    Rol ;
        //    RolHistory ;
        //    Room  ;
        //    RoomHistory ;
        //    SatisfactionStatus ;
        //    ServiceAssignment ;
        //    ServiceAssignmentHistory ;
        //    ServiceType;
        //    ServiceTypeHistory ;
        //    ShoppingCart ;
        //    ShoppingCartHistory ;
        //    Supplier ;
        //    UserRol;
        //    SupplierHistory ;

        #endregion



        HotelsManager hotelsManager = new HotelsManager();
        RegionManager regionManager=new RegionManager() ;
        DistrictManager districtManager = new DistrictManager();
        CityManager cityManager=new CityManager();
        //ProductManager productManager = new ProductManager();

        
        // GET: Admin/Hotels
        public ActionResult Index()
        {
            var liste = hotelsManager.ListAll();
            return View(liste);
            
        }
        private void Listes()
        {
            List<SelectListItem> regionlst = (from i in regionManager.ListAll()
                                              select new SelectListItem
                                              {
                                                  Text = i.RegionName,
                                                  Value = i.Id.ToString()
                                              }
                                ).ToList();
            ViewBag.Region = regionlst;

            List<SelectListItem> citylst = (from i in cityManager.ListAll()
                                            select new SelectListItem
                                            {
                                                Text = i.CityName,
                                                Value = i.Id.ToString()
                                            }
                                            ).ToList();
            ViewBag.City = citylst;

            List<SelectListItem> districtlst = (from i in districtManager.ListAll()
                                                select new SelectListItem
                                                {
                                                    Text = i.DistrictName,
                                                    Value = i.Id.ToString()
                                                }
                                            ).ToList();
            ViewBag.District = districtlst;
        }
        public ActionResult RegisterHotel()
        {
            Listes();
            HotelsViewModel hvm = new HotelsViewModel();
           
            return View(hvm);
        }
        [HttpPost]
        public ActionResult RegisterHotel(HotelsViewModel hotels)
        {
            if (hotels.Id == 0)
            {
                if (Request.Files.Count > 0)
                {
                    if (Request.Files[0].FileName == "")
                    {
                        hotels.HotelPhoto = "HotelNull.png";
                    }
                    else if (Request.Files[0].FileName != "")
                    {
                        string Dosyaadi = Guid.NewGuid().ToString();
                        string Uzanti = Path.GetExtension(Request.Files[0].FileName);
                        string Yol = "~/img/Hotels/" + Dosyaadi + Uzanti;
                        Request.Files[0].SaveAs(Server.MapPath(Yol));
                        hotels.HotelPhoto =  Dosyaadi + Uzanti;
                    }

                }

                hotelsManager.HotelsRegister(hotels);
            }
            else
            {
                var kontrol = hotelsManager.ListAll(x=>x.Id==hotels.Id).FirstOrDefault();
                if (kontrol != null)
                {
                    if (Request.Files.Count > 0)
                    {
                        if (kontrol.HotelPhoto == "" || kontrol.HotelPhoto == null && Request.Files[0].FileName == "")
                        {
                            hotels.HotelPhoto = "~/img/Hotel/HotelNull.png";

                        }
                        else if (Request.Files[0].FileName != "")
                        {
                            string Dosyaadi = Guid.NewGuid().ToString();
                            string Uzanti = Path.GetExtension(Request.Files[0].FileName);
                            string Yol = "~/img/Hotel/" + Dosyaadi + Uzanti;
                            Request.Files[0].SaveAs(Server.MapPath(Yol));
                            hotels.HotelPhoto = Dosyaadi + Uzanti;
                        }
                    }
                    
                    hotelsManager.HotelsUpdate(hotels);
                  

                    }
                }

     






            Listes();
            return View();
        }

        //public ActionResult HotelDelete(int id)
        //{//Test Edilecek.
           
        //    var kontrol = productManager.ProductGetAll(x => x.Hotelid == id).FirstOrDefault();
        //    if (kontrol == false)
        //    {
             
        //        var kontrol2 = productManager.GetAll(x=>x.Hotelid==id) ;
        //        if (kontrol2 == true)
        //        {
              
        //        }
        //        else
        //        {
        //            ViewBag.Hata2 = "Ürünler Tablosunda İlişkili Veriler Var ";
        //        }
        //    }
        //    else
        //    {
        //        ViewBag.Hata1 = "Personel Tablosunda İlişkili Veriler Var ";
        //    }
        //    return View();
        //}
    }
}