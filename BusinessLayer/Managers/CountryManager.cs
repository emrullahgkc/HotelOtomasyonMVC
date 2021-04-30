using BusinessLayer.Managers;
using BusinessLayer.Result;
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
    public class CountryManager : GenericManager<Country>, ICountryService
    {
        EfCountryRepository efCountryRepository = new EfCountryRepository();


        public BusinnessLayerResult<Country> RegisterCountry(Country data)
        {
            string countryName = ToTitleCase(data.CountryName);
            var kontrol = efCountryRepository.Find(x => x.Id == data.Id);
            Country country = efCountryRepository.Find(x => x.CountryName == countryName);
            BusinnessLayerResult<Country> blr = new BusinnessLayerResult<Country>();
            if (kontrol == null)
            {
                if (country != null)
                {
                    if (country.CountryName == countryName)
                    {
                        blr.AddError(ErrorMessageCode.CountryNameAlreadyExists, "Ülke Adı Kullanılıyor.");
                    }
                }
                else
                {
                    int DbResult = Insert(new Country()
                    {
                        CountryName = countryName,
                        Flag = data.Flag,
                        CurrencyUnit = data.CurrencyUnit,
                        IdentityCardTypeId = data.IdentityCardTypeId,
                        NativeLanguage = data.NativeLanguage,
                    });
                    if (DbResult > 0)
                    {
                        blr.Result = Find(x => x.CountryName == countryName);
                        
                    }
                }
            }
            else
            {
                return UpdateCountry(data);
            }
            return blr;



        }
        public BusinnessLayerResult<Country> GetCountryById(int id)
        {


            BusinnessLayerResult<Country> res = new BusinnessLayerResult<Country>();
            res.Result = efCountryRepository.Find(x => x.Id == id);
            if (res == null)
            {
                res.AddError(ErrorMessageCode.CountryNotFound, "Ülke Bulunamadı.");
            }
            return res;
        }
        public BusinnessLayerResult<Country> UpdateCountry(Country data)
        {
            string countryName = ToTitleCase(data.CountryName);
            var kontrol = efCountryRepository.Find(x => x.Id == data.Id);
            Country country = Find(x => x.CountryName == countryName);
            BusinnessLayerResult<Country> res = new BusinnessLayerResult<Country>();
            if (kontrol != null)
            {
                if (country != null && country.Id != data.Id)
                {
                    if (country.CountryName == countryName)
                    {
                        res.AddError(ErrorMessageCode.CountryNameAlreadyExists, "Ülke Adı Kayıtlı.");
                    }
                    return res;
                }
                res.Result = efCountryRepository.Find(x => x.Id == data.Id);
                res.Result.CountryName = ToTitleCase(data.CountryName);
                res.Result.NativeLanguage = data.NativeLanguage;
                res.Result.Flag = data.Flag;
                res.Result.CurrencyUnit = data.CurrencyUnit;
                //res.Result.IdentityCardTypeId = data.IdentityCardTypeId;
                if (string.IsNullOrEmpty(data.Flag) == false)
                {
                    res.Result.Flag = data.Flag;
                }
                //if (Convert.ToInt32(efCountryRepository.Updates(res.Result)) == 0)       
                if (Convert.ToInt32(Updates(res.Result)) == 0)
                {
                    res.AddError(ErrorMessageCode.CountryCouldNotUpdated, "Ülke Güncellenemedi.");
                }
            }
            else
            {
                return RegisterCountry(data);
            }
            return res;
        }
    }
}
