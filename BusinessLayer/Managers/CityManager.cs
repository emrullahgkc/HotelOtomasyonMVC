using BusinessLayer.Result;
using DataAccessLayer.Abstrack;
using DataAccessLayer.EntityFramework;
using Entity.Messages;
using Entity.Models;
using Otomasyon.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Managers
{
    public class CityManager : GenericManager<City>, ICityService
    {
        EfCityRepository efCityRepository = new EfCityRepository();
        BusinnessLayerResult<City> res = new BusinnessLayerResult<City>();

        public BusinnessLayerResult<City> RegisterCity(City city)
        {
            string cityName = ToTitleCase(city.CityName);
            City cty = efCityRepository.Find(x => x.Id == city.Id);
            if (cty == null)
            {

                if (cty.CityName == cityName)
                {
                    res.AddError(ErrorMessageCode.NameAlreadyExists, "Şehir Adı Kullanılıyor.");
                }
                if (cty.PlateNo == city.PlateNo)
                {
                    res.AddError(ErrorMessageCode.PlateNoAlreadyExists, "Plaka Numarası Kullanılıyor.");
                }
                if (cty.AreaCode == city.AreaCode)
                {
                    res.AddError(ErrorMessageCode.AreaCodeAlreadyExists, "Posta Numarası Kullanılıyor.");
                }
                else
                {
                    int DbResult = Insert(new City()
                    {
                        CityName=ToTitleCase(city.CityName),
                        AreaCode=city.AreaCode,
                        IsActive=city.IsActive,
                        PlateNo=city.PlateNo,
                        RegionId=city.RegionId
                    });
                    if (DbResult > 0)
                    {
                        res.Result = Find(x => x.CityName == cityName);
                    }
                }
            }
            else
            {
                City kontrol = efCityRepository.Find(x => x.CityName == cityName || x.AreaCode == city.AreaCode||x.PlateNo==city.PlateNo);

                if (kontrol != null && kontrol.Id != city.Id)
                {
                    if (kontrol.CityName == cityName) 
                    {
                        res.AddError(ErrorMessageCode.NameAlreadyExists, "Şehir Adı Kullanılıyor");
                    }
                    if (kontrol.AreaCode == city.AreaCode)
                    {
                        res.AddError(ErrorMessageCode.AreaCodeAlreadyExists, "Posta Kodu Kullanılıyor");

                    }
                    if (kontrol.PlateNo == city.PlateNo)
                    {
                        res.AddError(ErrorMessageCode.PlateNoAlreadyExists, "Plaka Numarası Kullanılıyor");


                    }
                }
                res.Result = Find(x => x.Id == city.Id);
                res.Result.CityName = ToTitleCase(city.CityName);
                res.Result.AreaCode = city.AreaCode;
                    res.Result.PlateNo = city.PlateNo;
                res.Result.RegionId = city.RegionId;
                if (Convert.ToInt32(Update(res.Result)) == 0)
                {
                    res.AddError(ErrorMessageCode.CityCouldNotUpdated, "Şehir Güncellenemedi.");
                }
            }
            return res;
        }
        public BusinnessLayerResult<City> GetCityById(int id)
        {
            res.Result = efCityRepository.Find(x => x.Id == id);
            if (res == null)
            {
                res.AddError(ErrorMessageCode.CityCouldNotFound, "Şehir Bulunamadı.");
            }
            return res;
        }
        public BusinnessLayerResult<City> RemoveById(int id)
        {
            // yetki seviyesi süper admin admin veya personel seviyesine göre silme yada pasife alma olacak 
            City city = Find(x => x.Id == id);
            if (city != null)
            {
                if (Delete(city) == 0)
                {
                    res.AddError(ErrorMessageCode.CityCouldNotRemove, "Şehir Silinemedi.");
                    return res;
                }

            }
            else
            {
                res.AddError(ErrorMessageCode.CityCouldNotFound, "Şehir Bulunamadı.");
            }
            return res;
        }
        public BusinnessLayerResult<City> UpdateById(City data)
        {
            string cityName = ToTitleCase(data.CityName);
            City city = efCityRepository.Find(x => x.CityName == cityName);
            BusinnessLayerResult<City> res = new BusinnessLayerResult<City> ();
            if(city!=null && city.Id!=data.Id)
            {
                if (city.CityName == cityName)
                {
                    res.AddError(ErrorMessageCode.CityNameAlreadyExists, "Şehir Adı Kayıtlı");
                }
                return res;
            }
            res.Result = efCityRepository.Find(x => x.Id == data.Id);
            res.Result.CityName = ToTitleCase(data.CityName);
            res.Result.AreaCode = data.AreaCode;
            res.Result.IsActive = data.IsActive;
            res.Result.RegionId = data.RegionId;
            res.Result.PlateNo = data.PlateNo;
            if (Convert.ToInt32(Updates(res.Result)) == 0)
            {
                res.AddError(ErrorMessageCode.CityCouldNotFound, "Şehir Güncellenemedi.");
            }
            return res;
        }
    }
}
