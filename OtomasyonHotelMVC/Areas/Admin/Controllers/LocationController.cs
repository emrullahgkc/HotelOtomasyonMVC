using BusinessLayer;
using BusinessLayer.Managers;
using BusinessLayer.Result;
using Entity.Messages;
using Entity.Models;
using OtomasyonHotelMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtomasyonHotelMVC.Areas.Admin.Controllers
{
    public class LocationController : Controller
    {
        private RegionManager regionManager = new RegionManager();
        private CityManager cityManager = new CityManager();
        private  DistrictManager districtManager = new DistrictManager();
        private CountryManager countryManager = new CountryManager();
        NotifyViewModelBase<string> islem;

        void Listeler()
        {
            List<SelectListItem> CountryList = (from i in countryManager.ListAll()
                                                select new SelectListItem
                                                {
                                                    Text = i.CountryName,
                                                    Value = i.Id.ToString()
                                                }
       ).ToList();
            ViewBag.Country = CountryList;
            List<SelectListItem> RegionList = (from i in regionManager.ListAll()
                                           select new SelectListItem
                                           {
                                               Text = i.RegionName,
                                               Value = i.Id.ToString()
                                           }
           ).ToList();
            ViewBag.Region = RegionList;
            List<SelectListItem> CityList = (from i in cityManager.ListAll()
                                               select new SelectListItem
                                               {
                                                   Text = i.CityName,
                                                   Value = i.Id.ToString()
                                               }
      ).ToList();
            ViewBag.City = CityList;
            List<SelectListItem> DistrictList = (from i in districtManager.ListAll()
                                               select new SelectListItem
                                               {
                                                   Text = i.DistrictName,
                                                   Value = i.Id.ToString()
                                               }
      ).ToList();
            ViewBag.District = DistrictList;

                   
        }

        // GET: Admin/Location
        public ActionResult Index()
        {
            return View(regionManager.ListAll());
        }
        public ActionResult RegionRegister()
        {
            Listeler();
            
            return View();
        }
        [HttpPost]
        public ActionResult RegionRegister(Region region)
        {
            if (ModelState.IsValid)
            {
                BusinnessLayerResult<Region> reg = regionManager.RegisterRegion(region);
                if (reg.Errors.Count > 0)
                {
                    reg.Errors.ForEach(x => ModelState.AddModelError("", x.Message));
                    return View(region);
                }
                OkViewModel okViewModel = new OkViewModel()
                //VİEW MODALLERDE PUPOP OLACAK
                {
                    Title = "Kayıt Başarılı",
                    Header = "Kayıt Başarılı",

                };
                okViewModel.Items.Add("Bölge Başarılı Bir Şekilde Kaydedilmiştir.");
                return View("OK", okViewModel);
            }
            



            if (region.Id == 0)
            {
                regionManager.Add(region);

            }
            else
            {
                var kontrol = regionManager.Find(x => x.Id == region.Id);
                if (kontrol != null)
                {
                    regionManager.Update(region);

                }
                else
                {
                    //HATA SAYFASİNA GİDECEK
                }
            }
            Listeler();
            return View("RegionRegister", region);
        }
        public ActionResult RegionJson()
        {
            Listeler();

            return View(new Region());
        }

        [HttpPost]
        public JsonResult RegionJson(Region region)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    BusinnessLayerResult<Region> reg = regionManager.RegisterRegion(region);
                    if (reg.Errors.Count > 0)
                    {
                        reg.Errors.ForEach(x => ModelState.AddModelError("", x.Message));
                        islem = new NotifyViewModelBase<string>()
                        {
                            IslemKodu = 2,
                            Title = "Kayıt Başarısız",
                            Header = "Kayıt Başarısız",

                        };
                        foreach (var hata in reg.Errors)
                        {
                            islem.Items.Add(hata.Message);
                        }

                        islem.Items.Add("Bölge Kaydedilemedi.!");

                        return Json(islem);
                    }
                    islem = new NotifyViewModelBase<string>()
                    //VİEW MODALLERDE PUPOP OLACAK
                    {
                        IslemKodu = 1,
                        Title = "Kayıt Başarılı",
                        Header = "Kayıt Başarılı",
                    };
                    islem.Items.Add("Bölge Başarılı Bir Şekilde Kaydedilmiştir.");
                    Listeler();
        
                    return Json(islem);
                }
                if (ModelState.Values.Count > 0)
                {
                    islem = new NotifyViewModelBase<string>()
                    {
                        IslemKodu = 2,
                        Title = "HATA",
                        Header = "HATA",
                    };
                    islem.Items.Add("Hata Oluştu");
                    return Json(islem);
                    //TODO:  VALİDATİON ÇALİŞMİYOR HATA VARSADA SİSTEMDE GÖSTERMİYOR KONTROL EDİLECEK.
                }
            }
            catch(Exception error)
            {
                ModelState.AddModelError("", error.Message);
                return Json(region);

            }

            return Json(region);



            //return Json("RegionJson");
        }
        public ActionResult RegionRegulation(int id)
        {
            var model = regionManager.Find(x=>x.Id==id);
            Listeler();
            return View("RegionRegister", model);
        }

        public ActionResult CityList()
        {

     
            return View(cityManager.ListAll());
        }
        public ActionResult CityRegister()
        {
            Listeler();
            
            return View(new City());
        }
        [HttpPost]
        public JsonResult  CityRegister(City city)
        {
            NotifyViewModelBase<string> islem;

            try
            {
                if (ModelState.IsValid)
                {
                    if (city.Id == 0)
                    {
                        BusinnessLayerResult<City> cty = cityManager.RegisterCity(city);
                        if (cty.Errors.Count > 0)
                        {
                            cty.Errors.ForEach(x => ModelState.AddModelError("", x.Message));
                            islem = new NotifyViewModelBase<string>()
                            {
                                IslemKodu = 2,
                                Title = "Kayıt Başarısız",
                                Header = "Kayıt Başarısız",
                                

                            };
                            foreach (var item in cty.Errors)
                            {
                                islem.Items.Add(item.Message);
                            }
                            islem.Items.Add("Şehir Kaydedilemedi..!");
                            return Json(islem);
                        }
                        islem = new NotifyViewModelBase<string>()
                        {
                            IslemKodu=1,
                            Title="Kayıt Başarılı",
                            Header="Kayıt Başarılı",
                        };
                        islem.Items.Add("Şehir Başarılı Bir Şekilde Kaydedilmiştir.");
                        Listeler();
                     
                        return Json(islem);
                    }
                    else
                    {
                        BusinnessLayerResult<City> cty = cityManager.GetCityById(city.Id);
                        islem = new NotifyViewModelBase<string>();
                        if (cty.Errors.Count > 0)
                        {
                            foreach (var item in cty.Errors)
                            {
                                islem.Items.Add(item.Message);
                            }
                            return Json(islem);
                        }
                        else
                        {
                            cty = cityManager.UpdateById(city);
                            if (cty.Errors.Count > 0)
                            {
                                foreach (var item in cty.Errors)
                                {
                                    islem.Items.Add(item.Message);
                                }
                                return Json(islem);
                            }
                        }   
                        Listeler();
                    }             
                }
                if (ModelState.Values.Count > 0)
                {
                    islem = new NotifyViewModelBase<string>()
                    {
                        IslemKodu = 2,
                        Title = "HATA",
                        Header = "HATA",
                    };
                    islem.Items.Add("Hata Oluştu");
                    return Json(islem);
                    //TODO:  VALİDATİON ÇALİŞMİYOR HATA VARSADA SİSTEMDE GÖSTERMİYOR KONTROL EDİLECEK.
                }
            }
            catch(Exception error)
            {
                ModelState.AddModelError("", error.Message);
                return Json(city);
            }  
            return Json( city);
        }       
        
        //TODO: GEREKİRSE SİLİNECEK YUKARDA REGİSTERDE SATEN SORGU YAPILIYOR
        public ActionResult CityRegulation(int id)
        {
            BusinnessLayerResult<City> cty = cityManager.GetCityById(id);
     
            Listeler();
            return View(cty);
        }

        public ActionResult DistrictList()
        {
            Listeler();
            return View(cityManager.ListAll());
        }
        public ActionResult DistrictRegister()
        {
            Listeler();
           
            return View(new District());
        }
        [HttpPost]
        public ActionResult DistrictRegister(District district)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (district.Id == 0)
                    {

                        BusinnessLayerResult<District> blr = districtManager.RegisterDistrict(district);
                        if (blr.Errors.Count > 0)
                        {
                            blr.Errors.ForEach(x => ModelState.AddModelError("", x.Message));
                            islem = new NotifyViewModelBase<string>()
                            {
                                IslemKodu = 2,
                                Title = "Kayıt Başarısız",
                                Header = "Kayıt Başarısız",
                            };
                            foreach (var hata in blr.Errors)
                            {
                                islem.Items.Add(hata.Message);
                            }
                            return View(islem);

                        }
                        islem = new NotifyViewModelBase<string>()
                        //VİEW MODALLERDE PUPOP OLACAK
                        {
                            IslemKodu = 1,
                            Title = "Kayıt Başarılı",
                            Header = "Kayıt Başarılı",
                        };
                        islem.Items.Add("İlçe Başarılı Bir Şekilde Kaydedildi.");

                    }
                    else
                    {
                        BusinnessLayerResult<District> blr = districtManager.UpdateDistrict(district);

                        if (blr.Errors.Count > 0)
                        {
                            blr.Errors.ForEach(x => ModelState.AddModelError("", x.Message));
                            islem = new NotifyViewModelBase<string>()
                            {
                                IslemKodu = 2,
                                Title = "Güncelleme Başarısız",
                                Header = "Güncelleme Başarısız",
                            };
                            foreach (var hata in blr.Errors)
                            {
                                islem.Items.Add(hata.Message);
                            }
                            return View(islem);
                        }
                        islem = new NotifyViewModelBase<string>()
                        //VİEW MODALLERDE PUPOP OLACAK
                        {
                            IslemKodu = 1,
                            Title = "Güncelleme Başarılı",
                            Header = "Güncelleme Başarılı",
                        };
                        islem.Items.Add("İlçe Başarılı Bir Şekilde Güncellendi.");
                        return View(islem);
                    }
                }
                if (ModelState.Values.Count > 0)
                {
                    islem = new NotifyViewModelBase<string>()
                    {
                        IslemKodu = 2,
                        Title = "HATA",
                        Header = "HATA",
                    };
                    islem.Items.Add("Hata Oluştu");
                    return Json(islem);
                    //TODO:  VALİDATİON ÇALİŞMİYOR HATA VARSADA SİSTEMDE GÖSTERMİYOR KONTROL EDİLECEK.

                }
            }
            catch (Exception error)
            {
                ModelState.AddModelError("", error.Message);

            }
            Listeler();

            return View(district);
            
        }
        public ActionResult DistrictRegulation(int id)
        {
            BusinnessLayerResult<District> district = districtManager.GetDistrictById(id);


            return View("DistrictRegister", district);
        }

        public ActionResult CountryList()
        {
            return View(countryManager.ListAll());
        }
        public ActionResult CountryRegister()
        {
            return View(new Country());
        }
        [HttpPost]
        public ActionResult  CountryRegister(Country country)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (country.Id == 0)
                    {

                        BusinnessLayerResult<Country> res = countryManager.RegisterCountry(country);
                        if (res.Errors.Count > 0)
                        {
                            res.Errors.ForEach(x => ModelState.AddModelError("", x.Message));
                            islem = new NotifyViewModelBase<string>()
                            {
                                IslemKodu = 2,
                                Title = "Kayıt Başarısız",
                                Header = "Kayıt Başarısız",
                            };
                            foreach (var hata in res.Errors)
                            {
                                islem.Items.Add(hata.Message);
                            }
                            return View(islem);

                        }
                        islem = new NotifyViewModelBase<string>()
                        //VİEW MODALLERDE PUPOP OLACAK
                        {
                            IslemKodu = 1,
                            Title = "Kayıt Başarılı",
                            Header = "Kayıt Başarılı",
                        };
                        islem.Items.Add("Ülke Başarılı Bir Şekilde Kaydedildi.");

                    }
                    else
                    {
                        BusinnessLayerResult<Country> res = countryManager.UpdateCountry(country);

                        if (res.Errors.Count > 0)
                        {
                            res.Errors.ForEach(x => ModelState.AddModelError("", x.Message));
                            islem = new NotifyViewModelBase<string>()
                            {
                                IslemKodu = 2,
                                Title = "Güncelleme Başarısız",
                                Header = "Güncelleme Başarısız",
                            };
                            foreach (var hata in res.Errors)
                            {
                                islem.Items.Add(hata.Message);
                            }

                        }
                        islem = new NotifyViewModelBase<string>()
                        //VİEW MODALLERDE PUPOP OLACAK
                        {
                            IslemKodu = 1,
                            Title = "Güncelleme Başarılı",
                            Header = "Güncelleme Başarılı",
                        };
                        islem.Items.Add("Ülke Başarılı Bir Şekilde Güncellendi.");


                        //    var kontrol = countryManager.Find(x=>x.Id==country.Id);
                        //    if (kontrol != null)
                        //    {
                        //        countryManager.Update(country);

                        //    }
                        //    else
                        //    {
                        //        //HATA SAYFASİNA GİDECEK
                        //    }
                        //}
                        //return View("CountryRegister",country);
                    }
                }
                if (ModelState.Values.Count > 0)
                {
                    islem = new NotifyViewModelBase<string>()
                    {
                        IslemKodu = 2,
                        Title = "HATA",
                        Header = "HATA",
                    };
                    islem.Items.Add("Hata Oluştu");
                    return Json(islem);
                    //TODO:  VALİDATİON ÇALİŞMİYOR HATA VARSADA SİSTEMDE GÖSTERMİYOR KONTROL EDİLECEK.

                }
            }
            catch(Exception error)
            {
                ModelState.AddModelError("", error.Message);

            }
            return View(country);
        }
        public ActionResult CountryRegulation(int id)
        {
            BusinnessLayerResult<Country> cty = countryManager.GetCountryById(id);
            Listeler();

            return View("CountryRegister", cty);
        }
 

    }
}