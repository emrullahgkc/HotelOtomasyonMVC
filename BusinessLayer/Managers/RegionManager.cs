using DataAccessLayer.Abstrack;
using DataAccessLayer.EntityFramework;
using Entity.Models;
using Entity.Messages;
using Entity.ValueObjects;
using Otomasyon.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Managers;
using System.Globalization;
using BusinessLayer.Result;

namespace BusinessLayer.Managers
{
    public class RegionManager : GenericManager<Region>, IRegionService
    {
        EfRegionRepository efRegionRepository = new EfRegionRepository();
        BusinnessLayerResult<Region> blr = new BusinnessLayerResult<Region>();


        public BusinnessLayerResult<Region> RegisterRegion(Region region)
        {


            var kontrol = efRegionRepository.Find(x => x.Id == region.Id);
            string regionName = ToTitleCase(region.RegionName);
            //nick= CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nick);

            Region rg = efRegionRepository.Find(x => x.RegionName == regionName || x.RegionCode == region.RegionCode);
            if (kontrol == null)
            {
                if (rg != null)
                {
                    if (rg.RegionName == regionName)
                    {
                        blr.AddError(ErrorMessageCode.RegionNameAlreadyExists, "Bölge Adı Kullanılıyor.");
                    }
                    if (rg.RegionCode == region.RegionCode.ToUpper())
                    {
                        blr.AddError(ErrorMessageCode.RegionCodeAlreadyExists, "Bölge Kodu Kullanılıyor.");
                    }
                }

                else
                {
                    int DbResult = Insert(new Region()
                    {
                        CountryId = region.CountryId,
                        RegionName = ToTitleCase(region.RegionName),
                        RegionCode = region.RegionCode.ToUpper(),
                        IsActive = region.IsActive
                    });
                    if (DbResult > 0)
                    {
                        blr.Result = Find(x => x.RegionName == regionName);
                    }
                }

            }
            else
            {
                return UpdateRegion(region);
            }
            return blr;
        }
        public BusinnessLayerResult<Region> GetRegionById(int id)
        {
            blr.Result = efRegionRepository.Find(x => x.Id == id);//neden resulttan varmi yokmu ariyor kontrol edilecek.
            if (blr == null)
            {
                blr.AddError(ErrorMessageCode.RegionNotFound, "Bölge Bulunamadı.");
            }
            return blr;
        }
        public BusinnessLayerResult<Region> RemoveById(int id)
        {
            Region region = Find(x => x.Id == id);
            if (region != null)
            {
                if (Delete(region) == 0)
                {
                    blr.AddError(ErrorMessageCode.RegionCouldNotRemove, "Bölge Silinemedi.");
                    return blr;
                }
            }
            else
            {
                blr.AddError(ErrorMessageCode.RegionNotFound, "Bölge Bulunamadı.");
            }
            return blr;

        }

        public BusinnessLayerResult<Region> UpdateRegion(Region region)
        {
            var kontrol = efRegionRepository.Find(x => x.Id == region.Id);
            string regionName = ToTitleCase(region.RegionName);
            Region rg=efRegionRepository.Find(x => x.RegionName == regionName || x.RegionCode == region.RegionCode); 
       if(kontrol != null)
            {
                if (rg != null && rg.Id != region.Id)
                {
                    if (rg.RegionName == regionName)
                    {
                        blr.AddError(ErrorMessageCode.RegionNameAlreadyExists, "Bölge Adı Kullanılıyor");
                    }
                    if (rg.RegionCode == region.RegionCode.ToUpper())
                    {
                        blr.AddError(ErrorMessageCode.RegionCodeAlreadyExists, "Bölge Kodu Kullanılıyor");
                    }
                }
                else
                {
                    blr.Result = Find(x => x.Id == region.Id);
                    blr.Result.RegionName = ToTitleCase(region.RegionName);
                    blr.Result.RegionCode = region.RegionCode.ToUpper();
                    blr.Result.IsActive = region.IsActive;
                    blr.Result.CountryId = region.CountryId;
                    if (Convert.ToInt32(Update(blr.Result)) == 0)
                    {
                        blr.AddError(ErrorMessageCode.RegionCouldNotUpdated, "Bölge Güncellenemedi.");
                    }
                }
                return blr;
            }
            else
            {
                return RegisterRegion(region);
            }
        }
        #region Önceki Kodlar



        //private Repository<Region> repo_region = new Repository<Region>();
        //public BusinessLayerResult<Region>RegisterRegion(RegionRegViewModel data)
        //{
        //    Region reg = repo_region.Find(x => x.RegionName == data.RegionName);
        //    BusinessLayerResult<Region> region = new BusinessLayerResult<Region>();
        //    if (reg != null)
        //    {
        //        region.AddError(ErrorMessageCode.RegionNameAlreadyExists, "Bölge Adı Kullanılıyor");
        //    }
        //    else
        //    {
        //        int dbResult = repo_region.Insert(new Region()
        //            {
        //            RegionName=data.RegionName
        //        });

        //    }
        //    return region;
        //}
        //public BusinessLayerResult<Region>GetRegionById(int id)
        //{
        //    BusinessLayerResult<Region> reg = new BusinessLayerResult<Region>();
        //    reg.Result = repo_region.Find(x => x.Id == id);
        //    if (reg.Result == null)
        //    {
        //        reg.AddError(ErrorMessageCode.RegionNotFound, "Bölge Bulunamadı.");
        //    }
        //    return reg;
        //}
        //public BusinessLayerResult<Region>RemoveRegionById(int id)
        //{
        //    Region reg = repo_region.Find(x => x.Id == id);
        //    BusinessLayerResult<Region> region = new BusinessLayerResult<Region>();
        //    if (reg != null)
        //    {
        //        if(repo_region.Delete(reg)==0)
        //        {
        //            region.AddError(ErrorMessageCode.RegionCouldNotRemove, "Bölge Silinemedi.");
        //            return region;
        //        }        
        //    }
        //    else
        //    {
        //        region.AddError(ErrorMessageCode.RegionCouldNotFind, "Bölge Bulunamadı.");

        //    }
        //    return region;
        //}
        #endregion
    }
}
