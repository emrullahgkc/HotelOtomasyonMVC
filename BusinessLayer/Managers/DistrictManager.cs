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
    public class DistrictManager:GenericManager<District>,IDistrictService
    {
        EfDistrictRepository efDistrictRepository = new EfDistrictRepository();
        BusinnessLayerResult<District> blr = new BusinnessLayerResult<District>();

        public BusinnessLayerResult<District>RegisterDistrict(District district)
        {
            var kontrol = efDistrictRepository.Find(x => x.Id == district.Id); 
            string districtName = ToTitleCase(district.DistrictName);
            District dst = efDistrictRepository.Find(x => x.DistrictName == districtName || x.PostCode == district.PostCode);
            if (kontrol == null)
            {
          
                if (dst != null)
                {
                    if (dst.DistrictName == districtName)
                    {
                        blr.AddError(ErrorMessageCode.DistrictNameAlreadyExists, "İlçe Adı Kullanılıyor.");
                    }
                    if (dst.PostCode == district.PostCode)
                    {
                        blr.AddError(ErrorMessageCode.PostCodeAlreadyExists, "Posta Kodu Kullanılıyor");
                    }
                }
                else
                {
                    int DbResult = efDistrictRepository.Insert(new District()
                    {
                        DistrictName = ToTitleCase(district.DistrictName),
                        CityId = district.CityId,
                        IsActive = district.IsActive,
                        PostCode = district.PostCode

                    });
                    if (DbResult > 0)
                    {
                        blr.Result = efDistrictRepository.Find(x => x.DistrictName == districtName);
                    }
                }
            }
            else
            {
                return UpdateDistrict(district);
            }
            return blr;
        }
        public BusinnessLayerResult<District>GetDistrictById(int id)
        {
            blr.Result = efDistrictRepository.Find(x => x.Id == id);//neden resulttan varmi yokmu ariyor kontrol edilecek.
            if (blr == null)
            {
                blr.AddError(ErrorMessageCode.DistrictNotFound, "İlçe Bulunamadı.");
            }
            return blr;
        }
        public BusinnessLayerResult<District> UpdateDistrict(District district)
        {
            var kontrol = efDistrictRepository.Find(x => x.Id == district.Id);
            string districtName = ToTitleCase(district.DistrictName);
            District dst = efDistrictRepository.Find(x => x.DistrictName == districtName);
            if (kontrol != null)
            {
                if (dst != null && dst.Id == district.Id)
                {
                    if (dst.DistrictName == districtName)
                    {
                        blr.AddError(ErrorMessageCode.DistrictNameAlreadyExists, "İlçe Adı Kullanılıyor");
                    }
                    if (dst.PostCode == district.PostCode)
                    {
                        blr.AddError(ErrorMessageCode.PostCodeAlreadyExists, "Posta Kodu Kullanılıyor");
                    }

                }
                else
                {
                    blr.Result = efDistrictRepository.Find(x => x.Id == district.Id);
                    blr.Result.DistrictName = ToTitleCase(district.DistrictName);
                    blr.Result.PostCode = district.PostCode;
                    blr.Result.CityId = district.CityId;
                    blr.Result.IsActive = district.IsActive;
                    if (Convert.ToInt32(Update(blr.Result)) == 0)
                    {
                        blr.AddError(ErrorMessageCode.DistrictCouldNotFound, "İlçe Güncellenemedi");
                    }
                }
            }
            else
            {
                return RegisterDistrict(district);
            }
            return blr;
        }



    }
}
