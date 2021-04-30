using DataAccessLayer.Abstrack;
using Entity;
using Entity.Models;
using Entity.ViewModels;
using Otomasyon.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfHotelsRepository:EfGenericRepository<Hotels>, IHotelsService
    {
        public EfHotelsRepository():base()
        {
                
        }
        //public bool HotelsDelete(int id)
        //{
        //    const string sql = "delete from Hotels where Id={0}";
        //    return context.Database.ExecuteSqlCommand(sql,id)>0;
        //}


        public bool HotelsRegister(HotelsViewModel hotels)
        {
            DateTime dateTime = DateTime.Now;
            const string sql ="insert into Hotels(HotelPhoto,HotelName,HotelAddress,FoundationYear,IsAktive,CreatedOn,CountryId,RegionId,CityId,DistrictId) Values({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10})";
            
            return context.Database.ExecuteSqlCommand(sql,hotels.HotelPhoto,hotels.HotelName,hotels.HotelAddress,hotels.FoundationYear,hotels.IsAktive,dateTime,hotels.CountryId,hotels.RegionId,hotels.CityId,hotels.DistrictId) > 0;
        }

        public bool HotelsUpdate(HotelsViewModel hotels)
        {
           
            const string sql = "update Hotels set HotelPhoto={0},HotelName={1},HotelAddress={2},FoundationYear={3},IsAktive={4},Regionid={5},Cityid={6},Districtid={7},CountryId={8} where Id ={9}";
            return context.Database.ExecuteSqlCommand(sql, hotels.HotelPhoto, hotels.HotelName,hotels.HotelAddress,hotels.FoundationYear,hotels.IsAktive,hotels.RegionId,hotels.CityId,hotels.DistrictId,hotels.CountryId,hotels.Id) > 0;
        }

        
    }
}
